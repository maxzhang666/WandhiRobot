namespace Native.Csharp.Customer.Window
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gb_Config = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new HZH_Controls.Controls.TabControlExt();
            this.tab_BaseConfig = new System.Windows.Forms.TabPage();
            this.dp_News = new HZH_Controls.Controls.UCDatePickerExt();
            this.label1 = new System.Windows.Forms.Label();
            this.sw_News = new HZH_Controls.Controls.UCSwitch();
            this.tab_CardTest = new System.Windows.Forms.TabPage();
            this.btn_XmlClear = new HZH_Controls.Controls.UCBtnExt();
            this.btn_NewsTest = new HZH_Controls.Controls.UCBtnExt();
            this.btn_XmlSend = new HZH_Controls.Controls.UCBtnExt();
            this.textBox_XmlTest = new HZH_Controls.Controls.TextBoxEx();
            this.tab_GroupTimers = new System.Windows.Forms.TabPage();
            this.dgv_TimerList = new System.Windows.Forms.DataGridView();
            this.dgc_IsOn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgc_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgc_Inteval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgc_Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cms_TimerList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsm_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Del = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_SaveConfig = new HZH_Controls.Controls.UCBtnExt();
            this.list_GroupList = new HZH_Controls.Controls.UCListExt();
            this.uc_TimeTick = new HZH_Controls.Controls.UCSwitch();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_Config.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_BaseConfig.SuspendLayout();
            this.tab_CardTest.SuspendLayout();
            this.tab_GroupTimers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TimerList)).BeginInit();
            this.cms_TimerList.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 408);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "群列表";
            // 
            // gb_Config
            // 
            this.gb_Config.Controls.Add(this.tabControl1);
            this.gb_Config.Controls.Add(this.btn_SaveConfig);
            this.gb_Config.Location = new System.Drawing.Point(197, 12);
            this.gb_Config.Name = "gb_Config";
            this.gb_Config.Size = new System.Drawing.Size(486, 408);
            this.gb_Config.TabIndex = 2;
            this.gb_Config.TabStop = false;
            this.gb_Config.Text = "功能";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_BaseConfig);
            this.tabControl1.Controls.Add(this.tab_CardTest);
            this.tabControl1.Controls.Add(this.tab_GroupTimers);
            this.tabControl1.IsShowCloseBtn = false;
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 30);
            this.tabControl1.Location = new System.Drawing.Point(6, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(474, 350);
            this.tabControl1.TabIndex = 3;
            // 
            // tab_BaseConfig
            // 
            this.tab_BaseConfig.Controls.Add(this.dp_News);
            this.tab_BaseConfig.Controls.Add(this.label2);
            this.tab_BaseConfig.Controls.Add(this.uc_TimeTick);
            this.tab_BaseConfig.Controls.Add(this.label1);
            this.tab_BaseConfig.Controls.Add(this.sw_News);
            this.tab_BaseConfig.Location = new System.Drawing.Point(4, 34);
            this.tab_BaseConfig.Name = "tab_BaseConfig";
            this.tab_BaseConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tab_BaseConfig.Size = new System.Drawing.Size(466, 312);
            this.tab_BaseConfig.TabIndex = 0;
            this.tab_BaseConfig.Text = "基础配置";
            this.tab_BaseConfig.UseVisualStyleBackColor = true;
            // 
            // dp_News
            // 
            this.dp_News.BackColor = System.Drawing.Color.White;
            this.dp_News.ConerRadius = 5;
            this.dp_News.CurrentTime = new System.DateTime(2019, 12, 26, 9, 36, 1, 0);
            this.dp_News.FillColor = System.Drawing.Color.Transparent;
            this.dp_News.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dp_News.IsRadius = true;
            this.dp_News.IsShowRect = true;
            this.dp_News.Location = new System.Drawing.Point(284, 11);
            this.dp_News.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dp_News.Name = "dp_News";
            this.dp_News.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.dp_News.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.dp_News.RectWidth = 1;
            this.dp_News.Size = new System.Drawing.Size(127, 32);
            this.dp_News.TabIndex = 2;
            this.dp_News.TimeFontSize = 20;
            this.dp_News.TimeType = HZH_Controls.Controls.DateTimePickerType.Time;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "每日新闻";
            // 
            // sw_News
            // 
            this.sw_News.BackColor = System.Drawing.Color.Transparent;
            this.sw_News.Checked = false;
            this.sw_News.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.sw_News.FalseTextColr = System.Drawing.Color.White;
            this.sw_News.Location = new System.Drawing.Point(153, 12);
            this.sw_News.Name = "sw_News";
            this.sw_News.Size = new System.Drawing.Size(83, 31);
            this.sw_News.SwitchType = HZH_Controls.Controls.SwitchType.Ellipse;
            this.sw_News.TabIndex = 0;
            this.sw_News.Texts = new string[] {
        "开启",
        "关闭"};
            this.sw_News.TrueColor = System.Drawing.Color.DeepSkyBlue;
            this.sw_News.TrueTextColr = System.Drawing.Color.White;
            // 
            // tab_CardTest
            // 
            this.tab_CardTest.Controls.Add(this.btn_XmlClear);
            this.tab_CardTest.Controls.Add(this.btn_NewsTest);
            this.tab_CardTest.Controls.Add(this.btn_XmlSend);
            this.tab_CardTest.Controls.Add(this.textBox_XmlTest);
            this.tab_CardTest.Location = new System.Drawing.Point(4, 34);
            this.tab_CardTest.Name = "tab_CardTest";
            this.tab_CardTest.Padding = new System.Windows.Forms.Padding(3);
            this.tab_CardTest.Size = new System.Drawing.Size(466, 312);
            this.tab_CardTest.TabIndex = 1;
            this.tab_CardTest.Text = "卡片测试器";
            this.tab_CardTest.UseVisualStyleBackColor = true;
            // 
            // btn_XmlClear
            // 
            this.btn_XmlClear.BackColor = System.Drawing.Color.White;
            this.btn_XmlClear.BtnBackColor = System.Drawing.Color.White;
            this.btn_XmlClear.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_XmlClear.BtnForeColor = System.Drawing.Color.White;
            this.btn_XmlClear.BtnText = "清空";
            this.btn_XmlClear.ConerRadius = 5;
            this.btn_XmlClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_XmlClear.EnabledMouseEffect = true;
            this.btn_XmlClear.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_XmlClear.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn_XmlClear.IsRadius = true;
            this.btn_XmlClear.IsShowRect = true;
            this.btn_XmlClear.IsShowTips = false;
            this.btn_XmlClear.Location = new System.Drawing.Point(107, 254);
            this.btn_XmlClear.Margin = new System.Windows.Forms.Padding(0);
            this.btn_XmlClear.Name = "btn_XmlClear";
            this.btn_XmlClear.RectColor = System.Drawing.Color.White;
            this.btn_XmlClear.RectWidth = 1;
            this.btn_XmlClear.Size = new System.Drawing.Size(91, 35);
            this.btn_XmlClear.TabIndex = 4;
            this.btn_XmlClear.TabStop = false;
            this.btn_XmlClear.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btn_XmlClear.TipsText = "";
            this.btn_XmlClear.BtnClick += new System.EventHandler(this.btn_XmlClear_Click);
            // 
            // btn_NewsTest
            // 
            this.btn_NewsTest.BackColor = System.Drawing.Color.White;
            this.btn_NewsTest.BtnBackColor = System.Drawing.Color.White;
            this.btn_NewsTest.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_NewsTest.BtnForeColor = System.Drawing.Color.White;
            this.btn_NewsTest.BtnText = "新闻简报测试";
            this.btn_NewsTest.ConerRadius = 5;
            this.btn_NewsTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_NewsTest.EnabledMouseEffect = true;
            this.btn_NewsTest.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_NewsTest.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn_NewsTest.IsRadius = true;
            this.btn_NewsTest.IsShowRect = true;
            this.btn_NewsTest.IsShowTips = false;
            this.btn_NewsTest.Location = new System.Drawing.Point(209, 254);
            this.btn_NewsTest.Margin = new System.Windows.Forms.Padding(0);
            this.btn_NewsTest.Name = "btn_NewsTest";
            this.btn_NewsTest.RectColor = System.Drawing.Color.White;
            this.btn_NewsTest.RectWidth = 1;
            this.btn_NewsTest.Size = new System.Drawing.Size(110, 35);
            this.btn_NewsTest.TabIndex = 4;
            this.btn_NewsTest.TabStop = false;
            this.btn_NewsTest.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btn_NewsTest.TipsText = "";
            this.btn_NewsTest.BtnClick += new System.EventHandler(this.btn_NewsTest_BtnClick);
            // 
            // btn_XmlSend
            // 
            this.btn_XmlSend.BackColor = System.Drawing.Color.White;
            this.btn_XmlSend.BtnBackColor = System.Drawing.Color.White;
            this.btn_XmlSend.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_XmlSend.BtnForeColor = System.Drawing.Color.White;
            this.btn_XmlSend.BtnText = "发送";
            this.btn_XmlSend.ConerRadius = 5;
            this.btn_XmlSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_XmlSend.EnabledMouseEffect = true;
            this.btn_XmlSend.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_XmlSend.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn_XmlSend.IsRadius = true;
            this.btn_XmlSend.IsShowRect = true;
            this.btn_XmlSend.IsShowTips = false;
            this.btn_XmlSend.Location = new System.Drawing.Point(6, 254);
            this.btn_XmlSend.Margin = new System.Windows.Forms.Padding(0);
            this.btn_XmlSend.Name = "btn_XmlSend";
            this.btn_XmlSend.RectColor = System.Drawing.Color.White;
            this.btn_XmlSend.RectWidth = 1;
            this.btn_XmlSend.Size = new System.Drawing.Size(91, 35);
            this.btn_XmlSend.TabIndex = 4;
            this.btn_XmlSend.TabStop = false;
            this.btn_XmlSend.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btn_XmlSend.TipsText = "";
            this.btn_XmlSend.BtnClick += new System.EventHandler(this.btn_XmlSend_Click);
            // 
            // textBox_XmlTest
            // 
            this.textBox_XmlTest.DecLength = 2;
            this.textBox_XmlTest.InputType = HZH_Controls.TextInputType.NotControl;
            this.textBox_XmlTest.Location = new System.Drawing.Point(6, 6);
            this.textBox_XmlTest.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.textBox_XmlTest.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.textBox_XmlTest.Multiline = true;
            this.textBox_XmlTest.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.textBox_XmlTest.Name = "textBox_XmlTest";
            this.textBox_XmlTest.OldText = null;
            this.textBox_XmlTest.PromptColor = System.Drawing.Color.Gray;
            this.textBox_XmlTest.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox_XmlTest.PromptText = "";
            this.textBox_XmlTest.RegexPattern = "";
            this.textBox_XmlTest.Size = new System.Drawing.Size(454, 171);
            this.textBox_XmlTest.TabIndex = 0;
            // 
            // tab_GroupTimers
            // 
            this.tab_GroupTimers.Controls.Add(this.dgv_TimerList);
            this.tab_GroupTimers.Location = new System.Drawing.Point(4, 34);
            this.tab_GroupTimers.Name = "tab_GroupTimers";
            this.tab_GroupTimers.Padding = new System.Windows.Forms.Padding(3);
            this.tab_GroupTimers.Size = new System.Drawing.Size(466, 312);
            this.tab_GroupTimers.TabIndex = 2;
            this.tab_GroupTimers.Text = "间隔消息";
            this.tab_GroupTimers.UseVisualStyleBackColor = true;
            // 
            // dgv_TimerList
            // 
            this.dgv_TimerList.AllowUserToAddRows = false;
            this.dgv_TimerList.AllowUserToDeleteRows = false;
            this.dgv_TimerList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_TimerList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_TimerList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_TimerList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgv_TimerList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_TimerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TimerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgc_IsOn,
            this.dgc_Name,
            this.dgc_Inteval,
            this.dgc_Content});
            this.dgv_TimerList.ContextMenuStrip = this.cms_TimerList;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TimerList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_TimerList.GridColor = System.Drawing.Color.Gray;
            this.dgv_TimerList.Location = new System.Drawing.Point(6, 9);
            this.dgv_TimerList.MultiSelect = false;
            this.dgv_TimerList.Name = "dgv_TimerList";
            this.dgv_TimerList.RowHeadersVisible = false;
            this.dgv_TimerList.RowTemplate.Height = 23;
            this.dgv_TimerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TimerList.Size = new System.Drawing.Size(454, 300);
            this.dgv_TimerList.TabIndex = 6;
            this.dgv_TimerList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TimerList_CellContentClick);
            // 
            // dgc_IsOn
            // 
            this.dgc_IsOn.DataPropertyName = "isOn";
            this.dgc_IsOn.FalseValue = "False";
            this.dgc_IsOn.HeaderText = "启用";
            this.dgc_IsOn.IndeterminateValue = "False";
            this.dgc_IsOn.Name = "dgc_IsOn";
            this.dgc_IsOn.ToolTipText = "是否启用任务";
            this.dgc_IsOn.TrueValue = "True";
            this.dgc_IsOn.Width = 40;
            // 
            // dgc_Name
            // 
            this.dgc_Name.DataPropertyName = "name";
            this.dgc_Name.HeaderText = "名称(不可重复)";
            this.dgc_Name.MinimumWidth = 140;
            this.dgc_Name.Name = "dgc_Name";
            this.dgc_Name.ReadOnly = true;
            this.dgc_Name.Width = 140;
            // 
            // dgc_Inteval
            // 
            this.dgc_Inteval.DataPropertyName = "intevalStr";
            this.dgc_Inteval.HeaderText = "间隔";
            this.dgc_Inteval.MinimumWidth = 80;
            this.dgc_Inteval.Name = "dgc_Inteval";
            this.dgc_Inteval.ReadOnly = true;
            // 
            // dgc_Content
            // 
            this.dgc_Content.DataPropertyName = "content";
            this.dgc_Content.HeaderText = "内容";
            this.dgc_Content.MinimumWidth = 212;
            this.dgc_Content.Name = "dgc_Content";
            this.dgc_Content.ReadOnly = true;
            this.dgc_Content.Width = 212;
            // 
            // cms_TimerList
            // 
            this.cms_TimerList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Add,
            this.tsm_Edit,
            this.tsm_Del});
            this.cms_TimerList.Name = "cms_TimerList";
            this.cms_TimerList.Size = new System.Drawing.Size(101, 70);
            // 
            // tsm_Add
            // 
            this.tsm_Add.Name = "tsm_Add";
            this.tsm_Add.Size = new System.Drawing.Size(100, 22);
            this.tsm_Add.Text = "添加";
            this.tsm_Add.Click += new System.EventHandler(this.tsm_Add_Click);
            // 
            // tsm_Edit
            // 
            this.tsm_Edit.Name = "tsm_Edit";
            this.tsm_Edit.Size = new System.Drawing.Size(100, 22);
            this.tsm_Edit.Text = "编辑";
            this.tsm_Edit.Click += new System.EventHandler(this.tsm_Edit_Click);
            // 
            // tsm_Del
            // 
            this.tsm_Del.Name = "tsm_Del";
            this.tsm_Del.Size = new System.Drawing.Size(100, 22);
            this.tsm_Del.Text = "删除";
            this.tsm_Del.Click += new System.EventHandler(this.tsm_Del_Click);
            // 
            // btn_SaveConfig
            // 
            this.btn_SaveConfig.BackColor = System.Drawing.Color.White;
            this.btn_SaveConfig.BtnBackColor = System.Drawing.Color.White;
            this.btn_SaveConfig.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SaveConfig.BtnForeColor = System.Drawing.Color.White;
            this.btn_SaveConfig.BtnText = "保存当前页签配置";
            this.btn_SaveConfig.ConerRadius = 5;
            this.btn_SaveConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SaveConfig.EnabledMouseEffect = true;
            this.btn_SaveConfig.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.btn_SaveConfig.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn_SaveConfig.IsRadius = true;
            this.btn_SaveConfig.IsShowRect = true;
            this.btn_SaveConfig.IsShowTips = false;
            this.btn_SaveConfig.Location = new System.Drawing.Point(6, 373);
            this.btn_SaveConfig.Margin = new System.Windows.Forms.Padding(0);
            this.btn_SaveConfig.Name = "btn_SaveConfig";
            this.btn_SaveConfig.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.btn_SaveConfig.RectWidth = 1;
            this.btn_SaveConfig.Size = new System.Drawing.Size(153, 29);
            this.btn_SaveConfig.TabIndex = 3;
            this.btn_SaveConfig.TabStop = false;
            this.btn_SaveConfig.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btn_SaveConfig.TipsText = "保存";
            this.btn_SaveConfig.BtnClick += new System.EventHandler(this.btn_SaveConfig_Click);
            // 
            // list_GroupList
            // 
            this.list_GroupList.AutoScroll = true;
            this.list_GroupList.AutoSelectFirst = true;
            this.list_GroupList.ItemBackColor = System.Drawing.Color.White;
            this.list_GroupList.ItemForeColor = System.Drawing.Color.Black;
            this.list_GroupList.ItemForeColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.list_GroupList.ItemHeight = 20;
            this.list_GroupList.ItemSelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.list_GroupList.ItemSelectedForeColor = System.Drawing.Color.White;
            this.list_GroupList.ItemSelectedForeColor2 = System.Drawing.Color.White;
            this.list_GroupList.Location = new System.Drawing.Point(18, 32);
            this.list_GroupList.Name = "list_GroupList";
            this.list_GroupList.SelectedCanClick = false;
            this.list_GroupList.Size = new System.Drawing.Size(167, 382);
            this.list_GroupList.SplitColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.list_GroupList.TabIndex = 5;
            this.list_GroupList.Title2Font = new System.Drawing.Font("微软雅黑", 14F);
            this.list_GroupList.TitleFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.list_GroupList.ItemClick += new HZH_Controls.Controls.UCListExt.ItemClickEvent(this.list_GroupList_ItemClick);
            // 
            // uc_TimeTick
            // 
            this.uc_TimeTick.BackColor = System.Drawing.Color.Transparent;
            this.uc_TimeTick.Checked = false;
            this.uc_TimeTick.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.uc_TimeTick.FalseTextColr = System.Drawing.Color.White;
            this.uc_TimeTick.Location = new System.Drawing.Point(153, 50);
            this.uc_TimeTick.Name = "uc_TimeTick";
            this.uc_TimeTick.Size = new System.Drawing.Size(83, 31);
            this.uc_TimeTick.SwitchType = HZH_Controls.Controls.SwitchType.Ellipse;
            this.uc_TimeTick.TabIndex = 0;
            this.uc_TimeTick.Texts = new string[] {
        "开启",
        "关闭"};
            this.uc_TimeTick.TrueColor = System.Drawing.Color.DeepSkyBlue;
            this.uc_TimeTick.TrueTextColr = System.Drawing.Color.White;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(31, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "整点报时";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(694, 428);
            this.Controls.Add(this.list_GroupList);
            this.Controls.Add(this.gb_Config);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "控制中心";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.gb_Config.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tab_BaseConfig.ResumeLayout(false);
            this.tab_BaseConfig.PerformLayout();
            this.tab_CardTest.ResumeLayout(false);
            this.tab_CardTest.PerformLayout();
            this.tab_GroupTimers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TimerList)).EndInit();
            this.cms_TimerList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gb_Config;
        private System.Windows.Forms.ContextMenuStrip cms_TimerList;
        private System.Windows.Forms.ToolStripMenuItem tsm_Add;
        private System.Windows.Forms.ToolStripMenuItem tsm_Edit;
        private System.Windows.Forms.ToolStripMenuItem tsm_Del;
        private HZH_Controls.Controls.UCBtnExt btn_SaveConfig;
        private HZH_Controls.Controls.TabControlExt tabControl1;
        private System.Windows.Forms.TabPage tab_BaseConfig;
        private System.Windows.Forms.TabPage tab_CardTest;
        private System.Windows.Forms.TabPage tab_GroupTimers;
        private HZH_Controls.Controls.TextBoxEx textBox_XmlTest;
        private HZH_Controls.Controls.UCBtnExt btn_XmlClear;
        private HZH_Controls.Controls.UCBtnExt btn_XmlSend;
        private HZH_Controls.Controls.UCListExt list_GroupList;
        private System.Windows.Forms.DataGridView dgv_TimerList;
        private HZH_Controls.Controls.UCBtnExt btn_NewsTest;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgc_IsOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgc_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgc_Inteval;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgc_Content;
        private System.Windows.Forms.Label label1;
        private HZH_Controls.Controls.UCSwitch sw_News;
        private HZH_Controls.Controls.UCDatePickerExt dp_News;
        private System.Windows.Forms.Label label2;
        private HZH_Controls.Controls.UCSwitch uc_TimeTick;
    }
}