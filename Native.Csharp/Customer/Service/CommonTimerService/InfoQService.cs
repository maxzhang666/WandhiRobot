using Native.Csharp.Customer.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Csharp.Customer.Service.CommonTimerService
{
    public class InfoQService : ICommonTimer
    {
        private string Api = "https://s.geekbang.org/api/gksearch/search";
        private void ArticleList()
        {
            var res = GHttpHelper.Http.Post(Api, new { q = "q资讯", t = 2, s = 20, p = 1 });
        }
        public bool AllowSend()
        {
            return false;
        }

        public bool AllowSend(DateTime time)
        {
            return true;
        }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
