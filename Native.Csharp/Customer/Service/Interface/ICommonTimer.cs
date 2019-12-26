using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Csharp.Customer.Service.Interface
{
    interface ICommonTimer
    {
        /// <summary>
        /// 是否达成发送条件
        /// </summary>
        /// <returns></returns>
        bool AllowSend();

        /// <summary>
        /// 是否达成发送条件
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        bool AllowSend(DateTime time);
        /// <summary>
        /// 执行内容
        /// </summary>
        /// <returns></returns>
        void Run();
    }
}
