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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] foods = { "sau ring", "mit", "bo", "thit heo" };
            int topPosion = 30;
             foreach(string food in foods) {
                 CheckBox cb = new CheckBox();
                 cb.Left = 50;
                 cb.Top = topPosion;
                 topPosion = topPosion + 30;
                 cb.Text = food;
                 Controls.Add(cb);
             }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
