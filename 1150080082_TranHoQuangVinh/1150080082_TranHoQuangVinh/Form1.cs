using System;
using System.Windows.Forms;

namespace _1150080082_TranHoQuangVinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Code khởi tạo cho Form (nếu cần)
        }

        // Sự kiện cho nút Cộng
        private void btnCong_Click(object sender, EventArgs e)
        {
            try
            {
                double soA = Convert.ToDouble(txtA.Text.Trim());
                double soB = Convert.ToDouble(txtB.Text.Trim());
                double ketQua = soA + soB;
                txtKetQua.Text = ketQua.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi Dữ Liệu");
            }
        }

        // Sự kiện cho nút Trừ
        private void btnTru_Click(object sender, EventArgs e)
        {
            try
            {
                double soA = Convert.ToDouble(txtA.Text.Trim());
                double soB = Convert.ToDouble(txtB.Text.Trim());
                double ketQua = soA - soB;
                txtKetQua.Text = ketQua.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi Dữ Liệu");
            }
        }

        // Sự kiện cho nút Nhân
        private void btnNhan_Click(object sender, EventArgs e)
        {
            try
            {
                double soA = Convert.ToDouble(txtA.Text.Trim());
                double soB = Convert.ToDouble(txtB.Text.Trim());
                double ketQua = soA * soB;
                txtKetQua.Text = ketQua.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi Dữ Liệu");
            }
        }

        // Sự kiện cho nút Chia
        private void btnChia_Click(object sender, EventArgs e)
        {
            try
            {
                double soA = Convert.ToDouble(txtA.Text.Trim());
                double soB = Convert.ToDouble(txtB.Text.Trim());

                if (soB == 0)
                {
                    MessageBox.Show("Không thể chia cho 0!", "Lỗi Phép Tính");
                    txtB.Focus();
                }
                else
                {
                    double ketQua = soA / soB;
                    txtKetQua.Text = ketQua.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi Dữ Liệu");
            }
        }

        // Sự kiện cho nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtKetQua.Clear();
            txtA.Focus();
        }

        // Sự kiện cho nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
