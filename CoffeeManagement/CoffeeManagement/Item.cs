using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CoffeeManagement
{
    class Item
    {
        #region VARIABLES
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int count { get; set; }
        #endregion
        #region CONSTRUCTORS
        public Item()
        {
            this.id = -1;
            this.name = "";
            this.price = -1;
            this.count = -1;
        }
        public Item(int id)
        {
            this.id = id;
            this.name = "";
            this.price = -1;
            this.count = -1;
        }
        public Item(int id, string name)
        {
            this.id = id;
            this.name = name;
            this.price = -1;
            this.count = -1;
        }
        public Item(int id, string name, double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.count = -1;
        }
        public Item(int id, string name, float price, int count)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.count = count;
        }
        #endregion
        #region CLASS METHODS
        //ADMIN PAGE
        public void AddItemToDB()
        {
            SqlConnection sc = new SqlConnection(User.scText);
            string query = "insert into ItemTable values('" + this.id + "','" + this.name + "','" + this.price + "')";
            Execute(new SqlCommand(query,sc), sc);
        }
        public void SaveItemChanges()
        {
            SqlConnection sc = new SqlConnection(User.scText);
            string query = "update ItemTable set itemName = @name , itemPrice = @price where itemId = @id";
            SqlCommand sm = new SqlCommand(query, sc);
            sm.Parameters.AddWithValue("@id", this.id);
            sm.Parameters.AddWithValue("@name", this.name);
            sm.Parameters.AddWithValue("@price", this.price);
            Execute(sm, sc);
        }
        public void DeleteItem(int itemCountInTable)
        {
            SqlConnection sc = new SqlConnection(User.scText);
            string query1 = "delete from ItemTable where itemId = " + id + "";
            string query2 = "update ItemTable set itemId = " + id + " where itemId = @id1";
            SqlCommand sm = new SqlCommand(query2, sc);
            Execute(new SqlCommand(query1, sc), sc);
            //Corrects the item ids.
            sc.Open();
            for (int i = id; i < itemCountInTable; i++)
            {
                sm.Parameters.AddWithValue("@id", i);
                sm.Parameters.AddWithValue("@id1", i + 1);
                sm.ExecuteNonQuery();
                sm.Parameters.RemoveAt("@id");
                sm.Parameters.RemoveAt("@id1");
            }
            sc.Close();
        }
        //USER PAGE
        public void AddToTable()
        {
            string tableName = "table" + this.id;
            SqlConnection sc = new SqlConnection(User.scText);
            string query2 = "UPDATE " + tableName + " SET itemCount += @count WHERE itemName = @name";
            string query3 = "INSERT INTO " + tableName + " VALUES('" + (this.name) + "','" + this.price + "','" + this.count + "')";
            string query4 = "(SELECT * FROM " + tableName + " WHERE itemName = @name) ";
            string query = " IF EXISTS" + query4 + query2 + " ELSE " + query3;
            SqlCommand sm = new SqlCommand(query, sc);
            sm.Parameters.AddWithValue("@name", this.name);
            sm.Parameters.AddWithValue("@count", this.count);
            Execute(sm, sc);
        }
        public void RemoveFromTable()
        {
            SqlConnection sc = new SqlConnection(User.scText);
            string query = "DELETE FROM table" + this.id + " WHERE itemName = @name";
            SqlCommand sm = new SqlCommand(query, sc);
            sm.Parameters.AddWithValue("@name", this.name);
            Execute(sm, sc);
        }
        #endregion
        #region STATIC FUNCTIONS
        public static Item CheckItemName(string name)
        {
            SqlConnection sc = new SqlConnection(User.scText);
            Item matchingItem = new Item();
            using (sc)
            {
                string query = "Select * from ItemTable where itemName = @name";
                SqlCommand sm = new SqlCommand(query, sc);
                sm.Parameters.AddWithValue("@name", name);
                sc.Open();
                using (SqlDataReader smReader = sm.ExecuteReader())
                    while (smReader.Read())
                    {
                        matchingItem.id = int.Parse(smReader["itemId"].ToString());
                        matchingItem.name = smReader["itemName"].ToString();
                        matchingItem.price = float.Parse(smReader["itemPrice"].ToString());
                    }
                sc.Close();
            }
            return matchingItem;
        }
        public static void SaveTableCount(int count)
        {
            SqlConnection sc = new SqlConnection(User.scText);
            string query = "UPDATE TableCount SET count = @count Where id = 1 ";
            SqlCommand sm = new SqlCommand(query, sc);
            sm.Parameters.AddWithValue("@count", count);
            Execute(sm, sc);
        }
        public static string GetTableCount()
        {
            string tableCount = "";
            SqlConnection sc = new SqlConnection(User.scText);
            using (sc)
            {
                string query = "Select * from TableCount where id=1";
                SqlCommand sm = new SqlCommand(query, sc);
                sc.Open();
                using (SqlDataReader smReader = sm.ExecuteReader())
                    while (smReader.Read())
                        tableCount = smReader["count"].ToString();
                sc.Close();
            }
            return tableCount;
        }
        public static void DeleteAllTable(string tableName)
        {
            SqlConnection sc = new SqlConnection(User.scText);
            string query = "DELETE FROM " + tableName;
            SqlCommand sm = new SqlCommand(query, sc);
            Execute(sm, sc);
        }
        public static void Execute(SqlCommand sm, SqlConnection sc)
        {
            sc.Open();
            sm.ExecuteNonQuery();
            sc.Close();
        }
        #endregion
    }
}
