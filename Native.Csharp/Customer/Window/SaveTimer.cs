using Native.Csharp.Customer.Model;
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
    public partial class SaveTimer : Form
    {
        public GroupTimer model;
        public SaveTimer()
        {
            InitializeComponent();
        }
        public SaveTimer(GroupTimer groupTimer)
        {
            InitializeComponent();
            model = groupTimer;
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (!DataInvalid(out var msg))
            {
                MessageBox.Show(msg, "信息不完整");
                return;
            }
            model.name = txt_TimerName.Text;
            model.Content = txt_Content.Text;
            model.Hour = (int)num_Hour.Value;
            model.Min = (int)num_Min.Value;
            model.Sec = (int)num_Sec.Value;
            
        }

        private bool DataInvalid(out string msg)
        {
            var res = true;
            msg = "";
            if (num_Hour.Value == 0 && num_Min.Value == 0 && num_Sec.Value == 0)
            {
                msg = "间隔不能都为0";
                return false;
            }
            if (string.IsNullOrEmpty(txt_TimerName.Text))
            {
                msg = "请填写任务名称";
                return false;
            }
            if (string.IsNullOrEmpty(txt_Content.Text))
            {
                msg = "内容不能为空";
                return false;
            }
            return res;
        }

        private void SaveTimer_Load(object sender, EventArgs e)
        {
            if (model != null)
            {
                this.Text = $"编辑-{model.name}";
                txt_TimerName.Text = model.name;

                num_Hour.Value = model.Hour;
                num_Min.Value = model.Min;
                num_Sec.Value = model.Sec;

                txt_Content.Text = model.Content;
            }
            else
            {
                model = new GroupTimer();
            }
        }
    }
}
