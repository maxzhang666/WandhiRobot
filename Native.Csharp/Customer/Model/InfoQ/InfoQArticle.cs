using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Csharp.Customer.Model.InfoQ
{
    class InfoQArticle
    {
        /// <summary>
        /// 
        /// </summary>
        public string uuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string info { get; set; }
        /// <summary>
        /// Q资讯：华为云推出类“钉钉”软件WeLink；YouTube删除加密视频；苹果位居全球科技公司2019终市值之首
        /// </summary>
        public string article_title { get; set; }
        /// <summary>
        /// Q资讯：华为云推出类“钉钉”软件WeLink；YouTube删除加密视频；苹果位居全球科技公司2019终市值之首
        /// </summary>
        public string article_sharetitle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string article_subtitle { get; set; }
        /// <summary>
        /// “不碰应用”的Flag倒了。
        /// </summary>
        public string article_summary { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string article_cover { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string article_cover_point { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string translator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_collect { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string no_author { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_promotion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string share_pic { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sub_type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int comment_user { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int comment_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string content { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int love { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_love { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int copyright { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int lead_author { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> relation_topic_list { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> relation_list { get; set; }
    }
}
