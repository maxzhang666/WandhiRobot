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
using Unity;

namespace Native.Csharp.App
{
    public static partial class Common
    {
        public static Timer Chp;

        #region 控制中心窗体
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
        /// 关闭窗体
        /// </summary>
        public static void CloseMainSetting()
        {
            _MainSetting.Dispose();
            _MainSetting = null;
        }
        #endregion

        #region 缓存

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
        #endregion

        #region 配置

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
        #endregion

        #region 计时器

        /// <summary>
        /// 初始化通用计时器
        /// </summary>
        public static void InitCommonTimer()
        {
            CommonTimer.Dispose();
            CommonTimer = new Timer((a) =>
            {
                var timerHandle = UnityContainer.Resolve<ICommonTimer>("通用计时器");
                NewTask(timerHandle.Run);
            }, null, 27 * 1000, 27 * 1000);
        }

        /// <summary>
        /// 通用计时器
        /// 具有默认执行频率
        /// 默认1秒一次  请在传入的方法中自行判断是否执行
        /// </summary>
        public static Timer CommonTimer { set; get; }
        /// <summary>
        /// 计时器列表
        /// </summary>
        public static Dictionary<string, Timer> Timers { set; get; } = new Dictionary<string, Timer>();
        #endregion

        #region 任务操作
        /// <summary>
        /// 睡眠指定时间后执行任务
        /// </summary>
        /// <param name="action"></param>
        /// <param name="time"></param>
        public static void NewTask(Action action, TimeSpan? time)
        {
            Task.Run(() =>
            {
                if (time.HasValue)
                {
                    Thread.Sleep(time.Value);
                }
                action.Invoke();
            });
        }
        /// <summary>
        /// 睡眠1-10随机秒后执行任务
        /// </summary>
        /// <param name="action"></param>
        public static void NewTask(Action action)
        {
            var time = TimeSpan.FromSeconds(new Random().NextDouble() * 10);
            NewTask(action, time);
        }

        #endregion

        #region 计时器初始化
        /// <summary>
        /// 刷新计时器
        /// </summary>
        public static void RefreshTimers()
        {
            Debug("刷新计时器", "刷新计时器");
            Task.Run(() =>
            {
                try
                {
                    //释放所有计时器
                    foreach (var item in Timers)
                    {
                        item.Value.Dispose();
                    }
                    Timers.Clear();
                    foreach (var item in AppConfig.groupConfigs)
                    {
                        foreach (var _item in item.Value.GroupTimers.Values.Where(a => a.isOn))
                        {
                            var groupTimer = _item;
                            var key = $"{item.Key}:{groupTimer.name}";
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
                    Debug("计时器刷新", e.Message);
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
            return _AppConfig;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseConfig"></param>
        /// <param name="CallBack">回调函数</param>
        /// <returns></returns>
        public static BaseConfig SaveConfig(BaseConfig baseConfig, Action CallBack)
        {
            var config = SaveConfig(baseConfig);
            if (CallBack != null)
            {
                CallBack.BeginInvoke(null, null);
            }
            return config;
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
#if DEBUG
            Log(LogerLevel.Debug, msg, module);
#endif
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
