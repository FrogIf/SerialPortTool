﻿using Frog.Util.Common;
using Frog.Util.Connection;
using Frog.Util.Log;
using Frog.Util.WinForm;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace SerialPortTool
{
    public partial class MainForm : Form
    {
        private readonly SerialPortOperator serialPortOperator;

        private readonly ILogger logger = LoggerFactory.GetRootLogger();

        public MainForm()
        {
            InitializeComponent();
            // 设置消息接收监听
            List<SerialPortOperator.ReceiveDataHandler> handlers = new List<SerialPortOperator.ReceiveDataHandler>();
            ReceiveDataHandler receiveDataHandler = new ReceiveDataHandler(this, new ReceiveDataHandler.ReceiveDataUpdateForm(ReceiveDataDisplay));
            handlers.Add(receiveDataHandler);
            this.serialPortOperator = new SerialPortOperator(handlers);
            LoggerFactory.setRootLogger(new MessageLogger(this.labelMessage));
        }

        // 窗体加载完成后执行
        private void MainForm_Load(object sender, EventArgs e)
        {
            Init();
            this.timerSendAuto = new System.Timers.Timer(Convert.ToInt64(numUpDownAutoSend.Value));
            this.timerSendAuto.AutoReset = true;    // 重复执行
            this.timerSendAuto.Elapsed += new ElapsedEventHandler(TimerSendAutoTick);
        }

        // 初始化
        private void Init()
        {
            btnOpenSerialPort.Text = TextHolder.OPEN_SERIAL_PORT;
            btnStartAutoSend.Text = TextHolder.START;

            this.refreshSerialName();

            // 波特率下拉列表值加载
            LoadComboBoxItems(cBoxBaud, SerialPortConfiguration.DEFAULT_BAUD_RATE, SerialPortConfiguration.BAUD_ARR);

            // 停止位下拉列表值加载
            LoadComboBoxItems(cBoxStopBit, SerialPortConfiguration.DEFAULT_STOP_BIT, SerialPortConfiguration.STOP_BIT_ARR);

            // 数据位下拉列表值加载
            LoadComboBoxItems(cBoxDataBit, SerialPortConfiguration.DEFAULT_DATA_BIT, SerialPortConfiguration.DATA_BIT_ARR);
        }

        private readonly string[] EMPTY_STRING_ARR = new string[0];

        // 加载combobox可选值
        private void LoadComboBoxItems(ComboBox comboBox, string defaultItem, string[] items)
        {
            comboBox.Items.Clear();
            if (items == null)
            {
                items = EMPTY_STRING_ARR;
            }
            foreach (string item in items)
            {
                comboBox.Items.Add(item);
            }
            comboBox.Text = defaultItem;
        }

        // 打开/关闭串口
        private void btnOpenSerialPort_Click(object sender, EventArgs e)
        {
            if (btnOpenSerialPort.Text.Equals(TextHolder.OPEN_SERIAL_PORT))
            {
                if(StringUtil.IsBlank(cBoxSerialName.Text))
                {
                    this.logger.error("请指定串口!");
                    return;
                }
                btnOpenSerialPort.Text = TextHolder.CLOSE_SERIAL_PORT;
                serialPortOperator.SetPortName(cBoxSerialName.Text);

                serialPortOperator.SetBaudRate(Convert.ToInt32(cBoxBaud.Text));
                serialPortOperator.SetStopBits(SerialPortOperator.GetStopBits(cBoxStopBit.Text));
                serialPortOperator.SetDataBits(Convert.ToInt32(cBoxDataBit.Text));

                serialPortOperator.OpenSerialPort();
                this.switchPortControlPanelStatus(false);
                this.logger.info("串口已打开.");
            }
            else
            {
                serialPortOperator.CloseSerialPort(() =>
                {
                    btnOpenSerialPort.Text = TextHolder.OPEN_SERIAL_PORT;
                    this.switchPortControlPanelStatus(true);
                });
            }
        }

        /// <summary>
        /// 刷新当前可用串口
        /// </summary>
        private void btnRefreshSerialName_Click(object sender, EventArgs e)
        {
            this.refreshSerialName();
        }

        /// <summary>
        /// 刷新当前串口列表
        /// </summary>
        private void refreshSerialName()
        {
            if (!serialPortOperator.IsOpen())
            {
                cBoxSerialName.Items.Clear();
                string[] ports = serialPortOperator.GetAvailablePortName();
                if (ports == null)
                {
                    ports = EMPTY_STRING_ARR;
                }
                foreach (string port in ports)
                {
                    cBoxSerialName.Items.Add(port);
                }
            }
        }

        private class MessageLogger : AbstractLogger
        {
            private readonly Label messageLabel;

            public MessageLogger(Label label):base("root", "info")
            {
                this.messageLabel = label;
            }

            protected override void outputLogToTarget(string message, string triggerLevel)
            {
                messageLabel.Invoke(new MethodInvoker(() => {
                    messageLabel.Text = message;
                    if (AbstractLogger.LEVEL_WARN.Equals(triggerLevel))
                    {
                        MessageTone.Notice(MessageTone.TriggerType.Warning);
                    }else if (AbstractLogger.LEVEL_ERROR.Equals(triggerLevel))
                    {
                        MessageTone.Notice(MessageTone.TriggerType.Error);
                    }
                }));
            }
        }

        // 窗体关闭过程中, 回调
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPortOperator.IsOpen())
            {
                serialPortOperator.CloseSerialPort(() =>
                {
                    this.btnOpenSerialPort.Text = TextHolder.OPEN_SERIAL_PORT;
                    this.switchPortControlPanelStatus(true);
                });
            }
        }

        /// <summary>
        /// 转换串口控制面板的状态
        /// </summary>
        /// <param name="status">true - 启用; false - 禁用</param>
        private void switchPortControlPanelStatus(bool status)
        {
            this.btnRefreshSerialName.Enabled = status;
            this.cBoxBaud.Enabled = status;
            this.cBoxDataBit.Enabled = status;
            this.cBoxStopBit.Enabled = status;
            this.cBoxSerialName.Enabled = status;
        }


        #region 接收数据
        private int receivedDataByteNum = 0;   // 接收到的数据的字节数

        // 接收区, 切换数据类型
        private void rBtnReceiveByte_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rBtnReceiveByte.Checked)
            {
                this.serialPortOperator.ReceiveDataType = SerialPortOperator.DataType.CHAR;
            }
            else
            {
                this.serialPortOperator.ReceiveDataType = SerialPortOperator.DataType.HEX;
            }
        }

        /// <summary>
        /// 串口接收消息处理器
        /// </summary>
        private class ReceiveDataHandler : SerialPortOperator.ReceiveDataHandler
        {

            private readonly Form form;

            public delegate void ReceiveDataUpdateForm(string input, int count);

            private readonly ReceiveDataUpdateForm updateMethod;

            public ReceiveDataHandler(Form form, ReceiveDataUpdateForm updateMethod)
            {
                this.form = form;
                this.updateMethod = updateMethod;
            }

            public void Handle(string message, int count)
            {
                this.form.Invoke(updateMethod, message, count);
            }

            public void Handle(byte[] buf, int count)
            {
                if (buf != null && buf.Length > 0)
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < buf.Length; i++)
                    {
                        if (buf[i] <= 0x0F)
                        {
                            sb.Append("0");
                        }
                        sb.Append(Convert.ToString(buf[i], 16).ToUpper() + " ");
                    }
                    this.form.Invoke(updateMethod, sb.ToString(), count);
                }
            }
        }

        private void btnClearReceive_Click(object sender, EventArgs e)
        {
            tBoxReceive.Clear();
        }

        private void btnReceiveCountReset_Click(object sender, EventArgs e)
        {
            labelReceivedCount.Text = "0";
            receivedDataByteNum = 0;
        }

        private void ReceiveDataDisplay(string input, int count)
        {
            this.tBoxReceive.Text += input;
            receivedDataByteNum += count;
            labelReceivedCount.Text = receivedDataByteNum.ToString();
        }
        private void btnSaveData_Click(object sender, EventArgs e)
        {
            string text = tBoxReceive.Text;
            if (StringUtil.IsEmpty(text))
            {
                return;
            }
            string fileName = DateTime.Now.Ticks.ToString() + "." + "data.txt";
            FileStream saveFile = new FileStream(fileName, FileMode.Create);
            StreamWriter fileWrite = new StreamWriter(saveFile);
            try
            {
                fileWrite.Write(text);
            }
            catch
            {
                this.logger.error("保存失败!");
                return;
            }
            finally
            {
                fileWrite.Close();
            }
            this.logger.info("保存成功!存储路径:" + System.Environment.CurrentDirectory + "\\" + fileName);
        }
        #endregion

        #region 发送数据
        private int sendedDataByteNum = 0;  // 发送数据字节数

        System.Timers.Timer timerSendAuto;

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!serialPortOperator.IsOpen())
            {
                logger.error("串口未打开");
                return;
            }
            string text = this.tBoxSend.Text;
            if (StringUtil.IsEmpty(text))
            {
                logger.warn("没有可以发送的内容!");
                return;
            }
            sendData(text);
        }

        private void sendData(string text)
        {
            SerialPortOperator.DataType sendDataType = this.rBtnSendByte.Checked ? SerialPortOperator.DataType.CHAR : SerialPortOperator.DataType.HEX;
            serialPortOperator.SendData(text, sendDataType);
            sendedDataByteNum += text.Length;
            this.Invoke(new MethodInvoker(() => {
                labelSendedCount.Text = sendedDataByteNum.ToString();
            }));
        }

        private void btnClearSend_Click(object sender, EventArgs e)
        {
            tBoxSend.Clear();
        }

        private void btnSendCount_Click(object sender, EventArgs e)
        {
            sendedDataByteNum = 0;
            this.labelSendedCount.Text = "0";
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog sendFile = new OpenFileDialog();
            sendFile.InitialDirectory = Application.StartupPath;
            sendFile.Filter = "文本文件|*.txt|全部文件|*.*";
            sendFile.FilterIndex = 1;
            if (sendFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader ioRead = null;
                try
                {
                    ioRead = File.OpenText(sendFile.FileName);
                    string dataReadRoute = ioRead.ReadToEnd();
                    if (dataReadRoute == null)
                    {
                        logger.warn("文件内容不存在!");
                        return;
                    }
                    tBoxSend.Text = dataReadRoute;
                }
                catch
                {
                    logger.error("读取失败!");
                    return;
                }
                finally
                {
                    if(ioRead != null)
                    {
                        ioRead.Close();
                    }
                }              
            }
        }

        private void btnStartAutoSend_Click(object sender, EventArgs e)
        {
            if (!serialPortOperator.IsOpen())
            {
                logger.error("串口未打开");
                return;
            }
            if (StringUtil.IsEmpty(tBoxSend.Text))
            {
                logger.warn("没有可以发送的内容!");
                return;
            }
            if (TextHolder.START.Equals(btnStartAutoSend.Text))
            {
                tBoxSend.ReadOnly = true;
                btnStartAutoSend.Text = TextHolder.END;
                switchSendControl(false);
                timerSendAuto.Interval = Convert.ToInt64(numUpDownAutoSend.Value);
                timerSendAuto.Start();
            }
            else
            {
                tBoxSend.ReadOnly = false;
                btnStartAutoSend.Text = TextHolder.START;
                switchSendControl(true);
                timerSendAuto.Stop();
            }
        }

        private void switchSendControl(bool status)
        {
            btnSend.Enabled = status;
            btnSendFile.Enabled = status;
            btnClearSend.Enabled = status;
        }

        /// <summary>
        /// 自动发送用的时钟所触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerSendAutoTick(object sender, ElapsedEventArgs e)
        {
            sendData(tBoxSend.Text);
        }
        #endregion


    }
}
