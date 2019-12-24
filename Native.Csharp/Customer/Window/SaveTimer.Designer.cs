namespace Native.Csharp.Customer.Window
{
    partial class SaveTimer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TimerName = new System.Windows.Forms.TextBox();
            this.txt_Content = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.num_Hour = new System.Windows.Forms.NumericUpDown();
            this.num_Min = new System.Windows.Forms.NumericUpDown();
            this.num_Sec = new System.Windows.Forms.NumericUpDown();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_Hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Sec)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "间隔";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "内容";
            // 
            // txt_TimerName
            // 
            this.txt_TimerName.Location = new System.Drawing.Point(60, 19);
            this.txt_TimerName.Name = "txt_TimerName";
            this.txt_TimerName.Size = new System.Drawing.Size(100, 21);
            this.txt_TimerName.TabIndex = 1;
            // 
            // txt_Content
            // 
            this.txt_Content.Location = new System.Drawing.Point(60, 84);
            this.txt_Content.Multiline = true;
            this.txt_Content.Name = "txt_Content";
            this.txt_Content.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_Content.Size = new System.Drawing.Size(268, 117);
            this.txt_Content.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "时";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "分";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "秒";
            // 
            // num_Hour
            // 
            this.num_Hour.Location = new System.Drawing.Point(61, 52);
            this.num_Hour.Name = "num_Hour";
            this.num_Hour.ReadOnly = true;
            this.num_Hour.Size = new System.Drawing.Size(34, 21);
            this.num_Hour.TabIndex = 2;
            // 
            // num_Min
            // 
            this.num_Min.Location = new System.Drawing.Point(124, 52);
            this.num_Min.Name = "num_Min";
            this.num_Min.ReadOnly = true;
            this.num_Min.Size = new System.Drawing.Size(34, 21);
            this.num_Min.TabIndex = 2;
            // 
            // num_Sec
            // 
            this.num_Sec.Location = new System.Drawing.Point(187, 52);
            this.num_Sec.Name = "num_Sec";
            this.num_Sec.ReadOnly = true;
            this.num_Sec.Size = new System.Drawing.Size(34, 21);
            this.num_Sec.TabIndex = 2;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(61, 207);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 3;
            this.btn_Ok.Text = "确定";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(205, 207);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // SaveTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(340, 242);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.num_Sec);
            this.Controls.Add(this.num_Min);
            this.Controls.Add(this.num_Hour);
            this.Controls.Add(this.txt_Content);
            this.Controls.Add(this.txt_TimerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaveTimer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SaveTimer";
            this.Load += new System.EventHandler(this.SaveTimer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_Hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Sec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TimerName;
        private System.Windows.Forms.TextBox txt_Content;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown num_Hour;
        private System.Windows.Forms.NumericUpDown num_Min;
        private System.Windows.Forms.NumericUpDown num_Sec;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Cancel;
    }
}