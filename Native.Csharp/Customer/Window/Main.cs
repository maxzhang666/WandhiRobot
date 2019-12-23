using Native.Csharp.App;
using Native.Csharp.Customer.Model;
using Native.Csharp.Sdk.Cqp.EventArgs;
using Native.Csharp.Sdk.Cqp.Interface;
using Native.Csharp.Sdk.Cqp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Native.Csharp.Customer.Window
{
    public partial class Main : Form
    {
        private BaseConfig Config;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Config = Common.AppConfig;
            InitGroupList();
        }

        private void InitGroupList()
        {
            var list = Common.CqApi.GetGroupList().Select(a => new ListViewItem { Text = $"{a.Name}({a.Id})", Tag = a });
            lv_GroupList.Items.AddRange(list.ToArray());
        }

        private void btn_XmlSend_Click(object sender, EventArgs e)
        {
            var groupNum = ((GroupInfo)lv_GroupList.SelectedItems[0].Tag);
            Common.CqApi.SendGroupMessage(groupNum.Id, textBox_XmlTest.Text);
        }

        private void btn_XmlClear_Click(object sender, EventArgs e)
        {
            textBox_XmlTest.Text = "";
        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
