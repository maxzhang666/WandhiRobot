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
            this.txt_Content = new HZH_Controls.Controls.TextBoxEx();
            this.num_Hour = new HZH_Controls.Controls.UCNumTextBox();
            this.num_Min = new HZH_Controls.Controls.UCNumTextBox();
            this.num_Sec = new HZH_Controls.Controls.UCNumTextBox();
            this.txt_TimerName = new HZH_Controls.Controls.UCTextBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txt_TimerName);
            this.panel3.Controls.Add(this.num_Sec);
            this.panel3.Controls.Add(this.num_Min);
            this.panel3.Controls.Add(this.num_Hour);
            this.panel3.Controls.Add(this.txt_Content);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Size = new System.Drawing.Size(552, 397);
            // 
            // txt_Content
            // 
            this.txt_Content.DecLength = 2;
            this.txt_Content.InputType = HZH_Controls.TextInputType.NotControl;
            this.txt_Content.Location = new System.Drawing.Point(89, 143);
            this.txt_Content.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txt_Content.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txt_Content.Multiline = true;
            this.txt_Content.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txt_Content.Name = "txt_Content";
            this.txt_Content.OldText = null;
            this.txt_Content.PromptColor = System.Drawing.Color.Gray;
            this.txt_Content.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Content.PromptText = "";
            this.txt_Content.RegexPattern = "";
            this.txt_Content.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Content.Size = new System.Drawing.Size(404, 127);
            this.txt_Content.TabIndex = 4;
            // 
            // num_Hour
            // 
            this.num_Hour.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Hour.InputType = HZH_Controls.TextInputType.Number;
            this.num_Hour.IsNumCanInput = true;
            this.num_Hour.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderNum;
            this.num_Hour.Location = new System.Drawing.Point(89, 85);
            this.num_Hour.MaxValue = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.num_Hour.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.num_Hour.Name = "num_Hour";
            this.num_Hour.Num = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Hour.Padding = new System.Windows.Forms.Padding(2);
            this.num_Hour.Size = new System.Drawing.Size(100, 30);
            this.num_Hour.TabIndex = 5;
            // 
            // num_Min
            // 
            this.num_Min.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Min.InputType = HZH_Controls.TextInputType.Number;
            this.num_Min.IsNumCanInput = true;
            this.num_Min.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderNum;
            this.num_Min.Location = new System.Drawing.Point(227, 85);
            this.num_Min.MaxValue = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.num_Min.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.num_Min.Name = "num_Min";
            this.num_Min.Num = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Min.Padding = new System.Windows.Forms.Padding(2);
            this.num_Min.Size = new System.Drawing.Size(100, 30);
            this.num_Min.TabIndex = 5;
            // 
            // num_Sec
            // 
            this.num_Sec.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Sec.InputType = HZH_Controls.TextInputType.Number;
            this.num_Sec.IsNumCanInput = true;
            this.num_Sec.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderNum;
            this.num_Sec.Location = new System.Drawing.Point(365, 85);
            this.num_Sec.MaxValue = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.num_Sec.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.num_Sec.Name = "num_Sec";
            this.num_Sec.Num = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Sec.Padding = new System.Windows.Forms.Padding(2);
            this.num_Sec.Size = new System.Drawing.Size(100, 30);
            this.num_Sec.TabIndex = 5;
            // 
            // txt_TimerName
            // 
            this.txt_TimerName.BackColor = System.Drawing.Color.Transparent;
            this.txt_TimerName.ConerRadius = 5;
            this.txt_TimerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimerName.DecLength = 2;
            this.txt_TimerName.FillColor = System.Drawing.Color.Empty;
            this.txt_TimerName.FocusBorderColor = System.Drawing.SystemColors.Highlight;
            this.txt_TimerName.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_TimerName.InputText = "";
            this.txt_TimerName.InputType = HZH_Controls.TextInputType.NotControl;
            this.txt_TimerName.IsFocusColor = true;
            this.txt_TimerName.IsRadius = true;
            this.txt_TimerName.IsShowClearBtn = true;
            this.txt_TimerName.IsShowKeyboard = false;
            this.txt_TimerName.IsShowRect = true;
            this.txt_TimerName.IsShowSearchBtn = false;
            this.txt_TimerName.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.txt_TimerName.Location = new System.Drawing.Point(89, 27);
            this.txt_TimerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TimerName.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txt_TimerName.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txt_TimerName.Name = "txt_TimerName";
            this.txt_TimerName.Padding = new System.Windows.Forms.Padding(5);
            this.txt_TimerName.PromptColor = System.Drawing.Color.Gray;
            this.txt_TimerName.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_TimerName.PromptText = "";
            this.txt_TimerName.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_TimerName.RectWidth = 1;
            this.txt_TimerName.RegexPattern = "";
            this.txt_TimerName.Size = new System.Drawing.Size(404, 42);
            this.txt_TimerName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(39, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(39, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "间隔";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(39, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "内容";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(195, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "时";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(333, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "分";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(471, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "秒";
            // 
            // SaveTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 397);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaveTimer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SaveTimer";
            this.Title = "新增";
            this.Load += new System.EventHandler(this.SaveTimer_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private HZH_Controls.Controls.UCNumTextBox num_Hour;
        private HZH_Controls.Controls.TextBoxEx txt_Content;
        private HZH_Controls.Controls.UCNumTextBox num_Min;
        private HZH_Controls.Controls.UCNumTextBox num_Sec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private HZH_Controls.Controls.UCTextBoxEx txt_TimerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}