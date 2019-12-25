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
            var config = Common.AppConfig;
#if DEBUG
            #region 报时器
            Common.CommonTimer = new Timer((a) =>
              {
                  var key = $"Hour:{DateTime.Now.Hour}";

                  Common.Debug("报时检测");

                  var flag = Common.Cache.Get(key, false);
                  if (DateTime.Now.Minute == 0 && !flag && DateTime.Now.Hour >= 7 && DateTime.Now.Hour <= 23)
                  {
                      var dang = new StringBuilder();
                      for (int i = 0; i < DateTime.Now.Hour; i++)
                      {
                          dang.Append("咣、");
                      }
                      Task.Run(() =>
                      {
                          long[] groups = { 783627728, 340569308, 655341576, 722457505 };
                          var msg = $"{dang.ToString().TrimEnd('、')}\r\n" + new ChpService().GetChp();

                          if (DateTime.Now.Hour == 23)
                          {
                              msg += "\r\n 夜深了，早点休息！";
                          }
                          foreach (var item in groups)
                          {
                              Common.CqApi.SendGroupMessage(item, msg);
                          }
                          Thread.Sleep(new Random().Next(1, 1000));
                      });
                      Common.Cache.Set(key, true, TimeSpan.FromMinutes(60));
                  }
              }, null, 17 * 1000, 17 * 1000);
            #endregion
#endif
            Common.RefreshTimers();
        }
    }
}
