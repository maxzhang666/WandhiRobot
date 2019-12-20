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
            this.ListBox_GroupList = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox_XmlTest = new System.Windows.Forms.TextBox();
            this.btn_XmlSend = new System.Windows.Forms.Button();
            this.btn_XmlClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBox_GroupList
            // 
            this.ListBox_GroupList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBox_GroupList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListBox_GroupList.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ListBox_GroupList.FormattingEnabled = true;
            this.ListBox_GroupList.HorizontalExtent = 10;
            this.ListBox_GroupList.HorizontalScrollbar = true;
            this.ListBox_GroupList.ItemHeight = 17;
            this.ListBox_GroupList.Location = new System.Drawing.Point(16, 20);
            this.ListBox_GroupList.MultiColumn = true;
            this.ListBox_GroupList.Name = "ListBox_GroupList";
            this.ListBox_GroupList.Size = new System.Drawing.Size(199, 376);
            this.ListBox_GroupList.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListBox_GroupList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 408);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "群列表";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(250, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 408);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "功能";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(6, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 382);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(424, 376);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(416, 350);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "基础配置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_XmlClear);
            this.tabPage2.Controls.Add(this.btn_XmlSend);
            this.tabPage2.Controls.Add(this.textBox_XmlTest);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(416, 350);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "卡片测试器";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // btn_XmlSend
            // 
            this.btn_XmlSend.Location = new System.Drawing.Point(3, 296);
            this.btn_XmlSend.Name = "btn_XmlSend";
            this.btn_XmlSend.Size = new System.Drawing.Size(105, 48);
            this.btn_XmlSend.TabIndex = 1;
            this.btn_XmlSend.Text = "发送";
            this.btn_XmlSend.UseVisualStyleBackColor = true;
            this.btn_XmlSend.Click += new System.EventHandler(this.btn_XmlSend_Click);
            // 
            // btn_XmlClear
            // 
            this.btn_XmlClear.Location = new System.Drawing.Point(114, 296);
            this.btn_XmlClear.Name = "btn_XmlClear";
            this.btn_XmlClear.Size = new System.Drawing.Size(105, 48);
            this.btn_XmlClear.TabIndex = 2;
            this.btn_XmlClear.Text = "清空";
            this.btn_XmlClear.UseVisualStyleBackColor = true;
            this.btn_XmlClear.Click += new System.EventHandler(this.btn_XmlClear_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 432);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "控制中心";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox_GroupList;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_XmlClear;
        private System.Windows.Forms.Button btn_XmlSend;
        private System.Windows.Forms.TextBox textBox_XmlTest;
    }
}