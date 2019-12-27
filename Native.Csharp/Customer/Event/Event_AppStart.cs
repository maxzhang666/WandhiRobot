using Native.Csharp.App;
using Native.Csharp.Customer.Service;
using Native.Csharp.Customer.Service.Interface;
using Native.Csharp.Sdk.Cqp.EventArgs;
using Native.Csharp.Sdk.Cqp.Interface;
using System;
using Unity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Native.Csharp.Customer.Event
{
    public class Event_AppStart : ICqAppEnable
    {
        public void CqAppEnable(object sender, CqAppEnableEventArgs e)
        {
            #region 刷新间隔计时器
            Common.RefreshTimers();
            #endregion

            #region 注册模块
            //注册群消息
            Common.UnityContainer.RegisterType<IReceiveGroupMessage, Event_GroupMessage>("群消息处理");
            //注册菜单控制中心
            Common.UnityContainer.RegisterType<ICallMenu, Event_MainSetting>("控制中心");
            //通用计时器
            Common.UnityContainer.RegisterType<ICommonTimer, NewsService>("通用计时器");
            Common.UnityContainer.RegisterType<ICommonTimer, TimeTickService>("通用计时器");
            #endregion
        }
    }
}
