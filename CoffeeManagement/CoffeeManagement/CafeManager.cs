using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;

namespace CoffeeManagement {
    public partial class CafeManagerForm : Form {

        Item item = new Item();
        bool isAdmin = false;
        public CafeManagerForm() {
            InitializeComponent();
        }
        public void SetAdmin() => isAdmin = true;
        public void SetHeader(string value) => lblHeader.Text = value;
        private void FormClose(object sender, FormClosedEventArgs e) => Application.Exit();
        private void FromLoad(object sender, EventArgs e) {
            AdmPullData(); admTxtTableCount.Text = Item.GetTableCount();
            PullDataItem(); PullDataTable();

            ADMINPANEL.Location = new Point(266, 74);
            USERPANEL.Location = new Point(266, 74);
            if (isAdmin) {
                SetHeader("ADMIN PAGE");
                ADMINPANEL.Dock = DockStyle.Fill;
                USERPANEL.Dock = DockStyle.None;
                USERPANEL.Width = 0;
            } else {
                SetHeader("USER PAGE");
                USERPANEL.Dock = DockStyle.Fill;
                ADMINPANEL.Dock = DockStyle.None;
                ADMINPANEL.Width = 0;
            }
        }
        private void txtKeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        //----------------------------------------------------------------\\
        #region STATES
        enum State {
            ADMIN,
            USER
        }
        State state;
        private void bttnAdminPage_Click(object sender, EventArgs e) => ChangeState(State.ADMIN);
        private void bttnUsetPage_Click(object sender, EventArgs e) => ChangeState(State.USER);
        private void ChangeState(State state) {
            if (this.state == state)
                return;
            this.state = state;

            //PANEL SİZES
            if(this.state == State.ADMIN && !isAdmin) {

            } else {
                ADMINPANEL.Dock = DockStyle.None;
                ADMINPANEL.Height = panelSelector.Height;
                USERPANEL.Dock = DockStyle.None;
                USERPANEL.Height = panelSelector.Height;
            }

            if (this.state == State.ADMIN && isAdmin) {
                SetHeader("ADMIN PAGE");
                AdmPullData(); admTxtTableCount.Text = Item.GetTableCount();
                bttnUsetPage.BackColor = Color.FromArgb(125, 110, 131);
                bttnAdminPage.BackColor = Color.FromArgb(81, 68, 87);
                USERPANEL.Width = 0;
                ADMINPANEL.Dock = DockStyle.Fill;
            } 
            if (this.state == State.USER) {
                SetHeader("USER PAGE");
                PullDataItem(); PullDataTable();
                bttnAdminPage.BackColor = Color.FromArgb(125, 110, 131);
                bttnUsetPage.BackColor = Color.FromArgb(81, 68, 87);
                ADMINPANEL.Width = 0;
                USERPANEL.Dock = DockStyle.Fill;
            }
        }
        #endregion
        //----------------------------------------------------------------\\
        #region ADMIN BUTTONS
        private void admBttnAdd_Click(object sender, EventArgs e) {
            if (admTxtName.Text != "" && admTxtPrice.Text != "") {
                item = new Item(
                        admDgwItemTable.Rows.Count,
                        admTxtName.Text,
                        Convert.ToDouble(admTxtPrice.Text)
                    );
                if (Item.CheckItemName(admTxtName.Text).name == item.name)
                    MessageBox.Show("Item already exists");
                else {
                    item.AddItemToDB();
                    MessageBox.Show("Item added succsessfully");
                    AdmPullData();
                }
            }
        }

        private void admBttnSet_Click(object sender, EventArgs e) {
            if(admTxtTableCount.Text != "") {
                Item.SaveTableCount(int.Parse(admTxtTableCount.Text));
                MessageBox.Show("Table count changed succsessfully");
            }
        }

        private void admBttnSave_Click(object sender, EventArgs e) {
            if(admTxtEditPrice.Text != "" && admTxtEditName.Text != "") {
                new Item(
                    item.id,
                    admTxtEditName.Text,
                    float.Parse(admTxtEditPrice.Text)
                ).SaveItemChanges();
                AdmPullData();
            }
        }

