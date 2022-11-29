
namespace CoffeeManagement
{
    partial class LogIn
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.bttnApply = new System.Windows.Forms.Button();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSignInScreen = new System.Windows.Forms.Button();
            this.btnLogInScreen = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDesc = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelConfPass = new System.Windows.Forms.Panel();
            this.lblConfPass = new System.Windows.Forms.Label();
            this.txtConfPass = new System.Windows.Forms.TextBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelConfPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnApply
            // 
            this.bttnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(110)))), ((int)(((byte)(131)))));
            this.bttnApply.FlatAppearance.BorderSize = 0;
            this.bttnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnApply.ForeColor = System.Drawing.Color.White;
            this.bttnApply.Location = new System.Drawing.Point(52, 98);
            this.bttnApply.Name = "bttnApply";
            this.bttnApply.Size = new System.Drawing.Size(180, 47);
            this.bttnApply.TabIndex = 3;
            this.bttnApply.Text = "APPLY";
            this.bttnApply.UseVisualStyleBackColor = false;
            this.bttnApply.Click += new System.EventHandler(this.bttnApply_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPass.Location = new System.Drawing.Point(8, 38);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(78, 20);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Password";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUser.Location = new System.Drawing.Point(6, 6);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(83, 20);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Username";
            // 
            // txtPass
            // 
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPass.Location = new System.Drawing.Point(113, 38);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(180, 19);
            this.txtPass.TabIndex = 1;
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUser.Location = new System.Drawing.Point(113, 6);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(180, 19);
            this.txtUser.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(211)))), ((int)(((byte)(195)))));
            this.panelMenu.Controls.Add(this.btnSignInScreen);
            this.panelMenu.Controls.Add(this.btnLogInScreen);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.MinimumSize = new System.Drawing.Size(200, 212);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 224);
            this.panelMenu.TabIndex = 1;
            // 
            // btnSignInScreen
            // 
            this.btnSignInScreen.AutoSize = true;
            this.btnSignInScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(110)))), ((int)(((byte)(131)))));
            this.btnSignInScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSignInScreen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSignInScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignInScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSignInScreen.ForeColor = System.Drawing.Color.White;
            this.btnSignInScreen.Location = new System.Drawing.Point(0, 145);
            this.btnSignInScreen.MaximumSize = new System.Drawing.Size(200, 75);
            this.btnSignInScreen.MinimumSize = new System.Drawing.Size(200, 75);
            this.btnSignInScreen.Name = "btnSignInScreen";
            this.btnSignInScreen.Size = new System.Drawing.Size(200, 75);
            this.btnSignInScreen.TabIndex = 6;
            this.btnSignInScreen.Text = "SIGN IN";
            this.btnSignInScreen.UseVisualStyleBackColor = false;
            this.btnSignInScreen.Click += new System.EventHandler(this.btnSignInScreen_Click);
            // 
            // btnLogInScreen
            // 
            this.btnLogInScreen.AutoSize = true;
            this.btnLogInScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(110)))), ((int)(((byte)(131)))));
            this.btnLogInScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogInScreen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogInScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogInScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogInScreen.ForeColor = System.Drawing.Color.White;
            this.btnLogInScreen.Location = new System.Drawing.Point(0, 70);
            this.btnLogInScreen.MaximumSize = new System.Drawing.Size(200, 75);
            this.btnLogInScreen.MinimumSize = new System.Drawing.Size(200, 75);
            this.btnLogInScreen.Name = "btnLogInScreen";
            this.btnLogInScreen.Size = new System.Drawing.Size(200, 75);
            this.btnLogInScreen.TabIndex = 5;
            this.btnLogInScreen.Text = "LOG IN";
            this.btnLogInScreen.UseVisualStyleBackColor = false;
            this.btnLogInScreen.Click += new System.EventHandler(this.btnLogInScreen_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(184)))), ((int)(((byte)(168)))));
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.MinimumSize = new System.Drawing.Size(200, 70);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 70);
            this.panelLogo.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::CoffeeManagement.Properties.Resources.YG;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 70);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 70);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(211)))), ((int)(((byte)(195)))));
            this.panel1.Controls.Add(this.lblDesc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(235, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 70);
            this.panel1.TabIndex = 17;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDesc.Location = new System.Drawing.Point(96, 25);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(112, 20);
            this.lblDesc.TabIndex = 0;
            this.lblDesc.Text = "LOG IN PAGE";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.bttnApply);
            this.panel2.Controls.Add(this.txtPass);
            this.panel2.Controls.Add(this.lblPass);
            this.panel2.Controls.Add(this.lblUser);
            this.panel2.Controls.Add(this.txtUser);
            this.panel2.Controls.Add(this.panelConfPass);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(200, 70);
            this.panel2.MinimumSize = new System.Drawing.Size(305, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 154);
            this.panel2.TabIndex = 18;
            // 
            // panelConfPass
            // 
            this.panelConfPass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelConfPass.Controls.Add(this.lblConfPass);
            this.panelConfPass.Controls.Add(this.txtConfPass);
            this.panelConfPass.Location = new System.Drawing.Point(2, 63);
            this.panelConfPass.MaximumSize = new System.Drawing.Size(300, 29);
            this.panelConfPass.MinimumSize = new System.Drawing.Size(0, 29);
            this.panelConfPass.Name = "panelConfPass";
            this.panelConfPass.Size = new System.Drawing.Size(300, 29);
            this.panelConfPass.TabIndex = 5;
            // 
            // lblConfPass
            // 
            this.lblConfPass.AutoSize = true;
            this.lblConfPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblConfPass.Location = new System.Drawing.Point(4, 6);
            this.lblConfPass.Name = "lblConfPass";
            this.lblConfPass.Size = new System.Drawing.Size(103, 20);
            this.lblConfPass.TabIndex = 3;
            this.lblConfPass.Text = "Confirm Pass";
            // 
            // txtConfPass
            // 
            this.txtConfPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtConfPass.Location = new System.Drawing.Point(111, 6);
            this.txtConfPass.Name = "txtConfPass";
            this.txtConfPass.PasswordChar = '*';
            this.txtConfPass.Size = new System.Drawing.Size(180, 19);
            this.txtConfPass.TabIndex = 2;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(237)))), ((int)(((byte)(227)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(505, 224);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(521, 263);
            this.MinimumSize = new System.Drawing.Size(521, 263);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee Management LogIn Page by YG";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelConfPass.ResumeLayout(false);
            this.panelConfPass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttnApply;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnLogInScreen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSignInScreen;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Panel panelConfPass;
        private System.Windows.Forms.Label lblConfPass;
        private System.Windows.Forms.TextBox txtConfPass;
    }
}

