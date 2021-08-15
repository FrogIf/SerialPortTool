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
            this.panelControl.Location = new System.Drawing.Point(12, 12);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(155, 252);
            this.panelControl.TabIndex = 0;
            // 
            // btnRefreshSerialName
            // 
            this.btnRefreshSerialName.Location = new System.Drawing.Point(107, 19);
            this.btnRefreshSerialName.Name = "btnRefreshSerialName";
            this.btnRefreshSerialName.Size = new System.Drawing.Size(43, 23);
            this.btnRefreshSerialName.TabIndex = 4;
            this.btnRefreshSerialName.Text = "刷新";
            this.btnRefreshSerialName.UseVisualStyleBackColor = true;
            this.btnRefreshSerialName.Click += new System.EventHandler(this.btnRefreshSerialName_Click);
            // 
            // btnOpenSerialPort
            // 
            this.btnOpenSerialPort.Location = new System.Drawing.Point(33, 215);
            this.btnOpenSerialPort.Name = "btnOpenSerialPort";
            this.btnOpenSerialPort.Size = new System.Drawing.Size(75, 23);
            this.btnOpenSerialPort.TabIndex = 8;
            this.btnOpenSerialPort.Text = "打开串口";
            this.btnOpenSerialPort.UseVisualStyleBackColor = true;
            this.btnOpenSerialPort.Click += new System.EventHandler(this.btnOpenSerialPort_Click);
            // 
            // cBoxDataBit
            // 
            this.cBoxDataBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxDataBit.FormattingEnabled = true;
            this.cBoxDataBit.Location = new System.Drawing.Point(53, 176);
            this.cBoxDataBit.Name = "cBoxDataBit";
            this.cBoxDataBit.Size = new System.Drawing.Size(97, 20);
            this.cBoxDataBit.TabIndex = 7;
            // 
            // labelDataBit
            // 
            this.labelDataBit.AutoSize = true;
            this.labelDataBit.Location = new System.Drawing.Point(3, 177);
            this.labelDataBit.Name = "labelDataBit";
            this.labelDataBit.Size = new System.Drawing.Size(47, 12);
            this.labelDataBit.TabIndex = 6;
            this.labelDataBit.Text = "数据位:";
            // 
            // cBoxStopBit
            // 
            this.cBoxStopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxStopBit.FormattingEnabled = true;
            this.cBoxStopBit.Location = new System.Drawing.Point(53, 126);
            this.cBoxStopBit.Name = "cBoxStopBit";
            this.cBoxStopBit.Size = new System.Drawing.Size(97, 20);
            this.cBoxStopBit.TabIndex = 5;
            // 
            // labelStopBit
            // 
            this.labelStopBit.AutoSize = true;
            this.labelStopBit.Location = new System.Drawing.Point(3, 128);
            this.labelStopBit.Name = "labelStopBit";
            this.labelStopBit.Size = new System.Drawing.Size(47, 12);
            this.labelStopBit.TabIndex = 4;
            this.labelStopBit.Text = "停止位:";
            // 
            // cBoxBaud
            // 
            this.cBoxBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxBaud.FormattingEnabled = true;
            this.cBoxBaud.Location = new System.Drawing.Point(53, 74);
            this.cBoxBaud.Name = "cBoxBaud";
            this.cBoxBaud.Size = new System.Drawing.Size(97, 20);
            this.cBoxBaud.TabIndex = 3;
            // 
            // labelBaud
            // 
            this.labelBaud.AutoSize = true;
            this.labelBaud.Location = new System.Drawing.Point(3, 74);
            this.labelBaud.Name = "labelBaud";
            this.labelBaud.Size = new System.Drawing.Size(47, 12);
            this.labelBaud.TabIndex = 2;
            this.labelBaud.Text = "波特率:";
            // 
            // cBoxSerialName
            // 
            this.cBoxSerialName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxSerialName.FormattingEnabled = true;
            this.cBoxSerialName.Location = new System.Drawing.Point(44, 20);
            this.cBoxSerialName.Name = "cBoxSerialName";
            this.cBoxSerialName.Size = new System.Drawing.Size(64, 20);
            this.cBoxSerialName.TabIndex = 1;
            // 
            // labelSerialName
            // 
            this.labelSerialName.AutoSize = true;
            this.labelSerialName.Location = new System.Drawing.Point(3, 22);
            this.labelSerialName.Name = "labelSerialName";
            this.labelSerialName.Size = new System.Drawing.Size(35, 12);
            this.labelSerialName.TabIndex = 0;
            this.labelSerialName.Text = "串口:";
            // 
            // panelReceivedCount
            // 
            this.panelReceivedCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelReceivedCount.Controls.Add(this.labelReceivedUnit);
            this.panelReceivedCount.Controls.Add(this.labelReceivedCount);
            this.panelReceivedCount.Controls.Add(this.labelReceivedText);
            this.panelReceivedCount.Location = new System.Drawing.Point(514, 6);
            this.panelReceivedCount.Margin = new System.Windows.Forms.Padding(2);
            this.panelReceivedCount.Name = "panelReceivedCount";
            this.panelReceivedCount.Size = new System.Drawing.Size(216, 23);
            this.panelReceivedCount.TabIndex = 1;
            // 
            // labelReceivedUnit
            // 
            this.labelReceivedUnit.AutoSize = true;
            this.labelReceivedUnit.Location = new System.Drawing.Point(175, 6);
            this.labelReceivedUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReceivedUnit.Name = "labelReceivedUnit";
            this.labelReceivedUnit.Size = new System.Drawing.Size(29, 12);
            this.labelReceivedUnit.TabIndex = 2;
            this.labelReceivedUnit.Text = "字节";
            // 
            // labelReceivedCount
            // 
            this.labelReceivedCount.AutoSize = true;
            this.labelReceivedCount.ForeColor = System.Drawing.Color.Lime;
            this.labelReceivedCount.Location = new System.Drawing.Point(110, 6);
            this.labelReceivedCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReceivedCount.Name = "labelReceivedCount";
            this.labelReceivedCount.Size = new System.Drawing.Size(11, 12);
            this.labelReceivedCount.TabIndex = 1;
            this.labelReceivedCount.Text = "0";
            // 
            // labelReceivedText
            // 
            this.labelReceivedText.AutoSize = true;
            this.labelReceivedText.Location = new System.Drawing.Point(7, 6);
            this.labelReceivedText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReceivedText.Name = "labelReceivedText";
            this.labelReceivedText.Size = new System.Drawing.Size(47, 12);
            this.labelReceivedText.TabIndex = 0;
            this.labelReceivedText.Text = "已接收:";
            // 
            // labelRec
            // 
            this.labelRec.AutoSize = true;
            this.labelRec.Location = new System.Drawing.Point(22, 12);
            this.labelRec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRec.Name = "labelRec";
            this.labelRec.Size = new System.Drawing.Size(47, 12);
            this.labelRec.TabIndex = 0;
            this.labelRec.Text = "接收区:";
            // 
            // labelSend
            // 
            this.labelSend.AutoSize = true;
            this.labelSend.Location = new System.Drawing.Point(12, 10);
            this.labelSend.Name = "labelSend";
            this.labelSend.Size = new System.Drawing.Size(47, 12);
            this.labelSend.TabIndex = 0;
            this.labelSend.Text = "发送区:";
            // 
            // panelSendCount
            // 
            this.panelSendCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSendCount.Controls.Add(this.labelSendedUnit);
            this.panelSendCount.Controls.Add(this.labelSendedCount);
            this.panelSendCount.Controls.Add(this.labelSendedText);
            this.panelSendCount.Location = new System.Drawing.Point(344, 10);
            this.panelSendCount.Name = "panelSendCount";
            this.panelSendCount.Size = new System.Drawing.Size(200, 20);
            this.panelSendCount.TabIndex = 1;
            // 
            // labelSendedUnit
            // 
            this.labelSendedUnit.AutoSize = true;
            this.labelSendedUnit.Location = new System.Drawing.Point(168, 4);
            this.labelSendedUnit.Name = "labelSendedUnit";
            this.labelSendedUnit.Size = new System.Drawing.Size(29, 12);
            this.labelSendedUnit.TabIndex = 2;
            this.labelSendedUnit.Text = "字节";
            // 
            // labelSendedCount
            // 
            this.labelSendedCount.AutoSize = true;
            this.labelSendedCount.ForeColor = System.Drawing.Color.Yellow;
            this.labelSendedCount.Location = new System.Drawing.Point(76, 4);
            this.labelSendedCount.Name = "labelSendedCount";
            this.labelSendedCount.Size = new System.Drawing.Size(11, 12);
            this.labelSendedCount.TabIndex = 1;
            this.labelSendedCount.Text = "0";
            // 
            // labelSendedText
            // 
            this.labelSendedText.AutoSize = true;
            this.labelSendedText.Location = new System.Drawing.Point(3, 4);
            this.labelSendedText.Name = "labelSendedText";
            this.labelSendedText.Size = new System.Drawing.Size(47, 12);
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
            this.gBoxSendConfig.Location = new System.Drawing.Point(548, 3);
            this.gBoxSendConfig.Name = "gBoxSendConfig";
            this.gBoxSendConfig.Size = new System.Drawing.Size(178, 166);
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
            this.gBoxAutoSend.Location = new System.Drawing.Point(8, 95);
            this.gBoxAutoSend.Name = "gBoxAutoSend";
            this.gBoxAutoSend.Size = new System.Drawing.Size(157, 65);
            this.gBoxAutoSend.TabIndex = 7;
            this.gBoxAutoSend.TabStop = false;
            this.gBoxAutoSend.Text = "自动发送";
            // 
            // btnStartAutoSend
            // 
            this.btnStartAutoSend.Location = new System.Drawing.Point(37, 36);
            this.btnStartAutoSend.Name = "btnStartAutoSend";
            this.btnStartAutoSend.Size = new System.Drawing.Size(75, 23);
            this.btnStartAutoSend.TabIndex = 3;
            this.btnStartAutoSend.Text = "开始";
            this.btnStartAutoSend.UseVisualStyleBackColor = true;
            this.btnStartAutoSend.Click += new System.EventHandler(this.btnStartAutoSend_Click);
            // 
            // labelAutoSendIntervalUnit
            // 
            this.labelAutoSendIntervalUnit.AutoSize = true;
            this.labelAutoSendIntervalUnit.Location = new System.Drawing.Point(138, 17);
            this.labelAutoSendIntervalUnit.Name = "labelAutoSendIntervalUnit";
            this.labelAutoSendIntervalUnit.Size = new System.Drawing.Size(17, 12);
            this.labelAutoSendIntervalUnit.TabIndex = 2;
            this.labelAutoSendIntervalUnit.Text = "ms";
            // 
            // numUpDownAutoSend
            // 
            this.numUpDownAutoSend.Location = new System.Drawing.Point(63, 14);
            this.numUpDownAutoSend.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numUpDownAutoSend.Name = "numUpDownAutoSend";
            this.numUpDownAutoSend.Size = new System.Drawing.Size(73, 21);
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
            this.labelAutoSendInterval.Location = new System.Drawing.Point(5, 18);
            this.labelAutoSendInterval.Name = "labelAutoSendInterval";
            this.labelAutoSendInterval.Size = new System.Drawing.Size(59, 12);
            this.labelAutoSendInterval.TabIndex = 0;
            this.labelAutoSendInterval.Text = "时间间隔:";
            // 
            // btnSendCount
            // 
            this.btnSendCount.Location = new System.Drawing.Point(90, 66);
            this.btnSendCount.Name = "btnSendCount";
            this.btnSendCount.Size = new System.Drawing.Size(75, 23);
            this.btnSendCount.TabIndex = 6;
            this.btnSendCount.Text = "重新计数";
            this.btnSendCount.UseVisualStyleBackColor = true;
            this.btnSendCount.Click += new System.EventHandler(this.btnSendCount_Click);
            // 
            // btnClearSend
            // 
            this.btnClearSend.Location = new System.Drawing.Point(8, 66);
            this.btnClearSend.Name = "btnClearSend";
            this.btnClearSend.Size = new System.Drawing.Size(75, 23);
            this.btnClearSend.TabIndex = 5;
            this.btnClearSend.Text = "清空发送";
            this.btnClearSend.UseVisualStyleBackColor = true;
            this.btnClearSend.Click += new System.EventHandler(this.btnClearSend_Click);
            // 
            // btnSendFile
            // 
            this.btnSendFile.Location = new System.Drawing.Point(90, 37);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(75, 23);
            this.btnSendFile.TabIndex = 4;
            this.btnSendFile.Text = "发送文件";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(8, 37);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "发送数据";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rBtnSendHex
            // 
            this.rBtnSendHex.AutoSize = true;
            this.rBtnSendHex.Location = new System.Drawing.Point(124, 15);
            this.rBtnSendHex.Name = "rBtnSendHex";
            this.rBtnSendHex.Size = new System.Drawing.Size(41, 16);
            this.rBtnSendHex.TabIndex = 2;
            this.rBtnSendHex.Text = "HEX";
            this.rBtnSendHex.UseVisualStyleBackColor = true;
            // 
            // rBtnSendByte
            // 
            this.rBtnSendByte.AutoSize = true;
            this.rBtnSendByte.Checked = true;
            this.rBtnSendByte.Location = new System.Drawing.Point(71, 15);
            this.rBtnSendByte.Name = "rBtnSendByte";
            this.rBtnSendByte.Size = new System.Drawing.Size(47, 16);
            this.rBtnSendByte.TabIndex = 1;
            this.rBtnSendByte.TabStop = true;
            this.rBtnSendByte.Text = "字节";
            this.rBtnSendByte.UseVisualStyleBackColor = true;
            // 
            // labelSendMethod
            // 
            this.labelSendMethod.AutoSize = true;
            this.labelSendMethod.Location = new System.Drawing.Point(6, 17);
            this.labelSendMethod.Name = "labelSendMethod";
            this.labelSendMethod.Size = new System.Drawing.Size(59, 12);
            this.labelSendMethod.TabIndex = 0;
            this.labelSendMethod.Text = "发送方式:";
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerMain.Location = new System.Drawing.Point(173, 12);
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
            this.splitContainerMain.Size = new System.Drawing.Size(734, 528);
            this.splitContainerMain.SplitterDistance = 349;
            this.splitContainerMain.TabIndex = 3;
            // 
            // rtBoxReceive
            // 
            this.rtBoxReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtBoxReceive.Location = new System.Drawing.Point(14, 34);
            this.rtBoxReceive.Name = "rtBoxReceive";
            this.rtBoxReceive.ReadOnly = true;
            this.rtBoxReceive.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtBoxReceive.Size = new System.Drawing.Size(617, 300);
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
            this.gBoxReceive.Location = new System.Drawing.Point(641, 34);
            this.gBoxReceive.Name = "gBoxReceive";
            this.gBoxReceive.Size = new System.Drawing.Size(85, 163);
            this.gBoxReceive.TabIndex = 3;
            this.gBoxReceive.TabStop = false;
            this.gBoxReceive.Text = "接收设置";
            // 
            // panelRecType
            // 
            this.panelRecType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRecType.Controls.Add(this.rBtnReceiveHex);
            this.panelRecType.Controls.Add(this.rBtnReceiveByte);
            this.panelRecType.Location = new System.Drawing.Point(6, 107);
            this.panelRecType.Name = "panelRecType";
            this.panelRecType.Size = new System.Drawing.Size(73, 49);
            this.panelRecType.TabIndex = 3;
            // 
            // rBtnReceiveHex
            // 
            this.rBtnReceiveHex.AutoSize = true;
            this.rBtnReceiveHex.Location = new System.Drawing.Point(12, 25);
            this.rBtnReceiveHex.Name = "rBtnReceiveHex";
            this.rBtnReceiveHex.Size = new System.Drawing.Size(41, 16);
            this.rBtnReceiveHex.TabIndex = 1;
            this.rBtnReceiveHex.Text = "HEX";
            this.rBtnReceiveHex.UseVisualStyleBackColor = true;
            // 
            // rBtnReceiveByte
            // 
            this.rBtnReceiveByte.AutoSize = true;
            this.rBtnReceiveByte.Checked = true;
            this.rBtnReceiveByte.Location = new System.Drawing.Point(12, 3);
            this.rBtnReceiveByte.Name = "rBtnReceiveByte";
            this.rBtnReceiveByte.Size = new System.Drawing.Size(47, 16);
            this.rBtnReceiveByte.TabIndex = 0;
            this.rBtnReceiveByte.TabStop = true;
            this.rBtnReceiveByte.Text = "字节";
            this.rBtnReceiveByte.UseVisualStyleBackColor = true;
            this.rBtnReceiveByte.CheckedChanged += new System.EventHandler(this.rBtnReceiveByte_CheckedChanged);
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(6, 78);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(75, 23);
            this.btnSaveData.TabIndex = 2;
            this.btnSaveData.Text = "保存数据";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnReceiveCountReset
            // 
            this.btnReceiveCountReset.Location = new System.Drawing.Point(6, 49);
            this.btnReceiveCountReset.Name = "btnReceiveCountReset";
            this.btnReceiveCountReset.Size = new System.Drawing.Size(75, 23);
            this.btnReceiveCountReset.TabIndex = 1;
            this.btnReceiveCountReset.Text = "重新计数";
            this.btnReceiveCountReset.UseVisualStyleBackColor = true;
            this.btnReceiveCountReset.Click += new System.EventHandler(this.btnReceiveCountReset_Click);
            // 
            // btnClearReceive
            // 
            this.btnClearReceive.Location = new System.Drawing.Point(6, 20);
            this.btnClearReceive.Name = "btnClearReceive";
            this.btnClearReceive.Size = new System.Drawing.Size(75, 23);
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
            this.rtBoxSend.Location = new System.Drawing.Point(14, 32);
            this.rtBoxSend.Name = "rtBoxSend";
            this.rtBoxSend.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtBoxSend.Size = new System.Drawing.Size(530, 136);
            this.rtBoxSend.TabIndex = 4;
            this.rtBoxSend.Text = "";
            // 
            // labelMessage
            // 
            this.labelMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(1, 531);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(29, 12);
            this.labelMessage.TabIndex = 4;
            this.labelMessage.Text = "消息";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(922, 546);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.panelControl);
            this.Margin = new System.Windows.Forms.Padding(2);
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

