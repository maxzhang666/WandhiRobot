using Native.Csharp.Customer.Model;
using Native.Csharp.Customer.Window;
using Native.Csharp.Sdk.Cqp.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Native.Csharp.App
{
    public static partial class Common
    {


        public static Timer Chp;

        /// <summary>
        /// 控制中心实例
        /// </summary>
        public static Main MainSetting
        {
            get
            {
                if (_MainSetting == null || _MainSetting.IsDisposed)
                {
                    _MainSetting = new Main();
                }
                return _MainSetting;
            }
        }
        private static Main _MainSetting { set; get; }
        /// <summary>
        /// 通用计时器
        /// 具有默认执行频率
        /// 默认1秒一次  请在传入的方法中自行判断是否执行
        /// </summary>
        public static Timer CommonTimer { set; get; }

        /// <summary>
        /// 计时器列表
        /// </summary>
        public static Dictionary<string, Timer> Timers { set; get; }

        /// <summary>
        /// 应用配置信息
        /// </summary>
        public static BaseConfig AppConfig { set; get; }

        #region 日志
        private static string flag = "Wandhi-";

        /// <summary>
        /// 日志
        /// </summary>
        /// <param name="msg">内容</param>
        /// <param name="module">模块</param>
        public static void Info(string msg, string module = "调试信息")
        {
            Log(LogerLevel.Info, msg, module);
        }
        /// <summary>
        /// 错误信息
        /// </summary>
        /// <param name="msg">内容</param>
        /// <param name="module">模块</param>
        public static void Error(string msg,string module = "调试信息")
        {
            Log(LogerLevel.Error, msg, module);
        }
        /// <summary>
        /// 调试信息
        /// </summary>
        /// <param name="msg">内容</param>
        /// <param name="module">模块</param>
        public static void Debug(string msg, string module = "调试信息")
        {
            Log(LogerLevel.Debug, msg, module);
        }

        /// <summary>
        /// 添加日志
        /// </summary>
        /// <param name="level">日志等级</param>
        /// <param name="msg">内容</param>
        /// <param name="module">模块</param>
        private static void Log(LogerLevel level, string msg, string module)
        {
            CqApi.AddLoger(Sdk.Cqp.Enum.LogerLevel.Info, $"{flag}{module}", msg);
        }
        #endregion
    }
}
