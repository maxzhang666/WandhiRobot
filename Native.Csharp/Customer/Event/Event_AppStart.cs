﻿using Native.Csharp.App;
using Native.Csharp.Customer.Service.Interface;
using Native.Csharp.Sdk.Cqp.EventArgs;
using Native.Csharp.Sdk.Cqp.Interface;
using System;
using Unity;
using Native.Csharp.Customer.Service.CommonTimerService;

namespace Native.Csharp.Customer.Event
{
    public class Event_AppStart : ICqAppEnable
    {
        public void CqAppEnable(object sender, CqAppEnableEventArgs e)
        {
            #region 注册模块
            //注册群消息
            Common.UnityContainer.RegisterType<IReceiveGroupMessage, Event_GroupMessage>("群消息处理");
            //注册菜单控制中心
            Common.UnityContainer.RegisterType<ICallMenu, Event_MainSetting>("控制中心");
            //通用计时器
            Common.UnityContainer.RegisterType<ICommonTimer, NewsService>("通用计时器-新闻");
            Common.UnityContainer.RegisterType<ICommonTimer, TimeTickService>("通用计时器-闹钟");
            Common.UnityContainer.RegisterType<ICommonTimer, InfoQService>("通用计时器-InfoQ");


            #endregion

            #region 刷新间隔计时器
            Common.RefreshTimers();
            Common.InitCommonTimer();
            #endregion
            Common.Info("应用初始化完毕");
        }
    }
}
