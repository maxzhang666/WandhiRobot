using HZH_Controls.Controls;
using HZH_Controls.Forms;
using Native.Csharp.App;
using Native.Csharp.Customer.Extension;
using Native.Csharp.Customer.Model;
using Native.Csharp.Customer.Service;
using Native.Csharp.Customer.Service.CommonTimerService;
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
        //private long CurrentGroup;
        private GroupConfig CurrentGroup;
        private BindingList<GroupTimer> GroupTimers = new BindingList<GroupTimer>();
        public Main()
        {
            InitializeComponent();
#if DEBUG
#else
            tab_BaseConfig.Parent = null;
            tab_CardTest.Parent = null;
#endif
        }

        #region 窗体

        private void Main_Load(object sender, EventArgs e)
        {
            Config = Common.AppConfig;
            dgv_TimerList.AutoGenerateColumns = false;
            InitGroupList();
        }
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Common.CloseMainSetting();
        }
        #endregion

        #region 群列表

        /// <summary>
        /// 群列表初始化
        /// </summary>
        private void InitGroupList()
        {
            var list = Common.CqApi.GetGroupList().Select(a => new ListEntity
            {
                ID = a.Id.ToString(),
                Title = $"{a.Name}({a.Id})",
                Source = a
            }).ToList();

            list_GroupList.SetList(list);
        }
        /// <summary>
        /// 切换群
        /// </summary>
        /// <param name="item"></param>
        private void list_GroupList_ItemClick(UCListItemExt item)
        {
            var selected = (GroupInfo)item.DataSource.Source;
            if (Config.groupConfigs.ContainsKey(selected.Id))
            {
                CurrentGroup = Config.groupConfigs[selected.Id];
            }
            else
            {
                CurrentGroup = new GroupConfig(selected.Id);
                Config.groupConfigs.Add(selected.Id, CurrentGroup);
            }

            gb_Config.Text = $"功能-当前群：{CurrentGroup.GroupId}";


            #region 初始化相关配置信息
            //定时任务
            InitGroupTimers();
            //基础配置信息
            InitBaseConfig();
            #endregion
        }
        #endregion

        #region 基础配置
        private void InitBaseConfig()
        {
            sw_News.Checked = CurrentGroup.NewsOn;
            if (CurrentGroup.NewsTime.HasValue)
            {
                dp_News.CurrentTime = CurrentGroup.NewsTime.Value;
            }
        }
        #endregion

        #region 测试

        private void btn_XmlSend_Click(object sender, EventArgs e)
        {
            Common.CqApi.SendGroupMessage(CurrentGroup.GroupId, textBox_XmlTest.Text);
        }
        /// <summary>
        /// 新闻简报测试
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_NewsTest_BtnClick(object sender, EventArgs e)
        {
            Common.CqApi.SendGroupMessage(CurrentGroup.GroupId, new NewsService().GetNews());
        }

        private void btn_XmlClear_Click(object sender, EventArgs e)
        {
            textBox_XmlTest.Text = "";
        }
        /// <summary>
        /// infoQ测试
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_InfoQTest_BtnClick(object sender, EventArgs e)
        {
            new InfoQService().Run();
        }
        #endregion

        #region 定时任务

        /// <summary>
        /// 初始化群定时任务列表
        /// </summary>
        /// <param name="GroupId"></param>
        private void InitGroupTimers()
        {
            #region 初始化定时任务列表
            GroupTimers.Clear();
            CurrentGroup.GroupTimers.Values.ToList().ForEach(a => GroupTimers.Add(a));
            var bs = new BindingSource();
            bs.DataSource = GroupTimers;
            dgv_TimerList.DataSource = bs;

            #endregion

        }
        private void tsm_Add_Click(object sender, EventArgs e)
        {
            var st = new SaveTimer(GroupTimers.Select(a => a.name).ToList());
            if (st.ShowDialog() == DialogResult.OK)
            {
                SaveTimer(st.model);
            }
        }

        private void tsm_Edit_Click(object sender, EventArgs e)
        {
            if (dgv_TimerList.HasSelected())
            {
                var mod = dgv_TimerList.GetFirstSelected<GroupTimer>();
                var st = new SaveTimer(mod, GroupTimers.Select(a => a.name).ToList());
                if (st.ShowDialog() == DialogResult.OK)
                {
                    SaveTimer(st.model);
                }
            }
        }

        private void tsm_Del_Click(object sender, EventArgs e)
        {
            if (dgv_TimerList.HasSelected())
            {
                var mod = dgv_TimerList.GetFirstSelected<GroupTimer>();
                dgv_TimerList.Rows.Remove(dgv_TimerList.SelectedRows[0]);
                var timer = GroupTimers.Where(a => a.name == mod.name).FirstOrDefault();
                if (timer != null)
                {
                    GroupTimers.Remove(timer);
                }
                dgv_TimerList.Refresh();
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
                //GroupTimers.Remove(timer);
                timer = mod;
            }
            else
            {
                GroupTimers.Add(mod);
            }
            dgv_TimerList.Refresh();
        }
        private void dgv_TimerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                GroupTimers[e.RowIndex].isOn = (bool)dgv_TimerList.Rows[e.RowIndex].Cells[0].EditedFormattedValue;
                dgv_TimerList.Refresh();
            }
        }
        #endregion

        #region 配置保存、更新

        private void btn_SaveConfig_Click(object sender, EventArgs e)
        {
            if (CurrentGroup != null && CurrentGroup.GroupId != 0)
            {
                Action action = null;
                switch (tabControl1.SelectedTab.Name)
                {
                    case "tab_GroupTimers":
                        CurrentGroup.GroupTimers = GroupTimers.ToDictionary(a => a.name, b => b);
                        action = Common.RefreshTimers;
                        break;
                    case "tab_BaseConfig":
                        action = SaveBaseConfig();
                        break;
                    default:
                        break;
                }
                Config = Common.SaveConfig(Config, action);
                FrmAnchorTips.ShowTips((Control)sender, "保存成功", AnchorTipsLocation.TOP, autoCloseTime: 2000);
            }
            else
            {
                FrmAnchorTips.ShowTips((Control)sender, "什么也没保存", AnchorTipsLocation.TOP, autoCloseTime: 2000);
            }
        }
        /// <summary>
        /// 保存基础配置
        /// </summary>
        private Action SaveBaseConfig()
        {
            //每日新闻
            CurrentGroup.NewsOn = sw_News.Checked;
            CurrentGroup.NewsTime = dp_News.CurrentTime;
            //整点报时
            CurrentGroup.TimeTickOn = sw_TimeTick.Checked;

            //刷新通用计时器
            return Common.InitCommonTimer;
        }




        #endregion


    }
}
