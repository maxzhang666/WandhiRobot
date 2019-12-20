using Native.Csharp.App;
using Native.Csharp.Customer.Model;
using Native.Csharp.Sdk.Cqp.EventArgs;
using Native.Csharp.Sdk.Cqp.Interface;
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
            var list = Common.CqApi.GetGroupList().Select(a => new { Name = $"{a.Name}({a.Id})", Value = a.Id }).ToList();

            ListBox_GroupList.DataSource = list;
            ListBox_GroupList.DataBindings.Add("Name", list, "Value");
            ListBox_GroupList.DisplayMember = "Name";
        }
    }
}
