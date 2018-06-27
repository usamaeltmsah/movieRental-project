using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class customerSignIn : Form
    {
        public customerSignIn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void custSignInButt_Click(object sender, EventArgs e)
        {
            //this.customerTable.Fill(this.)
            string x = customerEmail.Text;
            customerPassword.PasswordChar = '\u25CF';
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("The Caps Lock key is ON.");
            }
            // string y = customerPassword.Text;
            // MessageBox.Show("Your Email is : " + x);
            // MessageBox.Show("Your password is : " + y);
        }
    }
}
