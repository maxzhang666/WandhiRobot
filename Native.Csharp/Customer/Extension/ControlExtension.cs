using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Native.Csharp.Customer.Extension
{
    public static class ControlExtension
    {
        /// <summary>
        /// 是否具有选择项
        /// </summary>
        /// <param name="dgv"></param>
        /// <returns></returns>
        public static bool HasSelected(this DataGridView dgv)
        {
            return dgv.SelectedRows.Count > 0;
        }
        /// <summary>
        /// 获取第一个选择行
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dgv"></param>
        /// <returns></returns>
        public static T GetFirstSelected<T>(this DataGridView dgv)
        {
            if (dgv.HasSelected())
            {
                return (T)dgv.SelectedRows[0].DataBoundItem;
            }
            return default;
        }
    }
}
