using Native.Csharp.Sdk.Cqp.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Csharp.App.Event
{
    public class Event_GroupMessage : Native.Csharp.Sdk.Cqp.Interface.IReceiveGroupMessage
    {
        public void ReceiveGroupMessage(object sender, CqGroupMessageEventArgs e)
        {
            if (e.FromQQ.ToString() == "373884384")
            {
                Common.CqApi.SendGroupMessage(e.FromGroup, e.Message);
            }
        }
    }
}
