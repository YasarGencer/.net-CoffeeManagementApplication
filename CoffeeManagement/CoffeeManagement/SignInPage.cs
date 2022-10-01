using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class SignInPage : Form
    {
        public SignInPage()
        {
            InitializeComponent();
        }

        private void cbPassShown_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbPassShown.Checked)
            {
                txtPass.PasswordChar = '*';
                txtPass2.PasswordChar = '*';
            }
            else
            {
                txtPass.PasswordChar = '\0';
                txtPass2.PasswordChar = '\0';
            }
        }
        private void bttnSign_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == "" || txtPass2.Text == "" || txtUser.Text == "")
                MessageBox.Show("All areas must be filled");
            else if (txtPass.Text != txtPass2.Text)
                MessageBox.Show("Passwords doesn't match");
            else
                SignIn();
        }
        void SignIn()
        {
            MessageBox.Show("Sign In Successful");
            Hide();
        }
    }
}
