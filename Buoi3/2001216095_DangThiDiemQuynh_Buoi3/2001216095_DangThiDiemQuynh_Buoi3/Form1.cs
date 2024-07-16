using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;

namespace _2001216095_DangThiDiemQuynh_Buoi3
{
    public partial class Form1 : Form
    {
        SqlClass sql = new SqlClass();
        string connectionString = "Server=A109PC38;Database=QL_NV_Buoi3;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            this.button1.Click += button1_Click;
        }

        void button1_Click(object sender, EventArgs e)
        {
            //XuLy DT = new XuLy();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Example query to check credentials (use parameters to prevent SQL injection)
            string query = "SELECT * FROM NGUOIDUNG WHERE TEN = @username AND MATKHAU = @password";

            DataTable result = sql.ExecuteQuery(query);
            if (result.Rows.Count > 0)
            {
                // Successful login
                MessageBox.Show("Login successful!");
            }
            else
            {
                // Failed login
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
    
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            try
            {
                sql.CreateConnection(connectionString);

                if (sql.TestConnection())
                {
                    MessageBox.Show("Connected to database successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to connect to database.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
