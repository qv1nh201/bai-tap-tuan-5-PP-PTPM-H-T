using System;
using System.Windows.Forms;

namespace USCLN_BSCNN
{
    public partial class Apdung1 : Form
    {
        public Apdung1()
        {
            InitializeComponent();
        }
        // Hàm tính USCLN (Euclid)
        private int USCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return Math.Abs(a);
        }

        // Hàm tính BSCNN
        private int BSCNN(int a, int b)
        {
            return Math.Abs(a * b) / USCLN(a, b);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtA.Text.Trim());
                int b = int.Parse(txtB.Text.Trim());

                if (radUSCLN.Checked)
                {
                    txtKetQua.Text = USCLN(a, b).ToString();
                }
                else if (radBSCNN.Checked)
                {
                    txtKetQua.Text = BSCNN(a, b).ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn USCLN hoặc BSCNN!");
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ, vui lòng nhập số nguyên!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
