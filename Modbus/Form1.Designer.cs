namespace Modbus
{
    partial class Modbus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label stopBitsLabel;
            System.Windows.Forms.Label dataBitsLabel;
            System.Windows.Forms.Label parityLabel;
            this.txAddress = new System.Windows.Forms.TextBox();
            this.txMessageFrame = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.laAddress = new System.Windows.Forms.Label();
            this.laFunction = new System.Windows.Forms.Label();
            this.txFunction = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.laData0 = new System.Windows.Forms.Label();
            this.txData0 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.laData1 = new System.Windows.Forms.Label();
            this.txData1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.laData2 = new System.Windows.Forms.Label();
            this.txData2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.laCrcHi = new System.Windows.Forms.Label();
            this.txCrcHi = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.laCrcLo = new System.Windows.Forms.Label();
            this.txCrcLo = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.laData3 = new System.Windows.Forms.Label();
            this.txData3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.laMessageFrame = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.chMakeCrcError = new System.Windows.Forms.CheckBox();
            this.chAutoRespond = new System.Windows.Forms.CheckBox();
            this.chValidateCrc16 = new System.Windows.Forms.CheckBox();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.serialSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stopBitsComboBox = new System.Windows.Forms.ComboBox();
            this.portNameComboBox = new System.Windows.Forms.ComboBox();
            this.parityComboBox = new System.Windows.Forms.ComboBox();
            this.dataBitsComboBox = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.chFilterOutput = new System.Windows.Forms.CheckBox();
            this.maFilterOutput = new System.Windows.Forms.MaskedTextBox();
            this.btnFreze = new System.Windows.Forms.Button();
            this.chScrollToChar = new System.Windows.Forms.CheckBox();
            this.chAutoClear = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.chRlyNGrid = new System.Windows.Forms.CheckBox();
            this.chRlyPGrid = new System.Windows.Forms.CheckBox();
            this.chRlyNInv = new System.Windows.Forms.CheckBox();
            this.chRlyPInv = new System.Windows.Forms.CheckBox();
            this.laRXCrcCounter = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.txHoldingHigh = new System.Windows.Forms.TextBox();
            this.laTXCrcCounter = new System.Windows.Forms.Label();
            this.tBarHoldingHigh = new System.Windows.Forms.TrackBar();
            this.label18 = new System.Windows.Forms.Label();
            this.btnTx = new System.Windows.Forms.Button();
            this.btnRx = new System.Windows.Forms.Button();
            this.txHoldingLow = new System.Windows.Forms.TextBox();
            this.tBarHoldingLow = new System.Windows.Forms.TrackBar();
            this.label16 = new System.Windows.Forms.Label();
            this.txInput = new System.Windows.Forms.TextBox();
            this.tBInput = new System.Windows.Forms.TrackBar();
            this.label14 = new System.Windows.Forms.Label();
            this.txCoil = new System.Windows.Forms.TextBox();
            this.tBarCoil = new System.Windows.Forms.TrackBar();
            this.chSlaveLed2 = new System.Windows.Forms.CheckBox();
            this.label38 = new System.Windows.Forms.Label();
            this.chSlaveLed1 = new System.Windows.Forms.CheckBox();
            this.txSlaveValue = new System.Windows.Forms.TextBox();
            this.tBSlaveValue = new System.Windows.Forms.TrackBar();
            this.bnStartStoppSlave = new System.Windows.Forms.Button();
            this.label36 = new System.Windows.Forms.Label();
            this.txHoldingSlaveId = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label32 = new System.Windows.Forms.Label();
            this.txInputValue = new System.Windows.Forms.TextBox();
            this.prgBarInput = new System.Windows.Forms.ProgressBar();
            this.txtInputQty = new System.Windows.Forms.TextBox();
            this.txInputRegSlaveId = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.btnInputRegGet = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.txtInputStartAddr = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txCoilSwSlaveId = new System.Windows.Forms.TextBox();
            this.bnGetSwitches = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.chSw4 = new System.Windows.Forms.CheckBox();
            this.chSw3 = new System.Windows.Forms.CheckBox();
            this.chSw2 = new System.Windows.Forms.CheckBox();
            this.chSw1 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnHoldingRegSet = new System.Windows.Forms.Button();
            this.label37 = new System.Windows.Forms.Label();
            this.tBarHolding = new System.Windows.Forms.TrackBar();
            this.label33 = new System.Windows.Forms.Label();
            this.txHoldingValue = new System.Windows.Forms.TextBox();
            this.txtHoldingStartAddr = new System.Windows.Forms.TextBox();
            this.txtHoldingQty = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.btnHoldingRegGet = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGetCoilStatus = new System.Windows.Forms.Button();
            this.ChkLED4 = new System.Windows.Forms.CheckBox();
            this.txCoilSlaveId = new System.Windows.Forms.TextBox();
            this.ChkLED3 = new System.Windows.Forms.CheckBox();
            this.ChkLED2 = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.ChkLED1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.BtnTransmit8 = new System.Windows.Forms.Button();
            this.txModbus8 = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.BtnTransmit7 = new System.Windows.Forms.Button();
            this.txModbus7 = new System.Windows.Forms.MaskedTextBox();
            this.BtnTransmit6 = new System.Windows.Forms.Button();
            this.txModbus6 = new System.Windows.Forms.MaskedTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.BtnTransmit5 = new System.Windows.Forms.Button();
            this.BtnTransmit4 = new System.Windows.Forms.Button();
            this.BtnTransmit3 = new System.Windows.Forms.Button();
            this.BtnTransmit2 = new System.Windows.Forms.Button();
            this.btnClearScreen = new System.Windows.Forms.Button();
            this.txModbus5 = new System.Windows.Forms.MaskedTextBox();
            this.txModbus4 = new System.Windows.Forms.MaskedTextBox();
            this.txModbus3 = new System.Windows.Forms.MaskedTextBox();
            this.txModbus2 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPoll = new System.Windows.Forms.Button();
            this.txtSampleRate = new System.Windows.Forms.TextBox();
            this.txtRegisterQty = new System.Windows.Forms.TextBox();
            this.txtStartAddr = new System.Windows.Forms.TextBox();
            this.txtSlaveID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lstDataType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbData = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            stopBitsLabel = new System.Windows.Forms.Label();
            dataBitsLabel = new System.Windows.Forms.Label();
            parityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serialSettingsBindingSource)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarHoldingHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarHoldingLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarCoil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBSlaveValue)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarHolding)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // stopBitsLabel
            // 
            stopBitsLabel.AutoSize = true;
            stopBitsLabel.Location = new System.Drawing.Point(566, 11);
            stopBitsLabel.Name = "stopBitsLabel";
            stopBitsLabel.Size = new System.Drawing.Size(52, 13);
            stopBitsLabel.TabIndex = 40;
            stopBitsLabel.Text = "Stop Bits:";
            // 
            // dataBitsLabel
            // 
            dataBitsLabel.AutoSize = true;
            dataBitsLabel.Location = new System.Drawing.Point(426, 11);
            dataBitsLabel.Name = "dataBitsLabel";
            dataBitsLabel.Size = new System.Drawing.Size(53, 13);
            dataBitsLabel.TabIndex = 35;
            dataBitsLabel.Text = "Data Bits:";
            // 
            // parityLabel
            // 
            parityLabel.AutoSize = true;
            parityLabel.Location = new System.Drawing.Point(298, 14);
            parityLabel.Name = "parityLabel";
            parityLabel.Size = new System.Drawing.Size(36, 13);
            parityLabel.TabIndex = 37;
            parityLabel.Text = "Parity:";
            // 
            // txAddress
            // 
            this.txAddress.Location = new System.Drawing.Point(12, 29);
            this.txAddress.MaxLength = 2;
            this.txAddress.Name = "txAddress";
            this.txAddress.Size = new System.Drawing.Size(49, 20);
            this.txAddress.TabIndex = 1;
            this.txAddress.Text = "0";
            this.txAddress.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // txMessageFrame
            // 
            this.txMessageFrame.Location = new System.Drawing.Point(463, 29);
            this.txMessageFrame.Name = "txMessageFrame";
            this.txMessageFrame.ReadOnly = true;
            this.txMessageFrame.Size = new System.Drawing.Size(400, 20);
            this.txMessageFrame.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Function";
            // 
            // laAddress
            // 
            this.laAddress.AutoSize = true;
            this.laAddress.Location = new System.Drawing.Point(11, 52);
            this.laAddress.Name = "laAddress";
            this.laAddress.Size = new System.Drawing.Size(49, 13);
            this.laAddress.TabIndex = 6;
            this.laAddress.Text = "0000000";
            // 
            // laFunction
            // 
            this.laFunction.AutoSize = true;
            this.laFunction.Location = new System.Drawing.Point(66, 52);
            this.laFunction.Name = "laFunction";
            this.laFunction.Size = new System.Drawing.Size(49, 13);
            this.laFunction.TabIndex = 8;
            this.laFunction.Text = "0000000";
            // 
            // txFunction
            // 
            this.txFunction.Location = new System.Drawing.Point(67, 29);
            this.txFunction.MaxLength = 2;
            this.txFunction.Name = "txFunction";
            this.txFunction.Size = new System.Drawing.Size(49, 20);
            this.txFunction.TabIndex = 2;
            this.txFunction.Text = "0";
            this.txFunction.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Data";
            // 
            // laData0
            // 
            this.laData0.AutoSize = true;
            this.laData0.Location = new System.Drawing.Point(121, 52);
            this.laData0.Name = "laData0";
            this.laData0.Size = new System.Drawing.Size(49, 13);
            this.laData0.TabIndex = 13;
            this.laData0.Text = "0000000";
            // 
            // txData0
            // 
            this.txData0.Location = new System.Drawing.Point(122, 29);
            this.txData0.MaxLength = 2;
            this.txData0.Name = "txData0";
            this.txData0.Size = new System.Drawing.Size(49, 20);
            this.txData0.TabIndex = 4;
            this.txData0.Text = "0";
            this.txData0.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(174, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Data";
            // 
            // laData1
            // 
            this.laData1.AutoSize = true;
            this.laData1.Location = new System.Drawing.Point(176, 52);
            this.laData1.Name = "laData1";
            this.laData1.Size = new System.Drawing.Size(49, 13);
            this.laData1.TabIndex = 16;
            this.laData1.Text = "0000000";
            // 
            // txData1
            // 
            this.txData1.Location = new System.Drawing.Point(177, 29);
            this.txData1.MaxLength = 2;
            this.txData1.Name = "txData1";
            this.txData1.Size = new System.Drawing.Size(49, 20);
            this.txData1.TabIndex = 5;
            this.txData1.Text = "0";
            this.txData1.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(229, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Data";
            // 
            // laData2
            // 
            this.laData2.AutoSize = true;
            this.laData2.Location = new System.Drawing.Point(231, 52);
            this.laData2.Name = "laData2";
            this.laData2.Size = new System.Drawing.Size(49, 13);
            this.laData2.TabIndex = 19;
            this.laData2.Text = "0000000";
            // 
            // txData2
            // 
            this.txData2.Location = new System.Drawing.Point(232, 29);
            this.txData2.MaxLength = 2;
            this.txData2.Name = "txData2";
            this.txData2.Size = new System.Drawing.Size(49, 20);
            this.txData2.TabIndex = 6;
            this.txData2.Text = "0";
            this.txData2.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(339, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "CRC HI";
            // 
            // laCrcHi
            // 
            this.laCrcHi.AutoSize = true;
            this.laCrcHi.Location = new System.Drawing.Point(341, 52);
            this.laCrcHi.Name = "laCrcHi";
            this.laCrcHi.Size = new System.Drawing.Size(49, 13);
            this.laCrcHi.TabIndex = 22;
            this.laCrcHi.Text = "0000000";
            // 
            // txCrcHi
            // 
            this.txCrcHi.Location = new System.Drawing.Point(342, 29);
            this.txCrcHi.MaxLength = 2;
            this.txCrcHi.Name = "txCrcHi";
            this.txCrcHi.ReadOnly = true;
            this.txCrcHi.Size = new System.Drawing.Size(49, 20);
            this.txCrcHi.TabIndex = 8;
            this.txCrcHi.Text = "0";
            this.txCrcHi.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(394, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "CRC LO";
            // 
            // laCrcLo
            // 
            this.laCrcLo.AutoSize = true;
            this.laCrcLo.Location = new System.Drawing.Point(396, 52);
            this.laCrcLo.Name = "laCrcLo";
            this.laCrcLo.Size = new System.Drawing.Size(49, 13);
            this.laCrcLo.TabIndex = 25;
            this.laCrcLo.Text = "0000000";
            // 
            // txCrcLo
            // 
            this.txCrcLo.Location = new System.Drawing.Point(397, 29);
            this.txCrcLo.MaxLength = 2;
            this.txCrcLo.Name = "txCrcLo";
            this.txCrcLo.ReadOnly = true;
            this.txCrcLo.Size = new System.Drawing.Size(49, 20);
            this.txCrcLo.TabIndex = 9;
            this.txCrcLo.Text = "0";
            this.txCrcLo.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(284, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "Data";
            // 
            // laData3
            // 
            this.laData3.AutoSize = true;
            this.laData3.Location = new System.Drawing.Point(286, 52);
            this.laData3.Name = "laData3";
            this.laData3.Size = new System.Drawing.Size(49, 13);
            this.laData3.TabIndex = 28;
            this.laData3.Text = "0000000";
            // 
            // txData3
            // 
            this.txData3.Location = new System.Drawing.Point(287, 29);
            this.txData3.MaxLength = 2;
            this.txData3.Name = "txData3";
            this.txData3.Size = new System.Drawing.Size(49, 20);
            this.txData3.TabIndex = 7;
            this.txData3.Text = "0";
            this.txData3.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "RTU message frame";
            // 
            // laMessageFrame
            // 
            this.laMessageFrame.Location = new System.Drawing.Point(464, 52);
            this.laMessageFrame.Name = "laMessageFrame";
            this.laMessageFrame.ReadOnly = true;
            this.laMessageFrame.Size = new System.Drawing.Size(399, 20);
            this.laMessageFrame.TabIndex = 32;
            this.laMessageFrame.Text = "000000000000000000000000000000000000000000000000000000000000000";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbData);
            this.splitContainer1.Size = new System.Drawing.Size(1265, 670);
            this.splitContainer1.SplitterDistance = 420;
            this.splitContainer1.TabIndex = 33;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.chMakeCrcError);
            this.splitContainer2.Panel1.Controls.Add(this.chAutoRespond);
            this.splitContainer2.Panel1.Controls.Add(this.chValidateCrc16);
            this.splitContainer2.Panel1.Controls.Add(this.baudRateComboBox);
            this.splitContainer2.Panel1.Controls.Add(this.stopBitsComboBox);
            this.splitContainer2.Panel1.Controls.Add(stopBitsLabel);
            this.splitContainer2.Panel1.Controls.Add(this.portNameComboBox);
            this.splitContainer2.Panel1.Controls.Add(dataBitsLabel);
            this.splitContainer2.Panel1.Controls.Add(this.parityComboBox);
            this.splitContainer2.Panel1.Controls.Add(this.dataBitsComboBox);
            this.splitContainer2.Panel1.Controls.Add(parityLabel);
            this.splitContainer2.Panel1.Controls.Add(this.btnStart);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.chFilterOutput);
            this.splitContainer2.Panel2.Controls.Add(this.maFilterOutput);
            this.splitContainer2.Panel2.Controls.Add(this.btnFreze);
            this.splitContainer2.Panel2.Controls.Add(this.chScrollToChar);
            this.splitContainer2.Panel2.Controls.Add(this.chAutoClear);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox7);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox6);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Panel2.Controls.Add(this.BtnTransmit8);
            this.splitContainer2.Panel2.Controls.Add(this.txModbus8);
            this.splitContainer2.Panel2.Controls.Add(this.label20);
            this.splitContainer2.Panel2.Controls.Add(this.BtnTransmit7);
            this.splitContainer2.Panel2.Controls.Add(this.txModbus7);
            this.splitContainer2.Panel2.Controls.Add(this.BtnTransmit6);
            this.splitContainer2.Panel2.Controls.Add(this.txModbus6);
            this.splitContainer2.Panel2.Controls.Add(this.label22);
            this.splitContainer2.Panel2.Controls.Add(this.label21);
            this.splitContainer2.Panel2.Controls.Add(this.label19);
            this.splitContainer2.Panel2.Controls.Add(this.BtnTransmit5);
            this.splitContainer2.Panel2.Controls.Add(this.BtnTransmit4);
            this.splitContainer2.Panel2.Controls.Add(this.BtnTransmit3);
            this.splitContainer2.Panel2.Controls.Add(this.BtnTransmit2);
            this.splitContainer2.Panel2.Controls.Add(this.btnClearScreen);
            this.splitContainer2.Panel2.Controls.Add(this.txModbus5);
            this.splitContainer2.Panel2.Controls.Add(this.txModbus4);
            this.splitContainer2.Panel2.Controls.Add(this.txModbus3);
            this.splitContainer2.Panel2.Controls.Add(this.txModbus2);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.laMessageFrame);
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Panel2.Controls.Add(this.txAddress);
            this.splitContainer2.Panel2.Controls.Add(this.label17);
            this.splitContainer2.Panel2.Controls.Add(this.txMessageFrame);
            this.splitContainer2.Panel2.Controls.Add(this.laData3);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.txData3);
            this.splitContainer2.Panel2.Controls.Add(this.laAddress);
            this.splitContainer2.Panel2.Controls.Add(this.label15);
            this.splitContainer2.Panel2.Controls.Add(this.txFunction);
            this.splitContainer2.Panel2.Controls.Add(this.laCrcLo);
            this.splitContainer2.Panel2.Controls.Add(this.laFunction);
            this.splitContainer2.Panel2.Controls.Add(this.txCrcLo);
            this.splitContainer2.Panel2.Controls.Add(this.txData0);
            this.splitContainer2.Panel2.Controls.Add(this.label13);
            this.splitContainer2.Panel2.Controls.Add(this.laData0);
            this.splitContainer2.Panel2.Controls.Add(this.laCrcHi);
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Panel2.Controls.Add(this.txCrcHi);
            this.splitContainer2.Panel2.Controls.Add(this.txData1);
            this.splitContainer2.Panel2.Controls.Add(this.label11);
            this.splitContainer2.Panel2.Controls.Add(this.laData1);
            this.splitContainer2.Panel2.Controls.Add(this.laData2);
            this.splitContainer2.Panel2.Controls.Add(this.label9);
            this.splitContainer2.Panel2.Controls.Add(this.txData2);
            this.splitContainer2.Size = new System.Drawing.Size(1265, 420);
            this.splitContainer2.SplitterDistance = 52;
            this.splitContainer2.TabIndex = 0;
            // 
            // chMakeCrcError
            // 
            this.chMakeCrcError.AutoSize = true;
            this.chMakeCrcError.Location = new System.Drawing.Point(844, 30);
            this.chMakeCrcError.Name = "chMakeCrcError";
            this.chMakeCrcError.Size = new System.Drawing.Size(102, 17);
            this.chMakeCrcError.TabIndex = 84;
            this.chMakeCrcError.Text = "Make CRC error";
            this.chMakeCrcError.UseVisualStyleBackColor = true;
            // 
            // chAutoRespond
            // 
            this.chAutoRespond.AutoSize = true;
            this.chAutoRespond.Checked = true;
            this.chAutoRespond.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chAutoRespond.Location = new System.Drawing.Point(743, 30);
            this.chAutoRespond.Name = "chAutoRespond";
            this.chAutoRespond.Size = new System.Drawing.Size(89, 17);
            this.chAutoRespond.TabIndex = 83;
            this.chAutoRespond.Text = "Auto respond";
            this.chAutoRespond.UseVisualStyleBackColor = true;
            // 
            // chValidateCrc16
            // 
            this.chValidateCrc16.AutoSize = true;
            this.chValidateCrc16.Checked = true;
            this.chValidateCrc16.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chValidateCrc16.Location = new System.Drawing.Point(744, 11);
            this.chValidateCrc16.Name = "chValidateCrc16";
            this.chValidateCrc16.Size = new System.Drawing.Size(222, 17);
            this.chValidateCrc16.TabIndex = 42;
            this.chValidateCrc16.Text = "Perform ModBus CRC16 validation on RX";
            this.chValidateCrc16.UseVisualStyleBackColor = true;
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "BaudRate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.Location = new System.Drawing.Point(188, 8);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(103, 21);
            this.baudRateComboBox.TabIndex = 34;
            // 
            // stopBitsComboBox
            // 
            this.stopBitsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "StopBits", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.stopBitsComboBox.FormattingEnabled = true;
            this.stopBitsComboBox.Location = new System.Drawing.Point(615, 8);
            this.stopBitsComboBox.Name = "stopBitsComboBox";
            this.stopBitsComboBox.Size = new System.Drawing.Size(84, 21);
            this.stopBitsComboBox.TabIndex = 41;
            // 
            // portNameComboBox
            // 
            this.portNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "PortName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.portNameComboBox.FormattingEnabled = true;
            this.portNameComboBox.Location = new System.Drawing.Point(81, 8);
            this.portNameComboBox.Name = "portNameComboBox";
            this.portNameComboBox.Size = new System.Drawing.Size(101, 21);
            this.portNameComboBox.TabIndex = 39;
            // 
            // parityComboBox
            // 
            this.parityComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "Parity", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.parityComboBox.FormattingEnabled = true;
            this.parityComboBox.Location = new System.Drawing.Point(335, 8);
            this.parityComboBox.Name = "parityComboBox";
            this.parityComboBox.Size = new System.Drawing.Size(85, 21);
            this.parityComboBox.TabIndex = 38;
            // 
            // dataBitsComboBox
            // 
            this.dataBitsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "DataBits", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dataBitsComboBox.FormattingEnabled = true;
            this.dataBitsComboBox.Location = new System.Drawing.Point(485, 8);
            this.dataBitsComboBox.Name = "dataBitsComboBox";
            this.dataBitsComboBox.Size = new System.Drawing.Size(75, 21);
            this.dataBitsComboBox.TabIndex = 36;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(3, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(72, 45);
            this.btnStart.TabIndex = 29;
            this.btnStart.Text = "Connect";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // chFilterOutput
            // 
            this.chFilterOutput.AutoSize = true;
            this.chFilterOutput.Location = new System.Drawing.Point(1144, 47);
            this.chFilterOutput.Name = "chFilterOutput";
            this.chFilterOutput.Size = new System.Drawing.Size(81, 17);
            this.chFilterOutput.TabIndex = 93;
            this.chFilterOutput.Text = "Filter output";
            this.chFilterOutput.UseVisualStyleBackColor = true;
            // 
            // maFilterOutput
            // 
            this.maFilterOutput.Location = new System.Drawing.Point(1144, 21);
            this.maFilterOutput.Mask = "aa aa aa aa aa aa ";
            this.maFilterOutput.Name = "maFilterOutput";
            this.maFilterOutput.Size = new System.Drawing.Size(109, 20);
            this.maFilterOutput.TabIndex = 92;
            this.maFilterOutput.Text = "010F07D0";
            // 
            // btnFreze
            // 
            this.btnFreze.Location = new System.Drawing.Point(1178, 70);
            this.btnFreze.Name = "btnFreze";
            this.btnFreze.Size = new System.Drawing.Size(75, 23);
            this.btnFreze.TabIndex = 82;
            this.btnFreze.Text = "Freeze";
            this.btnFreze.UseVisualStyleBackColor = true;
            this.btnFreze.Click += new System.EventHandler(this.btnFreze_Click);
            // 
            // chScrollToChar
            // 
            this.chScrollToChar.AutoSize = true;
            this.chScrollToChar.Checked = true;
            this.chScrollToChar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chScrollToChar.Location = new System.Drawing.Point(1179, 137);
            this.chScrollToChar.Name = "chScrollToChar";
            this.chScrollToChar.Size = new System.Drawing.Size(85, 17);
            this.chScrollToChar.TabIndex = 81;
            this.chScrollToChar.Text = "Scroll to end";
            this.chScrollToChar.UseVisualStyleBackColor = true;
            // 
            // chAutoClear
            // 
            this.chAutoClear.AutoSize = true;
            this.chAutoClear.Checked = true;
            this.chAutoClear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chAutoClear.Location = new System.Drawing.Point(1179, 122);
            this.chAutoClear.Name = "chAutoClear";
            this.chAutoClear.Size = new System.Drawing.Size(74, 17);
            this.chAutoClear.TabIndex = 79;
            this.chAutoClear.Text = "Auto clear";
            this.chAutoClear.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.chRlyNGrid);
            this.groupBox7.Controls.Add(this.chRlyPGrid);
            this.groupBox7.Controls.Add(this.chRlyNInv);
            this.groupBox7.Controls.Add(this.chRlyPInv);
            this.groupBox7.Controls.Add(this.laRXCrcCounter);
            this.groupBox7.Controls.Add(this.label39);
            this.groupBox7.Controls.Add(this.txHoldingHigh);
            this.groupBox7.Controls.Add(this.laTXCrcCounter);
            this.groupBox7.Controls.Add(this.tBarHoldingHigh);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.btnTx);
            this.groupBox7.Controls.Add(this.btnRx);
            this.groupBox7.Controls.Add(this.txHoldingLow);
            this.groupBox7.Controls.Add(this.tBarHoldingLow);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.txInput);
            this.groupBox7.Controls.Add(this.tBInput);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.txCoil);
            this.groupBox7.Controls.Add(this.tBarCoil);
            this.groupBox7.Controls.Add(this.chSlaveLed2);
            this.groupBox7.Controls.Add(this.label38);
            this.groupBox7.Controls.Add(this.chSlaveLed1);
            this.groupBox7.Controls.Add(this.txSlaveValue);
            this.groupBox7.Controls.Add(this.tBSlaveValue);
            this.groupBox7.Controls.Add(this.bnStartStoppSlave);
            this.groupBox7.Controls.Add(this.label36);
            this.groupBox7.Controls.Add(this.txHoldingSlaveId);
            this.groupBox7.Location = new System.Drawing.Point(780, 202);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(482, 149);
            this.groupBox7.TabIndex = 73;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Slave";
            // 
            // chRlyNGrid
            // 
            this.chRlyNGrid.AutoSize = true;
            this.chRlyNGrid.Location = new System.Drawing.Point(409, 66);
            this.chRlyNGrid.Name = "chRlyNGrid";
            this.chRlyNGrid.Size = new System.Drawing.Size(76, 17);
            this.chRlyNGrid.TabIndex = 94;
            this.chRlyNGrid.Text = "RLY N grd";
            this.chRlyNGrid.UseVisualStyleBackColor = true;
            // 
            // chRlyPGrid
            // 
            this.chRlyPGrid.AutoSize = true;
            this.chRlyPGrid.Location = new System.Drawing.Point(409, 50);
            this.chRlyPGrid.Name = "chRlyPGrid";
            this.chRlyPGrid.Size = new System.Drawing.Size(75, 17);
            this.chRlyPGrid.TabIndex = 93;
            this.chRlyPGrid.Text = "RLY P grd";
            this.chRlyPGrid.UseVisualStyleBackColor = true;
            // 
            // chRlyNInv
            // 
            this.chRlyNInv.AutoSize = true;
            this.chRlyNInv.Location = new System.Drawing.Point(409, 34);
            this.chRlyNInv.Name = "chRlyNInv";
            this.chRlyNInv.Size = new System.Drawing.Size(75, 17);
            this.chRlyNInv.TabIndex = 92;
            this.chRlyNInv.Text = "RLY N inv";
            this.chRlyNInv.UseVisualStyleBackColor = true;
            // 
            // chRlyPInv
            // 
            this.chRlyPInv.AutoSize = true;
            this.chRlyPInv.Location = new System.Drawing.Point(409, 18);
            this.chRlyPInv.Name = "chRlyPInv";
            this.chRlyPInv.Size = new System.Drawing.Size(74, 17);
            this.chRlyPInv.TabIndex = 91;
            this.chRlyPInv.Text = "RLY P inv";
            this.chRlyPInv.UseVisualStyleBackColor = true;
            // 
            // laRXCrcCounter
            // 
            this.laRXCrcCounter.AutoSize = true;
            this.laRXCrcCounter.Location = new System.Drawing.Point(43, 128);
            this.laRXCrcCounter.Name = "laRXCrcCounter";
            this.laRXCrcCounter.Size = new System.Drawing.Size(66, 13);
            this.laRXCrcCounter.TabIndex = 82;
            this.laRXCrcCounter.Text = "crc error/ok:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(203, 100);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(46, 13);
            this.label39.TabIndex = 88;
            this.label39.Text = "Holding:";
            // 
            // txHoldingHigh
            // 
            this.txHoldingHigh.Location = new System.Drawing.Point(258, 97);
            this.txHoldingHigh.MaxLength = 4;
            this.txHoldingHigh.Name = "txHoldingHigh";
            this.txHoldingHigh.Size = new System.Drawing.Size(49, 20);
            this.txHoldingHigh.TabIndex = 90;
            this.txHoldingHigh.Text = "0";
            // 
            // laTXCrcCounter
            // 
            this.laTXCrcCounter.AutoSize = true;
            this.laTXCrcCounter.Location = new System.Drawing.Point(43, 105);
            this.laTXCrcCounter.Name = "laTXCrcCounter";
            this.laTXCrcCounter.Size = new System.Drawing.Size(66, 13);
            this.laTXCrcCounter.TabIndex = 80;
            this.laTXCrcCounter.Text = "crc error/ok:";
            // 
            // tBarHoldingHigh
            // 
            this.tBarHoldingHigh.Location = new System.Drawing.Point(319, 96);
            this.tBarHoldingHigh.Maximum = 255;
            this.tBarHoldingHigh.Name = "tBarHoldingHigh";
            this.tBarHoldingHigh.Size = new System.Drawing.Size(69, 45);
            this.tBarHoldingHigh.TabIndex = 89;
            this.tBarHoldingHigh.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(203, 71);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 13);
            this.label18.TabIndex = 85;
            this.label18.Text = "Holding:";
            // 
            // btnTx
            // 
            this.btnTx.Location = new System.Drawing.Point(6, 95);
            this.btnTx.Name = "btnTx";
            this.btnTx.Size = new System.Drawing.Size(31, 23);
            this.btnTx.TabIndex = 81;
            this.btnTx.Text = "TX";
            this.btnTx.UseVisualStyleBackColor = true;
            // 
            // btnRx
            // 
            this.btnRx.Location = new System.Drawing.Point(6, 118);
            this.btnRx.Name = "btnRx";
            this.btnRx.Size = new System.Drawing.Size(31, 23);
            this.btnRx.TabIndex = 80;
            this.btnRx.Text = "RX";
            this.btnRx.UseVisualStyleBackColor = true;
            // 
            // txHoldingLow
            // 
            this.txHoldingLow.Location = new System.Drawing.Point(258, 68);
            this.txHoldingLow.MaxLength = 4;
            this.txHoldingLow.Name = "txHoldingLow";
            this.txHoldingLow.Size = new System.Drawing.Size(49, 20);
            this.txHoldingLow.TabIndex = 87;
            this.txHoldingLow.Text = "0";
            // 
            // tBarHoldingLow
            // 
            this.tBarHoldingLow.Location = new System.Drawing.Point(319, 67);
            this.tBarHoldingLow.Maximum = 255;
            this.tBarHoldingLow.Name = "tBarHoldingLow";
            this.tBarHoldingLow.Size = new System.Drawing.Size(69, 45);
            this.tBarHoldingLow.TabIndex = 86;
            this.tBarHoldingLow.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(203, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 82;
            this.label16.Text = "Input:";
            // 
            // txInput
            // 
            this.txInput.Location = new System.Drawing.Point(258, 42);
            this.txInput.MaxLength = 4;
            this.txInput.Name = "txInput";
            this.txInput.Size = new System.Drawing.Size(49, 20);
            this.txInput.TabIndex = 84;
            this.txInput.Text = "0";
            // 
            // tBInput
            // 
            this.tBInput.Location = new System.Drawing.Point(319, 41);
            this.tBInput.Maximum = 255;
            this.tBInput.Name = "tBInput";
            this.tBInput.Size = new System.Drawing.Size(69, 45);
            this.tBInput.TabIndex = 83;
            this.tBInput.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(203, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 13);
            this.label14.TabIndex = 79;
            this.label14.Text = "Coil";
            // 
            // txCoil
            // 
            this.txCoil.Location = new System.Drawing.Point(258, 16);
            this.txCoil.MaxLength = 4;
            this.txCoil.Name = "txCoil";
            this.txCoil.Size = new System.Drawing.Size(49, 20);
            this.txCoil.TabIndex = 81;
            this.txCoil.Text = "0";
            // 
            // tBarCoil
            // 
            this.tBarCoil.Location = new System.Drawing.Point(319, 15);
            this.tBarCoil.Maximum = 255;
            this.tBarCoil.Name = "tBarCoil";
            this.tBarCoil.Size = new System.Drawing.Size(69, 45);
            this.tBarCoil.TabIndex = 80;
            this.tBarCoil.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // chSlaveLed2
            // 
            this.chSlaveLed2.AutoSize = true;
            this.chSlaveLed2.Location = new System.Drawing.Point(63, 74);
            this.chSlaveLed2.Name = "chSlaveLed2";
            this.chSlaveLed2.Size = new System.Drawing.Size(53, 17);
            this.chSlaveLed2.TabIndex = 62;
            this.chSlaveLed2.Text = "LED4";
            this.chSlaveLed2.UseVisualStyleBackColor = true;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(8, 50);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(51, 13);
            this.label38.TabIndex = 77;
            this.label38.Text = "Inp. Reg.";
            // 
            // chSlaveLed1
            // 
            this.chSlaveLed1.AutoSize = true;
            this.chSlaveLed1.Location = new System.Drawing.Point(11, 74);
            this.chSlaveLed1.Name = "chSlaveLed1";
            this.chSlaveLed1.Size = new System.Drawing.Size(53, 17);
            this.chSlaveLed1.TabIndex = 61;
            this.chSlaveLed1.Text = "LED1";
            this.chSlaveLed1.UseVisualStyleBackColor = true;
            // 
            // txSlaveValue
            // 
            this.txSlaveValue.Location = new System.Drawing.Point(63, 47);
            this.txSlaveValue.MaxLength = 4;
            this.txSlaveValue.Name = "txSlaveValue";
            this.txSlaveValue.Size = new System.Drawing.Size(49, 20);
            this.txSlaveValue.TabIndex = 78;
            this.txSlaveValue.Text = "0";
            // 
            // tBSlaveValue
            // 
            this.tBSlaveValue.Location = new System.Drawing.Point(124, 46);
            this.tBSlaveValue.Maximum = 100;
            this.tBSlaveValue.Name = "tBSlaveValue";
            this.tBSlaveValue.Size = new System.Drawing.Size(69, 45);
            this.tBSlaveValue.TabIndex = 77;
            // 
            // bnStartStoppSlave
            // 
            this.bnStartStoppSlave.Location = new System.Drawing.Point(121, 16);
            this.bnStartStoppSlave.Name = "bnStartStoppSlave";
            this.bnStartStoppSlave.Size = new System.Drawing.Size(72, 25);
            this.bnStartStoppSlave.TabIndex = 43;
            this.bnStartStoppSlave.Text = "Start slave";
            this.bnStartStoppSlave.UseVisualStyleBackColor = true;
            this.bnStartStoppSlave.Click += new System.EventHandler(this.bnStartStoppSlave_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(8, 22);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(48, 13);
            this.label36.TabIndex = 71;
            this.label36.Text = "SlaveID:";
            // 
            // txHoldingSlaveId
            // 
            this.txHoldingSlaveId.Location = new System.Drawing.Point(63, 19);
            this.txHoldingSlaveId.MaxLength = 2;
            this.txHoldingSlaveId.Name = "txHoldingSlaveId";
            this.txHoldingSlaveId.Size = new System.Drawing.Size(49, 20);
            this.txHoldingSlaveId.TabIndex = 72;
            this.txHoldingSlaveId.Text = "01";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label32);
            this.groupBox6.Controls.Add(this.txInputValue);
            this.groupBox6.Controls.Add(this.prgBarInput);
            this.groupBox6.Controls.Add(this.txtInputQty);
            this.groupBox6.Controls.Add(this.txInputRegSlaveId);
            this.groupBox6.Controls.Add(this.label30);
            this.groupBox6.Controls.Add(this.btnInputRegGet);
            this.groupBox6.Controls.Add(this.label31);
            this.groupBox6.Controls.Add(this.txtInputStartAddr);
            this.groupBox6.Controls.Add(this.label29);
            this.groupBox6.Location = new System.Drawing.Point(697, 84);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(166, 116);
            this.groupBox6.TabIndex = 72;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Get Input Reg.";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(6, 95);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(37, 13);
            this.label32.TabIndex = 57;
            this.label32.Text = "Value:";
            // 
            // txInputValue
            // 
            this.txInputValue.Location = new System.Drawing.Point(61, 92);
            this.txInputValue.MaxLength = 2;
            this.txInputValue.Name = "txInputValue";
            this.txInputValue.ReadOnly = true;
            this.txInputValue.Size = new System.Drawing.Size(49, 20);
            this.txInputValue.TabIndex = 64;
            this.txInputValue.Text = "0";
            // 
            // prgBarInput
            // 
            this.prgBarInput.Location = new System.Drawing.Point(113, 92);
            this.prgBarInput.Name = "prgBarInput";
            this.prgBarInput.Size = new System.Drawing.Size(44, 20);
            this.prgBarInput.TabIndex = 63;
            // 
            // txtInputQty
            // 
            this.txtInputQty.Location = new System.Drawing.Point(61, 69);
            this.txtInputQty.MaxLength = 2;
            this.txtInputQty.Name = "txtInputQty";
            this.txtInputQty.Size = new System.Drawing.Size(49, 20);
            this.txtInputQty.TabIndex = 58;
            this.txtInputQty.Text = "1";
            // 
            // txInputRegSlaveId
            // 
            this.txInputRegSlaveId.Location = new System.Drawing.Point(61, 18);
            this.txInputRegSlaveId.MaxLength = 2;
            this.txInputRegSlaveId.Name = "txInputRegSlaveId";
            this.txInputRegSlaveId.Size = new System.Drawing.Size(49, 20);
            this.txInputRegSlaveId.TabIndex = 62;
            this.txInputRegSlaveId.Text = "11";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 72);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(50, 13);
            this.label30.TabIndex = 57;
            this.label30.Text = "Reg. qty:";
            // 
            // btnInputRegGet
            // 
            this.btnInputRegGet.Location = new System.Drawing.Point(113, 10);
            this.btnInputRegGet.Name = "btnInputRegGet";
            this.btnInputRegGet.Size = new System.Drawing.Size(44, 79);
            this.btnInputRegGet.TabIndex = 61;
            this.btnInputRegGet.Text = "Get";
            this.btnInputRegGet.UseVisualStyleBackColor = true;
            this.btnInputRegGet.Click += new System.EventHandler(this.btnInputRegGet_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(6, 45);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(50, 13);
            this.label31.TabIndex = 59;
            this.label31.Text = "Start adr:";
            // 
            // txtInputStartAddr
            // 
            this.txtInputStartAddr.Location = new System.Drawing.Point(61, 42);
            this.txtInputStartAddr.MaxLength = 2;
            this.txtInputStartAddr.Name = "txtInputStartAddr";
            this.txtInputStartAddr.Size = new System.Drawing.Size(49, 20);
            this.txtInputStartAddr.TabIndex = 60;
            this.txtInputStartAddr.Text = "0";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 21);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(48, 13);
            this.label29.TabIndex = 61;
            this.label29.Text = "SlaveID:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txCoilSwSlaveId);
            this.groupBox5.Controls.Add(this.bnGetSwitches);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.chSw4);
            this.groupBox5.Controls.Add(this.chSw3);
            this.groupBox5.Controls.Add(this.chSw2);
            this.groupBox5.Controls.Add(this.chSw1);
            this.groupBox5.Location = new System.Drawing.Point(570, 81);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(121, 116);
            this.groupBox5.TabIndex = 71;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Get Switches 1-4";
            // 
            // txCoilSwSlaveId
            // 
            this.txCoilSwSlaveId.Location = new System.Drawing.Point(61, 18);
            this.txCoilSwSlaveId.MaxLength = 2;
            this.txCoilSwSlaveId.Name = "txCoilSwSlaveId";
            this.txCoilSwSlaveId.Size = new System.Drawing.Size(49, 20);
            this.txCoilSwSlaveId.TabIndex = 62;
            this.txCoilSwSlaveId.Text = "11";
            // 
            // bnGetSwitches
            // 
            this.bnGetSwitches.Location = new System.Drawing.Point(65, 45);
            this.bnGetSwitches.Name = "bnGetSwitches";
            this.bnGetSwitches.Size = new System.Drawing.Size(44, 63);
            this.bnGetSwitches.TabIndex = 61;
            this.bnGetSwitches.Text = "Get";
            this.bnGetSwitches.UseVisualStyleBackColor = true;
            this.bnGetSwitches.Click += new System.EventHandler(this.bnGetSwitches_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 21);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(48, 13);
            this.label24.TabIndex = 61;
            this.label24.Text = "SlaveID:";
            // 
            // chSw4
            // 
            this.chSw4.AutoSize = true;
            this.chSw4.Enabled = false;
            this.chSw4.Location = new System.Drawing.Point(8, 92);
            this.chSw4.Name = "chSw4";
            this.chSw4.Size = new System.Drawing.Size(50, 17);
            this.chSw4.TabIndex = 64;
            this.chSw4.Text = "SW4";
            this.chSw4.UseVisualStyleBackColor = true;
            // 
            // chSw3
            // 
            this.chSw3.AutoSize = true;
            this.chSw3.Enabled = false;
            this.chSw3.Location = new System.Drawing.Point(8, 75);
            this.chSw3.Name = "chSw3";
            this.chSw3.Size = new System.Drawing.Size(50, 17);
            this.chSw3.TabIndex = 63;
            this.chSw3.Text = "SW3";
            this.chSw3.UseVisualStyleBackColor = true;
            // 
            // chSw2
            // 
            this.chSw2.AutoSize = true;
            this.chSw2.Enabled = false;
            this.chSw2.Location = new System.Drawing.Point(8, 59);
            this.chSw2.Name = "chSw2";
            this.chSw2.Size = new System.Drawing.Size(50, 17);
            this.chSw2.TabIndex = 62;
            this.chSw2.Text = "SW2";
            this.chSw2.UseVisualStyleBackColor = true;
            // 
            // chSw1
            // 
            this.chSw1.AutoSize = true;
            this.chSw1.Enabled = false;
            this.chSw1.Location = new System.Drawing.Point(8, 42);
            this.chSw1.Name = "chSw1";
            this.chSw1.Size = new System.Drawing.Size(50, 17);
            this.chSw1.TabIndex = 61;
            this.chSw1.Text = "SW1";
            this.chSw1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.textBox5);
            this.groupBox4.Controls.Add(this.btnHoldingRegSet);
            this.groupBox4.Controls.Add(this.label37);
            this.groupBox4.Controls.Add(this.tBarHolding);
            this.groupBox4.Controls.Add(this.label33);
            this.groupBox4.Controls.Add(this.txHoldingValue);
            this.groupBox4.Controls.Add(this.txtHoldingStartAddr);
            this.groupBox4.Controls.Add(this.txtHoldingQty);
            this.groupBox4.Controls.Add(this.label35);
            this.groupBox4.Controls.Add(this.btnHoldingRegGet);
            this.groupBox4.Controls.Add(this.label34);
            this.groupBox4.Location = new System.Drawing.Point(879, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(208, 190);
            this.groupBox4.TabIndex = 71;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Set/Get Holding registers";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 83;
            this.label12.Text = "SlaveID:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(61, 19);
            this.textBox5.MaxLength = 2;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(49, 20);
            this.textBox5.TabIndex = 84;
            this.textBox5.Text = "01";
            // 
            // btnHoldingRegSet
            // 
            this.btnHoldingRegSet.Location = new System.Drawing.Point(113, 62);
            this.btnHoldingRegSet.Name = "btnHoldingRegSet";
            this.btnHoldingRegSet.Size = new System.Drawing.Size(44, 51);
            this.btnHoldingRegSet.TabIndex = 76;
            this.btnHoldingRegSet.Text = "Set";
            this.btnHoldingRegSet.UseVisualStyleBackColor = true;
            this.btnHoldingRegSet.Click += new System.EventHandler(this.btnHoldingRegSet_Click);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(6, 130);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(37, 13);
            this.label37.TabIndex = 75;
            this.label37.Text = "Value:";
            // 
            // tBarHolding
            // 
            this.tBarHolding.Location = new System.Drawing.Point(61, 118);
            this.tBarHolding.Maximum = 100;
            this.tBarHolding.Name = "tBarHolding";
            this.tBarHolding.Size = new System.Drawing.Size(96, 45);
            this.tBarHolding.TabIndex = 74;
            this.tBarHolding.ValueChanged += new System.EventHandler(this.tBarHolding_ValueChanged);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(6, 96);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(37, 13);
            this.label33.TabIndex = 65;
            this.label33.Text = "Value:";
            // 
            // txHoldingValue
            // 
            this.txHoldingValue.Location = new System.Drawing.Point(61, 93);
            this.txHoldingValue.MaxLength = 4;
            this.txHoldingValue.Name = "txHoldingValue";
            this.txHoldingValue.Size = new System.Drawing.Size(49, 20);
            this.txHoldingValue.TabIndex = 73;
            this.txHoldingValue.Text = "0";
            this.txHoldingValue.TextChanged += new System.EventHandler(this.txHolding_TextChanged);
            // 
            // txtHoldingStartAddr
            // 
            this.txtHoldingStartAddr.Location = new System.Drawing.Point(61, 43);
            this.txtHoldingStartAddr.MaxLength = 2;
            this.txtHoldingStartAddr.Name = "txtHoldingStartAddr";
            this.txtHoldingStartAddr.Size = new System.Drawing.Size(49, 20);
            this.txtHoldingStartAddr.TabIndex = 69;
            this.txtHoldingStartAddr.Text = "0";
            // 
            // txtHoldingQty
            // 
            this.txtHoldingQty.Location = new System.Drawing.Point(61, 70);
            this.txtHoldingQty.MaxLength = 2;
            this.txtHoldingQty.Name = "txtHoldingQty";
            this.txtHoldingQty.Size = new System.Drawing.Size(49, 20);
            this.txtHoldingQty.TabIndex = 67;
            this.txtHoldingQty.Text = "1";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(6, 46);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(50, 13);
            this.label35.TabIndex = 68;
            this.label35.Text = "Start adr:";
            // 
            // btnHoldingRegGet
            // 
            this.btnHoldingRegGet.Location = new System.Drawing.Point(113, 11);
            this.btnHoldingRegGet.Name = "btnHoldingRegGet";
            this.btnHoldingRegGet.Size = new System.Drawing.Size(44, 51);
            this.btnHoldingRegGet.TabIndex = 70;
            this.btnHoldingRegGet.Text = "Get";
            this.btnHoldingRegGet.UseVisualStyleBackColor = true;
            this.btnHoldingRegGet.Click += new System.EventHandler(this.btnHoldingRegGet_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(6, 73);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(50, 13);
            this.label34.TabIndex = 66;
            this.label34.Text = "Reg. qty:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGetCoilStatus);
            this.groupBox3.Controls.Add(this.ChkLED4);
            this.groupBox3.Controls.Add(this.txCoilSlaveId);
            this.groupBox3.Controls.Add(this.ChkLED3);
            this.groupBox3.Controls.Add(this.ChkLED2);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.ChkLED1);
            this.groupBox3.Location = new System.Drawing.Point(442, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(122, 116);
            this.groupBox3.TabIndex = 70;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Coils LED(1-4)";
            // 
            // btnGetCoilStatus
            // 
            this.btnGetCoilStatus.Location = new System.Drawing.Point(7, 39);
            this.btnGetCoilStatus.Name = "btnGetCoilStatus";
            this.btnGetCoilStatus.Size = new System.Drawing.Size(44, 70);
            this.btnGetCoilStatus.TabIndex = 60;
            this.btnGetCoilStatus.Text = "Get colis 1-4";
            this.btnGetCoilStatus.UseVisualStyleBackColor = true;
            this.btnGetCoilStatus.Click += new System.EventHandler(this.btnGetCoilStatus_Click);
            // 
            // ChkLED4
            // 
            this.ChkLED4.AutoSize = true;
            this.ChkLED4.Location = new System.Drawing.Point(57, 93);
            this.ChkLED4.Name = "ChkLED4";
            this.ChkLED4.Size = new System.Drawing.Size(53, 17);
            this.ChkLED4.TabIndex = 59;
            this.ChkLED4.Text = "LED4";
            this.ChkLED4.UseVisualStyleBackColor = true;
            this.ChkLED4.CheckedChanged += new System.EventHandler(this.chCoils_CheckedChanged);
            // 
            // txCoilSlaveId
            // 
            this.txCoilSlaveId.Location = new System.Drawing.Point(61, 19);
            this.txCoilSlaveId.MaxLength = 2;
            this.txCoilSlaveId.Name = "txCoilSlaveId";
            this.txCoilSlaveId.Size = new System.Drawing.Size(49, 20);
            this.txCoilSlaveId.TabIndex = 58;
            this.txCoilSlaveId.Text = "11";
            // 
            // ChkLED3
            // 
            this.ChkLED3.AutoSize = true;
            this.ChkLED3.Location = new System.Drawing.Point(57, 76);
            this.ChkLED3.Name = "ChkLED3";
            this.ChkLED3.Size = new System.Drawing.Size(53, 17);
            this.ChkLED3.TabIndex = 2;
            this.ChkLED3.Text = "LED3";
            this.ChkLED3.UseVisualStyleBackColor = true;
            this.ChkLED3.CheckedChanged += new System.EventHandler(this.chCoils_CheckedChanged);
            // 
            // ChkLED2
            // 
            this.ChkLED2.AutoSize = true;
            this.ChkLED2.Location = new System.Drawing.Point(57, 60);
            this.ChkLED2.Name = "ChkLED2";
            this.ChkLED2.Size = new System.Drawing.Size(53, 17);
            this.ChkLED2.TabIndex = 1;
            this.ChkLED2.Text = "LED2";
            this.ChkLED2.UseVisualStyleBackColor = true;
            this.ChkLED2.CheckedChanged += new System.EventHandler(this.chCoils_CheckedChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 22);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(48, 13);
            this.label23.TabIndex = 57;
            this.label23.Text = "SlaveID:";
            // 
            // ChkLED1
            // 
            this.ChkLED1.AutoSize = true;
            this.ChkLED1.Location = new System.Drawing.Point(57, 43);
            this.ChkLED1.Name = "ChkLED1";
            this.ChkLED1.Size = new System.Drawing.Size(53, 17);
            this.ChkLED1.TabIndex = 0;
            this.ChkLED1.Text = "LED1";
            this.ChkLED1.UseVisualStyleBackColor = true;
            this.ChkLED1.CheckedChanged += new System.EventHandler(this.chCoils_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Location = new System.Drawing.Point(218, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 166);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Write mult. hold. reg. (fun 16)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(63, 73);
            this.textBox2.MaxLength = 2;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(49, 20);
            this.textBox2.TabIndex = 48;
            this.textBox2.Text = "1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 96);
            this.textBox1.MaxLength = 2;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 63);
            this.textBox1.TabIndex = 56;
            this.textBox1.Text = "01100000000A14000100020003000400050006000700080009000a";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(8, 76);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(50, 13);
            this.label28.TabIndex = 47;
            this.label28.Text = "Reg. qty:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 45);
            this.button1.TabIndex = 47;
            this.button1.Text = "Transmitt";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(8, 22);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(48, 13);
            this.label27.TabIndex = 48;
            this.label27.Text = "SlaveID:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(8, 49);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(50, 13);
            this.label26.TabIndex = 50;
            this.label26.Text = "Start adr:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(63, 46);
            this.textBox3.MaxLength = 2;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(49, 20);
            this.textBox3.TabIndex = 55;
            this.textBox3.Text = "0";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(8, 96);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(37, 13);
            this.label25.TabIndex = 51;
            this.label25.Text = "Value:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(63, 19);
            this.textBox4.MaxLength = 2;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(49, 20);
            this.textBox4.TabIndex = 49;
            this.textBox4.Text = "1";
            // 
            // BtnTransmit8
            // 
            this.BtnTransmit8.Location = new System.Drawing.Point(457, 301);
            this.BtnTransmit8.Name = "BtnTransmit8";
            this.BtnTransmit8.Size = new System.Drawing.Size(75, 23);
            this.BtnTransmit8.TabIndex = 68;
            this.BtnTransmit8.Text = "Transmit";
            this.BtnTransmit8.UseVisualStyleBackColor = true;
            this.BtnTransmit8.Click += new System.EventHandler(this.btnTransmit_Click);
            // 
            // txModbus8
            // 
            this.txModbus8.Location = new System.Drawing.Point(289, 304);
            this.txModbus8.Mask = "aa aa aa aa  aa aa";
            this.txModbus8.Name = "txModbus8";
            this.txModbus8.Size = new System.Drawing.Size(148, 20);
            this.txModbus8.TabIndex = 67;
            this.txModbus8.Text = "010200030001";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(542, 307);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(232, 13);
            this.label20.TabIndex = 66;
            this.label20.Text = "Read coils (fun:1) / Read discrecet input (fun 2)";
            // 
            // BtnTransmit7
            // 
            this.BtnTransmit7.Location = new System.Drawing.Point(169, 302);
            this.BtnTransmit7.Name = "BtnTransmit7";
            this.BtnTransmit7.Size = new System.Drawing.Size(75, 23);
            this.BtnTransmit7.TabIndex = 65;
            this.BtnTransmit7.Text = "Transmit";
            this.BtnTransmit7.UseVisualStyleBackColor = true;
            this.BtnTransmit7.Click += new System.EventHandler(this.btnTransmit_Click);
            // 
            // txModbus7
            // 
            this.txModbus7.Location = new System.Drawing.Point(15, 304);
            this.txModbus7.Mask = "aa aa aa aa aa aa";
            this.txModbus7.Name = "txModbus7";
            this.txModbus7.Size = new System.Drawing.Size(148, 20);
            this.txModbus7.TabIndex = 64;
            this.txModbus7.Text = "01010000000A";
            // 
            // BtnTransmit6
            // 
            this.BtnTransmit6.Location = new System.Drawing.Point(457, 275);
            this.BtnTransmit6.Name = "BtnTransmit6";
            this.BtnTransmit6.Size = new System.Drawing.Size(75, 23);
            this.BtnTransmit6.TabIndex = 63;
            this.BtnTransmit6.Text = "Transmit";
            this.BtnTransmit6.UseVisualStyleBackColor = true;
            this.BtnTransmit6.Click += new System.EventHandler(this.btnTransmit_Click);
            // 
            // txModbus6
            // 
            this.txModbus6.Location = new System.Drawing.Point(289, 278);
            this.txModbus6.Mask = "aa aa aa aa aa aa aa aa";
            this.txModbus6.Name = "txModbus6";
            this.txModbus6.Size = new System.Drawing.Size(148, 20);
            this.txModbus6.TabIndex = 62;
            this.txModbus6.Text = "010f07d000080101";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(542, 281);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(87, 13);
            this.label22.TabIndex = 61;
            this.label22.Text = "inv. fase relay on";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(542, 255);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(63, 13);
            this.label21.TabIndex = 60;
            this.label21.Text = "All relays off";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(538, 333);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(209, 13);
            this.label19.TabIndex = 58;
            this.label19.Text = "SET 10 holdings registers (fun:16) 27 bytes";
            // 
            // BtnTransmit5
            // 
            this.BtnTransmit5.Location = new System.Drawing.Point(169, 276);
            this.BtnTransmit5.Name = "BtnTransmit5";
            this.BtnTransmit5.Size = new System.Drawing.Size(75, 23);
            this.BtnTransmit5.TabIndex = 56;
            this.BtnTransmit5.Text = "Transmit";
            this.BtnTransmit5.UseVisualStyleBackColor = true;
            this.BtnTransmit5.Click += new System.EventHandler(this.btnTransmit_Click);
            // 
            // BtnTransmit4
            // 
            this.BtnTransmit4.Location = new System.Drawing.Point(457, 250);
            this.BtnTransmit4.Name = "BtnTransmit4";
            this.BtnTransmit4.Size = new System.Drawing.Size(75, 23);
            this.BtnTransmit4.TabIndex = 55;
            this.BtnTransmit4.Text = "Transmit";
            this.BtnTransmit4.UseVisualStyleBackColor = true;
            this.BtnTransmit4.Click += new System.EventHandler(this.btnTransmit_Click);
            // 
            // BtnTransmit3
            // 
            this.BtnTransmit3.Location = new System.Drawing.Point(169, 250);
            this.BtnTransmit3.Name = "BtnTransmit3";
            this.BtnTransmit3.Size = new System.Drawing.Size(75, 23);
            this.BtnTransmit3.TabIndex = 54;
            this.BtnTransmit3.Text = "Transmit";
            this.BtnTransmit3.UseVisualStyleBackColor = true;
            this.BtnTransmit3.Click += new System.EventHandler(this.btnTransmit_Click);
            // 
            // BtnTransmit2
            // 
            this.BtnTransmit2.Location = new System.Drawing.Point(457, 328);
            this.BtnTransmit2.Name = "BtnTransmit2";
            this.BtnTransmit2.Size = new System.Drawing.Size(75, 23);
            this.BtnTransmit2.TabIndex = 53;
            this.BtnTransmit2.Text = "Transmit";
            this.BtnTransmit2.UseVisualStyleBackColor = true;
            this.BtnTransmit2.Click += new System.EventHandler(this.btnTransmit_Click);
            // 
            // btnClearScreen
            // 
            this.btnClearScreen.Location = new System.Drawing.Point(1178, 96);
            this.btnClearScreen.Name = "btnClearScreen";
            this.btnClearScreen.Size = new System.Drawing.Size(75, 23);
            this.btnClearScreen.TabIndex = 33;
            this.btnClearScreen.Text = "Clear screen";
            this.btnClearScreen.UseVisualStyleBackColor = true;
            this.btnClearScreen.Click += new System.EventHandler(this.btnClearScreen_Click);
            // 
            // txModbus5
            // 
            this.txModbus5.Location = new System.Drawing.Point(15, 278);
            this.txModbus5.Mask = "aa aa aa aa aa aa aa aa aa";
            this.txModbus5.Name = "txModbus5";
            this.txModbus5.Size = new System.Drawing.Size(148, 20);
            this.txModbus5.TabIndex = 51;
            this.txModbus5.Text = "010F0000000A02FFC0";
            // 
            // txModbus4
            // 
            this.txModbus4.Location = new System.Drawing.Point(289, 252);
            this.txModbus4.Mask = "aa aa aa aa aa aa aa aa";
            this.txModbus4.Name = "txModbus4";
            this.txModbus4.Size = new System.Drawing.Size(148, 20);
            this.txModbus4.TabIndex = 50;
            this.txModbus4.Text = "010f07d000080100";
            // 
            // txModbus3
            // 
            this.txModbus3.Location = new System.Drawing.Point(15, 252);
            this.txModbus3.Mask = "aa aa aa aa aa aa ";
            this.txModbus3.Name = "txModbus3";
            this.txModbus3.Size = new System.Drawing.Size(148, 20);
            this.txModbus3.TabIndex = 49;
            this.txModbus3.Text = "01050003FF00";
            // 
            // txModbus2
            // 
            this.txModbus2.Location = new System.Drawing.Point(15, 330);
            this.txModbus2.Mask = "aa aa aa aa aa aa aa aa aa aa aa aa aa aa aa aa aa aa aa aa aa aa aa aa aa aa aa";
            this.txModbus2.Name = "txModbus2";
            this.txModbus2.Size = new System.Drawing.Size(422, 20);
            this.txModbus2.TabIndex = 48;
            this.txModbus2.Text = "01100000000A14000100020003000400050006000700080009000a";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPoll);
            this.groupBox1.Controls.Add(this.txtSampleRate);
            this.groupBox1.Controls.Add(this.txtRegisterQty);
            this.groupBox1.Controls.Add(this.txtStartAddr);
            this.groupBox1.Controls.Add(this.txtSlaveID);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lstDataType);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 166);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Read mult. hold. regi. (fun:3)";
            // 
            // btnPoll
            // 
            this.btnPoll.Location = new System.Drawing.Point(120, 17);
            this.btnPoll.Name = "btnPoll";
            this.btnPoll.Size = new System.Drawing.Size(72, 45);
            this.btnPoll.TabIndex = 34;
            this.btnPoll.Text = "Connect";
            this.btnPoll.UseVisualStyleBackColor = true;
            this.btnPoll.Click += new System.EventHandler(this.btnPoll_Click);
            // 
            // txtSampleRate
            // 
            this.txtSampleRate.Location = new System.Drawing.Point(61, 100);
            this.txtSampleRate.MaxLength = 2;
            this.txtSampleRate.Name = "txtSampleRate";
            this.txtSampleRate.Size = new System.Drawing.Size(49, 20);
            this.txtSampleRate.TabIndex = 46;
            this.txtSampleRate.Text = "0";
            // 
            // txtRegisterQty
            // 
            this.txtRegisterQty.Location = new System.Drawing.Point(61, 73);
            this.txtRegisterQty.MaxLength = 2;
            this.txtRegisterQty.Name = "txtRegisterQty";
            this.txtRegisterQty.Size = new System.Drawing.Size(49, 20);
            this.txtRegisterQty.TabIndex = 45;
            this.txtRegisterQty.Text = "1";
            // 
            // txtStartAddr
            // 
            this.txtStartAddr.Location = new System.Drawing.Point(62, 46);
            this.txtStartAddr.MaxLength = 2;
            this.txtStartAddr.Name = "txtStartAddr";
            this.txtStartAddr.Size = new System.Drawing.Size(49, 20);
            this.txtStartAddr.TabIndex = 44;
            this.txtStartAddr.Text = "0";
            // 
            // txtSlaveID
            // 
            this.txtSlaveID.Location = new System.Drawing.Point(62, 19);
            this.txtSlaveID.MaxLength = 2;
            this.txtSlaveID.Name = "txtSlaveID";
            this.txtSlaveID.Size = new System.Drawing.Size(49, 20);
            this.txtSlaveID.TabIndex = 39;
            this.txtSlaveID.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Data:";
            // 
            // lstDataType
            // 
            this.lstDataType.FormattingEnabled = true;
            this.lstDataType.Location = new System.Drawing.Point(61, 127);
            this.lstDataType.Name = "lstDataType";
            this.lstDataType.Size = new System.Drawing.Size(83, 21);
            this.lstDataType.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Sample:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Reg. qty:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Start adr:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "SlaveID:";
            // 
            // tbData
            // 
            this.tbData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbData.Location = new System.Drawing.Point(0, 0);
            this.tbData.Multiline = true;
            this.tbData.Name = "tbData";
            this.tbData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbData.Size = new System.Drawing.Size(1265, 246);
            this.tbData.TabIndex = 18;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 648);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1265, 22);
            this.statusStrip.TabIndex = 34;
            this.statusStrip.Text = "statusStrip";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 17);
            this.lblStatus.Text = "Ready";
            // 
            // Modbus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 670);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Modbus";
            this.Text = "ModBus RTU CRC16";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serialSettingsBindingSource)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarHoldingHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarHoldingLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarCoil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBSlaveValue)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarHolding)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txAddress;
        private System.Windows.Forms.TextBox txMessageFrame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label laAddress;
        private System.Windows.Forms.Label laFunction;
        private System.Windows.Forms.TextBox txFunction;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label laData0;
        private System.Windows.Forms.TextBox txData0;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label laData1;
        private System.Windows.Forms.TextBox txData1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label laData2;
        private System.Windows.Forms.TextBox txData2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label laCrcHi;
        private System.Windows.Forms.TextBox txCrcHi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label laCrcLo;
        private System.Windows.Forms.TextBox txCrcLo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label laData3;
        private System.Windows.Forms.TextBox txData3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox laMessageFrame;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnClearScreen;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.BindingSource serialSettingsBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSampleRate;
        private System.Windows.Forms.TextBox txtRegisterQty;
        private System.Windows.Forms.TextBox txtStartAddr;
        private System.Windows.Forms.TextBox txtSlaveID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox lstDataType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPoll;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ComboBox baudRateComboBox;
        private System.Windows.Forms.ComboBox stopBitsComboBox;
        private System.Windows.Forms.ComboBox portNameComboBox;
        private System.Windows.Forms.ComboBox parityComboBox;
        private System.Windows.Forms.ComboBox dataBitsComboBox;
        private System.Windows.Forms.Button BtnTransmit5;
        private System.Windows.Forms.Button BtnTransmit4;
        private System.Windows.Forms.Button BtnTransmit3;
        private System.Windows.Forms.Button BtnTransmit2;
        private System.Windows.Forms.MaskedTextBox txModbus5;
        private System.Windows.Forms.MaskedTextBox txModbus4;
        private System.Windows.Forms.MaskedTextBox txModbus3;
        private System.Windows.Forms.MaskedTextBox txModbus2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button BtnTransmit8;
        private System.Windows.Forms.MaskedTextBox txModbus8;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button BtnTransmit7;
        private System.Windows.Forms.MaskedTextBox txModbus7;
        private System.Windows.Forms.Button BtnTransmit6;
        private System.Windows.Forms.MaskedTextBox txModbus6;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ChkLED4;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txCoilSlaveId;
        private System.Windows.Forms.CheckBox ChkLED3;
        private System.Windows.Forms.CheckBox ChkLED2;
        private System.Windows.Forms.CheckBox ChkLED1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnGetCoilStatus;
        private System.Windows.Forms.CheckBox chValidateCrc16;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txInputValue;
        private System.Windows.Forms.ProgressBar prgBarInput;
        private System.Windows.Forms.TextBox txtInputQty;
        private System.Windows.Forms.TextBox txInputRegSlaveId;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button btnInputRegGet;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtInputStartAddr;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txCoilSwSlaveId;
        private System.Windows.Forms.Button bnGetSwitches;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.CheckBox chSw4;
        private System.Windows.Forms.CheckBox chSw3;
        private System.Windows.Forms.CheckBox chSw2;
        private System.Windows.Forms.CheckBox chSw1;
        private System.Windows.Forms.Button btnHoldingRegSet;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TrackBar tBarHolding;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox txHoldingValue;
        private System.Windows.Forms.TextBox txtHoldingStartAddr;
        private System.Windows.Forms.TextBox txtHoldingQty;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txHoldingSlaveId;
        private System.Windows.Forms.Button btnHoldingRegGet;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox chSlaveLed2;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.CheckBox chSlaveLed1;
        private System.Windows.Forms.TextBox txSlaveValue;
        private System.Windows.Forms.TrackBar tBSlaveValue;
        private System.Windows.Forms.Button bnStartStoppSlave;
        private System.Windows.Forms.CheckBox chAutoClear;
        private System.Windows.Forms.Button btnTx;
        private System.Windows.Forms.Button btnRx;
        private System.Windows.Forms.Label laRXCrcCounter;
        private System.Windows.Forms.Label laTXCrcCounter;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox txHoldingHigh;
        private System.Windows.Forms.TrackBar tBarHoldingHigh;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txHoldingLow;
        private System.Windows.Forms.TrackBar tBarHoldingLow;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txInput;
        private System.Windows.Forms.TrackBar tBInput;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txCoil;
        private System.Windows.Forms.TrackBar tBarCoil;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.CheckBox chScrollToChar;
        private System.Windows.Forms.Button btnFreze;
        private System.Windows.Forms.CheckBox chMakeCrcError;
        private System.Windows.Forms.CheckBox chAutoRespond;
        private System.Windows.Forms.CheckBox chFilterOutput;
        private System.Windows.Forms.MaskedTextBox maFilterOutput;
        private System.Windows.Forms.CheckBox chRlyNGrid;
        private System.Windows.Forms.CheckBox chRlyPGrid;
        private System.Windows.Forms.CheckBox chRlyNInv;
        private System.Windows.Forms.CheckBox chRlyPInv;
    }
}

