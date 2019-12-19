using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Csharp.Customer.Model
{
    public class BaseConfig
    {
        /// <summary>
        /// 主人QQ
        /// </summary>
        public string Master { set; get; }
        /// <summary>
        /// 群配置
        /// </summary>
        public List<GroupConfig> groupConfigs = new List<GroupConfig>();
    }
}
