using Native.Csharp.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Csharp.Customer.Service
{
    public class ChpService
    {
        public long send;
        public ChpService(long send)
        {
            this.send = send;
        }
        public void run()
        {
            var msg = GHttpHelper.Http.Get("https://chp.shadiao.app/api.php");
            Common.CqApi.SendGroupMessage(send, msg);
        }
    }
}
