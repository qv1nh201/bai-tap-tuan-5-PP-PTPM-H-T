namespace _1150080082_TranHoQuangVinh
{
    partial class Apdung2
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

        private void InitializeComponent()
        {
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.lsbLog = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Consolas", 12F);
            this.txtDisplay.Location = new System.Drawing.Point(17, 17);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(215, 26);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lsbLog
            // 
            this.lsbLog.FormattingEnabled = true;
            this.lsbLog.HorizontalScrollbar = true;
            this.lsbLog.Location = new System.Drawing.Point(279, 17);
            this.lsbLog.Name = "lsbLog";
            this.lsbLog.Size = new System.Drawing.Size(258, 173);
            this.lsbLog.TabIndex = 1;
            // 
            // Apdung2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 390);
            this.Controls.Add(this.lsbLog);
            this.Controls.Add(this.txtDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Apdung2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Áp dụng 2 - Security Panel Trần Hồ Quang Vinh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.ListBox lsbLog;
    }
}
