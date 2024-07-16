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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string[] texts = {"textBox1", "textBox2", "textBox3", "textBox4"};
            int topPosition = 30;
            foreach (string text in texts)
            {
                TextBox tb = new TextBox();
                tb.Left = 50;
                tb.Top = topPosition;
                topPosition = topPosition + 30;
                tb.Text = text;
                Controls.Add(tb);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
