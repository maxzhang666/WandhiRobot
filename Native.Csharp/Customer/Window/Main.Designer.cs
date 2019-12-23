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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lv_GroupList = new System.Windows.Forms.ListView();
            this.gb_Config = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_SaveConfig = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_BaseConfig = new System.Windows.Forms.TabPage();
            this.tab_CardTest = new System.Windows.Forms.TabPage();
            this.btn_XmlClear = new System.Windows.Forms.Button();
            this.btn_XmlSend = new System.Windows.Forms.Button();
            this.textBox_XmlTest = new System.Windows.Forms.TextBox();
            this.tab_GroupTimers = new System.Windows.Forms.TabPage();
            this.dgv_TimerList = new System.Windows.Forms.DataGridView();
            this.cms_TimerList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsm_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.TimerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Intervals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimerContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsm_Del = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.gb_Config.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_CardTest.SuspendLayout();
            this.tab_GroupTimers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TimerList)).BeginInit();
            this.cms_TimerList.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lv_GroupList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 408);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "群列表";
            // 
            // lv_GroupList
            // 
            this.lv_GroupList.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lv_GroupList.FullRowSelect = true;
            this.lv_GroupList.HideSelection = false;
            this.lv_GroupList.Location = new System.Drawing.Point(6, 20);
            this.lv_GroupList.MultiSelect = false;
            this.lv_GroupList.Name = "lv_GroupList";
            this.lv_GroupList.Size = new System.Drawing.Size(165, 375);
            this.lv_GroupList.TabIndex = 4;
            this.lv_GroupList.UseCompatibleStateImageBehavior = false;
            this.lv_GroupList.View = System.Windows.Forms.View.List;
            this.lv_GroupList.SelectedIndexChanged += new System.EventHandler(this.lv_GroupList_SelectedIndexChanged);
            this.lv_GroupList.Click += new System.EventHandler(this.lv_GroupList_Click);
            // 
            // gb_Config
            // 
            this.gb_Config.Controls.Add(this.panel1);
            this.gb_Config.Location = new System.Drawing.Point(206, 12);
            this.gb_Config.Name = "gb_Config";
            this.gb_Config.Size = new System.Drawing.Size(486, 408);
            this.gb_Config.TabIndex = 2;
            this.gb_Config.TabStop = false;
            this.gb_Config.Text = "功能";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_SaveConfig);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(6, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 382);
            this.panel1.TabIndex = 0;
            // 
            // btn_SaveConfig
            // 
            this.btn_SaveConfig.Location = new System.Drawing.Point(13, 352);
            this.btn_SaveConfig.Name = "btn_SaveConfig";
            this.btn_SaveConfig.Size = new System.Drawing.Size(98, 23);
            this.btn_SaveConfig.TabIndex = 1;
            this.btn_SaveConfig.Text = "保存当前配置页";
            this.btn_SaveConfig.UseVisualStyleBackColor = true;
            this.btn_SaveConfig.Click += new System.EventHandler(this.btn_SaveConfig_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_BaseConfig);
            this.tabControl1.Controls.Add(this.tab_CardTest);
            this.tabControl1.Controls.Add(this.tab_GroupTimers);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(471, 347);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_BaseConfig
            // 
            this.tab_BaseConfig.Location = new System.Drawing.Point(4, 22);
            this.tab_BaseConfig.Name = "tab_BaseConfig";
            this.tab_BaseConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tab_BaseConfig.Size = new System.Drawing.Size(463, 321);
            this.tab_BaseConfig.TabIndex = 2;
            this.tab_BaseConfig.Text = "基础配置";
            this.tab_BaseConfig.UseVisualStyleBackColor = true;
            // 
            // tab_CardTest
            // 
            this.tab_CardTest.Controls.Add(this.btn_XmlClear);
            this.tab_CardTest.Controls.Add(this.btn_XmlSend);
            this.tab_CardTest.Controls.Add(this.textBox_XmlTest);
            this.tab_CardTest.Location = new System.Drawing.Point(4, 22);
            this.tab_CardTest.Name = "tab_CardTest";
            this.tab_CardTest.Padding = new System.Windows.Forms.Padding(3);
            this.tab_CardTest.Size = new System.Drawing.Size(463, 321);
            this.tab_CardTest.TabIndex = 3;
            this.tab_CardTest.Text = "卡片测试器";
            this.tab_CardTest.UseVisualStyleBackColor = true;
            // 
            // btn_XmlClear
            // 
            this.btn_XmlClear.Location = new System.Drawing.Point(117, 270);
            this.btn_XmlClear.Name = "btn_XmlClear";
            this.btn_XmlClear.Size = new System.Drawing.Size(105, 48);
            this.btn_XmlClear.TabIndex = 2;
            this.btn_XmlClear.Text = "清空";
            this.btn_XmlClear.UseVisualStyleBackColor = true;
            this.btn_XmlClear.Click += new System.EventHandler(this.btn_XmlClear_Click);
            // 
            // btn_XmlSend
            // 
            this.btn_XmlSend.Location = new System.Drawing.Point(6, 270);
            this.btn_XmlSend.Name = "btn_XmlSend";
            this.btn_XmlSend.Size = new System.Drawing.Size(105, 48);
            this.btn_XmlSend.TabIndex = 1;
            this.btn_XmlSend.Text = "发送";
            this.btn_XmlSend.UseVisualStyleBackColor = true;
            this.btn_XmlSend.Click += new System.EventHandler(this.btn_XmlSend_Click);
            // 
            // textBox_XmlTest
            // 
            this.textBox_XmlTest.Location = new System.Drawing.Point(6, 3);
            this.textBox_XmlTest.Multiline = true;
            this.textBox_XmlTest.Name = "textBox_XmlTest";
            this.textBox_XmlTest.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_XmlTest.Size = new System.Drawing.Size(407, 128);
            this.textBox_XmlTest.TabIndex = 0;
            // 
            // tab_GroupTimers
            // 
            this.tab_GroupTimers.Controls.Add(this.dgv_TimerList);
            this.tab_GroupTimers.Location = new System.Drawing.Point(4, 22);
            this.tab_GroupTimers.Name = "tab_GroupTimers";
            this.tab_GroupTimers.Padding = new System.Windows.Forms.Padding(3);
            this.tab_GroupTimers.Size = new System.Drawing.Size(463, 321);
            this.tab_GroupTimers.TabIndex = 4;
            this.tab_GroupTimers.Text = "定时发送";
            this.tab_GroupTimers.UseVisualStyleBackColor = true;
            // 
            // dgv_TimerList
            // 
            this.dgv_TimerList.AllowUserToAddRows = false;
            this.dgv_TimerList.AllowUserToDeleteRows = false;
            this.dgv_TimerList.AllowUserToOrderColumns = true;
            this.dgv_TimerList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_TimerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TimerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimerName,
            this.Intervals,
            this.TimerContent});
            this.dgv_TimerList.ContextMenuStrip = this.cms_TimerList;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TimerList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_TimerList.Location = new System.Drawing.Point(6, 6);
            this.dgv_TimerList.MultiSelect = false;
            this.dgv_TimerList.Name = "dgv_TimerList";
            this.dgv_TimerList.ReadOnly = true;
            this.dgv_TimerList.RowHeadersVisible = false;
            this.dgv_TimerList.RowTemplate.Height = 23;
            this.dgv_TimerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TimerList.Size = new System.Drawing.Size(451, 218);
            this.dgv_TimerList.TabIndex = 0;
            // 
            // cms_TimerList
            // 
            this.cms_TimerList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Add,
            this.tsm_Edit,
            this.tsm_Del});
            this.cms_TimerList.Name = "cms_TimerList";
            this.cms_TimerList.Size = new System.Drawing.Size(181, 92);
            // 
            // tsm_Add
            // 
            this.tsm_Add.Name = "tsm_Add";
            this.tsm_Add.Size = new System.Drawing.Size(180, 22);
            this.tsm_Add.Text = "添加";
            this.tsm_Add.Click += new System.EventHandler(this.tsm_Add_Click);
            // 
            // tsm_Edit
            // 
            this.tsm_Edit.Name = "tsm_Edit";
            this.tsm_Edit.Size = new System.Drawing.Size(180, 22);
            this.tsm_Edit.Text = "编辑";
            this.tsm_Edit.Click += new System.EventHandler(this.tsm_Edit_Click);
            // 
            // TimerName
            // 
            this.TimerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TimerName.DataPropertyName = "name";
            this.TimerName.FillWeight = 110.7522F;
            this.TimerName.HeaderText = "名称(不可重复)";
            this.TimerName.MinimumWidth = 100;
            this.TimerName.Name = "TimerName";
            this.TimerName.ReadOnly = true;
            // 
            // Intervals
            // 
            this.Intervals.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Intervals.DataPropertyName = "intevalStr";
            this.Intervals.FillWeight = 80F;
            this.Intervals.HeaderText = "间隔时间";
            this.Intervals.MinimumWidth = 70;
            this.Intervals.Name = "Intervals";
            this.Intervals.ReadOnly = true;
            // 
            // TimerContent
            // 
            this.TimerContent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TimerContent.DataPropertyName = "content";
            this.TimerContent.FillWeight = 92.2935F;
            this.TimerContent.HeaderText = "内容";
            this.TimerContent.MinimumWidth = 230;
            this.TimerContent.Name = "TimerContent";
            this.TimerContent.ReadOnly = true;
            // 
            // tsm_Del
            // 
            this.tsm_Del.Name = "tsm_Del";
            this.tsm_Del.Size = new System.Drawing.Size(180, 22);
            this.tsm_Del.Text = "删除";
            this.tsm_Del.Click += new System.EventHandler(this.tsm_Del_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 429);
            this.Controls.Add(this.gb_Config);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "控制中心";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.gb_Config.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_BaseConfig;
        private System.Windows.Forms.TabPage tab_CardTest;
        private System.Windows.Forms.Button btn_XmlClear;
        private System.Windows.Forms.Button btn_XmlSend;
        private System.Windows.Forms.TextBox textBox_XmlTest;
        private System.Windows.Forms.TabPage tab_GroupTimers;
        private System.Windows.Forms.DataGridView dgv_TimerList;
        private System.Windows.Forms.ContextMenuStrip cms_TimerList;
        private System.Windows.Forms.ToolStripMenuItem tsm_Add;
        private System.Windows.Forms.ToolStripMenuItem tsm_Edit;
        private System.Windows.Forms.ListView lv_GroupList;
        private System.Windows.Forms.Button btn_SaveConfig;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intervals;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimerContent;
        private System.Windows.Forms.ToolStripMenuItem tsm_Del;
    }
}