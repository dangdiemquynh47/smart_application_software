using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LibComponents
{
    public class UserTextBox: TextBox
    {
        ErrorProvider errorProvider;
        public UserTextBox()
        {
            this.errorProvider = new ErrorProvider();
            this.KeyPress += UserTextBox_KeyPress;
        }

        void UserTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex(@"[^a-zA-Z0-9\s]");
            String text = this.Text;
            Match match = regex.Match(text);

            if (match.Success)
            {
                errorProvider.SetError(this, "Noi dung nhap is not valid");
            }
            else errorProvider.Clear();

        }
    }
}
