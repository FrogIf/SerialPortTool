using System;
using System.IO.Ports;

namespace SerialPortTool
{
    class SerialPortConfigure
    {
        /// <summary>
        /// 默认波特率
        /// </summary>
        public const string DEFAULT_BAUD_RATE = "115200";

        /// <summary>
        /// 波特率可选值
        /// </summary>
        public static readonly string[] BAUD_ARR = {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000",
            "256000",
            "1000000"
        };

        /// <summary>
        /// 默认停止位
        /// </summary>
        public const string DEFAULT_STOP_BIT = "One";

        /// <summary>
        /// 停止位可选值
        /// </summary>
        public static readonly string[] STOP_BIT_ARR = {
            "One",
            "Two",
            "None",
            "OnePointFive"
        };

        /// <summary>
        /// 默认数据位
        /// </summary>
        public const string DEFAULT_DATA_BIT = "8";

        /// <summary>
        /// 数据位可选值
        /// </summary>
        public static readonly string[] DATA_BIT_ARR = {
            "5", "6", "7", "8"
        };
    }
}
