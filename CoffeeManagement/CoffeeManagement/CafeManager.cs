using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;

namespace CoffeeManagement {
    public partial class CafeManagerForm : Form {

        Item item = new Item();
        public CafeManagerForm() {
            InitializeComponent();
        }
        private void FormClose(object sender, FormClosedEventArgs e) => Application.Exit();
        private void FromLoad(object sender, EventArgs e) {
            AdmPullData(); admTxtTableCount.Text = Item.GetTableCount();
        }

        #region SELECTION BUTTONS
        enum State {
            ADMIN,
            USER
        }
        State state;
        private void bttnAdminPage_Click(object sender, EventArgs e) => ChangeState(State.ADMIN);
        private void bttnUsetPage_Click(object sender, EventArgs e) => ChangeState(State.USER);
        private async void ChangeState(State state) {
            if (this.state == state)
                return;
            this.state = state;

            //PANEL SİZES
            ADMINPANEL.Dock = DockStyle.None;
            ADMINPANEL.Height = CafeManagerForm.ActiveForm.Height - panelTop.Height;
            //ADMINPANEL.Width = CafeManagerForm.ActiveForm.Width - panelSelector.Width;

            if(this.state == State.ADMIN) {
                //BUTTON COLORS
                bttnUsetPage.BackColor = Color.FromArgb(125, 110, 131);
                bttnAdminPage.BackColor = Color.FromArgb(81, 68, 87);
                while (true) {
                    if (ADMINPANEL.Width >= CafeManagerForm.ActiveForm.Width - panelSelector.Width) {
                        ADMINPANEL.Dock = DockStyle.Fill;
                        return;
                    }
                    ADMINPANEL.Width += 20;
                    await Task.Delay(5);
                }
            }
            else if (this.state == State.USER) {
                bttnAdminPage.BackColor = Color.FromArgb(125, 110, 131);
                bttnUsetPage.BackColor = Color.FromArgb(81, 68, 87);
                while (true) {
                    if (ADMINPANEL.Width <= 0) {
                        return;
                    }
                    ADMINPANEL.Width -= 20;
                    await Task.Delay(5);
                }
            }
        }
        #endregion
        #region ADMIN BUTTONS
        private void admBttnAdd_Click(object sender, EventArgs e) {
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

        private void admBttnSet_Click(object sender, EventArgs e) {
            Item.SaveTableCount(int.Parse(admTxtTableCount.Text));
            MessageBox.Show("Table count changed succsessfully");
        }

        private void admBttnSave_Click(object sender, EventArgs e) {
            new Item(
                item.id,
                admTxtEditName.Text,
                float.Parse(admTxtEditPrice.Text)
            ).SaveItemChanges();
            AdmPullData();
        }

        private void admBttnDelete_Click(object sender, EventArgs e) {
            item.DeleteItem(admDgwItemTable.Rows.Count - 1);
            AdmPullData();
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

        private void txtKeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}
