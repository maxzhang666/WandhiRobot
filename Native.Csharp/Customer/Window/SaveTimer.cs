using HZH_Controls.Forms;
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
    public partial class SaveTimer : FrmWithOKCancel1
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

        protected override void DoEnter()
        {
            if (!DataInvalid(out var msg))
            {
                FrmDialog.ShowDialog(this, msg, "信息不完整");
                return;
            }
            model.name = txt_TimerName.InputText;
            model.Content = txt_Content.Text;
            model.Hour = (int)num_Hour.Num;
            model.Min = (int)num_Min.Num;
            model.Sec = (int)num_Sec.Num;
            base.DoEnter();
            this.DialogResult = DialogResult.OK;
        }




        private void btn_Ok_Click(object sender, EventArgs e)
        {

        }

        private bool DataInvalid(out string msg)
        {
            var res = true;
            msg = "";
            if (num_Hour.Num == 0 && num_Min.Num == 0 && num_Sec.Num == 0)
            {
                msg = "间隔不能都为0";
                return false;
            }
            if (string.IsNullOrEmpty(txt_TimerName.InputText))
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
                this.Title = $"编辑-{model.name}";
                txt_TimerName.Text = model.name;

                num_Hour.Num = model.Hour;
                num_Min.Num = model.Min;
                num_Sec.Num = model.Sec;

                txt_Content.Text = model.Content;
            }
            else
            {
                model = new GroupTimer();
            }
        }



        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void num_Min_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
