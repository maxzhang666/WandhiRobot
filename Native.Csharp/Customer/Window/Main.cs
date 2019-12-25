using HZH_Controls.Controls;
using HZH_Controls.Forms;
using Native.Csharp.App;
using Native.Csharp.Customer.Extension;
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
            dgv_TimerList.AutoGenerateColumns = false;
            InitGroupList();
        }

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
            CurrentGroup = selected.Id;
            gb_Config.Text = $"功能-当前群：{CurrentGroup}";


            #region 初始化相关配置信息
            //定时任务
            InitGroupTimers(CurrentGroup);
            #endregion
        }
        #endregion

        #region 定时任务


        #endregion

        #region 测试

        private void btn_XmlSend_Click(object sender, EventArgs e)
        {
            Common.CqApi.SendGroupMessage(CurrentGroup, textBox_XmlTest.Text);
        }
        /// <summary>
        /// 新闻简报测试
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_NewsTest_BtnClick(object sender, EventArgs e)
        {
            Common.CqApi.SendGroupMessage(CurrentGroup, new NewsService().GetNews());
        }
        private void btn_XmlClear_Click(object sender, EventArgs e)
        {
            textBox_XmlTest.Text = "";
        }
        #endregion

        #region 定时任务

        /// <summary>
        /// 初始化群定时任务列表
        /// </summary>
        /// <param name="GroupId"></param>
        private void InitGroupTimers(long GroupId)
        {
            #region 初始化定时任务列表
            if (Config.groupConfigs.ContainsKey(GroupId))
            {
                GroupTimers = Config.groupConfigs[GroupId].GroupTimers.Values.ToList();
            }
            else
            {
                GroupTimers = new List<GroupTimer>();
            }
            var bs = new BindingSource();
            bs.DataSource = GroupTimers;
            dgv_TimerList.DataSource = bs;

            #endregion

        }
        private void tsm_Add_Click(object sender, EventArgs e)
        {
            var st = new SaveTimer();
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
                var st = new SaveTimer(mod);
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
                    Config.groupConfigs.Add(CurrentGroup, groupConfig);
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

            Config = Common.SaveConfig(Config);
            FrmAnchorTips.ShowTips((Control)sender, "保存成功", AnchorTipsLocation.TOP, autoCloseTime: 2000);
        }

        #endregion

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Common.CloseMainSetting();
        }


    }
}
