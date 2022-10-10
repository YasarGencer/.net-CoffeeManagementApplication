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
    public partial class LogIn : Form
    {
        public LogIn() => InitializeComponent();
        //SETS PASSWORD TEXTS AS SHOWN OR HIDEN
        private void cbPassShown_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbPassShown.Checked)   txtPass.PasswordChar = '*';
            else    txtPass.PasswordChar = '\0';
        }
        //SIGN IN BUTTON
        private void bttnSign_Click(object sender, EventArgs e) => new SignInPage().Show();
        //LOG IN BUTTON
        private void bttnLog_Click(object sender, EventArgs e)
        {
            User writenUser = new User(txtUser.Text,txtPass.Text);
            User controlUser = User.CheckUserName(writenUser.username);
            if(controlUser.password == writenUser.password)
            {
                MessageBox.Show("Log in succsessfull");
                if (writenUser.username == "admin")     new AdminPage().Show();
                else    new UserPage().Show();
                this.Close();
            }
            MessageBox.Show("Incorrect password or username");
        }
    }
}
