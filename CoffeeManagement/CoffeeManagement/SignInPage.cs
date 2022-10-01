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
            else if (CheckUserName(txtUser.Text).username == txtUser.Text)
                MessageBox.Show("User already exists");
            else
                SignIn();
        }
        void SignIn()
        {
            SqlConnection sc = new SqlConnection(@"Data Source=LAPTOP-AAAAAAAA;Initial Catalog=CoffeeManagement;Persist Security Info=True;User ID=sa;Password=123456");
            SqlCommand sm = new SqlCommand("insert into UserInfo values('" + txtUser.Text + "','" + txtPass.Text + "')", sc);
            sc.Open();
            sm.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show("Sign In Successful");
            Hide();
        }
        User CheckUserName(string fName)
        {
            SqlConnection sc = new SqlConnection(@"Data Source=LAPTOP-AAAAAAAA;Initial Catalog=CoffeeManagement;Persist Security Info=True;User ID=sa;Password=123456");
            User matchingPerson = new User();
            using (sc)
            {
                string oString = "Select * from UserInfo where username=@fName";
                SqlCommand oCmd = new SqlCommand(oString, sc);
                oCmd.Parameters.AddWithValue("@Fname", fName);
                sc.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                    while (oReader.Read())
                    {
                        matchingPerson.username = oReader["username"].ToString();
                        matchingPerson.password = oReader["password"].ToString();
                    }
            }
            sc.Close();
            return matchingPerson;
        }
    }
   
}
