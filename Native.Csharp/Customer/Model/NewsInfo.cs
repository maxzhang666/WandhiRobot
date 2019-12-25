using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Csharp.Customer.Model
{
    public class NewsInfo
    {
        public int code { set; get; }

        public NewsData data { set; get; }

        public string message { set; get; }
    }    
    public class Calendar
    {
        /// <summary>
        /// 
        /// </summary>
        public int lYear { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int lMonth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int lDay { get; set; }
        /// <summary>
        /// 猪
        /// </summary>
        public string animal { get; set; }
        /// <summary>
        /// 二零一九年
        /// </summary>
        public string yearCn { get; set; }
        /// <summary>
        /// 冬月
        /// </summary>
        public string monthCn { get; set; }
        /// <summary>
        /// 三十
        /// </summary>
        public string dayCn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int cYear { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int cMonth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int cDay { get; set; }
        /// <summary>
        /// 己亥
        /// </summary>
        public string gzYear { get; set; }
        /// <summary>
        /// 丙子
        /// </summary>
        public string gzMonth { get; set; }
        /// <summary>
        /// 丙申
        /// </summary>
        public string gzDay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string isToday { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string isLeap { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int nWeek { get; set; }
        /// <summary>
        /// 星期三
        /// </summary>
        public string ncWeek { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string isTerm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string term { get; set; }
    }

    public class History
    {
        /// <summary>
        /// 1946年12月25日，《中华民国宪法》确认了蒋介石的个人统治。
        /// </summary>
        public string @event { get; set; }
    }

    public class News
    {
        /// <summary>
        /// 北京民航总医院遇袭医生抢救无效去世 工信部核发4个新手机号段
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// 国内
        /// </summary>
        public string category { get; set; }
    }

    public class Phrase
    {
        /// <summary>
        /// 设身处地
        /// </summary>
        public string phrase { get; set; }
        /// <summary>
        /// 设：设想。设想自己处在别人的那种境地。指替别人的处境着想。
        /// </summary>
        public string explain { get; set; }
        /// <summary>
        /// 《礼记·中庸》：“体群臣也。”朱熹注：“体，谓设以身处其地而察其心也。”
        /// </summary>
        public string @from { get; set; }
        /// <summary>
        /// 若非梦往神游，何谓～？（清·李渔《闲情偶寄》卷三《语求肖似》）
        /// </summary>
        public string example { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string simple { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string pinyin { get; set; }
    }

    public class Sentence
    {
        /// <summary>
        /// 泰戈尔
        /// </summary>
        public string author { get; set; }
        /// <summary>
        /// 世界上的一切伟大运动都与某种伟大理想有关。
        /// </summary>
        public string sentence { get; set; }
    }

    public class Detail
    {
        /// <summary>
        /// 
        /// </summary>
        public string date { get; set; }
        /// <summary>
        /// 小雨
        /// </summary>
        public string text_day { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string code_day { get; set; }
        /// <summary>
        /// 多云
        /// </summary>
        public string text_night { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string code_night { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string high { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string low { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string precip { get; set; }
        /// <summary>
        /// 无持续风向
        /// </summary>
        public string wind_direction { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string wind_direction_degree { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string wind_speed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string wind_scale { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string humidity { get; set; }
    }

    public class Weather
    {
        /// <summary>
        /// 郑州
        /// </summary>
        public string city { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string weatherOf { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Detail detail { get; set; }
    }

    public class NewsData
    {
        /// <summary>
        /// 特性：1、支持传入ip参数,获取指定ip地址所在城市的天气预报. 例如http://news.topurl.cn/api?ip=101.68.1.1；2、每日18点前播报当日天气,18点后预报明日天气；3、calendar.term代表节气；4、支持https；5、单个ip15秒内最多调用15次。
        /// </summary>
        public string _intro { get; set; }
        /// <summary>
        /// 日历
        /// </summary>
        public Calendar calendar { get; set; }
        /// <summary>
        /// 历史上的今天
        /// </summary>
        public List<History> historyList { get; set; }
        /// <summary>
        /// 新闻列表
        /// </summary>
        public List<News> newsList { get; set; }
        /// <summary>
        /// 每日成语
        /// </summary>
        public Phrase phrase { get; set; }
        /// <summary>
        /// 每日名言
        /// </summary>
        public Sentence sentence { get; set; }
        /// <summary>
        /// 天气
        /// </summary>
        public Weather weather { get; set; }
    }
}
