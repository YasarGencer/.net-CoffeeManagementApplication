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
        }
        private void UserPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #region Pull Data
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
        }
        #endregion
        int itemId = -1, tableId = -1;
        int itemPriceTemp = 0;
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
                        txtName.Text = oReader["itemName"].ToString();
                        itemPriceTemp = int.Parse(oReader["itemPrice"].ToString());
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
                sc.Open();
                sm1.ExecuteNonQuery(); 
                sc.Close();
                PullDataContent();
            }

        }
        private void bttnAdd_Click(object sender, EventArgs e)
        {
            if (tableId != -1 && itemId != -1)
            {
                string tableName = "table" + tableId;
                int currentCount = 0;
                SqlConnection sc = new SqlConnection(AdminPage.sctext);
                using (sc)
                {
                    string query = "Select * from " + tableName + " where itemName=" + txtName.Text;
                    SqlCommand sm = new SqlCommand(query, sc);
                    sc.Open();
                    using (SqlDataReader smReader = sm.ExecuteReader())
                        while (smReader.Read())
                        {
                            currentCount = int.Parse(smReader["itemCount"].ToString());
                        }
                    string query2;
                    if (currentCount == 0)
                        query2 = "insert into " + tableName + " values('" + (txtName.Text) + "','" + itemPriceTemp + "','" + int.Parse(txtCount.Text) + "')";
                    else
                        query2 ="update " + tableName + " set itemCount = " + (currentCount + int.Parse(txtCount.Text)) + " where itemName=" + txtName.Text;

                    sm.ExecuteNonQuery();
                    PullDataContent();
                }
                sc.Close();
            }
        }
    }
}
