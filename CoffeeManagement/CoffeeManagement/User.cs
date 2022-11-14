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
            "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Cafebase.mdf;Integrated Security=True";
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
            Item.Execute(sm, sc);
        }
        #endregion
        #region STATIC FUNTIONS
        public static User CheckUserName(string name)
        {
            SqlConnection sc = new SqlConnection(scText);
            User matchingPerson = new User();
            using (sc)
            {
                string query = "Select * from UserInfo where username = @name ";
                SqlCommand sm = new SqlCommand(query, sc);
                sm.Parameters.AddWithValue("@name", name);
                sc.Open();
                using (SqlDataReader smReader = sm.ExecuteReader())
                    while (smReader.Read())
                    {
                        matchingPerson.username = smReader["username"].ToString();
                        matchingPerson.password = smReader["password"].ToString();
                    }
            }
            sc.Close();
            return matchingPerson;
        }
        #endregion
    }
}
