using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001216095_DangThiDiemQuynh_Buoi2
{
    public partial class Form2 : Form
    {
        public Form1 mainForm;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1; // Lưu tham chiếu của Form1 vào biến mainForm
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = upperTextBox1.Text.Trim();
            if (!string.IsNullOrEmpty(userName))
            {
                mainForm.SetStatusBarText("Xin chào người dùng: " + userName);
                this.Close(); // Đóng FormLogin sau khi đăng nhập thành công
            }
            else
            {
                MessageBox.Show("Please enter a username.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
