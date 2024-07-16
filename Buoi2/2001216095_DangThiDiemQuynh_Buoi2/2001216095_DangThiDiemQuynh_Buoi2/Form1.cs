using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controls_DataGridView;

namespace _2001216095_DangThiDiemQuynh_Buoi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Khởi tạo DataGridView và thiết lập thuộc tính
            customDataGridView2 = new CustomDataGridView();
            customDataGridView2.Dock = DockStyle.Fill;

            // Thêm DataGridView vào Form
            this.Controls.Add(customDataGridView2);

            // Thiết lập cột cho DataGridView (nếu cần)
            customDataGridView2.Columns.Add("Column1", "Column 1");
            customDataGridView2.Columns.Add("Column2", "Column 2");
            customDataGridView2.Columns.Add("Column3", "Column 3");

            // Thêm một số hàng mẫu vào DataGridView
            customDataGridView2.Rows.Add("Value1", "Value2", "Value3");
            customDataGridView2.Rows.Add("Value4", "Value5", "Value6");

            // Thêm một hàng mới bằng cách sử dụng mảng giá trị
            string[] newRow = { "New Value 1", "New Value 2", "New Value 3" };
            customDataGridView2.Rows.Add(newRow);
        }

        private void statusBar1_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        // Phương thức public để thiết lập nội dung StatusBar
        public void SetStatusBarText(string text)
        {
            statusBar1.Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Khởi tạo FormLogin và hiển thị nó
            Form2 loginForm = new Form2(this); // Truyền tham chiếu của Form1 vào FormLogin
            loginForm.Show();
        }

        private void dataGridView2Colors1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
