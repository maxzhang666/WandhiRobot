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
        public ChpService()
        {

        }
        public void run()
        {
            Common.CqApi.SendGroupMessage(send, GetChp());
        }

        public string GetChp()
        {
            return GHttpHelper.Http.Get("https://chp.shadiao.app/api.php");
        }
    }
}
