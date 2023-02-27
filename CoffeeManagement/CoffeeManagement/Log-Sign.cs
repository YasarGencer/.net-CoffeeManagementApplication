using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class LogIn : Form
    {
        CafeManagerForm cafe;
        public enum State {
            LOGIN,
            SIGNIN
        }
        public State currentState = State.LOGIN;
        public LogIn() {
            InitializeComponent();
            panelConfPass.Width = 0;
            ChangeState(currentState);
            cafe = new CafeManagerForm();
        }
        #region BUTTONS
        private void bttnApply_Click(object sender, EventArgs e) {
            User writenUser = new User(txtUser.Text, txtPass.Text);
            //ERROR CHECHKING
            if (txtUser.Text == "" || txtPass.Text == "") {
                MessageBox.Show("Don't leave any text area blank.");
                return;
            }
            if (currentState == State.SIGNIN) {
                if (txtConfPass.Text == "") {
                    MessageBox.Show("Don't leave any text area blank.");
                    return;
                }
                if (txtPass.Text != txtConfPass.Text) {
                    MessageBox.Show("Passwords doesn't match");
                    return;
                }
                if (User.CheckUserName(txtUser.Text).username == txtUser.Text) {
                    MessageBox.Show("User already exists");
                    return;
                }
             //ERROR CHECHKING
                writenUser.SignIn();
                MessageBox.Show("Sign In Successful");
            }
            //ERROR CHECHKING
            if (User.CheckUserName(writenUser.username).password != writenUser.password) {
                MessageBox.Show("Incorrect password or username");
                return;
            }
            cafe.SetUser(writenUser);
            if (writenUser.username == "admin")
                cafe.SetAdmin();
            cafe.Show();
            MessageBox.Show("Log in succsessfull");
            this.Hide();
        }
        private void btnSignInScreen_Click(object sender, EventArgs e) {
            ChangeState(State.SIGNIN);
        }

        private void btnLogInScreen_Click(object sender, EventArgs e) {
            ChangeState(State.LOGIN);
        }
        #endregion
        char[] sign = { 'S', 'I', 'G', 'N', ' ', 'I', 'N', ' ', 'P', 'A', 'G', 'E' };
        char[] log = { 'L','O','G',' ','I','N', ' ', 'P', 'A', 'G', 'E' };
        private async void ChangeState(State state) {
            currentState = state;
            lblDesc.Text = "";
            txtConfPass.Text = "";
            if (currentState == State.LOGIN) {
                btnSignInScreen.BackColor = Color.FromArgb(125, 110, 131);
                btnLogInScreen.BackColor = Color.FromArgb(81, 68, 87);
                while (true) {
                    if (panelConfPass.Width > 0)
                        panelConfPass.Width -= 20;
                    if(lblDesc.Text.Length < log.Length)
                        lblDesc.Text += log[lblDesc.Text.Length];
                    if (panelConfPass.Width <= 0 && lblDesc.Text.Length >= log.Length)
                        return;
                    await Task.Delay(5);
                }
            } else {
                btnLogInScreen.BackColor = Color.FromArgb(125, 110, 131);
                btnSignInScreen.BackColor = Color.FromArgb(81, 68, 87);
                while (true) {
                    if (panelConfPass.Width < 300)
                        panelConfPass.Width += 20;
                    if (lblDesc.Text.Length < sign.Length)
                        lblDesc.Text += sign[lblDesc.Text.Length];
                    if (panelConfPass.Width >= 300 && lblDesc.Text.Length >= sign.Length)
                        return;
                    await Task.Delay(5);
                }
            }
        }
    }
}
