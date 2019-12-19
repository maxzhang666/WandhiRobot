using Native.Csharp.Customer.Model;
using Native.Csharp.Customer.Window;
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
                if (_MainSetting == null)
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
    }
}
