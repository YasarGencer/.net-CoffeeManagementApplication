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
            User newUser = UserTest(txtUser.Text);
            if(newUser.password == txtPass.Text)
            {
                MessageBox.Show("Log in succsessfull");
                this.Hide();
                if (txtUser.Text == "admin")
                    new AdminPage().Show();
                else
                    new UserPage().Show();
            }
            else if(newUser.password != txtPass.Text)
            {
                MessageBox.Show("Incorrect password or username");
            }

        }
        public User UserTest(string fName)
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

    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}
