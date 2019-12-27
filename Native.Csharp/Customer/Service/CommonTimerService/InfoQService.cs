using GHttpHelper;
using Native.Csharp.Customer.Model;
using Native.Csharp.Customer.Model.InfoQ;
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
        /// <summary>
        /// 获取首篇文章
        /// </summary>
        /// <returns></returns>
        private string ArticleFirst()
        {
            var res = Http.Post<CommonResult<InfoQModel>>(Api, new { q = "q资讯", t = 2, s = 20, p = 1 });
            if (res.code == 0)
            {

            }
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
