using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LibComponents
{
    public class PassTextBox: TextBox
    {
          ErrorProvider errorProvider;
          private const int MaxLength = 6;
          public PassTextBox()
        {
            this.errorProvider = new ErrorProvider();
            this.KeyPress += PassTextBox_KeyPress;
        }

        void PassTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex(@"[^a-zA-Z0-9\s]");
            String text = this.Text;
            Match match = regex.Match(text);

            if (match.Success && this.Text.Length >= MaxLength && !char.IsControl(e.KeyChar))
            {
                errorProvider.Clear();
            }
            else
                errorProvider.SetError(this, "Noi dung nhap is not valid");


        }
    }
}