        private void admBttnDelete_Click(object sender, EventArgs e) {
            if(admDgwItemTable.SelectedRows.Count > 0) {
                item.DeleteItem(admDgwItemTable.Rows.Count - 1);
                AdmPullData();
            }
        }
        #endregion
        #region ADMIN INTERACTABLES
        private void admDgwItemTable_SelectionChanged(object sender, EventArgs e) {
            if (admDgwItemTable.RowCount > 0 && admDgwItemTable.SelectedRows.Count > 0) {
                item = new Item(
                    int.Parse(admDgwItemTable.SelectedRows[0].Cells[0].Value.ToString()),
                    admDgwItemTable.SelectedRows[0].Cells[1].Value.ToString(),
                    float.Parse(admDgwItemTable.SelectedRows[0].Cells[2].Value.ToString())
                    );
                admTxtEditName.Text = item.name.ToString();
                admTxtEditPrice.Text = item.price.ToString();
            }
        }
        #endregion
        #region ADMIN DATA
        public void AdmPullData() {
            SqlConnection sc = new SqlConnection(User.scText);
            string query = "select * from ItemTable order by itemId";
            sc.Open();
            SqlCommand sm = new SqlCommand(query, sc);
            SqlDataAdapter da = new SqlDataAdapter(sm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            admDgwItemTable.DataSource = dt;
            sc.Close();
        }
        #endregion
        //----------------------------------------------------------------\\
        #region USER BUTTONS
        int tableId = -1, tableCount = 0;

        private void userBttnAdd_Click(object sender, EventArgs e) {
            if (tableId != -1) {
                new Item(
                    tableId,
                    userDgwItemTable.SelectedRows[0].Cells[1].Value.ToString(),
                    float.Parse(userDgwItemTable.SelectedRows[0].Cells[2].Value.ToString()),
                    1
                    ).AddToTable();
                PullDataContent();
            }
        }

        private void userBttnRemove_Click(object sender, EventArgs e) {
            if (userDgwContentTable.SelectedRows.Count > 0) {
                if (int.Parse(userDgwContentTable.SelectedRows[0].Cells[2].Value.ToString()) <= 0)
                    new Item(
                           tableId,
                           userDgwContentTable.SelectedRows[0].Cells[0].Value.ToString()
                           ).RemoveFromTable();
                else
                    new Item(
                          tableId,
                          userDgwContentTable.SelectedRows[0].Cells[0].Value.ToString(),
                          1,
                          -1
                          ).AddToTable();
                PullDataContent();
            }
        }

        private void userBttnTransfer_Click(object sender, EventArgs e) {
            if(userDgwContentTable.RowCount > 0) {
                //CREATE AN ITEM
                Item item = new Item(
                        tableId,
                        userDgwContentTable.SelectedRows[0].Cells[0].Value.ToString(),
                        float.Parse(userDgwContentTable.SelectedRows[0].Cells[1].Value.ToString()),
                        -1
                        );
                //DECREASE ITEM FROM CONTENT TABLE
                item.AddToTable();
                //REMOVE ITEMS WHICH HAS BELOW 1 COUNT FROM CONTENT TABLE
                for (int i = 0; i < userDgwContentTable.RowCount; i++)
                    if (int.Parse(userDgwContentTable.Rows[i].Cells[2].Value.ToString()) <= 0)
                        item.RemoveFromTable();
                //ADD ITEM TO PAYEMENT TABLE //NO DATABASE INTERACTION
                //CHEK IF ITEM IS ALREADY IN THE PAYEMENT TABLE, INCREASE THE COUNT IF SO
                bool contentWriten = false;
                for (int i = 0; i < userDgwPayementTable.RowCount; i++)
                    if (item.name == userDgwPayementTable.Rows[i].Cells[0].Value.ToString()) {
                        userDgwPayementTable.Rows[i].Cells[2].Value = (1 + int.Parse(userDgwPayementTable.Rows[i].Cells[2].Value.ToString()));
                        contentWriten = true;
                        break;
                    }
                //ADD ITEM TO THE PAYEMENT TABLE IF IT DOESN'T EXISTS
                if (!contentWriten && userDgwContentTable.RowCount > 0)
                    userDgwPayementTable.Rows.Add(item.name, item.price, 1);
                //FIX THE CONTENT TABLE WITHOUT PULLING FROM DB TO NOT MESS UP THE ORDER
                userDgwContentTable.SelectedRows[0].Cells[2].Value = (int.Parse(userDgwContentTable.SelectedRows[0].Cells[2].Value.ToString()) - 1);
                if (int.Parse(userDgwContentTable.SelectedRows[0].Cells[2].Value.ToString()) <= 0)
                    userDgwContentTable.Rows.RemoveAt(userDgwContentTable.SelectedRows[0].Index);

                PullPrice();
            }
        }

        private void userBttnRemove2_Click(object sender, EventArgs e) {
            if (userDgwPayementTable.SelectedRows.Count > 0) {
                //CREATE AN ITEM
                Item item = new Item(
                        tableId,
                        userDgwPayementTable.SelectedRows[0].Cells[0].Value.ToString(),
                        float.Parse(userDgwPayementTable.SelectedRows[0].Cells[1].Value.ToString()),
                        1
                        );
                //ADD ITEM TO THE CONTENT TABLE
                item.AddToTable();
                //DECREASE OR DELETE ITEM TO PAYEMENT TABLE //NO DATABASE INTERACTION
                userDgwPayementTable.SelectedRows[0].Cells[2].Value = (int.Parse(userDgwPayementTable.SelectedRows[0].Cells[2].Value.ToString()) - 1);
                if (int.Parse(userDgwPayementTable.SelectedRows[0].Cells[2].Value.ToString()) <= 0)
                    userDgwPayementTable.Rows.Remove(userDgwPayementTable.SelectedRows[0]);

                PullDataContent();
            }
        }

        private void userPay_Click(object sender, EventArgs e) {
            userDgwPayementTable.Rows.Clear();
            SaveInfo(int.Parse(userTxtBill.Text));
            PullPrice();
        }

        private void userBttnPayAll_Click(object sender, EventArgs e) {
            string tableName = "table" + tableId;
            Item.DeleteAllTable(tableName);
            userDgwPayementTable.Rows.Clear();
            SaveInfo(int.Parse(userTxtBillAll.Text));
            PullDataContent();
        }
        #endregion
        #region USER INTERACTABLES
        private void userDgwTableTable_SelectionChanged(object sender, EventArgs e) {
            //SET TABLE ID
            if (userDgwTableTable.SelectedRows.Count > 0)
                tableId = int.Parse(userDgwTableTable.SelectedRows[0].Index.ToString()) + 1;
            //CREATE THE TABLE IF DOESN'T EXISTS
            if (tableId != -1) {
                SqlConnection sc = new SqlConnection(User.scText);
                string tableName = "table" + tableId;
                string query1 = "IF object_id('" + tableName + "') is null CREATE TABLE " + tableName + " (itemName varchar(50),itemPrice float, itemCount int);";
                SqlCommand sm1 = new SqlCommand(query1, sc);
                sc.Open(); sm1.ExecuteNonQuery(); sc.Close();
            }
            PullDataContent();
        }
        #endregion
        #region USER DATA
        public void PullDataItem() {
            userDgwTableTable.Rows.Clear();
            SqlConnection sc = new SqlConnection(User.scText);
            string query = "select * from ItemTable order by itemId";
            sc.Open();
            SqlCommand sm = new SqlCommand(query, sc);
            SqlDataAdapter da = new SqlDataAdapter(sm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            userDgwItemTable.DataSource = dt;
            sc.Close();
        }
        public void PullDataTable() {
            SqlConnection sc = new SqlConnection(User.scText);
            string query = "select * from TableCount where id = 1";
            SqlCommand sm = new SqlCommand(query, sc);
            sc.Open();
            using (SqlDataReader oReader = sm.ExecuteReader())
                while (oReader.Read())
                    tableCount = int.Parse(oReader["count"].ToString());
            for (int i = 1; i <= tableCount; i++) {
                var index = userDgwTableTable.Rows.Add();
                userDgwTableTable.Rows[index].Cells[0].Value = i;
            }
            sc.Close();
        }
        public void PullDataContent() {
            SqlConnection sc = new SqlConnection(User.scText);
            string query = "select * from table" + tableId;
            sc.Open();
            SqlCommand sm = new SqlCommand(query, sc);
            SqlDataAdapter da = new SqlDataAdapter(sm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            userDgwContentTable.DataSource = dt;
            sc.Close();
            PullPrice();
        }
        public void PullPrice() {
            int price = 0, price2 = 0;
            for (int i = 0; i < userDgwContentTable.Rows.Count; i++)
                price += int.Parse(userDgwContentTable.Rows[i].Cells[1].Value.ToString()) * int.Parse(userDgwContentTable.Rows[i].Cells[2].Value.ToString());
            for (int i = 0; i < userDgwPayementTable.RowCount; i++)
                price2 += int.Parse(userDgwPayementTable.Rows[i].Cells[1].Value.ToString()) * int.Parse(userDgwPayementTable.Rows[i].Cells[2].Value.ToString());
            userTxtBillAll.Text = (price + price2).ToString();
            userTxtBill.Text = price2.ToString();
        }
        #endregion
        //----------------------------------------------------------------\\
        private void SaveInfo(float value) {
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
