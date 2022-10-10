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
        Item item;
        public AdminPage() => InitializeComponent();
        private void AdminPage_Load(object sender, EventArgs e)
        {
            PullData(); txtTableCount.Text = Item.GetTableCount();
        }
        private void AdminPage_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
        #region BUTTONS
        private void bttnUserPage_Click(object sender, EventArgs e)
        {
            new UserPage().Show();
        }
        private void bttnAdd_Click(object sender, EventArgs e)
        {
            Item newItem = new Item(dgwItemTable.Rows.Count, txtName.Text, float.Parse(txtPrice.Text));
            if (Item.CheckItemName(txtName.Text).name == txtName.Text)
                MessageBox.Show("Item already exists");
            else
            {
                newItem.AddItemToDB();
                MessageBox.Show("Item added succsessfully");
                PullData();
            }
        }
        private void bttnTableCount_Click(object sender, EventArgs e)
        {
            Item.SaveTableCount(int.Parse(txtTableCount.Text));
            MessageBox.Show("Table count changed succsessfully");
        }
        private void bttnSaveEdit_Click(object sender, EventArgs e)
        {
            item.SaveItemChanges();
            PullData();
        }
        private void bttnDeleteItem_Click(object sender, EventArgs e)
        {
            item.DeleteItem(dgwItemTable.Rows.Count - 1);
            PullData();
        }
        #endregion
        #region INTERACTABLES
        private void dgwItemTable_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwItemTable.SelectedRows.Count > 0)
            {
                item.id = int.Parse(dgwItemTable.SelectedRows[0].Cells[0].Value.ToString());
                item.name = dgwItemTable.SelectedRows[0].Cells[1].Value.ToString();
                item.price = float.Parse(dgwItemTable.SelectedRows[0].Cells[2].Value.ToString());
                txtEditName.Text = item.name.ToString();
                txtEditPrice.Text = item.price.ToString();
            }
        }
        #endregion

        public void PullData()
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
    }
}
