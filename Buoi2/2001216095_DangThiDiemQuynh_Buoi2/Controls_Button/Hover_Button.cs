using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Controls_Button
{
    public class Hover_Button: Button
    {
        public Hover_Button()
        {
            this.MouseEnter += Hover_Button_MouseEnter;
            this.MouseLeave += Hover_Button_MouseLeave;
        }

        void Hover_Button_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
        }

        void Hover_Button_MouseEnter(object sender, EventArgs e)
        {
        
            this.BackColor = Color.Red;

        }
    }
}
