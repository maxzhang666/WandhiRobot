using GHttpHelper;
using Native.Csharp.App;
using Native.Csharp.Customer.Extension;
using Native.Csharp.Customer.Model;
using Native.Csharp.Customer.Model.InfoQ;
using Native.Csharp.Customer.Service.Interface;
using Newtonsoft.Json;
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
        private string ArticleApi = "https://www.infoq.cn/public/v1/article/getDetail";
        private string Referer = "https://s.geekbang.org/search/c=2/k=q%E8%B5%84%E8%AE%AF/t=";

        private string CacheKey = "InfoQ";
        /// <summary>
        /// 获取首篇文章
        /// </summary>
        /// <returns></returns>
        private InfoQItem ArticleFirst()
        {
            var res = Http.Post<CommonResult<InfoQModel>>(Api, new { q = "q资讯", t = 2, s = 20, p = 1 }, RequestType.Json, Referer, Encoding.UTF8);
            InfoQItem article = null;
            if (res.code == 0)
            {
                article = res.data.list.FirstOrDefault();
            }
            return article;
        }
        private string ArticleContent(string Url)
        {
            var urls = Url.Split('/');
            var uuid = urls.LastOrDefault();
            var res = Http.Post<CommonResult<InfoQArticle>>(ArticleApi, new { uuid = uuid }, RequestType.Json, Url, Encoding: Encoding.UTF8);
            return res.code == 0 ? res.data.content : "";
        }
        /// <summary>
        /// 获取要发送的消息
        /// </summary>
        /// <returns></returns>
        public string GetMsg()
        {
            var article = ArticleFirst();
            var sb = new StringBuilder();
            var cache = Common.Cache.Get<string>(CacheKey);
            if (cache.NotEmpty())
            {
                sb.Append(cache);
            }
            else
            {
                if (article != null && article.publishTime.Day == DateTime.Now.Day)
                {
                    var content = ArticleContent(article.content_url);
                    var list = new List<string>();
                    if (!string.IsNullOrEmpty(content))
                    {
                        var rg = new Regex("<strong>(.*)<\\/strong>");
                        var matches = rg.Matches(content);
                        foreach (Match item in matches)
                        {
                            try
                            {
                                list.Add(item.Groups[1].Value);
                            }
                            catch (Exception)
                            {
                                continue;
                            }
                        }
                    }
                    if (list.Count > 0)
                    {
                        sb.Append("每日IT资讯\r\n");
                        sb.Append(string.Join("\r\n\r\n", list));
                        Common.Cache.Set(CacheKey, sb.ToString(), TimeSpan.FromDays(1));
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
            Common.Debug("infoq发送判断：" + time.ToString(), "infoq");
            return DateTime.Now.Hour == time.Hour && DateTime.Now.Minute == time.Minute;
        }

        public void Run()
        {
            var msg = GetMsg();
            Common.Debug($"信息已获取:{msg.NotEmpty().ToString()}", "infoq");
            if (!string.IsNullOrEmpty(msg))
            {
                foreach (var item in Common.AppConfig.groupConfigs.Values.Where(a => a.InfoQOn && a.InfoQTime.HasValue))
                {
                    var key = $"{item.GroupId}:{CacheKey}";
                    //重复、时间验证
                    if (!Common.Cache.Get(key, false) && AllowSend(item.InfoQTime.Value))
                    {
                        Common.CqApi.SendGroupMessage(item.GroupId, msg);
                        Common.Cache.Set(key, true);
                    }
                }
            }
        }
    }
}
