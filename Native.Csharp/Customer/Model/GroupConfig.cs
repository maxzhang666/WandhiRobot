using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Csharp.Customer.Model
{
    public class GroupConfig
    {
        public GroupConfig()
        {

        }
        public GroupConfig(long GroupId)
        {
            this.GroupId = GroupId;
        }
        /// <summary>
        /// 群号
        /// </summary>
        public long GroupId { set; get; }

        #region 每日新闻
        /// <summary>
        /// 开关
        /// </summary>
        public bool NewsOn { set; get; } = false;
        /// <summary>
        /// 发送时间
        /// </summary>
        public DateTime? NewsTime { set; get; }
        #endregion

        #region 整点报时           

        /// <summary>
        /// 开关
        /// </summary>
        public bool TimeTickOn { set; get; }
        #endregion

        /// <summary>
        /// 群定时任务配置
        /// </summary>
        public Dictionary<string, GroupTimer> GroupTimers { set; get; } = new Dictionary<string, GroupTimer>();
    }
}
