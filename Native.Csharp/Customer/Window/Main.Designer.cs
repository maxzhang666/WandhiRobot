﻿namespace Native.Csharp.Customer.Window
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
            this.SuspendLayout();
            // 
            // ListBox_GroupList
            // 
            this.ListBox_GroupList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBox_GroupList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListBox_GroupList.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ListBox_GroupList.FormattingEnabled = true;
            this.ListBox_GroupList.ItemHeight = 21;
            this.ListBox_GroupList.Location = new System.Drawing.Point(12, 12);
            this.ListBox_GroupList.Name = "ListBox_GroupList";
            this.ListBox_GroupList.Size = new System.Drawing.Size(197, 401);
            this.ListBox_GroupList.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 432);
            this.Controls.Add(this.ListBox_GroupList);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "控制中心";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox_GroupList;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}