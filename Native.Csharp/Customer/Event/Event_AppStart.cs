using Native.Csharp.App;
using Native.Csharp.Customer.Service;
using Native.Csharp.Sdk.Cqp.EventArgs;
using Native.Csharp.Sdk.Cqp.Interface;
using System;
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
            //初始化配置
            var configService = new ConfigService();
            Common.AppConfig = configService.Config;
            //Common.Chp = new Timer((a) => { new ChpService(783627728).run(); }, null, 5000, 5000);
        }
    }
}
