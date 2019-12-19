using Native.Csharp.App;
using Native.Csharp.Customer.Window;
using Native.Csharp.Sdk.Cqp.EventArgs;
using Native.Csharp.Sdk.Cqp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Csharp.Customer.Event
{
    public class Event_MainSetting : ICallMenu
    {
        /// <summary>
        /// 打开设置窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CallMenu(object sender, CqCallMenuEventArgs e)
        {
            Common.Debug("调用设置中心单例模式", "设置");
            Common.MainSetting.Show();
        }
    }
}
