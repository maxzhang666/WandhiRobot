using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Csharp.Customer.Model
{
    /// <summary>
    /// 群定时消息
    /// </summary>
    public class GroupTimer
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 间隔 文字
        /// </summary>
        public string intevalStr
        {
            get
            {
                return $"{(Hour != 0 ? $"{Hour}小时" : "")}{(Min != 0 ? $"{Min}小时" : "")}{(Sec != 0 ? $"{Sec}秒" : "")}";
            }
        }
        /// <summary>
        /// 间隔 小时
        /// </summary>
        public int Hour { set; get; }
        /// <summary>
        /// 间隔 分钟
        /// </summary>
        public int Min { get; set; }
        /// <summary>
        /// 间隔 秒
        /// </summary>
        public int Sec { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
    }
}
