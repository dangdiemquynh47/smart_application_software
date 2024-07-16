using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibComponents
{
    public class UpperTextBox: TextBox
    {
        public UpperTextBox()
        {
            this.KeyPress += UpperTextBox_KeyPress;
        }

        void UpperTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsUpper(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
                  
    }
}
