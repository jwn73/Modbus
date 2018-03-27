using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerialPortListener.Serial;

namespace Modbus
{
    public partial class Modbus : Form
    {
        Crc16 crc16 = new Crc16();
        Crc16_Modbus crc16Modbus = new Crc16_Modbus();
        SerialPortManager _spManager;
        StringBuilder strRxData = new StringBuilder();
        List<byte> serialData = new List<byte>();
        modbus mb = new modbus();
        System.Timers.Timer timer = new System.Timers.Timer();
        System.Timers.Timer slaveTimer = new System.Timers.Timer();
        System.Timers.Timer slaveRXTXClear = new System.Timers.Timer();
        string dataType;
        //bool isPolling = false;
        int pollCount;
        int rxCrcError = 0;
        int rxCrcOk = 0;

        #region Constructor
        public Modbus()
        {
            InitializeComponent();
            btnStart.BackColor = Color.Red;
            btnStart.Text = "Connect";

            btnPoll.BackColor = Color.Red;
            btnPoll.Text = "Connect";

            bnStartStoppSlave.BackColor = Color.Red;
            bnStartStoppSlave.Text = "Connect";

            btnFreze.BackColor = Color.Green;
            btnFreze.Text = "FREZZE";

            UserInitialization();

            txtRegisterQty.Text = "10";
            txtSampleRate.Text = "1000";
            txtSlaveID.Text = "1";
            txtStartAddr.Text = "0";

            string[] dataTypes = { "Decimal", "Hexadecimal", "Float", "Reverse" };

            foreach (string dataType in dataTypes)
                lstDataType.Items.Add(dataType);
            lstDataType.SelectedIndex = 0;

            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
            slaveTimer.Elapsed += new System.Timers.ElapsedEventHandler(slaveTimer_Elapsed);
            slaveRXTXClear.Elapsed += new System.Timers.ElapsedEventHandler(slaveRXTXClear_Elapsed);

        }
        #endregion

