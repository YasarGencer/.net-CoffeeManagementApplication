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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbPassShown_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbPassShown.Checked)
                txtPass.PasswordChar = '*';
            else
                txtPass.PasswordChar = '\0';
        }

        private void bttnSign_Click(object sender, EventArgs e)
        {
            new SignInPage().Show();
        }

        private void bttnLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminPage().Show();
        }
    }
}
