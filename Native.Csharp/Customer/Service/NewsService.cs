using Native.Csharp.App;
using Native.Csharp.Customer.Model;
using Native.Csharp.Customer.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Csharp.Customer.Service
{
    public class NewsService : ICommonTimer
    {
        private string api = "https://news.topurl.cn/api";
        private string CacheKey = "News";
        public string GetNews()
        {
            //获取新闻 缓存保存12个小时
            var data = Common.Cache.Get<NewsData>(CacheKey);
            if (data == null)
            {
                var mod = GetData();
                if (mod.code != 200)
                {
                    return "";
                }
                data = mod.data;
                Common.Cache.Set(CacheKey, data);
            }

            #region 拼接新闻信息


            var msg = $@"嗨简报:{DateTime.Now.ToString("MM月dd日")},农历{data.calendar.monthCn}{data.calendar.dayCn},工作愉快,平安喜乐
【快讯】
{string.Join("\r\n", data.newsList.Select(a => $"[{a.category}]{a.title}"))}
【历史上的今天】
{string.Join("\r\n", data.historyList.Select(a => $"{a.@event}"))}
【今日成语】
{data.phrase.pinyin}
{data.phrase.phrase}
含义:{data.phrase.explain}
出处:{data.phrase.from}
";
            #endregion
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

        public void Run()
        {
            var msg = GetNews();
            if (!string.IsNullOrEmpty(msg))
            {
                foreach (var item in Common.AppConfig.groupConfigs.Values.Where(a => a.NewsOn && a.NewsTime.HasValue))
                {
                    Common.CqApi.SendGroupMessage(item.GroupId, msg);
                }
            }
        }
    }
}
