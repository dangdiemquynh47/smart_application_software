using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace LibComponents
{
    public class MailTextBox: TextBox
    {
        ErrorProvider errorProvider;
        public MailTextBox()
        {
            //this.Validated += MailTextBox_Validated;
            this.errorProvider = new ErrorProvider();
            this.KeyPress += MailTextBox_KeyPress;
        }

        // Cach 3
        void MailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex(@"^\w+@[a-zA-Z_]+\.[a-zA-Z]{2,3}$");
            String email = this.Text;
            Match match = regex.Match(email);

            if (match.Success)
            {
                errorProvider.Clear();
            }
            else errorProvider.SetError(this, "email is not valid");
        }

        //void MailTextBox_Validated(object sender, EventArgs e)
        //{
            //Cach 1
            // string email = this.Text.Trim();
            // if (!IsValidEmail(email))
            //{
              //  ErrorProvider.setError
            //}

            // Cach 2
            //try
            //{
            //    MailAddress mail = new MailAddress(this.Text);
            //}
            //catch (FormatException)
            //{
            //    DialogResult result = MessageBox.Show("Email khong hop le", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        //}
        
        // Cach 1

        //private bool IsValidEmail(string email)
        //{
        //    if(email.Contains("@") && email.EndsWith(".com")) {
        //        return true;
        //    }
        //    return false;
        //}
    }
}
