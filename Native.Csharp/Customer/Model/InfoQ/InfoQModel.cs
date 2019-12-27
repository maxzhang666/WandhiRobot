using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Csharp.Customer.Model.InfoQ
{
    public class InfoQModel
    {
        /// <summary>
        /// 搜索时间
        /// </summary>
        public double search_time { get; set; }
        /// <summary>
        /// 页码
        /// </summary>
        public int page { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public int num { get; set; }
        /// <summary>
        /// 总量
        /// </summary>
        public int total { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<InfoQItem> list { get; set; }
    }
}
