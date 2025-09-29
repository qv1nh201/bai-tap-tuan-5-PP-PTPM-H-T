using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _1150080082_TranHoQuangVinh
{
    public partial class Apdung2 : Form
    {
        private string currentPwd = "";
        private Dictionary<string, string> pwdToGroup;

        public Apdung2()
        {
            InitializeComponent();
            InitializePasswordMap();
            CreateKeypadButtons(); // tạo bàn phím số khi khởi tạo form
        }

        private void InitializePasswordMap()
        {
            pwdToGroup = new Dictionary<string, string>()
            {
                { "1496", "Phát triển công nghệ" },
                { "2673", "Phát triển công nghệ" },
                { "7462", "Nghiên cứu viên" },
                { "8884", "Thiết kế mô hình" },
                { "3842", "Thiết kế mô hình" },
                { "3383", "Thiết kế mô hình" }
            };
        }

        private void CreateKeypadButtons()
        {
            int btnW = 60, btnH = 50, margin = 5;
            string[,] layout = new string[4, 3]
            {
                { "1", "2", "3" },
                { "4", "5", "6" },
                { "7", "8", "9" },
                { "Clear", "0", "Enter" }
            };

            for (int r = 0; r < 4; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    string text = layout[r, c];
                    Button b = new Button
                    {
                        Text = text,
                        Width = btnW,
                        Height = btnH,
                        Left = 20 + c * (btnW + margin),
                        Top = 60 + r * (btnH + margin)
                    };

                    if (text == "Clear")
                        b.Click += BtnClear_Click;
                    else if (text == "Enter")
                        b.Click += BtnEnter_Click;
                    else
                        b.Click += DigitButton_Click;

                    this.Controls.Add(b);
                }
            }
        }

        private void DigitButton_Click(object sender, EventArgs e)
        {
            if (sender is Button b)
            {
                currentPwd += b.Text;
                txtDisplay.Text = new string('*', currentPwd.Length);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            currentPwd = "";
            txtDisplay.Text = "";
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            if (pwdToGroup.TryGetValue(currentPwd, out string groupName))
            {
                lsbLog.Items.Insert(0, $"{timestamp} — {groupName} — CHẤP NHẬN");
            }
            else
            {
                lsbLog.Items.Insert(0, $"{timestamp} — {currentPwd} — TỪ CHỐI");
            }

            currentPwd = "";
            txtDisplay.Text = "";
        }
    }
}
