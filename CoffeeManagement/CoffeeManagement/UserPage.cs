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

        int  tableId = -1, tableCount = 0;

        #region BUTTON
        private void bttnAdd_Click(object sender, EventArgs e)
        {
            if (tableId != -1)
            {
                new Item(
                    tableId,
                    txtName.Text,
                    float.Parse(dgwItemTable.SelectedRows[0].Cells[2].Value.ToString()),
                    int.Parse(txtCount.Text)
                    ).AddToTable();
                PullDataContent();
            }
        }
        private void bttnRemove_Click(object sender, EventArgs e)
        {
            if (dgwContentTable.SelectedRows.Count > 0)
            {
                if(int.Parse(dgwContentTable.SelectedRows[0].Cells[2].Value.ToString()) <= 0)
                    new Item(
                           tableId,
                           txtName2.Text
                           ).RemoveFromTable();
                else
                    new Item(
                          tableId,
                          txtName2.Text,
                          1,
                          -1
                          ).AddToTable();
                PullDataContent();
            }
        }
        private void bttnRemove2_Click(object sender, EventArgs e)
        {
            if(dgwPayementTable.SelectedRows.Count > 0)
            {
                //CREATE AN ITEM
                Item item = new Item(
                        tableId,
                        dgwPayementTable.SelectedRows[0].Cells[0].Value.ToString(),
                        float.Parse(dgwPayementTable.SelectedRows[0].Cells[1].Value.ToString()),
                        1
                        );
                //ADD ITEM TO THE CONTENT TABLE
                item.AddToTable();
                //DECREASE OR DELETE ITEM TO PAYEMENT TABLE //NO DATABASE INTERACTION
                dgwPayementTable.SelectedRows[0].Cells[2].Value = (int.Parse(dgwPayementTable.SelectedRows[0].Cells[2].Value.ToString()) - 1);
                if (int.Parse(dgwPayementTable.SelectedRows[0].Cells[2].Value.ToString()) <= 0)
                    dgwPayementTable.Rows.Remove(dgwPayementTable.SelectedRows[0]);

                PullDataContent();
            }
        }
        private void bttnTransfer_Click(object sender, EventArgs e)
        {
            //CREATE AN ITEM
            Item item = new Item(
                    tableId,
                    dgwContentTable.SelectedRows[0].Cells[0].Value.ToString(),
                    float.Parse(dgwContentTable.SelectedRows[0].Cells[1].Value.ToString()),
                    -1
                    );
                //DECREASE ITEM FROM CONTENT TABLE
            item.AddToTable();
            //REMOVE ITEMS WHICH HAS BELOW 1 COUNT FROM CONTENT TABLE
            for (int i = 0; i < dgwContentTable.RowCount; i++)
                if (int.Parse(dgwContentTable.Rows[i].Cells[2].Value.ToString()) <= 0)
                    item.RemoveFromTable();
            //ADD ITEM TO PAYEMENT TABLE //NO DATABASE INTERACTION
                //CHEK IF ITEM IS ALREADY IN THE PAYEMENT TABLE, INCREASE THE COUNT IF SO
            bool contentWriten = false;
            for (int i = 0; i < dgwPayementTable.RowCount; i++)
                if (item.name == dgwPayementTable.Rows[i].Cells[0].Value.ToString())
                {
                    dgwPayementTable.Rows[i].Cells[2].Value = (1 + int.Parse(dgwPayementTable.Rows[i].Cells[2].Value.ToString()));
                    contentWriten = true;
                    break;
                }
                //ADD ITEM TO THE PAYEMENT TABLE IF IT DOESN'T EXISTS
            if (!contentWriten && dgwContentTable.RowCount > 0)
                dgwPayementTable.Rows.Add(item.name, item.price, 1);
                //FIX THE CONTENT TABLE WITHOUT PULLING FROM DB TO NOT MESS UP THE ORDER
            dgwContentTable.SelectedRows[0].Cells[2].Value = (int.Parse(dgwContentTable.SelectedRows[0].Cells[2].Value.ToString()) - 1);
            if (int.Parse(dgwContentTable.SelectedRows[0].Cells[2].Value.ToString()) <= 0)
                dgwContentTable.Rows.RemoveAt(dgwContentTable.SelectedRows[0].Index);

            PullPrice();
        }
        private void bttnPayAll_Click(object sender, EventArgs e)
        {
            string tableName = "table" + tableId;
            Item.DeleteAllTable(tableName);
            dgwPayementTable.Rows.Clear();
            SaveInfo(int.Parse(txtBillAll.Text));
            PullDataContent();
        }
        private void bttnPay_Click(object sender, EventArgs e)
        {
            dgwPayementTable.Rows.Clear();
            SaveInfo(int.Parse(txtBill.Text));
            PullPrice();
        }
        #endregion
        #region INTERACTABLES
        private void dgwItemTable_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwItemTable.SelectedRows.Count > 0)
                txtName.Text = dgwItemTable.SelectedRows[0].Cells[1].Value.ToString();
        }
        private void dgwTableTable_SelectionChanged(object sender, EventArgs e)
        {
            //SET TABLE ID
            if (dgwTableTable.SelectedRows.Count > 0)
                tableId = int.Parse(dgwTableTable.SelectedRows[0].Index.ToString()) + 1;
            //CREATE THE TABLE IF DOESN'T EXISTS
            if (tableId != -1)
            {
                SqlConnection sc = new SqlConnection(User.scText);
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
        #region PULL DATA
        public void PullDataItem()
        {
            SqlConnection sc = new SqlConnection(User.scText);
            string query = "select * from ItemTable order by itemId";
            sc.Open();
            SqlCommand sm = new SqlCommand(query, sc);
            SqlDataAdapter da = new SqlDataAdapter(sm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgwItemTable.DataSource = dt;
            sc.Close();
        }
        public void PullDataTable()
        {
            SqlConnection sc = new SqlConnection(User.scText);
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
            SqlConnection sc = new SqlConnection(User.scText);
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
        private void txtCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dgwContentTable_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void SaveInfo(float value)
        {
            SqlConnection sc = new SqlConnection(User.scText);
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
}
