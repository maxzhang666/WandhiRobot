using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Csharp.Customer.Model
{
    public class GroupConfig
    {
        /// <summary>
        /// 群号
        /// </summary>
        public long GroupId { set; get; }
        /// <summary>
        /// 群定时任务配置
        /// </summary>
        public Dictionary<string, GroupTimer> GroupTimers { set; get; } = new Dictionary<string, GroupTimer>();
    }
}
