using Native.Csharp.App;
using Native.Csharp.Customer.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Csharp.Customer.Service.CommonTimerService
{
    public class TimeTickService : ICommonTimer
    {
        public bool AllowSend()
        {
            return DateTime.Now.Minute == 0;
        }

        public bool AllowSend(DateTime time)
        {
            return time.Minute == 0;
        }

        public void Run()
        {
            var hour = DateTime.Now.Hour;
            var key = $"TimeTick:{hour}";
            Common.Debug("报时器报时检测");
            if (AllowSend() && hour >= 7 && hour <= 23 && Common.Cache.Get(key, true))
            {
                var msg = Common.Cache.Get($"{hour}:chp", new ChpService().GetChp);
                var dang = GenerateDang(hour);
                if (hour == 23)
                {
                    msg += "\r\n 夜深了，早点休息！";
                }
                foreach (var item in Common.AppConfig.groupConfigs.Values.Where(a => a.TimeTickOn))
                {
                    Common.NewTask(() =>
                    {
                        Common.CqApi.SendGroupMessage(item.GroupId, msg);
                    }, TimeSpan.FromSeconds(100));
                }
                Common.Cache.Set(key, true, TimeSpan.FromMinutes(60));
            }
        }

        private string GenerateDang(int Hour)
        {
            var dang = new StringBuilder();
            for (int i = 0; i < Hour; i++)
            {
                dang.Append("噹、");
            }
            return dang.ToString().TrimEnd('、');
        }
    }
}
