using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001216095_DangThiDiemQuynh_Buoi1
{
    public partial class Form3 : Form
    {
      
        public Form3()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void Them(int sl)
        {
            int top = 50;
            int left = 50;
            progressBar1.Maximum = sl * sl;
            for (int i = 0; i < sl; i++)
            {
                for (int j = 0; j < sl; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(30, 30);
                    btn.Top = top;
                    btn.Left = left;
                    left = left + 50;
                    btn.Click += btn_Click;
                    this.progressBar1.Value = this.progressBar1.Value + 1;
                    this.groupBox1.Controls.Add(btn);
                }
                top = top + 50;
                left = 50;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        bool flag = true;
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (flag == true)
            {
                btn.Text = "O";
                flag = false;
                return;
            }
                btn.Text = "X";
                flag = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pN = 0;
            if ((int.Parse(textBox1.Text)) * (int.Parse(textBox1.Text)) > 50)
            {
                return;
            }
            pN = int.Parse(textBox1.Text);
            Them(pN);
        }
    }
}
