using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CoffeeManagement
{
    public class User
    {
        #region VARIABLES
        public string username { get; set; }
        public string password { get; set; }
        public static string scText = 
            "Data Source=LAPTOP-AAAAAAAA;Initial Catalog=CoffeeManagement;Persist Security Info=True;User ID=sa;Password=123456";
        #endregion
        #region CONSTRUCTORS
        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public User()
        {
            this.username = "";
            this.password = "";
        }
        #endregion
        #region CLASS METHODS
        public void SignIn()
        {
            SqlConnection sc = new SqlConnection(scText);
            SqlCommand sm = new SqlCommand
                ("insert into UserInfo values('" + this.username + "','" + 
                this.password + "')", sc);
            sc.Open();
            sm.ExecuteNonQuery();
            sc.Close();
        }
        #endregion
        #region STATIC FUNTIONS
        public static User CheckUserName(string fName)
        {
            SqlConnection sc = new SqlConnection(scText);
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
        #endregion
    }
}
