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
            Common.CommonTimer = new Timer((a) =>
              {
                  var key = $"Hour:{DateTime.Now.Hour}";
                  Common.Debug("报时");
                  var flag = Common.Cache.Get(key, false);
                  if (DateTime.Now.Minute == 0 && !flag)
                  {
                      var dang = new StringBuilder();
                      for (int i = 0; i < DateTime.Now.Hour; i++)
                      {
                          dang.Append("咣、");
                      }
                      Common.CqApi.SendGroupMessage(783627728, $"整点了，老子给大家送个钟，{dang.ToString().TrimEnd('、')}");
                      Common.Cache.Set(key, true);
                  }
              }, null, 20000, 20000);
            //Common.Chp = new Timer((a) => { new ChpService(783627728).run(); }, null, 5000, 5000);
        }
    }
}
