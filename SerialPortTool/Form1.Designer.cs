namespace SerialPortTool
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelControl = new System.Windows.Forms.Panel();
            this.btnRefreshSerialName = new System.Windows.Forms.Button();
            this.btnOpenSerialPort = new System.Windows.Forms.Button();
            this.cBoxDataBit = new System.Windows.Forms.ComboBox();
            this.labelDataBit = new System.Windows.Forms.Label();
            this.cBoxStopBit = new System.Windows.Forms.ComboBox();
            this.labelStopBit = new System.Windows.Forms.Label();
            this.cBoxBaud = new System.Windows.Forms.ComboBox();
            this.labelBaud = new System.Windows.Forms.Label();
            this.cBoxSerialName = new System.Windows.Forms.ComboBox();
            this.labelSerialName = new System.Windows.Forms.Label();
            this.panelReceivedCount = new System.Windows.Forms.Panel();
            this.labelReceivedUnit = new System.Windows.Forms.Label();
            this.labelReceivedCount = new System.Windows.Forms.Label();
            this.labelReceivedText = new System.Windows.Forms.Label();
            this.labelRec = new System.Windows.Forms.Label();
            this.labelSend = new System.Windows.Forms.Label();
            this.panelSendCount = new System.Windows.Forms.Panel();
            this.labelSendedUnit = new System.Windows.Forms.Label();
            this.labelSendedCount = new System.Windows.Forms.Label();
            this.labelSendedText = new System.Windows.Forms.Label();
            this.gBoxSendConfig = new System.Windows.Forms.GroupBox();
            this.gBoxAutoSend = new System.Windows.Forms.GroupBox();
            this.btnStartAutoSend = new System.Windows.Forms.Button();
            this.labelAutoSendIntervalUnit = new System.Windows.Forms.Label();
            this.numUpDownAutoSend = new System.Windows.Forms.NumericUpDown();
            this.labelAutoSendInterval = new System.Windows.Forms.Label();
            this.btnSendCount = new System.Windows.Forms.Button();
            this.btnClearSend = new System.Windows.Forms.Button();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.rBtnSendHex = new System.Windows.Forms.RadioButton();
            this.rBtnSendByte = new System.Windows.Forms.RadioButton();
            this.labelSendMethod = new System.Windows.Forms.Label();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.rtBoxReceive = new System.Windows.Forms.RichTextBox();
            this.gBoxReceive = new System.Windows.Forms.GroupBox();
            this.panelRecType = new System.Windows.Forms.Panel();
            this.rBtnReceiveHex = new System.Windows.Forms.RadioButton();
            this.rBtnReceiveByte = new System.Windows.Forms.RadioButton();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnReceiveCountReset = new System.Windows.Forms.Button();
            this.btnClearReceive = new System.Windows.Forms.Button();
            this.rtBoxSend = new System.Windows.Forms.RichTextBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.panelControl.SuspendLayout();
            this.panelReceivedCount.SuspendLayout();
            this.panelSendCount.SuspendLayout();
            this.gBoxSendConfig.SuspendLayout();
            this.gBoxAutoSend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAutoSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.gBoxReceive.SuspendLayout();
            this.panelRecType.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelControl.Controls.Add(this.btnRefreshSerialName);
            this.panelControl.Controls.Add(this.btnOpenSerialPort);
            this.panelControl.Controls.Add(this.cBoxDataBit);
            this.panelControl.Controls.Add(this.labelDataBit);
            this.panelControl.Controls.Add(this.cBoxStopBit);
            this.panelControl.Controls.Add(this.labelStopBit);
            this.panelControl.Controls.Add(this.cBoxBaud);
            this.panelControl.Controls.Add(this.labelBaud);
            this.panelControl.Controls.Add(this.cBoxSerialName);
            this.panelControl.Controls.Add(this.labelSerialName);
            this.panelControl.Location = new System.Drawing.Point(16, 16);
            this.panelControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(206, 335);
            this.panelControl.TabIndex = 0;
            // 
            // btnRefreshSerialName
            // 
            this.btnRefreshSerialName.Location = new System.Drawing.Point(143, 25);
            this.btnRefreshSerialName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefreshSerialName.Name = "btnRefreshSerialName";
            this.btnRefreshSerialName.Size = new System.Drawing.Size(57, 31);
            this.btnRefreshSerialName.TabIndex = 4;
            this.btnRefreshSerialName.Text = "刷新";
            this.btnRefreshSerialName.UseVisualStyleBackColor = true;
            this.btnRefreshSerialName.Click += new System.EventHandler(this.btnRefreshSerialName_Click);
            // 
            // btnOpenSerialPort
            // 
            this.btnOpenSerialPort.Location = new System.Drawing.Point(44, 287);
            this.btnOpenSerialPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpenSerialPort.Name = "btnOpenSerialPort";
            this.btnOpenSerialPort.Size = new System.Drawing.Size(100, 31);
            this.btnOpenSerialPort.TabIndex = 8;
            this.btnOpenSerialPort.Text = "打开串口";
            this.btnOpenSerialPort.UseVisualStyleBackColor = true;
            this.btnOpenSerialPort.Click += new System.EventHandler(this.btnOpenSerialPort_Click);
            // 
            // cBoxDataBit
            // 
            this.cBoxDataBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxDataBit.FormattingEnabled = true;
            this.cBoxDataBit.Location = new System.Drawing.Point(71, 235);
            this.cBoxDataBit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBoxDataBit.Name = "cBoxDataBit";
            this.cBoxDataBit.Size = new System.Drawing.Size(128, 24);
            this.cBoxDataBit.TabIndex = 7;
            // 
            // labelDataBit
            // 
            this.labelDataBit.AutoSize = true;
            this.labelDataBit.Location = new System.Drawing.Point(4, 236);
            this.labelDataBit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDataBit.Name = "labelDataBit";
            this.labelDataBit.Size = new System.Drawing.Size(55, 16);
            this.labelDataBit.TabIndex = 6;
            this.labelDataBit.Text = "数据位:";
            // 
            // cBoxStopBit
            // 
            this.cBoxStopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxStopBit.FormattingEnabled = true;
            this.cBoxStopBit.Location = new System.Drawing.Point(71, 168);
            this.cBoxStopBit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBoxStopBit.Name = "cBoxStopBit";
            this.cBoxStopBit.Size = new System.Drawing.Size(128, 24);
            this.cBoxStopBit.TabIndex = 5;
            // 
            // labelStopBit
            // 
            this.labelStopBit.AutoSize = true;
            this.labelStopBit.Location = new System.Drawing.Point(4, 171);
            this.labelStopBit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStopBit.Name = "labelStopBit";
            this.labelStopBit.Size = new System.Drawing.Size(55, 16);
            this.labelStopBit.TabIndex = 4;
            this.labelStopBit.Text = "停止位:";
            // 
            // cBoxBaud
            // 
            this.cBoxBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxBaud.FormattingEnabled = true;
            this.cBoxBaud.Location = new System.Drawing.Point(71, 99);
            this.cBoxBaud.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBoxBaud.Name = "cBoxBaud";
            this.cBoxBaud.Size = new System.Drawing.Size(128, 24);
            this.cBoxBaud.TabIndex = 3;
            // 
            // labelBaud
            // 
            this.labelBaud.AutoSize = true;
            this.labelBaud.Location = new System.Drawing.Point(4, 99);
            this.labelBaud.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBaud.Name = "labelBaud";
            this.labelBaud.Size = new System.Drawing.Size(55, 16);
            this.labelBaud.TabIndex = 2;
            this.labelBaud.Text = "波特率:";
            // 
            // cBoxSerialName
            // 
            this.cBoxSerialName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxSerialName.FormattingEnabled = true;
            this.cBoxSerialName.Location = new System.Drawing.Point(59, 27);
            this.cBoxSerialName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBoxSerialName.Name = "cBoxSerialName";
            this.cBoxSerialName.Size = new System.Drawing.Size(84, 24);
            this.cBoxSerialName.TabIndex = 1;
            // 
            // labelSerialName
            // 
            this.labelSerialName.AutoSize = true;
            this.labelSerialName.Location = new System.Drawing.Point(4, 29);
            this.labelSerialName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSerialName.Name = "labelSerialName";
            this.labelSerialName.Size = new System.Drawing.Size(40, 16);
            this.labelSerialName.TabIndex = 0;
            this.labelSerialName.Text = "串口:";
            // 
            // panelReceivedCount
            // 
            this.panelReceivedCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelReceivedCount.Controls.Add(this.labelReceivedUnit);
            this.panelReceivedCount.Controls.Add(this.labelReceivedCount);
            this.panelReceivedCount.Controls.Add(this.labelReceivedText);
            this.panelReceivedCount.Location = new System.Drawing.Point(686, 8);
            this.panelReceivedCount.Name = "panelReceivedCount";
            this.panelReceivedCount.Size = new System.Drawing.Size(288, 31);
            this.panelReceivedCount.TabIndex = 1;
            // 
            // labelReceivedUnit
            // 
            this.labelReceivedUnit.AutoSize = true;
            this.labelReceivedUnit.Location = new System.Drawing.Point(233, 8);
            this.labelReceivedUnit.Name = "labelReceivedUnit";
            this.labelReceivedUnit.Size = new System.Drawing.Size(37, 16);
            this.labelReceivedUnit.TabIndex = 2;
            this.labelReceivedUnit.Text = "字节";
            // 
            // labelReceivedCount
            // 
            this.labelReceivedCount.AutoSize = true;
            this.labelReceivedCount.ForeColor = System.Drawing.Color.Lime;
            this.labelReceivedCount.Location = new System.Drawing.Point(147, 8);
            this.labelReceivedCount.Name = "labelReceivedCount";
            this.labelReceivedCount.Size = new System.Drawing.Size(14, 16);
            this.labelReceivedCount.TabIndex = 1;
            this.labelReceivedCount.Text = "0";
            // 
            // labelReceivedText
            // 
            this.labelReceivedText.AutoSize = true;
            this.labelReceivedText.Location = new System.Drawing.Point(9, 8);
            this.labelReceivedText.Name = "labelReceivedText";
            this.labelReceivedText.Size = new System.Drawing.Size(55, 16);
            this.labelReceivedText.TabIndex = 0;
            this.labelReceivedText.Text = "已接收:";
            // 
            // labelRec
            // 
            this.labelRec.AutoSize = true;
            this.labelRec.Location = new System.Drawing.Point(29, 16);
            this.labelRec.Name = "labelRec";
            this.labelRec.Size = new System.Drawing.Size(55, 16);
            this.labelRec.TabIndex = 0;
            this.labelRec.Text = "接收区:";
            // 
            // labelSend
            // 
            this.labelSend.AutoSize = true;
            this.labelSend.Location = new System.Drawing.Point(16, 13);
            this.labelSend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSend.Name = "labelSend";
            this.labelSend.Size = new System.Drawing.Size(55, 16);
            this.labelSend.TabIndex = 0;
            this.labelSend.Text = "发送区:";
            // 
            // panelSendCount
            // 
            this.panelSendCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSendCount.Controls.Add(this.labelSendedUnit);
            this.panelSendCount.Controls.Add(this.labelSendedCount);
            this.panelSendCount.Controls.Add(this.labelSendedText);
            this.panelSendCount.Location = new System.Drawing.Point(460, 13);
            this.panelSendCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSendCount.Name = "panelSendCount";
            this.panelSendCount.Size = new System.Drawing.Size(267, 27);
            this.panelSendCount.TabIndex = 1;
            // 
            // labelSendedUnit
            // 
            this.labelSendedUnit.AutoSize = true;
            this.labelSendedUnit.Location = new System.Drawing.Point(224, 5);
            this.labelSendedUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSendedUnit.Name = "labelSendedUnit";
            this.labelSendedUnit.Size = new System.Drawing.Size(37, 16);
            this.labelSendedUnit.TabIndex = 2;
            this.labelSendedUnit.Text = "字节";
            // 
            // labelSendedCount
            // 
            this.labelSendedCount.AutoSize = true;
            this.labelSendedCount.ForeColor = System.Drawing.Color.Yellow;
            this.labelSendedCount.Location = new System.Drawing.Point(101, 5);
            this.labelSendedCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSendedCount.Name = "labelSendedCount";
            this.labelSendedCount.Size = new System.Drawing.Size(14, 16);
            this.labelSendedCount.TabIndex = 1;
            this.labelSendedCount.Text = "0";
            // 
            // labelSendedText
            // 
            this.labelSendedText.AutoSize = true;
            this.labelSendedText.Location = new System.Drawing.Point(4, 5);
            this.labelSendedText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSendedText.Name = "labelSendedText";
            this.labelSendedText.Size = new System.Drawing.Size(55, 16);
            this.labelSendedText.TabIndex = 0;
            this.labelSendedText.Text = "已发送:";
            // 
            // gBoxSendConfig
            // 
            this.gBoxSendConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxSendConfig.Controls.Add(this.gBoxAutoSend);
            this.gBoxSendConfig.Controls.Add(this.btnSendCount);
            this.gBoxSendConfig.Controls.Add(this.btnClearSend);
            this.gBoxSendConfig.Controls.Add(this.btnSendFile);
            this.gBoxSendConfig.Controls.Add(this.btnSend);
            this.gBoxSendConfig.Controls.Add(this.rBtnSendHex);
            this.gBoxSendConfig.Controls.Add(this.rBtnSendByte);
            this.gBoxSendConfig.Controls.Add(this.labelSendMethod);
            this.gBoxSendConfig.Location = new System.Drawing.Point(732, 4);
            this.gBoxSendConfig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxSendConfig.Name = "gBoxSendConfig";
            this.gBoxSendConfig.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxSendConfig.Size = new System.Drawing.Size(237, 221);
            this.gBoxSendConfig.TabIndex = 3;
            this.gBoxSendConfig.TabStop = false;
            this.gBoxSendConfig.Text = "发送设置";
            // 
            // gBoxAutoSend
            // 
            this.gBoxAutoSend.Controls.Add(this.btnStartAutoSend);
            this.gBoxAutoSend.Controls.Add(this.labelAutoSendIntervalUnit);
            this.gBoxAutoSend.Controls.Add(this.numUpDownAutoSend);
            this.gBoxAutoSend.Controls.Add(this.labelAutoSendInterval);
            this.gBoxAutoSend.Location = new System.Drawing.Point(11, 127);
            this.gBoxAutoSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxAutoSend.Name = "gBoxAutoSend";
            this.gBoxAutoSend.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxAutoSend.Size = new System.Drawing.Size(209, 87);
            this.gBoxAutoSend.TabIndex = 7;
            this.gBoxAutoSend.TabStop = false;
            this.gBoxAutoSend.Text = "自动发送";
            // 
            // btnStartAutoSend
            // 
            this.btnStartAutoSend.Location = new System.Drawing.Point(49, 48);
            this.btnStartAutoSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStartAutoSend.Name = "btnStartAutoSend";
            this.btnStartAutoSend.Size = new System.Drawing.Size(100, 31);
            this.btnStartAutoSend.TabIndex = 3;
            this.btnStartAutoSend.Text = "开始";
            this.btnStartAutoSend.UseVisualStyleBackColor = true;
            this.btnStartAutoSend.Click += new System.EventHandler(this.btnStartAutoSend_Click);
            // 
            // labelAutoSendIntervalUnit
            // 
            this.labelAutoSendIntervalUnit.AutoSize = true;
            this.labelAutoSendIntervalUnit.Location = new System.Drawing.Point(184, 23);
            this.labelAutoSendIntervalUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAutoSendIntervalUnit.Name = "labelAutoSendIntervalUnit";
            this.labelAutoSendIntervalUnit.Size = new System.Drawing.Size(25, 16);
            this.labelAutoSendIntervalUnit.TabIndex = 2;
            this.labelAutoSendIntervalUnit.Text = "ms";
            // 
            // numUpDownAutoSend
            // 
            this.numUpDownAutoSend.Location = new System.Drawing.Point(84, 19);
            this.numUpDownAutoSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numUpDownAutoSend.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numUpDownAutoSend.Name = "numUpDownAutoSend";
            this.numUpDownAutoSend.Size = new System.Drawing.Size(97, 22);
            this.numUpDownAutoSend.TabIndex = 1;
            this.numUpDownAutoSend.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // labelAutoSendInterval
            // 
            this.labelAutoSendInterval.AutoSize = true;
            this.labelAutoSendInterval.Location = new System.Drawing.Point(7, 24);
            this.labelAutoSendInterval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAutoSendInterval.Name = "labelAutoSendInterval";
            this.labelAutoSendInterval.Size = new System.Drawing.Size(70, 16);
            this.labelAutoSendInterval.TabIndex = 0;
            this.labelAutoSendInterval.Text = "时间间隔:";
            // 
            // btnSendCount
            // 
            this.btnSendCount.Location = new System.Drawing.Point(120, 88);
            this.btnSendCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSendCount.Name = "btnSendCount";
            this.btnSendCount.Size = new System.Drawing.Size(100, 31);
            this.btnSendCount.TabIndex = 6;
            this.btnSendCount.Text = "重新计数";
            this.btnSendCount.UseVisualStyleBackColor = true;
            this.btnSendCount.Click += new System.EventHandler(this.btnSendCount_Click);
            // 
            // btnClearSend
            // 
            this.btnClearSend.Location = new System.Drawing.Point(11, 88);
            this.btnClearSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClearSend.Name = "btnClearSend";
            this.btnClearSend.Size = new System.Drawing.Size(100, 31);
            this.btnClearSend.TabIndex = 5;
            this.btnClearSend.Text = "清空发送";
            this.btnClearSend.UseVisualStyleBackColor = true;
            this.btnClearSend.Click += new System.EventHandler(this.btnClearSend_Click);
            // 
            // btnSendFile
            // 
            this.btnSendFile.Location = new System.Drawing.Point(120, 49);
            this.btnSendFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(100, 31);
            this.btnSendFile.TabIndex = 4;
            this.btnSendFile.Text = "发送文件";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(11, 49);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 31);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "发送数据";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rBtnSendHex
            // 
            this.rBtnSendHex.AutoSize = true;
            this.rBtnSendHex.Location = new System.Drawing.Point(165, 20);
            this.rBtnSendHex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBtnSendHex.Name = "rBtnSendHex";
            this.rBtnSendHex.Size = new System.Drawing.Size(52, 20);
            this.rBtnSendHex.TabIndex = 2;
            this.rBtnSendHex.Text = "HEX";
            this.rBtnSendHex.UseVisualStyleBackColor = true;
            // 
            // rBtnSendByte
            // 
            this.rBtnSendByte.AutoSize = true;
            this.rBtnSendByte.Checked = true;
            this.rBtnSendByte.Location = new System.Drawing.Point(95, 20);
            this.rBtnSendByte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBtnSendByte.Name = "rBtnSendByte";
            this.rBtnSendByte.Size = new System.Drawing.Size(55, 20);
            this.rBtnSendByte.TabIndex = 1;
            this.rBtnSendByte.TabStop = true;
            this.rBtnSendByte.Text = "字节";
            this.rBtnSendByte.UseVisualStyleBackColor = true;
            // 
            // labelSendMethod
            // 
            this.labelSendMethod.AutoSize = true;
            this.labelSendMethod.Location = new System.Drawing.Point(8, 23);
            this.labelSendMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSendMethod.Name = "labelSendMethod";
            this.labelSendMethod.Size = new System.Drawing.Size(70, 16);
            this.labelSendMethod.TabIndex = 0;
            this.labelSendMethod.Text = "发送方式:";
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerMain.Location = new System.Drawing.Point(231, 16);
            this.splitContainerMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.rtBoxReceive);
            this.splitContainerMain.Panel1.Controls.Add(this.gBoxReceive);
            this.splitContainerMain.Panel1.Controls.Add(this.labelRec);
            this.splitContainerMain.Panel1.Controls.Add(this.panelReceivedCount);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.rtBoxSend);
            this.splitContainerMain.Panel2.Controls.Add(this.gBoxSendConfig);
            this.splitContainerMain.Panel2.Controls.Add(this.labelSend);
            this.splitContainerMain.Panel2.Controls.Add(this.panelSendCount);
            this.splitContainerMain.Size = new System.Drawing.Size(979, 704);
            this.splitContainerMain.SplitterDistance = 465;
            this.splitContainerMain.SplitterWidth = 5;
            this.splitContainerMain.TabIndex = 3;
            // 
            // rtBoxReceive
            // 
            this.rtBoxReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtBoxReceive.Location = new System.Drawing.Point(19, 45);
            this.rtBoxReceive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtBoxReceive.Name = "rtBoxReceive";
            this.rtBoxReceive.ReadOnly = true;
            this.rtBoxReceive.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtBoxReceive.Size = new System.Drawing.Size(822, 399);
            this.rtBoxReceive.TabIndex = 4;
            this.rtBoxReceive.Text = "";
            this.rtBoxReceive.TextChanged += new System.EventHandler(this.rtBoxReceive_TextChanged);
            // 
            // gBoxReceive
            // 
            this.gBoxReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxReceive.Controls.Add(this.panelRecType);
            this.gBoxReceive.Controls.Add(this.btnSaveData);
            this.gBoxReceive.Controls.Add(this.btnReceiveCountReset);
            this.gBoxReceive.Controls.Add(this.btnClearReceive);
            this.gBoxReceive.Location = new System.Drawing.Point(856, 45);
            this.gBoxReceive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxReceive.Name = "gBoxReceive";
            this.gBoxReceive.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBoxReceive.Size = new System.Drawing.Size(113, 217);
            this.gBoxReceive.TabIndex = 3;
            this.gBoxReceive.TabStop = false;
            this.gBoxReceive.Text = "接收设置";
            // 
            // panelRecType
            // 
            this.panelRecType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRecType.Controls.Add(this.rBtnReceiveHex);
            this.panelRecType.Controls.Add(this.rBtnReceiveByte);
            this.panelRecType.Location = new System.Drawing.Point(8, 143);
            this.panelRecType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelRecType.Name = "panelRecType";
            this.panelRecType.Size = new System.Drawing.Size(97, 65);
            this.panelRecType.TabIndex = 3;
            // 
            // rBtnReceiveHex
            // 
            this.rBtnReceiveHex.AutoSize = true;
            this.rBtnReceiveHex.Location = new System.Drawing.Point(16, 33);
            this.rBtnReceiveHex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBtnReceiveHex.Name = "rBtnReceiveHex";
            this.rBtnReceiveHex.Size = new System.Drawing.Size(52, 20);
            this.rBtnReceiveHex.TabIndex = 1;
            this.rBtnReceiveHex.Text = "HEX";
            this.rBtnReceiveHex.UseVisualStyleBackColor = true;
            // 
            // rBtnReceiveByte
            // 
            this.rBtnReceiveByte.AutoSize = true;
            this.rBtnReceiveByte.Checked = true;
            this.rBtnReceiveByte.Location = new System.Drawing.Point(16, 4);
            this.rBtnReceiveByte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBtnReceiveByte.Name = "rBtnReceiveByte";
            this.rBtnReceiveByte.Size = new System.Drawing.Size(55, 20);
            this.rBtnReceiveByte.TabIndex = 0;
            this.rBtnReceiveByte.TabStop = true;
            this.rBtnReceiveByte.Text = "字节";
            this.rBtnReceiveByte.UseVisualStyleBackColor = true;
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(8, 104);
            this.btnSaveData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(100, 31);
            this.btnSaveData.TabIndex = 2;
            this.btnSaveData.Text = "保存数据";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnReceiveCountReset
            // 
            this.btnReceiveCountReset.Location = new System.Drawing.Point(8, 65);
            this.btnReceiveCountReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReceiveCountReset.Name = "btnReceiveCountReset";
            this.btnReceiveCountReset.Size = new System.Drawing.Size(100, 31);
            this.btnReceiveCountReset.TabIndex = 1;
            this.btnReceiveCountReset.Text = "重新计数";
            this.btnReceiveCountReset.UseVisualStyleBackColor = true;
            this.btnReceiveCountReset.Click += new System.EventHandler(this.btnReceiveCountReset_Click);
            // 
            // btnClearReceive
            // 
            this.btnClearReceive.Location = new System.Drawing.Point(8, 27);
            this.btnClearReceive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClearReceive.Name = "btnClearReceive";
            this.btnClearReceive.Size = new System.Drawing.Size(100, 31);
            this.btnClearReceive.TabIndex = 0;
            this.btnClearReceive.Text = "清空接收";
            this.btnClearReceive.UseVisualStyleBackColor = true;
            this.btnClearReceive.Click += new System.EventHandler(this.btnClearReceive_Click);
            // 
            // rtBoxSend
            // 
            this.rtBoxSend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtBoxSend.Location = new System.Drawing.Point(19, 43);
            this.rtBoxSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtBoxSend.Name = "rtBoxSend";
            this.rtBoxSend.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtBoxSend.Size = new System.Drawing.Size(706, 181);
            this.rtBoxSend.TabIndex = 4;
            this.rtBoxSend.Text = "";
            // 
            // labelMessage
            // 
            this.labelMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(1, 708);
            this.labelMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(37, 16);
            this.labelMessage.TabIndex = 4;
            this.labelMessage.Text = "消息";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1229, 728);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.panelControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "串口调试助手";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.panelReceivedCount.ResumeLayout(false);
            this.panelReceivedCount.PerformLayout();
            this.panelSendCount.ResumeLayout(false);
            this.panelSendCount.PerformLayout();
            this.gBoxSendConfig.ResumeLayout(false);
            this.gBoxSendConfig.PerformLayout();
            this.gBoxAutoSend.ResumeLayout(false);
            this.gBoxAutoSend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAutoSend)).EndInit();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.gBoxReceive.ResumeLayout(false);
            this.panelRecType.ResumeLayout(false);
            this.panelRecType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Label labelSerialName;
        private System.Windows.Forms.ComboBox cBoxSerialName;
        private System.Windows.Forms.Label labelBaud;
        private System.Windows.Forms.ComboBox cBoxBaud;
        private System.Windows.Forms.Label labelStopBit;
        private System.Windows.Forms.ComboBox cBoxStopBit;
        private System.Windows.Forms.Label labelDataBit;
        private System.Windows.Forms.ComboBox cBoxDataBit;
        private System.Windows.Forms.Button btnOpenSerialPort;
        private System.Windows.Forms.Label labelRec;
        private System.Windows.Forms.Panel panelReceivedCount;
        private System.Windows.Forms.Label labelReceivedText;
        private System.Windows.Forms.Label labelReceivedCount;
        private System.Windows.Forms.Label labelReceivedUnit;
        private System.Windows.Forms.Label labelSend;
        private System.Windows.Forms.Panel panelSendCount;
        private System.Windows.Forms.Label labelSendedText;
        private System.Windows.Forms.Label labelSendedCount;
        private System.Windows.Forms.Label labelSendedUnit;
        private System.Windows.Forms.GroupBox gBoxSendConfig;
        private System.Windows.Forms.Label labelSendMethod;
        private System.Windows.Forms.RadioButton rBtnSendByte;
        private System.Windows.Forms.RadioButton rBtnSendHex;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.Button btnClearSend;
        private System.Windows.Forms.Button btnSendCount;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.GroupBox gBoxAutoSend;
        private System.Windows.Forms.Label labelAutoSendInterval;
        private System.Windows.Forms.NumericUpDown numUpDownAutoSend;
        private System.Windows.Forms.Label labelAutoSendIntervalUnit;
        private System.Windows.Forms.Button btnStartAutoSend;
        private System.Windows.Forms.GroupBox gBoxReceive;
        private System.Windows.Forms.Button btnClearReceive;
        private System.Windows.Forms.Button btnReceiveCountReset;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Panel panelRecType;
        private System.Windows.Forms.RadioButton rBtnReceiveByte;
        private System.Windows.Forms.RadioButton rBtnReceiveHex;
        private System.Windows.Forms.Button btnRefreshSerialName;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.RichTextBox rtBoxReceive;
        private System.Windows.Forms.RichTextBox rtBoxSend;
    }
}

