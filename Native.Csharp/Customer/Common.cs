using Native.Csharp.Customer.Model;
using Native.Csharp.Customer.Service;
using Native.Csharp.Customer.Service.Interface;
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
        /// 缓存操作
        /// </summary>
        public static ICache Cache
        {
            get
            {
                if (_MemoryCacheService == null)
                {
                    _MemoryCacheService = new MemoryCacheService();
                }
                return _MemoryCacheService;
            }
        }
        private static MemoryCacheService _MemoryCacheService { set; get; }

        /// <summary>
        /// 配置操作类
        /// </summary>
        public static ConfigService ConfigService
        {
            get
            {
                if (_ConfigService == null)
                {
                    _ConfigService = new ConfigService();
                }
                return _ConfigService;
            }
        }
        private static ConfigService _ConfigService;

        /// <summary>
        /// 通用计时器
        /// 具有默认执行频率
        /// 默认1秒一次  请在传入的方法中自行判断是否执行
        /// </summary>
        public static Timer CommonTimer { set; get; }

        /// <summary>
        /// 事件列表
        /// </summary>
        public static List<Action> Funcs { set; get; }

        /// <summary>
        /// 计时器列表
        /// </summary>
        public static Dictionary<string, Timer> Timers { set; get; } = new Dictionary<string, Timer>();

        #region 计时器初始化
        /// <summary>
        /// 刷新计时器
        /// </summary>
        public static void RefreshTimers()
        {
            Task.Run(() =>
            {
                try
                {
                    foreach (var item in AppConfig.groupConfigs)
                    {
                        foreach (var _item in item.Value.GroupTimers)
                        {
                            var groupTimer = _item.Value;
                            var key = $"{item.Key}:{groupTimer.name}";
                            if (Timers.ContainsKey(key))
                            {
                                Timers[key].Dispose();
                                Timers.Remove(key);
                            }
                            //生成计时器
                            Timers.Add(key, new Timer(
                                _ =>
                                {
                                    CqApi.SendGroupMessage(item.Key, groupTimer.Content);
                                }, null, groupTimer.inteval, groupTimer.inteval
                                ));
                        }
                    }
                }
                catch (Exception e)
                {
                    Common.Debug("计时器刷新", e.Message);
                }
            });
        }
        #endregion

        #region 配置操作
        /// <summary>
        /// 应用配置信息
        /// </summary>
        public static BaseConfig AppConfig
        {
            get
            {
                if (_AppConfig == null)
                {
                    _AppConfig = ConfigService.InitConfig();
                    RefreshTimers();
                }
                return _AppConfig;
            }
        }
        private static BaseConfig _AppConfig { set; get; }
        /// <summary>
        /// 保存配置信息
        /// </summary>
        /// <param name="baseConfig"></param>
        /// <returns></returns>
        public static BaseConfig SaveConfig(BaseConfig baseConfig)
        {
            _AppConfig = ConfigService.SaveConfig(baseConfig);
            RefreshTimers();
            return _AppConfig;
        }
        #endregion

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
        public static void Error(string msg, string module = "调试信息")
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
