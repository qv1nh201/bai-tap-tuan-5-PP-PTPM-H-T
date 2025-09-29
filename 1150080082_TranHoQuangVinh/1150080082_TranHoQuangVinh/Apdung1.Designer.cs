namespace USCLN_BSCNN
{
    partial class Apdung1
    {
        private System.ComponentModel.IContainer components = null;

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
            this.groupBoxNhap = new System.Windows.Forms.GroupBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxChon = new System.Windows.Forms.GroupBox();
            this.radBSCNN = new System.Windows.Forms.RadioButton();
            this.radUSCLN = new System.Windows.Forms.RadioButton();
            this.groupBoxKetQua = new System.Windows.Forms.GroupBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBoxNhap.SuspendLayout();
            this.groupBoxChon.SuspendLayout();
            this.groupBoxKetQua.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxNhap
            // 
            this.groupBoxNhap.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBoxNhap.Controls.Add(this.txtB);
            this.groupBoxNhap.Controls.Add(this.txtA);
            this.groupBoxNhap.Controls.Add(this.label2);
            this.groupBoxNhap.Controls.Add(this.label1);
            this.groupBoxNhap.Location = new System.Drawing.Point(9, 10);
            this.groupBoxNhap.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxNhap.Name = "groupBoxNhap";
            this.groupBoxNhap.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxNhap.Size = new System.Drawing.Size(188, 81);
            this.groupBoxNhap.TabIndex = 0;
            this.groupBoxNhap.TabStop = false;
            this.groupBoxNhap.Text = "Nhập dữ liệu:";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(75, 49);
            this.txtB.Margin = new System.Windows.Forms.Padding(2);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(91, 20);
            this.txtB.TabIndex = 3;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(75, 20);
            this.txtA.Margin = new System.Windows.Forms.Padding(2);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(91, 20);
            this.txtA.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số nguyên b:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số nguyên a:";
            // 
            // groupBoxChon
            // 
            this.groupBoxChon.BackColor = System.Drawing.Color.Silver;
            this.groupBoxChon.Controls.Add(this.radBSCNN);
            this.groupBoxChon.Controls.Add(this.radUSCLN);
            this.groupBoxChon.Location = new System.Drawing.Point(210, 10);
            this.groupBoxChon.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxChon.Name = "groupBoxChon";
            this.groupBoxChon.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxChon.Size = new System.Drawing.Size(126, 81);
            this.groupBoxChon.TabIndex = 1;
            this.groupBoxChon.TabStop = false;
            this.groupBoxChon.Text = "Tùy chọn:";
            // 
            // radBSCNN
            // 
            this.radBSCNN.AutoSize = true;
            this.radBSCNN.Location = new System.Drawing.Point(11, 49);
            this.radBSCNN.Margin = new System.Windows.Forms.Padding(2);
            this.radBSCNN.Name = "radBSCNN";
            this.radBSCNN.Size = new System.Drawing.Size(62, 17);
            this.radBSCNN.TabIndex = 1;
            this.radBSCNN.TabStop = true;
            this.radBSCNN.Text = "BSCNN";
            this.radBSCNN.UseVisualStyleBackColor = true;
            // 
            // radUSCLN
            // 
            this.radUSCLN.AutoSize = true;
            this.radUSCLN.Location = new System.Drawing.Point(11, 24);
            this.radUSCLN.Margin = new System.Windows.Forms.Padding(2);
            this.radUSCLN.Name = "radUSCLN";
            this.radUSCLN.Size = new System.Drawing.Size(61, 17);
            this.radUSCLN.TabIndex = 0;
            this.radUSCLN.TabStop = true;
            this.radUSCLN.Text = "USCLN";
            this.radUSCLN.UseVisualStyleBackColor = true;
            // 
            // groupBoxKetQua
            // 
            this.groupBoxKetQua.Controls.Add(this.txtKetQua);
            this.groupBoxKetQua.Controls.Add(this.btnTim);
            this.groupBoxKetQua.Controls.Add(this.btnThoat);
            this.groupBoxKetQua.Location = new System.Drawing.Point(9, 106);
            this.groupBoxKetQua.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxKetQua.Name = "groupBoxKetQua";
            this.groupBoxKetQua.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxKetQua.Size = new System.Drawing.Size(347, 65);
            this.groupBoxKetQua.TabIndex = 2;
            this.groupBoxKetQua.TabStop = false;
            this.groupBoxKetQua.Text = "Kết quả:";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(14, 28);
            this.txtKetQua.Margin = new System.Windows.Forms.Padding(2);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(183, 20);
            this.txtKetQua.TabIndex = 2;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(201, 24);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(56, 24);
            this.btnTim.TabIndex = 1;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(271, 25);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(56, 24);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Apdung1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 181);
            this.Controls.Add(this.groupBoxKetQua);
            this.Controls.Add(this.groupBoxChon);
            this.Controls.Add(this.groupBoxNhap);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Apdung1";
            this.Text = "Tìm USCLN và BSCNN của số nguyên a và b";
            this.groupBoxNhap.ResumeLayout(false);
            this.groupBoxNhap.PerformLayout();
            this.groupBoxChon.ResumeLayout(false);
            this.groupBoxChon.PerformLayout();
            this.groupBoxKetQua.ResumeLayout(false);
            this.groupBoxKetQua.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxNhap;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxChon;
        private System.Windows.Forms.RadioButton radBSCNN;
        private System.Windows.Forms.RadioButton radUSCLN;
        private System.Windows.Forms.GroupBox groupBoxKetQua;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThoat;
    }
}
