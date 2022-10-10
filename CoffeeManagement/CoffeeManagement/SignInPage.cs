using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CoffeeManagement
{
    public partial class SignInPage : Form
    {
        public SignInPage() => InitializeComponent();  
        #region BUTTONS
        //SIGN IN BUTTON
        private void bttnSign_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == "" || txtPass2.Text == "" || txtUser.Text == "")
                MessageBox.Show("All areas must be filled");
            else if (txtPass.Text != txtPass2.Text)
                MessageBox.Show("Passwords doesn't match");
            else if (User.CheckUserName(txtUser.Text).username == txtUser.Text)
                MessageBox.Show("User already exists");
            else
            {
                new User(txtUser.Text, txtPass.Text).SignIn();
                MessageBox.Show("Sign In Successful");
                this.Close();
            }
        }
        #endregion
        #region INTERACTABLES
        //SETS PASSWORD TEXTS AS SHOWN OR HIDEN
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
        #endregion
    }
}
