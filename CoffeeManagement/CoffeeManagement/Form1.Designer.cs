
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
            this.lblSignInInfo = new System.Windows.Forms.Label();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.bttnSign = new System.Windows.Forms.Button();
            this.lblLogIn = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbPassShown = new System.Windows.Forms.CheckBox();
            this.bttnLog = new System.Windows.Forms.Button();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSignInInfo
            // 
            this.lblSignInInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSignInInfo.AutoSize = true;
            this.lblSignInInfo.Location = new System.Drawing.Point(218, 164);
            this.lblSignInInfo.Name = "lblSignInInfo";
            this.lblSignInInfo.Size = new System.Drawing.Size(145, 13);
            this.lblSignInInfo.TabIndex = 16;
            this.lblSignInInfo.Text = "If yoıu don\'t have an account";
            // 
            // pictureLogo
            // 
            this.pictureLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureLogo.ErrorImage = null;
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.InitialImage = null;
            this.pictureLogo.Location = new System.Drawing.Point(230, 16);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(123, 124);
            this.pictureLogo.TabIndex = 17;
            this.pictureLogo.TabStop = false;
            this.pictureLogo.WaitOnLoad = true;
            // 
            // bttnSign
            // 
            this.bttnSign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnSign.Location = new System.Drawing.Point(206, 180);
            this.bttnSign.Name = "bttnSign";
            this.bttnSign.Size = new System.Drawing.Size(168, 23);
            this.bttnSign.TabIndex = 15;
            this.bttnSign.Text = "Sign in";
            this.bttnSign.UseVisualStyleBackColor = true;
            this.bttnSign.Click += new System.EventHandler(this.bttnSign_Click);
            // 
            // lblLogIn
            // 
            this.lblLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLogIn.AutoSize = true;
            this.lblLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLogIn.Location = new System.Drawing.Point(57, 2);
            this.lblLogIn.Margin = new System.Windows.Forms.Padding(0);
            this.lblLogIn.Name = "lblLogIn";
            this.lblLogIn.Size = new System.Drawing.Size(60, 25);
            this.lblLogIn.TabIndex = 13;
            this.lblLogIn.Text = "Login";
            this.lblLogIn.UseMnemonic = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.cbPassShown);
            this.groupBox1.Controls.Add(this.bttnLog);
            this.groupBox1.Controls.Add(this.lblPass);
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.Controls.Add(this.txtInfo);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Location = new System.Drawing.Point(4, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 175);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // cbPassShown
            // 
            this.cbPassShown.AutoSize = true;
            this.cbPassShown.Location = new System.Drawing.Point(69, 55);
            this.cbPassShown.Name = "cbPassShown";
            this.cbPassShown.Size = new System.Drawing.Size(105, 17);
            this.cbPassShown.TabIndex = 13;
            this.cbPassShown.Text = "PasswordShown";
            this.cbPassShown.UseVisualStyleBackColor = true;
            this.cbPassShown.CheckedChanged += new System.EventHandler(this.cbPassShown_CheckedChanged);
            // 
            // bttnLog
            // 
            this.bttnLog.Location = new System.Drawing.Point(6, 120);
            this.bttnLog.Name = "bttnLog";
            this.bttnLog.Size = new System.Drawing.Size(168, 23);
            this.bttnLog.TabIndex = 4;
            this.bttnLog.Text = "Log in";
            this.bttnLog.UseVisualStyleBackColor = true;
            this.bttnLog.Click += new System.EventHandler(this.bttnLog_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(0, 55);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(53, 13);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Password";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(-3, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(55, 13);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Username";
            // 
            // txtInfo
            // 
            this.txtInfo.Enabled = false;
            this.txtInfo.Location = new System.Drawing.Point(0, 149);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(180, 20);
            this.txtInfo.TabIndex = 6;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(2, 76);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(180, 20);
            this.txtPass.TabIndex = 1;
            // 
            // txtUser
            // 
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUser.Location = new System.Drawing.Point(6, 25);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(180, 20);
            this.txtUser.TabIndex = 0;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 213);
            this.Controls.Add(this.lblSignInInfo);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.bttnSign);
            this.Controls.Add(this.lblLogIn);
            this.Controls.Add(this.groupBox1);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSignInInfo;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Button bttnSign;
        private System.Windows.Forms.Label lblLogIn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbPassShown;
        private System.Windows.Forms.Button bttnLog;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
    }
}

