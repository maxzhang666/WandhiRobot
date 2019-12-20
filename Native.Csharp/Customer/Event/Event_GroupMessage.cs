using Native.Csharp.App;
using Native.Csharp.Sdk.Cqp.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Csharp.Customer.Event
{
    public class Event_GroupMessage : Native.Csharp.Sdk.Cqp.Interface.IReceiveGroupMessage
    {
        public void ReceiveGroupMessage(object sender, CqGroupMessageEventArgs e)
        {
            //if (e.FromQQ.ToString() == "373884384")
            //{
            //    var msg = GHttpHelper.Http.Get("https://chp.shadiao.app/api.php");
            //    Common.CqApi.SendGroupMessage(e.FromGroup, $"当前群号:[{e.FromGroup}],骚话:{msg}");
            //}
        }
    }
}
