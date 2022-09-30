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

namespace CoffeeManagementSystem
{
    public partial class SignInPage : Form
    {
        public SignInPage()
        {
            InitializeComponent();
        }

        SqlConnection sc = new SqlConnection(@"Data Source=LAPTOP-AAAAAAAA;Initial Catalog=sqlTest;Persist Security Info=True;User ID=sa;Password=123456");
        private void SignInPage_Load(object sender, EventArgs e)
        {

        }

        private void bttnSignIn_Click(object sender, EventArgs e)
        {
            SqlCommand sm = new SqlCommand("insert into UserInfo values('" + txtUsername.Text + "', '" + txtPassword.Text + "')", sc);

            sc.Open();

            sm.ExecuteNonQuery();

            sc.Close();

            MessageBox.Show("Sign In Completed Successfully");
        }
    }
}
