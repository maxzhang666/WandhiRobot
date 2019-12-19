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
        public void CallMenu(object sender, CqCallMenuEventArgs e)
        {
            Common.CqApi.AddLoger(Sdk.Cqp.Enum.LogerLevel.Debug, "Wandhi-设置", "调用设置中心单例模式");            
            Common.MainSetting.Show();            
        }
    }
}
