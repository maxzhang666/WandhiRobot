using Native.Csharp.Customer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Csharp.Customer.Service
{
    public class NewsService
    {
        private string api = "https://news.topurl.cn/api";
        public string GetNews()
        {
            var mod = GetData();
            var data = mod.data;
            var msg = $@"嗨简报:{DateTime.Now.ToString("MM月dd日")},农历{data.calendar.monthCn}{data.calendar.dayCn},工作愉快,平安喜乐
【快讯】
{data.newsList.Select(a => $"[{a.category}]{a.title}\r\n")}
【历史上的今天】
{data.historyList.Select(a => $"{a.@event}\r\n")}
【今日成语】
{data.phrase.pinyin}
{data.phrase.phrase}
含义:{data.phrase.explain}
出处:{data.phrase.from}
";
            return msg;
        }
        public NewsInfo GetData()
        {
            NewsInfo mod;
            try
            {
                mod = GHttpHelper.Http.Get<NewsInfo>(api);
            }
            catch (Exception e)
            {
                mod = new NewsInfo
                {
                    code = -1
                };
            }
            return mod;
        }
    }
}
