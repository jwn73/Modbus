using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modbus
{
    class modbus
    {
        private SerialPortListener.Serial.SerialPortManager _spManager;
        public string modbusStatus;

        #region Constructor / Deconstructor
        public modbus()
        {
        }
        ~modbus()
        {
        }
        #endregion

        #region Open / Close Procedures
        public bool Open(SerialPortListener.Serial.SerialPortManager _spManager)
        {
            this._spManager = _spManager;
            return true;
        }
        public bool Close()
        {
            return true;
        }
        #endregion

        #region CRC Computation
        private void GetCRC(byte[] message, ref byte[] CRC)
        {
            //Function expects a modbus message of any length as well as a 2 byte CRC array in which to 
            //return the CRC values:

            ushort CRCFull = 0xFFFF;
            byte CRCHigh = 0xFF, CRCLow = 0xFF;
            char CRCLSB;

            for (int i = 0; i < (message.Length) - 2; i++)
            {
                CRCFull = (ushort)(CRCFull ^ message[i]);

                for (int j = 0; j < 8; j++)
                {
                    CRCLSB = (char)(CRCFull & 0x0001);
                    CRCFull = (ushort)((CRCFull >> 1) & 0x7FFF);

                    if (CRCLSB == 1)
                        CRCFull = (ushort)(CRCFull ^ 0xA001);
                }
            }
            CRC[1] = CRCHigh = (byte)((CRCFull >> 8) & 0xFF);
            CRC[0] = CRCLow = (byte)(CRCFull & 0xFF);
        }
        #endregion

        #region Build Message
        private void BuildMessage(byte address, byte type, ushort start, ushort registers, ref byte[] message)
        {
            //Array to receive CRC bytes:
            byte[] CRC = new byte[2];

            message[0] = address;
            message[1] = type;
            message[2] = (byte)(start >> 8);
            message[3] = (byte)start;
            message[4] = (byte)(registers >> 8);
            message[5] = (byte)registers;

            GetCRC(message, ref CRC);
            message[message.Length - 2] = CRC[0];
            message[message.Length - 1] = CRC[1];
        }
        #endregion

        #region Check Response
        public bool CheckResponse(byte[] response)
        {
            //Perform a basic CRC check:
            byte[] CRC = new byte[2];
            GetCRC(response, ref CRC);
            if (CRC[0] == response[response.Length - 2] && CRC[1] == response[response.Length - 1])
            {
                if (response[1] > 128)
                    throw new Exception("Exception Response Function Code: " + MakeTwoChar(Convert.ToString(Convert.ToInt32(response[1].ToString(), 10), 16) + " ") + GetExceptionResponseCode(response[2]));
                return true;
            }
            else
                return false;
        }
        private string GetExceptionResponseCode(byte response)
        {
            switch( response)
            {
                case 01: return " (01: Illegal Function)";
                case 02: return " (02: Illegal Data Address)";
                case 03: return " (03: Illegal Data Value)";
                case 04: return " (04: Slave Device Failure)";
                case 05: return " (05: Acknowledge)";
                case 06: return " (06: Slave Device Busy)";
                case 07: return " (07: Negative Acknowledge)";
                case 08: return " (08: Memory Parity Error)";
                case 10: return " (0A: Gateway Path Unavailable)";
                case 11: return " (0B: Gateway Target Device Failed to Respond)";

                default: return " (" + MakeTwoChar(Convert.ToString(Convert.ToInt32(response.ToString(), 10), 16) + " ") + ": Unknown Exception Code)";

            }
        }
        #endregion

        #region Function 16 - Write Multiple Registers
        public bool SendFc16(byte address, ushort start, ushort registers, short[] values)
        {

                //Clear in/out buffers:
                _spManager.ClearBuffers();
                
                //Message is 1 addr + 1 fcn + 2 start + 2 reg + 1 count + 2 * reg vals + 2 CRC
                byte[] message = new byte[9 + 2 * registers];
                //Function 16 response is fixed at 8 bytes
                byte[] response = new byte[8];

                //Add bytecount to message:
                message[6] = (byte)(registers * 2);
                //Put write values into message prior to sending:
                for (int i = 0; i < registers; i++)
                {
                    message[7 + 2 * i] = (byte)(values[i] >> 8);
                    message[8 + 2 * i] = (byte)(values[i]);
                }
                //Build outgoing message:
                BuildMessage(address, (byte)16, start, registers, ref message);

                //Send Modbus message to Serial Port:
                try
                {
                _spManager.Write(message, 0, message.Length);
                    _spManager.ReadBytes(ref response);
                }
                catch (Exception err)
                {
                    modbusStatus = "Error in write event: " + err.Message;
                    return false;
                }
                //Evaluate message:
                if (CheckResponse(response))
                {
                    modbusStatus = "Write successful";
                    return true;
                }
                else
                {
                    modbusStatus = "CRC error";
                    return false;
                }
        }
        #endregion

        #region Function 3 - Read Registers
        public bool SendFc3(byte address, ushort start, ushort registers, ref short[] values)
        {
            //Ensure port is open:

            //Clear in/out buffers:
            _spManager.ClearBuffers();
            //Function 3 request is always 8 bytes:
            byte[] message = new byte[8];
            //Function 3 response buffer:
            byte[] response = new byte[5 + 2 * registers];
            //Build outgoing modbus message:
            BuildMessage(address, (byte)3, start, registers, ref message);
            //Send modbus message to Serial Port:
            try
            {
                _spManager.Write(message, 0, message.Length);
                _spManager.ReadBytes(ref response);
            }
            catch (Exception err)
            {
                modbusStatus = "Error in read event: " + err.Message;
                return false;
            }
            //Evaluate message:
            if (CheckResponse(response))
            {
                //Return requested register values:
                for (int i = 0; i < (response.Length - 5) / 2; i++)
                {
                    values[i] = response[2 * i + 3];
                    values[i] <<= 8;
                    values[i] += response[2 * i + 4];
                }
                modbusStatus = "Read successful";
                return true;
            }
            else
            {
                modbusStatus = "CRC error";
                return false;
            }

        }
        #endregion

        #region WriteCommand
        //public string SendRegisterCommand(byte[] message, ushort registers, ref short[] values)
        //{

        //    //Clear in/out buffers:
        //    _spManager.ClearBuffers();
        //    byte[] response = new byte[5 + 2 * registers];

        //    byte[] CRC = new byte[2];
        //    GetCRC(message, ref CRC);
        //    message[message.Length - 2] = CRC[0];
        //    message[message.Length - 1] = CRC[1];

        //    try
        //    {
        //        _spManager.Write(message, 0, message.Length);
        //        _spManager.ReadBytes(ref response);
        //    }
        //    catch (Exception err)
        //    {
        //        modbusStatus = "Error in read event: " + err.Message;
        //        return "Error in read event: " + err.Message;
        //    }
        //    //Evaluate message:
        //    if (CheckResponse(response))
        //    {
        //        //Return requested register values:
        //        for (int i = 0; i < (response.Length - 5) / 2; i++)
        //        {
        //            values[i] = response[2 * i + 3];
        //            values[i] <<= 8;
        //            values[i] += response[2 * i + 4];
        //        }
        //        modbusStatus = "Read successful";
        //        return "TX:" + ConvertToHexString(message) + Environment.NewLine + "RX:" + ConvertToHexString(response) + Environment.NewLine;
        //    }
        //    else
        //    {
        //        modbusStatus = "CRC error";
        //        return "CRC error";
        //    }

        //}
        /// <summary>
        /// 
        /// </summary>
        public int StartDataAddress
        {
            get;set;
        }
        /// <summary>
        /// 
        /// </summary>
        public int ReadQuantity
        {
            get; set;
        }
        /// <summary>
        /// 
        /// </summary>
        public bool RegisterValues
        {
            get; set;
        }
        public bool CoilValues
        {
            get; set;
        }
        public bool ValidateRXCRC16
        {
            get; set;
        }

        public string SendCommand(byte[] message, ref byte[] response, ref short[] values)
        {
            try
            {
                //Clear in/out buffers:
                _spManager.ClearBuffers();
                StartDataAddress = 0;
                ReadQuantity = 0;
                CoilValues = RegisterValues = false;
                response = CreateResponseArray(message, out values);

                byte[] CRC = new byte[2];
                GetCRC(message, ref CRC);
                message[message.Length - 2] = CRC[0];
                message[message.Length - 1] = CRC[1];

                try
                {
                    _spManager.Write(message, 0, message.Length);
                    _spManager.ReadBytes(ref response);
                }
                catch (Exception err)
                {
                    modbusStatus = "Error in read event: " + err.Message;
                    if(response != null && response.Length> 1 && response[1] > 128)
                    {

                    }
                    else
                        return "Error in read event: " + err.Message + Environment.NewLine + "TX:" + ConvertToHexString(message) + Environment.NewLine + "RX:" + ConvertToHexString(response) + Environment.NewLine; ;
                }
                //Evaluate message:
                if (!ValidateRXCRC16 || CheckResponse(response))
                {
                    if (RegisterValues)
                    {
                        //Return requested register values:
                        for (int i = 0; i < (response.Length - 5) / 2; i++)
                        {
                            values[i] = response[2 * i + 3];
                            values[i] <<= 8;
                            values[i] += response[2 * i + 4];
                        }
                    }
                    else if (CoilValues)
                    {
                        for (int i = 0; i < values.Length; i++)
                        {
                            if (response.Length == i + 3)
                                break;
                            values[i] = response[i + 3];
                        }
                    }
                    modbusStatus = "Read successful";
                    return "TX:" + ConvertToHexString(message) + Environment.NewLine + "RX:" + ConvertToHexString(response) + Environment.NewLine;
                }
                else
                {
                    modbusStatus = "CRC error";
                    return "CRC error";
                }
            }
            catch (Exception err)
            {
                if (err.Message.Contains("Exception Response Function Code: "))
                {
                    modbusStatus = err.Message;
                    return err.Message;
                }
                else
                {
                    modbusStatus = "Error in SendCommand method: " + err.Message;
                    return "Error in SendCommand method: " + err.Message;
                }
            }

        }
        private byte[] CreateResponseArray(byte[] message, out short[] values)
        {
            string startAddressHex = "";
            string ReadLengthHex = "";
            int length = 0;
            CoilValues = RegisterValues = false;
            values = null;
            switch (message[1])
            {
                case 01:    //Read	Discrete Output Coils
                case 02:    //Read	Discrete Input Contacts
                    startAddressHex = MakeTwoChar(Convert.ToString(Convert.ToInt32(message[2].ToString(), 10), 16)).Trim() + MakeTwoChar(Convert.ToString(Convert.ToInt32(message[3].ToString(), 10), 16)).Trim();
                    StartDataAddress = Convert.ToInt32(Math.Ceiling(((double)Convert.ToInt32(startAddressHex, 16))));
                    ReadLengthHex = MakeTwoChar(Convert.ToString(Convert.ToInt32(message[4].ToString(), 10), 16)).Trim() + MakeTwoChar(Convert.ToString(Convert.ToInt32(message[5].ToString(), 10), 16)).Trim();
                    ReadQuantity = Convert.ToInt32(Math.Ceiling(((double)Convert.ToInt32(ReadLengthHex, 16))));
                    length = (int)Math.Ceiling(((double)ReadQuantity / 8)) + 5;
                    values = new short[(int)Math.Ceiling(((double)ReadQuantity / 8))];
                    CoilValues = true;
                    break;
                case 03:    //Read	Analog Output Holding Registers
                case 04:    //Read	Analog Input Registers
                    startAddressHex = MakeTwoChar(Convert.ToString(Convert.ToInt32(message[2].ToString(), 10), 16)).Trim() + MakeTwoChar(Convert.ToString(Convert.ToInt32(message[3].ToString(), 10), 16)).Trim();
                    StartDataAddress = Convert.ToInt32(Math.Ceiling(((double)Convert.ToInt32(startAddressHex, 16))));
                    ReadLengthHex = MakeTwoChar(Convert.ToString(Convert.ToInt32(message[4].ToString(), 10), 16)).Trim() + MakeTwoChar(Convert.ToString(Convert.ToInt32(message[5].ToString(), 10), 16)).Trim();
                    ReadQuantity = Convert.ToInt32(ReadLengthHex, 16);
                    length = ReadQuantity * 2 + 5;
                    RegisterValues = true;
                    values = new short[Convert.ToInt32(length)];
                    break;
                case 05:    //Write single	Discrete Output Coil
                case 06:    //Write single	Analog Output Holding Register
                case 15:    //Write multiple	Discrete Output Coils
                case 16:    //Write multiple	Analog Output Holding Registers
                    startAddressHex = MakeTwoChar(Convert.ToString(Convert.ToInt32(message[2].ToString(), 10), 16)).Trim() + MakeTwoChar(Convert.ToString(Convert.ToInt32(message[3].ToString(), 10), 16)).Trim();
                    StartDataAddress = Convert.ToInt32(Math.Ceiling(((double)Convert.ToInt32(startAddressHex, 16))));
                    length = 8;
                    break;

                default:
                    length = 8;
                    break;
            }

            return new byte[length];
        }
        public string SendCommand(byte[] message, bool forceErrorCRC = false)
        {
            byte[] CRC = new byte[2];
            GetCRC(message, ref CRC);
            message[message.Length - 2] = forceErrorCRC == true ? (byte)0x00 : CRC[0];
            message[message.Length - 1] = forceErrorCRC == true ? (byte)0x00 : CRC[1];

            try
            {
                _spManager.Write(message, 0, message.Length);
                return "TX:" + ConvertToHexString(message) + " - " + DateTime.Now.Second.ToString() + ":" + DateTime.Now.Millisecond.ToString() + Environment.NewLine;
            }
            catch (Exception err)
            {
                modbusStatus = "Error in TX event: " + err.Message;
                return "Error in TX event: " + err.Message + Environment.NewLine + "TX:" + ConvertToHexString(message) + " InputRegisterRespons - " + DateTime.Now.Second.ToString() + ":" + DateTime.Now.Millisecond.ToString() + Environment.NewLine;
            }
        }
        public string ConvertToHexString(byte[] message, bool useSpaceSeparator = true)
        {
           System.Text.StringBuilder returnString = new StringBuilder();
            foreach (var item in message)
            {
                if(useSpaceSeparator)
                    returnString.Append(MakeTwoChar(Convert.ToString(Convert.ToInt32(item.ToString(), 10), 16) + " ", useSpaceSeparator));
                else
                    returnString.Append(MakeTwoChar(Convert.ToString(Convert.ToInt32(item.ToString(), 10), 16), useSpaceSeparator));
            }
            return returnString.ToString();
        }
        private string MakeTwoChar(string charArray, bool useSpaceSeparator = true)
        {
            string space = " ";
            if (!useSpaceSeparator)
                space = "";
            if (charArray.Trim().Length == 2)
                return charArray.Trim() + space;
            else if (charArray.Trim().Length == 1)
                return "0" + charArray.Trim() + space;
            else
                return "00 ";

        }
        #endregion
    }
}
