﻿using System;
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
    public partial class AdminPage : Form
    {
        public static string sctext = "Data Source=LAPTOP-AAAAAAAA;Initial Catalog=CoffeeManagement;Persist Security Info=True;User ID=sa;Password=123456";
        public AdminPage()
        {
            InitializeComponent();
        }
        private void AdminPage_Load(object sender, EventArgs e)
        {
            PullData(); GetTableCount();
        }
        private void AdminPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void bttnUserPage_Click(object sender, EventArgs e)
        {
            new UserPage().Show();
        }
        private void bttnAdd_Click(object sender, EventArgs e)
        {
            if (CheckItem(txtName.Text).name == txtName.Text)
                MessageBox.Show("Item already exists");
            else 
                SaveItem();
        }
        private void bttnTableCount_Click(object sender, EventArgs e)
        {
            SaveTableCount(int.Parse(txtTableCount.Text));
        }
        void SaveItem()
        {
            SqlConnection sc = new SqlConnection(@sctext);
            SqlCommand sm = new SqlCommand("insert into ItemTable values('" + (dgwItemTable.Rows.Count) + "','" + txtName.Text + "','" + txtPrice.Text + "')", sc);
            sc.Open();
            sm.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show("Item added succsessfully");
            PullData();
        }
        public void PullData()
        {
            SqlConnection sc = new SqlConnection(@sctext);
            string query = "select * from ItemTable order by itemId";
            sc.Open();
            SqlCommand sm = new SqlCommand(query, sc);
            SqlDataAdapter da = new SqlDataAdapter(sm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgwItemTable.DataSource = dt;
            sc.Close();
        }
        public Item CheckItem(string fName)
        {
            SqlConnection sc = new SqlConnection(@sctext);
            Item matchingItem = new Item();
            using (sc)
            {
                string oString = "Select * from ItemTable where itemName=@fName";
                SqlCommand sm = new SqlCommand(oString, sc);
                sm.Parameters.AddWithValue("@Fname", fName);
                sc.Open();
                using (SqlDataReader smReader = sm.ExecuteReader())
                    while (smReader.Read())
                    {
                        matchingItem.name = smReader["itemName"].ToString();
                        matchingItem.price = smReader["itemPrice"].ToString();
                    }
            }
            sc.Close();
            return matchingItem;
        }
        void SaveTableCount(int fCount)
        {
            SqlConnection sc = new SqlConnection(@sctext);
            SqlCommand sm = new SqlCommand("UPDATE TableCount SET count = @fCount Where id = 1 ",sc);
            sm.Parameters.AddWithValue("@fCount", fCount);
            sc.Open();
            sm.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show("Table count changed succsessfully");
        }
        void GetTableCount()
        {
            SqlConnection sc = new SqlConnection(@sctext);
            using (sc)
            {
                string oString = "Select * from TableCount where id=1";
                SqlCommand sm = new SqlCommand(oString, sc);
                sc.Open();
                using (SqlDataReader oReader = sm.ExecuteReader())
                    while (oReader.Read())
                        txtTableCount.Text = oReader["count"].ToString();
            }
            sc.Close();
        }

        public int id  = -1;
        private void dgwItemTable_SelectionChanged(object sender, EventArgs e)
        {
            if(dgwItemTable.SelectedRows.Count > 0)
            {
                SqlConnection sc = new SqlConnection(@sctext);
                id = int.Parse(dgwItemTable.SelectedRows[0].Cells[0].Value.ToString());
                string query = "select * from ItemTable where itemId = @id";
                SqlCommand sm = new SqlCommand(query, sc);
                sm.Parameters.AddWithValue("@id", id);
                sc.Open();
                using (SqlDataReader oReader = sm.ExecuteReader())
                    while (oReader.Read())
                    {
                        txtEditName.Text = oReader["itemName"].ToString();
                        txtEditPrice.Text = oReader["itemPrice"].ToString();
                    }
                sc.Close();
            }
        }

        private void bttnSaveEdit_Click(object sender, EventArgs e)
        {
            if (id != -1)
            {
                SqlConnection sc = new SqlConnection(@sctext);
                id = int.Parse(dgwItemTable.SelectedRows[0].Cells[0].Value.ToString());
                string query = "update ItemTable set itemPrice = @price , itemName = @name where itemId = @id";
                SqlCommand sm = new SqlCommand(query, sc);
                sm.Parameters.AddWithValue("@id", id);
                sm.Parameters.AddWithValue("@name", txtEditName.Text);
                sm.Parameters.AddWithValue("@price", (float)int.Parse(txtEditPrice.Text));
                sc.Open();
                sm.ExecuteNonQuery();
                sc.Close();
                PullData();
            }
        }

        private void bttnDeleteItem_Click(object sender, EventArgs e)
        {
            if (id != -1)
            {
                SqlConnection sc = new SqlConnection(@sctext);
                id = int.Parse(dgwItemTable.SelectedRows[0].Cells[0].Value.ToString());
                string query1 = "delete from ItemTable where itemId = @id";
                string query2 = "update ItemTable set itemId = @id where itemId = @id1";
                SqlCommand sm1 = new SqlCommand(query1, sc);
                SqlCommand sm2 = new SqlCommand(query2, sc);
                sm1.Parameters.AddWithValue("@id", id);
                sc.Open();
                sm1.ExecuteNonQuery();
                for (int i = id; i < dgwItemTable.Rows.Count - 1; i++)
                {
                    Console.WriteLine("Convert   " + (i + 1) + "   to     " + i );
                    sm2.Parameters.AddWithValue("@id", i);
                    sm2.Parameters.AddWithValue("@id1", i + 1);
                    sm2.ExecuteNonQuery();
                    sm2.Parameters.RemoveAt("@id");
                    sm2.Parameters.RemoveAt("@id1");
                    
                }
                sc.Close();
                PullData();
            }
        }

        private void dgwItemTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
