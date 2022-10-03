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

        #endregion

        int itemId, tableId;
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
                    }
                sc.Close();
            }
        }
        private void dgwTableTable_SelectionChanged(object sender, EventArgs e)
        {
        }
        private void bttnAdd_Click(object sender, EventArgs e)
        {
            if (itemId != -1 && tableId != -1)
            {
                SqlConnection sc = new SqlConnection(AdminPage.sctext);

                //check for database for table
                string query1 = "CREATE TABLE Persons(itemName varchar(50),itemPrice float, itemCount int);";
            }
        }
    }
}
