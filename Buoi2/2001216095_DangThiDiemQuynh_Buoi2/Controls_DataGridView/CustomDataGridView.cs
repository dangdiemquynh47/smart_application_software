using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Controls_DataGridView
{
    public class CustomDataGridView : DataGridView
    {
        public CustomDataGridView()
        {
            this.AllowUserToAddRows = false;
            this.RowHeadersVisible = false;
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.AlternatingRowsDefaultCellStyle.BackColor = Color.Black;
        }

        protected override void OnRowPrePaint(DataGridViewRowPrePaintEventArgs e)
        {
            // Gọi cơ chế vẽ dòng mặc định của DataGridView
            base.OnRowPrePaint(e);

            // Chỉnh màu nền cho các dòng chẵn và lẻ
            if (e.RowIndex % 2 == 0)
            {
                this.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
            else
            {
                this.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
            }
        }
    }
}
