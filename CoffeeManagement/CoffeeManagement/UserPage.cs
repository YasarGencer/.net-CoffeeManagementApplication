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
    public partial class UserPage : Form
    {
        public UserPage()
        {
            InitializeComponent();
        }
        private void UserPage_Load(object sender, EventArgs e)
        {
            PullDataItem();
            PullDataTable();
            txtCount.Text = "1";
        }
        private void UserPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #region PULL DATA
        public void PullDataItem()
        {
            SqlConnection sc = new SqlConnection(AdminPage.sctext);
            string query = "select * from ItemTable order by itemId";
            sc.Open();
            SqlCommand sm = new SqlCommand(query, sc);
            SqlDataAdapter da = new SqlDataAdapter(sm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgwItemTable.DataSource = dt;
            sc.Close();
        }
        int tableCount = 0;
        public void PullDataTable()
        {
            SqlConnection sc = new SqlConnection(AdminPage.sctext);
            string query = "select * from TableCount where id = 1";
            SqlCommand sm = new SqlCommand(query, sc);
            sc.Open();
            using (SqlDataReader oReader = sm.ExecuteReader())
                while (oReader.Read())
                    tableCount = int.Parse(oReader["count"].ToString());
            for (int i = 1; i <= tableCount; i++)
            {
                var index = dgwTableTable.Rows.Add();
                dgwTableTable.Rows[index].Cells[0].Value = i;
            }
            sc.Close();
        }
        public void PullDataContent()
        {
            SqlConnection sc = new SqlConnection(AdminPage.sctext);
            string query = "select * from table" + tableId;
            sc.Open();
            SqlCommand sm = new SqlCommand(query, sc);
            SqlDataAdapter da = new SqlDataAdapter(sm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgwContentTable.DataSource = dt;
            sc.Close();
            PullPrice();
        }
        public void PullPrice()
        {
            int price = 0, price2 = 0;
            for (int i = 0; i < dgwContentTable.Rows.Count; i++)
                price += int.Parse(dgwContentTable.Rows[i].Cells[1].Value.ToString()) * int.Parse(dgwContentTable.Rows[i].Cells[2].Value.ToString());
            for (int i = 0; i < dgwPayementTable.RowCount; i++)
                price2 += int.Parse(dgwPayementTable.Rows[i].Cells[1].Value.ToString()) * int.Parse(dgwPayementTable.Rows[i].Cells[2].Value.ToString());
            txtBillAll.Text = (price + price2).ToString();
            txtBill.Text = price2.ToString();
            
        }
        #endregion
        #region SELECTION CHANGED
        int itemId = -1, tableId = -1;
        Content chosenContent = new Content();
        private void dgwItemTable_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwItemTable.SelectedRows.Count > 0)
            {
                SqlConnection sc = new SqlConnection(AdminPage.sctext);
                itemId = int.Parse(dgwItemTable.SelectedRows[0].Cells[0].Value.ToString());
                string query = "select * from ItemTable where itemId = @id";
                SqlCommand sm = new SqlCommand(query, sc);
                sm.Parameters.AddWithValue("@id", itemId);
                sc.Open();
                using (SqlDataReader oReader = sm.ExecuteReader())
                    while (oReader.Read())
                    {
                        chosenContent.name = oReader["itemName"].ToString();
                        chosenContent.price = int.Parse(oReader["itemPrice"].ToString());
                        txtName.Text = chosenContent.name;
                    }
                sc.Close();
            }
        }
        private void dgwTableTable_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwTableTable.SelectedRows.Count > 0)
                tableId = int.Parse(dgwTableTable.SelectedRows[0].Index.ToString()) + 1;
            if (itemId != -1 && tableId != -1)
            {
                SqlConnection sc = new SqlConnection(AdminPage.sctext);
                string tableName = "table" + tableId;
                string query1 = "IF object_id('" + tableName + "') is null CREATE TABLE " + tableName + " (itemName varchar(50),itemPrice float, itemCount int);";
                SqlCommand sm1 = new SqlCommand(query1, sc);
                sc.Open(); sm1.ExecuteNonQuery(); sc.Close();
            }
            PullDataContent();
        }
        private void dgwContentTable_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwContentTable.SelectedRows.Count > 0)
                txtName2.Text = dgwContentTable.SelectedRows[0].Cells[0].Value.ToString();
        }
        #endregion
        private void bttnRemove_Click(object sender, EventArgs e)
        {
            if(dgwContentTable.SelectedRows.Count > 0)
            {
                SqlConnection sc = new SqlConnection(AdminPage.sctext);
                string name = dgwContentTable.SelectedRows[0].Cells[0].Value.ToString();
                string query1 = "DELETE FROM table" + tableId + " WHERE itemName = @name";
                SqlCommand sm1 = new SqlCommand(query1, sc);
                sm1.Parameters.AddWithValue("@name", name);
                sc.Open();
                sm1.ExecuteNonQuery();
                sc.Close();
                PullDataContent();
            }
        }
        private void bttnTransfer_Click(object sender, EventArgs e)
        {
            string tableName = "table" + tableId;
            Content content = new Content();
            content.name = "";
            SqlConnection sc = new SqlConnection(AdminPage.sctext);
            string query = "SELECT * FROM " + tableName + " WHERE itemName = @name";
            string query2 = "UPDATE " + tableName + " SET itemCount -= 1 WHERE itemName = @name";
            SqlCommand sm = new SqlCommand(query, sc);
            SqlCommand sm2 = new SqlCommand(query2, sc);
            sm.Parameters.AddWithValue("@name", txtName2.Text);
            sm2.Parameters.AddWithValue("@name", txtName2.Text);
            sc.Open();
            using (SqlDataReader smReader = sm.ExecuteReader())
                while (smReader.Read())
                {
                    content.name = smReader["itemName"].ToString();
                    content.price = int.Parse(smReader["itemPrice"].ToString());
                }
            sm2.ExecuteNonQuery();
            sc.Close();
            for (int i = 0; i < dgwContentTable.RowCount; i++)
                if (int.Parse(dgwContentTable.Rows[i].Cells[2].Value.ToString()) <= 0)
                    bttnRemove_Click(sender, e);
            bool contentWriten = false;
            for (int i = 0; i < dgwPayementTable.RowCount; i++)
                if(content.name == dgwPayementTable.Rows[i].Cells[0].Value.ToString())
                {
                    dgwPayementTable.Rows[i].Cells[2].Value = (1 + int.Parse(dgwPayementTable.Rows[i].Cells[2].Value.ToString()));
                    contentWriten = true;
                    break;
                }
            if (!contentWriten && dgwContentTable.RowCount > 0)
                dgwPayementTable.Rows.Add(content.name,content.price,1);
            dgwContentTable.SelectedRows[0].Cells[2].Value = (int.Parse(dgwContentTable.SelectedRows[0].Cells[2].Value.ToString())-1);
            if (int.Parse(dgwContentTable.SelectedRows[0].Cells[2].Value.ToString()) <= 0)
                dgwContentTable.Rows.RemoveAt(dgwContentTable.SelectedRows[0].Index);
            PullPrice();
        }
        private void bttnRemove2_Click(object sender, EventArgs e)
        {
            string tableName = "table" + tableId;
            Content content = new Content();
            content.name = dgwPayementTable.SelectedRows[0].Cells[0].Value.ToString();
            content.price = int.Parse(dgwPayementTable.SelectedRows[0].Cells[1].Value.ToString());
            SqlConnection sc = new SqlConnection(AdminPage.sctext); ;
            string query2 = "UPDATE " + tableName + " SET itemCount += 1 WHERE itemName = @name";
            string query3 = "INSERT INTO " + tableName + " VALUES('" + (content.name) + "','" + content.price + "','1')";
            string query4 = "(SELECT * FROM " + tableName + " WHERE itemName = @name) ";
            string query = " IF EXISTS" + query4 + query2 + " ELSE " + query3;
            SqlCommand sm = new SqlCommand(query, sc);
            sm.Parameters.AddWithValue("@name", content.name);
            sc.Open(); sm.ExecuteNonQuery(); sc.Close();
            dgwPayementTable.SelectedRows[0].Cells[2].Value = (int.Parse(dgwPayementTable.SelectedRows[0].Cells[2].Value.ToString()) - 1);
            if (int.Parse(dgwPayementTable.SelectedRows[0].Cells[2].Value.ToString()) <= 0)
                dgwPayementTable.Rows.Remove(dgwPayementTable.SelectedRows[0]);
            PullDataContent();
        }
        private void bttnPayAll_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection(AdminPage.sctext);
            string query1 = "DELETE FROM table" + tableId;
            SqlCommand sm1 = new SqlCommand(query1, sc);
            sc.Open();
            sm1.ExecuteNonQuery();
            sc.Close();
            SaveInfo(int.Parse(txtBillAll.Text));
            PullDataContent();
        }
        private void bttnPay_Click(object sender, EventArgs e)
        {
            dgwPayementTable.Rows.Clear();
            SaveInfo(int.Parse(txtBill.Text));
            PullPrice();
        }
        private void bttnAdd_Click(object sender, EventArgs e)
        {
            if (tableId != -1 && itemId != -1)
            {
                string tableName = "table" + tableId;
                SqlConnection sc = new SqlConnection(AdminPage.sctext);
                string query2 = "UPDATE " + tableName + " SET itemCount += @count WHERE itemName = @name";
                string query3 = "INSERT INTO " + tableName + " VALUES('" + (chosenContent.name) + "','" + chosenContent.price + "','" + int.Parse(txtCount.Text) + "')";
                string query4 = "(SELECT * FROM " + tableName + " WHERE itemName = @name) ";
                string query = " IF EXISTS" + query4 + query2 + " ELSE " + query3;
                SqlCommand sm = new SqlCommand(query, sc);
                sm.Parameters.AddWithValue("@name", txtName.Text);
                sm.Parameters.AddWithValue("@count", txtCount.Text);
                sc.Open(); sm.ExecuteNonQuery(); sc.Close();
                PullDataContent();
            }
        }
        private void SaveInfo(float value)
        {
            SqlConnection sc = new SqlConnection(AdminPage.sctext);
            string date = DateTime.Today.ToString().Split(' ')[0];
            string query2 = "UPDATE SaleInfo SET TotalSale += @sale  WHERE Date = @date ";
            string query3 = "INSERT INTO SaleInfo VALUES('" + value + "','" + date + "' ) ";
            string query4 = "(SELECT * FROM SaleInfo WHERE Date = @date ) ";
            string query = " IF EXISTS" + query4 + query2 + " ELSE " + query3;
            SqlCommand sm = new SqlCommand(query, sc);
            sm.Parameters.AddWithValue("@date", date);
            sm.Parameters.AddWithValue("@sale", value);
            sc.Open(); sm.ExecuteNonQuery(); sc.Close();
            PullDataContent();
        }
    }
    public class Content
    {
        public String name;
        public float price;
        public int count;
    }
}
