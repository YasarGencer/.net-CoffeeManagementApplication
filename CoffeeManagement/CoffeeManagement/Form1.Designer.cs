
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
            this.bttnLog = new System.Windows.Forms.Button();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnLogInScreen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSignInScreen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnLog
            // 
            this.bttnLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(110)))), ((int)(((byte)(131)))));
            this.bttnLog.FlatAppearance.BorderSize = 0;
            this.bttnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnLog.ForeColor = System.Drawing.Color.White;
            this.bttnLog.Location = new System.Drawing.Point(55, 91);
            this.bttnLog.Name = "bttnLog";
            this.bttnLog.Size = new System.Drawing.Size(180, 47);
            this.bttnLog.TabIndex = 4;
            this.bttnLog.Text = "Log in";
            this.bttnLog.UseVisualStyleBackColor = false;
            this.bttnLog.Click += new System.EventHandler(this.bttnLog_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPass.Location = new System.Drawing.Point(8, 51);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(78, 20);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Password";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUser.Location = new System.Drawing.Point(6, 19);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(83, 20);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Username";
            // 
            // txtPass
            // 
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPass.Location = new System.Drawing.Point(113, 51);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(180, 19);
            this.txtPass.TabIndex = 1;
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUser.Location = new System.Drawing.Point(113, 19);
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
            this.panelMenu.Size = new System.Drawing.Size(200, 212);
            this.panelMenu.TabIndex = 1;
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
            this.btnLogInScreen.MaximumSize = new System.Drawing.Size(200, 140);
            this.btnLogInScreen.MinimumSize = new System.Drawing.Size(200, 70);
            this.btnLogInScreen.Name = "btnLogInScreen";
            this.btnLogInScreen.Size = new System.Drawing.Size(200, 70);
            this.btnLogInScreen.TabIndex = 2;
            this.btnLogInScreen.Text = "LOG IN";
            this.btnLogInScreen.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(211)))), ((int)(((byte)(195)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(235, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 70);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.bttnLog);
            this.panel2.Controls.Add(this.txtPass);
            this.panel2.Controls.Add(this.lblPass);
            this.panel2.Controls.Add(this.lblUser);
            this.panel2.Controls.Add(this.txtUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(200, 70);
            this.panel2.MinimumSize = new System.Drawing.Size(305, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 141);
            this.panel2.TabIndex = 18;
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
            this.btnSignInScreen.Location = new System.Drawing.Point(0, 140);
            this.btnSignInScreen.MaximumSize = new System.Drawing.Size(200, 140);
            this.btnSignInScreen.MinimumSize = new System.Drawing.Size(200, 70);
            this.btnSignInScreen.Name = "btnSignInScreen";
            this.btnSignInScreen.Size = new System.Drawing.Size(200, 70);
            this.btnSignInScreen.TabIndex = 3;
            this.btnSignInScreen.Text = "SIGN IN";
            this.btnSignInScreen.UseVisualStyleBackColor = false;
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
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(237)))), ((int)(((byte)(227)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(505, 211);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(521, 250);
            this.MinimumSize = new System.Drawing.Size(521, 250);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee Management LogIn Page by YG";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttnLog;
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
    }
}

