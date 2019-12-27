using GHttpHelper;
using Native.Csharp.Customer.Model;
using Native.Csharp.Customer.Model.InfoQ;
using Native.Csharp.Customer.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private InfoQItem ArticleFirst()
        {
            var res = Http.Post<CommonResult<InfoQModel>>(Api, new { q = "q资讯", t = 2, s = 20, p = 1 }, RequestType.Json);
            InfoQItem article = null;
            if (res.code == 0)
            {
                article = res.data.list.FirstOrDefault();
            }
            return article;
        }

        private string GetMsg()
        {
            var article = ArticleFirst();
            var sb = new StringBuilder();
            if (article != null && article.publishTime.Day == DateTime.Now.Day)
            {
                var content = Http.Get<string>(article.content_url);
                if (!string.IsNullOrEmpty(content))
                {
                    var rg = new Regex("<strong>(.*)<\\/strong>");
                    var matches = rg.Matches(content);
                    foreach (Match item in matches)
                    {
                        sb.Append("test");
                    }
                }
            }
            return sb.ToString();
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
            var msg = GetMsg();
        }
    }
}