        #region Textbox
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Length != 2 || !VaildateHex((sender as TextBox).Text))
            {
                SetLabel((sender as TextBox).Name, "");
                return;
            }
            SetLabel((sender as TextBox).Name, Hex2binary((sender as TextBox).Text));
        }
        private string Hex2binary(string hexvalue)
        {
            return Convert.ToString(Convert.ToInt32(hexvalue, 16), 2).PadLeft(8, '0');
        }
        private bool VaildateHex(string hexvalue)
        {
            if (hexvalue.Length == 0)
                return true;
            if (hexvalue.Length > 0)
            {
                if (Convert.ToByte(hexvalue[0]) < 48 || Convert.ToByte(hexvalue[0]) > 102
                    || (Convert.ToByte(hexvalue[0]) > 57 && Convert.ToByte(hexvalue[0]) < 65)
                    || (Convert.ToByte(hexvalue[0]) > 70 && Convert.ToByte(hexvalue[0]) < 97))
                    return false;
            }
            if (hexvalue.Length > 1)
            {
                if (Convert.ToByte(hexvalue[1]) < 48 || Convert.ToByte(hexvalue[1]) > 102
                    || (Convert.ToByte(hexvalue[1]) > 57 && Convert.ToByte(hexvalue[1]) < 65)
                    || (Convert.ToByte(hexvalue[1]) > 70 && Convert.ToByte(hexvalue[1]) < 97))
                    return false;
            }
            return true;
        }
        private void SetLabel(string TextBoxName, string value)
        {
            if (TextBoxName == "txAddress")
                laAddress.Text = value;
            else if (TextBoxName == "txFunction")
                laFunction.Text = value;
            else if (TextBoxName.Contains("txData0"))
                laData0.Text = value;
            else if (TextBoxName.Contains("txData1"))
                laData1.Text = value;
            else if (TextBoxName.Contains("txData2"))
                laData2.Text = value;
            else if (TextBoxName.Contains("txData3"))
                laData3.Text = value;
            else if (TextBoxName.Contains("txCrcHi"))
                laCrcHi.Text = value;
            else if (TextBoxName.Contains("txCrcLo"))
                laCrcLo.Text = value;
            else if (TextBoxName.Contains("txMessageFrame"))
                laMessageFrame.Text = value;

            laMessageFrame.Text = laAddress.Text + laFunction.Text + laData0.Text + laData1.Text + laData2.Text + (string.IsNullOrEmpty(laData3.Text) ? "" : laData3.Text) + laCrcHi.Text + laCrcLo.Text;

            if (txAddress.Text.Length != 2 || txFunction.Text.Length != 2 || txData0.Text.Length != 2 || txData1.Text.Length != 2 || txData2.Text.Length != 2 || txData3.Text.Length == 1)
            {
                laMessageFrame.Text = txMessageFrame.Text = "";
            }
            else
            {
                try
                {
                    //ushort checksum = crc16.ComputeChecksum(new byte[] { byte.Parse(Convert.ToString(Convert.ToInt32(txAddress.Text, 16), 10)), byte.Parse(Convert.ToString(Convert.ToInt32(txFunction.Text, 16), 10)), byte.Parse(Convert.ToString(Convert.ToInt32(txData0.Text, 16), 10)), byte.Parse(Convert.ToString(Convert.ToInt32(txData1.Text, 16), 10)), byte.Parse(Convert.ToString(Convert.ToInt32(txData2.Text, 16), 10)), byte.Parse(Convert.ToString(Convert.ToInt32(txData3.Text, 16), 10)) });
                    ushort checksum = 0;
                    if (txData3.Text.Length == 2)
                        checksum = Crc16_Modbus.ComputeCrc(new byte[] { byte.Parse(Convert.ToString(Convert.ToInt32(txAddress.Text, 16), 10)), byte.Parse(Convert.ToString(Convert.ToInt32(txFunction.Text, 16), 10)), byte.Parse(Convert.ToString(Convert.ToInt32(txData0.Text, 16), 10)), byte.Parse(Convert.ToString(Convert.ToInt32(txData1.Text, 16), 10)), byte.Parse(Convert.ToString(Convert.ToInt32(txData2.Text, 16), 10)), byte.Parse(Convert.ToString(Convert.ToInt32(txData3.Text, 16), 10)) });
                    else
                        checksum = Crc16_Modbus.ComputeCrc(new byte[] { byte.Parse(Convert.ToString(Convert.ToInt32(txAddress.Text, 16), 10)), byte.Parse(Convert.ToString(Convert.ToInt32(txFunction.Text, 16), 10)), byte.Parse(Convert.ToString(Convert.ToInt32(txData0.Text, 16), 10)), byte.Parse(Convert.ToString(Convert.ToInt32(txData1.Text, 16), 10)), byte.Parse(Convert.ToString(Convert.ToInt32(txData2.Text, 16), 10)) });
                    txCrcHi.Text = Convert.ToString(Convert.ToInt32(BitConverter.GetBytes(checksum)[0].ToString(), 10), 16);
                    laCrcHi.Text = Hex2binary(txCrcHi.Text);
                    txCrcLo.Text = Convert.ToString(Convert.ToInt32(BitConverter.GetBytes(checksum)[1].ToString(), 10), 16);
                    laCrcLo.Text = Hex2binary(txCrcLo.Text);
                    txMessageFrame.Text = txAddress.Text + txFunction.Text + txData0.Text + txData1.Text + txData2.Text + txData3.Text + txCrcHi.Text + txCrcLo.Text;
                }
                catch
                {

                }

            }
        }
        #endregion

        #region UserInitialization RS232
        private void UserInitialization()
        {
            _spManager = new SerialPortManager();
            mb.Open(_spManager);
            SerialSettings mySerialSettings = _spManager.CurrentSerialSettings;
            serialSettingsBindingSource.DataSource = mySerialSettings;
            portNameComboBox.DataSource = mySerialSettings.PortNameCollection;
            baudRateComboBox.DataSource = mySerialSettings.BaudRateCollection;
            dataBitsComboBox.DataSource = mySerialSettings.DataBitsCollection;
            parityComboBox.DataSource = Enum.GetValues(typeof(System.IO.Ports.Parity));
            stopBitsComboBox.DataSource = Enum.GetValues(typeof(System.IO.Ports.StopBits));

            //Set deafult values
            if (mySerialSettings.BaudRateCollection.Contains(115200))
                mySerialSettings.BaudRate = 115200;
            if (mySerialSettings.PortNameCollection.Contains("COM6"))
                mySerialSettings.PortName = "COM6";

            mySerialSettings.Parity = System.IO.Ports.Parity.None;
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);

            LoadSetting();
        }
        #endregion

        #region MainForm_FormClosing
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
            _spManager.Dispose();
        }
        #endregion

        #region button events
        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (btnStart.BackColor == Color.Red)
            {
                btnStart.BackColor = Color.Green;
                btnStart.Text = "Disconnect";
                _spManager.StartListening();
                LockRS232Settings(false);

            }
            else
            {
                btnStart.BackColor = Color.Red;
                btnStart.Text = "Connect";
                _spManager.StopListening();
                LockRS232Settings(true);
            }
        }
        private void btnPoll_Click(object sender, EventArgs e)
        {
            if (btnPoll.BackColor == Color.Red)
            {
                btnPoll.BackColor = Color.Green;
                btnPoll.Text = "Disconnect";
                StartPoll();
                LockPollSettings(false);

            }
            else
            {
                btnPoll.BackColor = Color.Red;
                btnPoll.Text = "Connect";
                StopPoll();
                LockPollSettings(true);
            }
        }
        private void btnClearScreen_Click(object sender, EventArgs e)
        {
            tbData.Clear();
            rxCrcError = 0;
            rxCrcOk = 0;
        }
        #endregion

        #region Start and Stop Procedures
        private void StartPoll()
        {
            pollCount = 0;
            mb.Open(_spManager);
            dataType = lstDataType.SelectedItem.ToString();

            //Set polling flag:
            //isPolling = true;

            //Start timer using provided values:
            timer.AutoReset = true;
            if (txtSampleRate.Text != "")
                timer.Interval = Convert.ToDouble(txtSampleRate.Text);
            else
                timer.Interval = 1000;
            timer.Start();

            lblStatus.Text = mb.modbusStatus;
        }
        private void StopPoll()
        {
            //Stop timer and close COM port:
            //isPolling = false;
            timer.Stop();
            mb.Close();

            btnStart.Enabled = true;

            lblStatus.Text = mb.modbusStatus;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            StartPoll();
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            StopPoll();
        }
        #endregion

        #region Delegate Functions
        public delegate void GUIDelegate(string paramString);
        public delegate void GUIClear();
        public delegate void GUIStatus(string paramString);
        public void DoGUIClear()
        {
            if (this.InvokeRequired)
            {
                GUIClear delegateMethod = new GUIClear(this.DoGUIClear);
                this.Invoke(delegateMethod);
            }
            else {
                if (btnFreze.BackColor == Color.Red)
                    return;

                this.tbData.Text = "";
            }
        }
        public void DoGUIStatus(string paramString)
        {
            if (this.InvokeRequired)
            {
                GUIStatus delegateMethod = new GUIStatus(this.DoGUIStatus);
                this.Invoke(delegateMethod, new object[] { paramString });
            }
            else
                this.lblStatus.Text = paramString;
        }
        public void DoGUIUpdate(string paramString)
        {
            if (this.InvokeRequired)
            {
                GUIDelegate delegateMethod = new GUIDelegate(this.DoGUIUpdate);
                this.Invoke(delegateMethod, new object[] { paramString });
            }
            else
            {
                if (chFilterOutput.Checked && !paramString.Contains(maFilterOutput.Text.ToLower().Trim()))
                    return;
                if (btnFreze.BackColor == Color.Red)
                    return;
                if (chScrollToChar.Checked)
                {
                        this.tbData.AppendText(paramString);  
                }
                else
                    this.tbData.Text += paramString;

                laRXCrcCounter.Text = "crc ok/error: " + rxCrcOk.ToString() + " / " + rxCrcError.ToString();              
                Application.DoEvents();
            }
        }
        #endregion

        #region Timer Elapsed Event Handler
        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            PollFunction();
        }
        #endregion

        #region Poll Function
        private void PollFunction()
        {
            //Update GUI:
            DoGUIClear();
            pollCount++;
            DoGUIStatus("Poll count: " + pollCount.ToString());

            //Create array to accept read values:
            short[] values = new short[Convert.ToInt32(txtRegisterQty.Text)];
            ushort pollStart;
            ushort pollLength;

            if (txtStartAddr.Text != "")
                pollStart = Convert.ToUInt16(txtStartAddr.Text);
            else
                pollStart = 0;
            if (txtRegisterQty.Text != "")
                pollLength = Convert.ToUInt16(txtRegisterQty.Text);
            else
                pollLength = 10;

            //Read registers and display data in desired format:
            try
            {
                while (!mb.SendFc3(Convert.ToByte(txtSlaveID.Text), pollStart, pollLength, ref values)) ;
            }
            catch (Exception err)
            {
                DoGUIStatus("Error in modbus read: " + err.Message);
            }

            PrintRegisterRespons(values, pollStart, pollLength);


        }
        private void PrintRegisterRespons(short[] values, ushort pollStart, ushort pollLength)
        {
            if (values == null || values.Length == 0)
                return;
            string itemString;
            switch (dataType)
            {
                case "Decimal":
                    for (int i = 0; i < pollLength; i++)
                    {
                        itemString = "[" + Convert.ToString(pollStart + i + 40001) + "] , MB[" +
                            Convert.ToString(pollStart + i) + "] = " + values[i].ToString();
                        DoGUIUpdate(itemString);
                    }
                    break;
                case "Hexadecimal":
                    for (int i = 0; i < pollLength; i++)
                    {
                        itemString = "[" + Convert.ToString(pollStart + i + 40001) + "] , MB[" +
                            Convert.ToString(pollStart + i) + "] = " + values[i].ToString("X");
                        DoGUIUpdate(itemString);
                    }
                    break;
                case "Float":
                    for (int i = 0; i < (pollLength / 2); i++)
                    {
                        int intValue = (int)values[2 * i];
                        intValue <<= 16;
                        intValue += (int)values[2 * i + 1];
                        itemString = "[" + Convert.ToString(pollStart + 2 * i + 40001) + "] , MB[" +
                            Convert.ToString(pollStart + 2 * i) + "] = " +
                            (BitConverter.ToSingle(BitConverter.GetBytes(intValue), 0)).ToString();
                        DoGUIUpdate(itemString);
                    }
                    break;
                case "Reverse":
                    for (int i = 0; i < (pollLength / 2); i++)
                    {
                        int intValue = (int)values[2 * i + 1];
                        intValue <<= 16;
                        intValue += (int)values[2 * i];
                        itemString = "[" + Convert.ToString(pollStart + 2 * i + 40001) + "] , MB[" +
                            Convert.ToString(pollStart + 2 * i) + "] = " +
                            (BitConverter.ToSingle(BitConverter.GetBytes(intValue), 0)).ToString();
                        DoGUIUpdate(itemString);
                    }
                    break;
            }
        }
        private void PrintCoilRespons(short[] values, ushort pollStart, ushort pollLength)
        {
            string itemString;
            switch (dataType)
            {
                case "Decimal":
                    for (int i = 0; i < pollLength; i++)
                    {
                        itemString = "[" + Convert.ToString(pollStart + i + 1) + "] , MB[" +
                            Convert.ToString(pollStart + i) + "] = " + values[i].ToString();
                        DoGUIUpdate(itemString);
                    }
                    break;
                case "Hexadecimal":
                    for (int i = 0; i < pollLength; i++)
                    {
                        itemString = "[" + Convert.ToString(pollStart + i + 1) + "] , MB[" +
                            Convert.ToString(pollStart + i) + "] = " + values[i].ToString("X");
                        DoGUIUpdate(itemString);
                    }
                    break;
                case "Float":
                    for (int i = 0; i < (pollLength / 2); i++)
                    {
                        int intValue = (int)values[2 * i];
                        intValue <<= 16;
                        intValue += (int)values[2 * i + 1];
                        itemString = "[" + Convert.ToString(pollStart + 2 * i + 1) + "] , MB[" +
                            Convert.ToString(pollStart + 2 * i) + "] = " +
                            (BitConverter.ToSingle(BitConverter.GetBytes(intValue), 0)).ToString();
                        DoGUIUpdate(itemString);
                    }
                    break;
                case "Reverse":
                    for (int i = 0; i < (pollLength / 2); i++)
                    {
                        int intValue = (int)values[2 * i + 1];
                        intValue <<= 16;
                        intValue += (int)values[2 * i];
                        itemString = "[" + Convert.ToString(pollStart + 2 * i + 1) + "] , MB[" +
                            Convert.ToString(pollStart + 2 * i) + "] = " +
                            (BitConverter.ToSingle(BitConverter.GetBytes(intValue), 0)).ToString();
                        DoGUIUpdate(itemString);
                    }
                    break;
            }
        }
        #endregion

        #region LockForm
        private void LockRS232Settings(bool value)
        {
            portNameComboBox.Enabled = baudRateComboBox.Enabled = parityComboBox.Enabled = dataBitsComboBox.Enabled = stopBitsComboBox.Enabled = value;
        }
        private void LockPollSettings(bool value)
        {
            txtSlaveID.Enabled = txtStartAddr.Enabled = txtRegisterQty.Enabled = txtSampleRate.Enabled = lstDataType.Enabled = value;
        }
        #endregion

        #region Settings
        private void LoadSetting()
        {
            if (_spManager.CurrentSerialSettings.BaudRateCollection.Contains(Properties.Settings.Default.BaudRate))
                _spManager.CurrentSerialSettings.BaudRate = Properties.Settings.Default.BaudRate;
            if (_spManager.CurrentSerialSettings.PortNameCollection.Contains(Properties.Settings.Default.PortName))
                _spManager.CurrentSerialSettings.PortName = Properties.Settings.Default.PortName;
            if (_spManager.CurrentSerialSettings.DataBitsCollection.Contains(Properties.Settings.Default.DataBits))
                _spManager.CurrentSerialSettings.DataBits = Properties.Settings.Default.DataBits;

            _spManager.CurrentSerialSettings.Parity = System.IO.Ports.Parity.None;


        }
        private void SaveSettings()
        {

            Properties.Settings.Default.BaudRate = _spManager.CurrentSerialSettings.BaudRate;
            Properties.Settings.Default.PortName = _spManager.CurrentSerialSettings.PortName;
            Properties.Settings.Default.DataBits = _spManager.CurrentSerialSettings.DataBits;
            //Properties.Settings.Default.Parity = _spManager.CurrentSerialSettings.Parity;
            Properties.Settings.Default.StopBits = _spManager.CurrentSerialSettings.StopBits.ToString();
            Properties.Settings.Default.Save();
        }
        #endregion

        #region Transmitt MAster message
        private void btnTransmit_Click(object sender, EventArgs e)
        {
            mb.ValidateRXCRC16 = chValidateCrc16.Checked;
            if ((sender as Button).Name == "BtnTransmit2")
                SendMessage(txModbus2);
            else if ((sender as Button).Name == "BtnTransmit3")
                SendMessage(txModbus3);
            else if ((sender as Button).Name == "BtnTransmit4")
                SendMessage(txModbus4);
            else if ((sender as Button).Name == "BtnTransmit5")
                SendMessage(txModbus5);
            else if ((sender as Button).Name == "BtnTransmit6")
                SendMessage(txModbus6);
            else if ((sender as Button).Name == "BtnTransmit7")
                SendMessage(txModbus7);

        }
        private void SendMessage(MaskedTextBox sender)
        {
            if ((sender as MaskedTextBox).Text.Replace(" ", "").Length % 2 == 1)
            {
                DoGUIUpdate("Lengt need to be even not odd");
                return;
            }

            //mb.Open(_spManager);
            dataType = lstDataType.SelectedItem.ToString();
            byte[] message = new byte[(sender as MaskedTextBox).Text.Replace(" ", "").Length / 2 + 2];
            int startPos = 0;
            for (int i = 0; i < message.Length - 2; i++)
            {
                if (startPos + 2 > (sender as MaskedTextBox).Text.Replace(" ", "").Length)
                    break;
                message[i] = byte.Parse(Convert.ToString(Convert.ToInt32((sender as MaskedTextBox).Text.Replace(" ", "").Substring(startPos, 2), 16), 10)); // Address
                startPos += 2;
            }
            short[] values = new short[Convert.ToInt32(txtRegisterQty.Text)];
            byte[] response = new byte[8];

            DoGUIUpdate(mb.SendCommand(message, ref response, ref values));
            if (message != null && message.Length > 4)
            {
                //PrintRegisterRespons(values, Convert.ToUInt16(txtStartAddr.Text), Convert.ToUInt16(txtRegisterQty.Text));
                PrintRegisterRespons(values, Convert.ToUInt16(mb.StartDataAddress), Convert.ToUInt16(mb.ReadQuantity));
            }

        }
        #endregion

        #region Master comamnds
        private void SetSingleCoil(int slaveId, int startAddress, bool value)
        {
            mb.ValidateRXCRC16 = chValidateCrc16.Checked;
            byte[] message = new byte[8];
            byte[] response = new byte[8];
            short[] values = new short[0];
            message[0] = (byte)slaveId;
            message[1] = 5;
            message[2] = (byte)SplitIntToByte(startAddress, true);
            message[3] = (byte)SplitIntToByte(startAddress, false);
            message[4] = (byte)(value ? 0xFF : 0);
            message[5] = 0;
            DoGUIUpdate(mb.SendCommand(message, ref response, ref values));
        }
        private short[] GetCoilStatus(int slaveId, int startAddress, int numOfCoils)
        {
            mb.ValidateRXCRC16 = chValidateCrc16.Checked;
            byte[] message = new byte[8];
            byte[] response = new byte[8];
            short[] values = new short[0];
            message[0] = (byte)slaveId;
            message[1] = 1;
            message[2] = (byte)SplitIntToByte(startAddress, true);
            message[3] = (byte)SplitIntToByte(startAddress, false);
            message[4] = (byte)SplitIntToByte(numOfCoils, true);
            message[5] = (byte)SplitIntToByte(numOfCoils, false);

            DoGUIUpdate(mb.SendCommand(message, ref response, ref values));
            return values;
        }
        private void chCoils_CheckedChanged(object sender, EventArgs e)
        {

            if ((sender as CheckBox).Name == "ChkLED1")
                SetSingleCoil(Convert.ToInt32(txCoilSlaveId.Text, 16), 16, (sender as CheckBox).Checked);
            if ((sender as CheckBox).Name == "ChkLED2")
                SetSingleCoil(Convert.ToInt32(txCoilSlaveId.Text, 16), 17, (sender as CheckBox).Checked);
            if ((sender as CheckBox).Name == "ChkLED3")
                SetSingleCoil(Convert.ToInt32(txCoilSlaveId.Text, 16), 18, (sender as CheckBox).Checked);
            if ((sender as CheckBox).Name == "ChkLED4")
                SetSingleCoil(Convert.ToInt32(txCoilSlaveId.Text, 16), 19, (sender as CheckBox).Checked);
        }
        #endregion

        #region SplitIntToByte
        private int SplitIntToByte(int value, bool highValue)
        {
            string hexValue = Convert.ToString(Convert.ToInt32(value.ToString(), 10), 16);
            if (hexValue != null && hexValue.Length < 3 && highValue)
                return 0;
            else if (hexValue != null && hexValue.Length < 3 && !highValue)
                return value;
            else if (hexValue != null && hexValue.Length == 3 && !highValue)
                return Convert.ToInt32(hexValue.Substring(1, 2), 16);
            else if (hexValue != null && hexValue.Length == 3 && highValue)
                return Convert.ToInt32(hexValue.Substring(0, 1), 16);
            else if (hexValue != null && hexValue.Length == 4 && !highValue)
                return Convert.ToInt32(hexValue.Substring(2, 2), 16);
            else if (hexValue != null && hexValue.Length == 4 && highValue)
                return Convert.ToInt32(hexValue.Substring(0, 2), 16);
            else
                return 0;

        }
        #endregion

        #region CombineBytesToInt
        private int CombineBytesToInt(byte[] array)
        {
            return Convert.ToInt32(mb.ConvertToHexString(array, false), 16);
        }
        #endregion

        #region ExtBoard Slave functions
        private void btnGetCoilStatus_Click(object sender, EventArgs e)
        {
            short[] values = GetCoilStatus(Convert.ToInt32(txCoilSlaveId.Text, 16), 16, 4);
            if (values == null || values.Length != 1)
                return;
            ChkLED1.CheckedChanged -= chCoils_CheckedChanged;
            ChkLED2.CheckedChanged -= chCoils_CheckedChanged;
            ChkLED3.CheckedChanged -= chCoils_CheckedChanged;
            ChkLED4.CheckedChanged -= chCoils_CheckedChanged;

            ChkLED1.Checked = ((values[0] & (1 << 0)) != 0);  //BitConverter.GetBytes((values[0] & (1 << bit) != 0; 
            ChkLED2.Checked = ((values[0] & (1 << 1)) != 0);
            ChkLED3.Checked = ((values[0] & (1 << 2)) != 0);
            ChkLED4.Checked = ((values[0] & (1 << 3)) != 0);

            ChkLED1.CheckedChanged += chCoils_CheckedChanged;
            ChkLED2.CheckedChanged += chCoils_CheckedChanged;
            ChkLED3.CheckedChanged += chCoils_CheckedChanged;
            ChkLED4.CheckedChanged += chCoils_CheckedChanged;
        }

        private void txHolding_TextChanged(object sender, EventArgs e)
        {
            tBarHolding.ValueChanged -= tBarHolding_ValueChanged;
            //tBarHolding.Value = Convert.ToInt16(txHoldingValue.Text);
            tBarHolding.ValueChanged += tBarHolding_ValueChanged;
        }

        private void tBarHolding_ValueChanged(object sender, EventArgs e)
        {
            txHoldingValue.TextChanged -= txHolding_TextChanged;
            txHoldingValue.Text = tBarHolding.Value.ToString();
            txHoldingValue.TextChanged += txHolding_TextChanged;
        }

        private void bnGetSwitches_Click(object sender, EventArgs e)
        {

        }

        private void btnInputRegGet_Click(object sender, EventArgs e)
        {
            mb.ValidateRXCRC16 = chValidateCrc16.Checked;
            byte[] message = new byte[8];
            byte[] response = new byte[8];
            short[] values = new short[1];
            message[0] = (byte)Convert.ToInt32(txInputRegSlaveId.Text, 16);
            message[1] = 0x04;
            message[2] = (byte)SplitIntToByte(Convert.ToInt32(txtInputStartAddr.Text, 16), true);
            message[3] = (byte)SplitIntToByte(Convert.ToInt32(txtInputStartAddr.Text, 16), false);
            message[4] = (byte)SplitIntToByte(Convert.ToInt32(txtInputQty.Text, 16), true);
            message[5] = (byte)SplitIntToByte(Convert.ToInt32(txtInputQty.Text, 16), false);

            DoGUIUpdate(mb.SendCommand(message, ref response, ref values));
            //prgBarInput.Value = Convert.ToInt32(response[4]);
            txInputValue.Text = response[4].ToString();
            Application.DoEvents();
        }

        private void btnHoldingRegGet_Click(object sender, EventArgs e)
        {
            mb.ValidateRXCRC16 = chValidateCrc16.Checked;
            byte[] message = new byte[8];
            byte[] response = new byte[8];
            short[] values = new short[1];
            message[0] = (byte)Convert.ToInt32(txHoldingSlaveId.Text, 16);
            message[1] = 0x03;
            message[2] = (byte)SplitIntToByte(Convert.ToInt32(txtHoldingStartAddr.Text, 16), true);
            message[3] = (byte)SplitIntToByte(Convert.ToInt32(txtHoldingStartAddr.Text, 16), false);
            message[4] = (byte)SplitIntToByte(Convert.ToInt32(txtHoldingQty.Text, 16), true);
            message[5] = (byte)SplitIntToByte(Convert.ToInt32(txtHoldingQty.Text, 16), false);

            DoGUIUpdate(mb.SendCommand(message, ref response, ref values));
            txHoldingValue.Text = mb.ConvertToHexString(new byte[] { response[3], response[4] }, false);
        }

        private void btnHoldingRegSet_Click(object sender, EventArgs e)
        {
            mb.ValidateRXCRC16 = chValidateCrc16.Checked;
            byte[] message = new byte[8];
            byte[] response = new byte[8];
            short[] values = new short[1];
            message[0] = (byte)Convert.ToInt32(txHoldingSlaveId.Text, 16);
            message[1] = 0x06;
            message[2] = (byte)SplitIntToByte(Convert.ToInt32(txtHoldingStartAddr.Text, 16), true);
            message[3] = (byte)SplitIntToByte(Convert.ToInt32(txtHoldingStartAddr.Text, 16), false);
            message[4] = (byte)SplitIntToByte(Convert.ToInt32(txHoldingValue.Text, 16), true);
            message[5] = (byte)SplitIntToByte(Convert.ToInt32(txHoldingValue.Text, 16), false);

            DoGUIUpdate(mb.SendCommand(message, ref response, ref values));
            //txHoldingValue.Text = response[4].ToString();
        }
        #endregion

        #region Start/Stop Slave
        private void bnStartStoppSlave_Click(object sender, EventArgs e)
        {
            if (bnStartStoppSlave.BackColor == Color.Red)
            {
                bnStartStoppSlave.BackColor = Color.Green;
                bnStartStoppSlave.Text = "Disconnect";
                slaveTimer.Interval = 1;
                slaveTimer.Start();
                slaveRXTXClear.Interval = 1000;
                slaveRXTXClear.Start();
                
                //_spManager.NewSerialDataRecieved += new EventHandler<SerialDataEventArgs>(_spManager_NewSerialDataRecieved);
            }
            else
            {
                bnStartStoppSlave.BackColor = Color.Red;
                bnStartStoppSlave.Text = "Connect";
                slaveTimer.Stop();
                slaveRXTXClear.Stop();
                //_spManager.NewSerialDataRecieved -= new EventHandler<SerialDataEventArgs>(_spManager_NewSerialDataRecieved);

            }
        }
        #endregion

        #region slaveTimer_Elapsed
        void slaveTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (this.InvokeRequired)
            {
                // Using this.Invoke causes deadlock when closing serial port, and BeginInvoke is good practice anyway.
                this.BeginInvoke(new EventHandler<System.Timers.ElapsedEventArgs>(slaveTimer_Elapsed), new object[] { sender, e });
                return;
            }
            byte[] bytes = new byte[0];
            try
            {
                bytes = _spManager.GetAllBytes();
            }
            catch { }
            if (bytes.Length > 0)
            {
                btnRx.BackColor = Color.Green;
                foreach (byte item in bytes)
                    serialData.Add(item);
            }

            if (serialData.Count > 4)
            {
                HandleMasterRequest(serialData.ToArray<byte>());
                serialData = new List<byte>();
            }
        }
        //void SplitData(byte[] rxData)
        //{
        //    try
        //    {
        //        for (int i = 0; i < length; i++)
        //        {
        //            if(rxData)
        //        }
        //    }
        //    if()
        //}
        void slaveRXTXClear_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (this.InvokeRequired)
            {
                // Using this.Invoke causes deadlock when closing serial port, and BeginInvoke is good practice anyway.
                this.BeginInvoke(new EventHandler<System.Timers.ElapsedEventArgs>(slaveRXTXClear_Elapsed), new object[] { sender, e });
                return;
            }
            btnRx.BackColor = Color.Red;
            btnTx.BackColor = Color.Red;
        }
        #endregion

        #region _spManager_NewSerialDataRecieved
        /// <summary>
        /// Event for new data on serialport
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void _spManager_NewSerialDataRecieved(object sender, SerialDataEventArgs e)
        {
            if (this.InvokeRequired)
            {
                // Using this.Invoke causes deadlock when closing serial port, and BeginInvoke is good practice anyway.
                this.BeginInvoke(new EventHandler<SerialDataEventArgs>(_spManager_NewSerialDataRecieved), new object[] { sender, e });
                return;
            }

            //foreach (byte item in e.Data.ToArray<byte>())
            //    serialData.Add(item);

            HandleMasterRequest(e.Data.ToArray<byte>());
        }
        #endregion

        #region HandleMasterRequest
        void HandleMasterRequest(byte[] rxData)
        {
            if (rxData.Length < 5)
                return;
            if (!mb.CheckResponse(rxData))
                rxCrcError++;
            else
                rxCrcOk++;

            if (rxData.Length < 5 || rxData.Length > 256 || (chValidateCrc16.Checked && !mb.CheckResponse(rxData)))
            {
                DoGUIUpdate("RX:" + mb.ConvertToHexString(rxData) + (chValidateCrc16.Checked == true ? CheckRXCRC(rxData) : "") + "\t\t\tUNPROSSED\t\t\t" + DateTime.Now.Second.ToString() + ":" + DateTime.Now.Millisecond.ToString() + Environment.NewLine);
                return;
            }

            if (chAutoRespond.Checked && rxData[1] == 0x01 && rxData.Length > 2)
                CoilRespons(rxData);
            else if (chAutoRespond.Checked && rxData[1] == 0x02 && rxData.Length > 2)
                ReadInputStatus(rxData);
            else if (chAutoRespond.Checked && rxData[1] == 0x03 && rxData.Length > 5)
                ReadHoldingRegister(rxData);
            else if (chAutoRespond.Checked && rxData[1] == 0x04 && rxData.Length > 2)
                InputRegisterRespons(rxData);
            else if (chAutoRespond.Checked && rxData[1] == 0x05 && rxData.Length > 5)
                WriteSingleCoilRespons(rxData);
            else if (chAutoRespond.Checked && rxData[1] == 0x06 && rxData.Length > 5)
                WriteSingleHoldingRegister(rxData);
            else if (chAutoRespond.Checked && rxData[1] == 0x0F && rxData.Length > 5) //15
                ForceMultipleCoils(rxData);
            else if (chAutoRespond.Checked && rxData[1] == 0x10 && rxData.Length > 5) //16
                PresetMultipleRegisters(rxData);
            else
                DoGUIUpdate("RX:" + mb.ConvertToHexString(rxData) + (chValidateCrc16.Checked == true ? CheckRXCRC(rxData) : "") + "\t\t\tUNPROSSED\t\t\t" + DateTime.Now.Second.ToString() + ":" + DateTime.Now.Millisecond.ToString() + Environment.NewLine);


        }
        #endregion

        #region Grid Inverter simulator
        void SetRelays(byte[] rxData)
        {
            //01 0f 07 d0 00 08 01 01 ff 30--  Realy on
            //01 0f 07 d0 00 08 01 00 3e f0 - crc ok Relay OFf

            if (rxData[2] == 0x07 && rxData[3] == 0xd0 && rxData[4] == 0x00 && rxData[5] == 0x08)
            {
                if ((rxData[7] & (1 << 0)) == 1)
                    chRlyPInv.Checked = true;
                else
                    chRlyPInv.Checked = false;

                if ((rxData[7] & (1 << 1)) == 2)
                    chRlyNInv.Checked = true;
                else
                    chRlyNInv.Checked = false;

                if ((rxData[7] & (1 << 2)) == 4)
                    chRlyPGrid.Checked = true;
                else
                    chRlyPGrid.Checked = false;

                if ((rxData[7] & (1 << 3)) == 8)
                    chRlyNGrid.Checked = true;
                else
                    chRlyNGrid.Checked = false;
            }
        }
        void ForceMultipleCoils(byte[] rxData)
        {
            mb.ValidateRXCRC16 = chValidateCrc16.Checked;
            byte[] message = new byte[8];
            message[0] = (byte)Convert.ToInt32(txHoldingSlaveId.Text, 16);
            message[1] = 0x0F;
            message[2] = rxData[2];
            message[3] = rxData[3];
            message[4] = rxData[4];
            message[5] = rxData[5];

            if (rxData[2] == 0x07 && rxData[3] == 0xd0 && rxData[4] == 0x00 && rxData[5] == 0x08)
                SetRelays(rxData);
            if (chAutoClear.Checked == true)
                DoGUIClear();

            DoGUIUpdate("RX:" + mb.ConvertToHexString(rxData) + CheckRXCRC(rxData) + "\t\t\tForceMultipleCoils\t\t\t" + DateTime.Now.Second.ToString() + ":" + DateTime.Now.Millisecond.ToString() + Environment.NewLine);
            btnTx.BackColor = Color.Green;
            DoGUIUpdate(mb.SendCommand(message));
        }
        void ReadInputStatus(byte[] rxData)
        {
            mb.ValidateRXCRC16 = chValidateCrc16.Checked;
            byte[] array = { rxData[4], rxData[5] };
            int coils = CombineBytesToInt(array);
            byte[] message = new byte[(int)Math.Ceiling(((double)coils / 8)) + 5];
            message[0] = (byte)Convert.ToInt32(txHoldingSlaveId.Text, 16);
            message[1] = 0x02;
            message[2] = (byte)((int)Math.Ceiling((double)coils / 8)); //number of bytes returned;

            for (int i = 3; i < message.Length; i++)
            {
                message[i] = (byte)Convert.ToInt32(txInput.Text, 16); ;
            }

            if (chAutoClear.Checked == true)
                DoGUIClear();

            DoGUIUpdate("RX:" + mb.ConvertToHexString(rxData) + CheckRXCRC(rxData) + " ReadInputStatus - " + DateTime.Now.Second.ToString() + ":" + DateTime.Now.Millisecond.ToString() + Environment.NewLine);
            btnTx.BackColor = Color.Green;
            DoGUIUpdate(mb.SendCommand(message));
        }
        void PresetMultipleRegisters(byte[] rxData)
        {
            DoGUIUpdate("RX:" + mb.ConvertToHexString(rxData));
            mb.ValidateRXCRC16 = chValidateCrc16.Checked;

            byte[] message = new byte[8];
            message[0] = rxData[0];
            message[1] = rxData[1];
            message[2] = rxData[2];
            message[3] = rxData[3];
            message[4] = rxData[4];
            message[5] = rxData[5];

            if (chAutoClear.Checked == true)
                DoGUIClear();
            DoGUIUpdate("RX:" + mb.ConvertToHexString(rxData) + " PresetMultipleRegisters - " + DateTime.Now.Second.ToString() + ":" + DateTime.Now.Millisecond.ToString() + Environment.NewLine);
            btnTx.BackColor = Color.Green;
            DoGUIUpdate(mb.SendCommand(message));
        }
        void ReadHoldingRegister(byte[] rxData)
        {
            //01 03 00 00 00 0a c5 cd 
            DoGUIUpdate("RX:" + mb.ConvertToHexString(rxData));
            mb.ValidateRXCRC16 = chValidateCrc16.Checked;

            byte[] array = { rxData[4], rxData[5] };
            int registers = CombineBytesToInt(array);
            byte[] message = new byte[5 + (registers * 2)];
            message[0] = rxData[0];
            message[1] = rxData[1];
            message[2] = (byte)(registers * 2); //number of bytes returned;

            for (int i = 3; i < message.Length - 3; i += 2)
            {
                message[i] = (byte)Convert.ToInt32(txHoldingLow.Text, 16);
                message[i + 1] = (byte)Convert.ToInt32(txHoldingHigh.Text, 16);
            }

            if (chAutoClear.Checked == true)
                DoGUIClear();
            DoGUIUpdate("RX:" + mb.ConvertToHexString(rxData) + " ReadHoldingRegister - " + DateTime.Now.Second.ToString() + ":" + DateTime.Now.Millisecond.ToString() + Environment.NewLine);
            btnTx.BackColor = Color.Green;
            DoGUIUpdate(mb.SendCommand(message));
        }
        void CoilRespons(byte[] rxData)
        {
            mb.ValidateRXCRC16 = chValidateCrc16.Checked;
            byte[] array = { rxData[4], rxData[5] };
            int coils = CombineBytesToInt(array); 
            byte[] message = new byte[(int)Math.Ceiling(((double)coils / 8)) + 5];
            byte coilValue = 0;
            if (rxData[3] == 0x3c && chSlaveLed1.Checked)
                coilValue = 0x01;
            if (rxData[3] == 0x3c && chSlaveLed2.Checked)
                coilValue += 0x08;

            message[0] = (byte)Convert.ToInt32(txHoldingSlaveId.Text, 16);
            message[1] = 0x01;
            message[2] = (byte)((int)Math.Ceiling((double)coils / 8)); //number of bytes returned;
            message[3] = coilValue;
            for (int i = 4; i < message.Length; i++)
            {
                message[i] = (byte)Convert.ToInt32(txCoil.Text, 10);
            }

            if (chAutoClear.Checked == true)
                DoGUIClear();

            DoGUIUpdate("RX:" + mb.ConvertToHexString(rxData) + CheckRXCRC(rxData) + "\t\t\tCoilRespons\t\t\t" + DateTime.Now.Second.ToString() + ":" + DateTime.Now.Millisecond.ToString() + Environment.NewLine);
            btnTx.BackColor = Color.Green;
            DoGUIUpdate(mb.SendCommand(message, chMakeCrcError.Checked));
        }
        private string CheckRXCRC(byte[] rxData)
        {
            string crc = "";
            if (chValidateCrc16.Checked)
            {
                crc = " - crc ok";
                try
                {
                    if (!mb.CheckResponse(rxData))
                        crc = " - crc ERROR";
                }
                catch (Exception e)
                {
                    crc = " - " + e.Message;
                }
            }
            return crc;
        }
        void InputRegisterRespons(byte[] rxData)
        {
            mb.ValidateRXCRC16 = chValidateCrc16.Checked;
            byte[] array = { rxData[4], rxData[5] };
            int registers = CombineBytesToInt(array);
            byte[] message = new byte[5 + (registers * 2)];

            //byte[] message = new byte[7];
            message[0] = (byte)Convert.ToInt32(txHoldingSlaveId.Text, 16);
            message[1] = 0x04;
            //message[2] = 0x01;
            //message[3] = 0x00;
            //message[4] = (byte)tBSlaveValue.Value;

            if (chAutoClear.Checked == true)
                DoGUIClear();


            message[2] = (byte)(registers * 2); //number of bytes returned;
            //message[3] = 0x00;
            //message[4] = (byte)tBSlaveValue.Value;
            for (int i = 3; i < message.Length - 3; i += 2)
            {
                message[i] = (byte)Convert.ToInt32(txHoldingLow.Text, 16);
                message[i + 1] = (byte)Convert.ToInt32(txHoldingHigh.Text, 16);
            }

            DoGUIUpdate("RX:" + mb.ConvertToHexString(rxData) + CheckRXCRC(rxData) + " InputRegisterRespons - " + DateTime.Now.Second.ToString() + ":" + DateTime.Now.Millisecond.ToString() + Environment.NewLine);
            btnTx.BackColor = Color.Green;
            DoGUIUpdate(mb.SendCommand(message));
        }
        void WriteSingleCoilRespons(byte[] rxData)
        {
            txSlaveValue.Text = rxData[4].ToString() + rxData[5].ToString();
            mb.ValidateRXCRC16 = chValidateCrc16.Checked;
            byte[] message = new byte[7];
            message[0] = (byte)Convert.ToInt32(txHoldingSlaveId.Text, 16);
            message[1] = 0x05;
            message[2] = rxData[2];
            message[3] = rxData[3];
            message[4] = rxData[4]; 
            message[5] = rxData[5];

            if (chAutoClear.Checked == true)
                DoGUIClear();
            DoGUIUpdate("RX:" + mb.ConvertToHexString(rxData) + CheckRXCRC(rxData) + " WriteSingleHoldingRegister - " + DateTime.Now.Second.ToString() + ":" + DateTime.Now.Millisecond.ToString() + Environment.NewLine);
            btnTx.BackColor = Color.Green;
            DoGUIUpdate(mb.SendCommand(message));
        }
        void WriteSingleHoldingRegister(byte[] rxData)
        {
            txSlaveValue.Text = rxData[4].ToString() + rxData[5].ToString();
            mb.ValidateRXCRC16 = chValidateCrc16.Checked;
            byte[] message = new byte[7];
            message[0] = (byte)Convert.ToInt32(txHoldingSlaveId.Text, 16);
            message[1] = 0x06;
            message[2] = rxData[2];
            message[3] = rxData[3];
            message[4] = (byte)SplitIntToByte(Convert.ToInt32(txSlaveValue.Text, 16), true);
            message[5] = (byte)SplitIntToByte(Convert.ToInt32(txSlaveValue.Text, 16), false);

            if (chAutoClear.Checked == true)
                DoGUIClear();
            DoGUIUpdate("RX:" + mb.ConvertToHexString(rxData) + CheckRXCRC(rxData) + " WriteSingleHoldingRegister - " + DateTime.Now.Second.ToString() + ":" + DateTime.Now.Millisecond.ToString() + Environment.NewLine);
            btnTx.BackColor = Color.Green;
            DoGUIUpdate(mb.SendCommand(message));
        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            if ((sender as TrackBar).Name == "tBarCoil")
                txCoil.Text = (sender as TrackBar).Value.ToString();
            else if ((sender as TrackBar).Name == "tBInput")
                txInput.Text = (sender as TrackBar).Value.ToString();
            else if ((sender as TrackBar).Name == "tBarHoldingLow")
                txHoldingLow.Text = (sender as TrackBar).Value.ToString();
            else if ((sender as TrackBar).Name == "tBarHoldingHigh")
                txHoldingHigh.Text = (sender as TrackBar).Value.ToString();
        }
        #endregion

        private void btnFreze_Click(object sender, EventArgs e)
        {
            if (btnFreze.BackColor == Color.Red)
            {
                btnFreze.BackColor = Color.Green;
                btnFreze.Text = "FREZZE";
            }
            else
            {
                btnFreze.BackColor = Color.Red;
                btnFreze.Text = "RUN";

            }
        }
    }
}
