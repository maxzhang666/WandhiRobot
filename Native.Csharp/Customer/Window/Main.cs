﻿using Native.Csharp.App;
using Native.Csharp.Customer.Model;
using Native.Csharp.Customer.Service;
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
        /// <summary>
        /// 当前群号
        /// </summary>
        private long CurrentGroup;
        private List<GroupTimer> GroupTimers = new List<GroupTimer>();
        public Main()
        {
            InitializeComponent();
#if DEBUG
#else
            tabPage1.Parent = null;
            tab_CardTest.Parent = null;      
#endif
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Config = Common.AppConfig;
            InitGroupList();
        }

        #region 群列表
        /// <summary>
        /// 选择群
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lv_GroupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_GroupList.SelectedItems.Count > 0)
            {
                var selected = (GroupInfo)lv_GroupList.SelectedItems[0].Tag;
                CurrentGroup = selected.Id;
                gb_Config.Text = $"功能-{CurrentGroup}";


                #region 初始化相关配置信息
                //定时任务
                InitGroupTimers(CurrentGroup);
                #endregion
            }
        }

        /// <summary>
        /// 群列表初始化
        /// </summary>
        private void InitGroupList()
        {
            var list = Common.CqApi.GetGroupList().Select(a => new ListViewItem { Text = $"{a.Name}({a.Id})", Tag = a });
            lv_GroupList.Items.AddRange(list.ToArray());
        }

        /// <summary>
        /// 群列表单击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lv_GroupList_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region 定时任务

        /// <summary>
        /// 初始化群定时任务列表
        /// </summary>
        /// <param name="GroupId"></param>
        private void InitGroupTimers(long GroupId)
        {
            if (Config.groupConfigs.ContainsKey(GroupId))
            {
                this.GroupTimers = Config.groupConfigs[GroupId].GroupTimers.Values.ToList();
            }
            dgv_TimerList.DataSource = GroupTimers;
        }
        #endregion

        #region 卡片测试

        private void btn_XmlSend_Click(object sender, EventArgs e)
        {
            var groupNum = ((GroupInfo)lv_GroupList.SelectedItems[0].Tag);
            Common.CqApi.SendGroupMessage(groupNum.Id, textBox_XmlTest.Text);
        }

        private void btn_XmlClear_Click(object sender, EventArgs e)
        {
            textBox_XmlTest.Text = "";
        }
        #endregion

        #region 定时任务


        private void tsm_Add_Click(object sender, EventArgs e)
        {
            var st = new SaveTimer();
            if (st.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void tsm_Edit_Click(object sender, EventArgs e)
        {
            var mod = (GroupTimer)dgv_TimerList.SelectedRows[0].DataBoundItem;
            var st = new SaveTimer(mod);
            if (st.ShowDialog() == DialogResult.OK)
            {

            }
        }
        /// <summary>
        /// 保存计时器信息
        /// </summary>
        /// <param name="mod"></param>
        private void SaveTimer(GroupTimer mod)
        {
            var timer = GroupTimers.Where(a => a.name == mod.name).FirstOrDefault();
            if (timer != null)
            {
                GroupTimers.Remove(timer);
            }
            GroupTimers.Add(mod);
        }

        #endregion

        #region 配置保存、更新

        private void btn_SaveConfig_Click(object sender, EventArgs e)
        {
            if (CurrentGroup != 0)
            {
                GroupConfig groupConfig;
                if (Config.groupConfigs.ContainsKey(CurrentGroup))
                {
                    groupConfig = Config.groupConfigs[CurrentGroup];
                }
                else
                {
                    groupConfig = new GroupConfig(CurrentGroup);
                }
                switch (tabControl1.SelectedTab.Name)
                {
                    case "tab_GroupTimers":
                        groupConfig.GroupTimers = GroupTimers.ToDictionary(a => a.name, b => b);
                        break;
                    default:
                        break;
                }
            }

            Common.AppConfig = this.Config;
            new  ConfigService()
        }
        #endregion
    }
}
