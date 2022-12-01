
namespace CoffeeManagement
{
    partial class AdminPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttnUserPage = new System.Windows.Forms.Button();
            this.bttnTableCount = new System.Windows.Forms.Button();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.txtTableCount = new System.Windows.Forms.TextBox();
            this.lblTableCount = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.coffeeManagementItemSet = new CoffeeManagement.CafebaseDataSet();
            this.itemTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.bttnAdminPage = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bttnUsetPage = new System.Windows.Forms.Button();
            this.panelSelector = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblEditHeader = new System.Windows.Forms.Label();
            this.lblEditName = new System.Windows.Forms.Label();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.lblEditPrice = new System.Windows.Forms.Label();
            this.txtEditPrice = new System.Windows.Forms.TextBox();
            this.bttnDeleteItem = new System.Windows.Forms.Button();
            this.bttnSaveEdit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgwItemTable = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeManagementItemSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTableBindingSource)).BeginInit();
            this.panel5.SuspendLayout();
            this.panelSelector.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwItemTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bttnUserPage);
            this.panel1.Controls.Add(this.bttnTableCount);
            this.panel1.Controls.Add(this.bttnAdd);
            this.panel1.Controls.Add(this.txtTableCount);
            this.panel1.Controls.Add(this.lblTableCount);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(50, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 507);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bttnUserPage
            // 
            this.bttnUserPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(110)))), ((int)(((byte)(131)))));
            this.bttnUserPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnUserPage.ForeColor = System.Drawing.Color.White;
            this.bttnUserPage.Location = new System.Drawing.Point(16, 359);
            this.bttnUserPage.Name = "bttnUserPage";
            this.bttnUserPage.Size = new System.Drawing.Size(181, 62);
            this.bttnUserPage.TabIndex = 9;
            this.bttnUserPage.Text = "OPEN USER PAGE";
            this.bttnUserPage.UseVisualStyleBackColor = false;
            this.bttnUserPage.Click += new System.EventHandler(this.bttnUserPage_Click);
            // 
            // bttnTableCount
            // 
            this.bttnTableCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(110)))), ((int)(((byte)(131)))));
            this.bttnTableCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnTableCount.ForeColor = System.Drawing.Color.White;
            this.bttnTableCount.Location = new System.Drawing.Point(16, 265);
            this.bttnTableCount.Name = "bttnTableCount";
            this.bttnTableCount.Size = new System.Drawing.Size(181, 62);
            this.bttnTableCount.TabIndex = 4;
            this.bttnTableCount.Text = "SET";
            this.bttnTableCount.UseVisualStyleBackColor = false;
            this.bttnTableCount.Click += new System.EventHandler(this.bttnTableCount_Click);
            // 
            // bttnAdd
            // 
            this.bttnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(110)))), ((int)(((byte)(131)))));
            this.bttnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAdd.ForeColor = System.Drawing.Color.White;
            this.bttnAdd.Location = new System.Drawing.Point(16, 137);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(181, 62);
            this.bttnAdd.TabIndex = 2;
            this.bttnAdd.Text = "ADD";
            this.bttnAdd.UseVisualStyleBackColor = false;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // txtTableCount
            // 
            this.txtTableCount.Location = new System.Drawing.Point(16, 239);
            this.txtTableCount.Name = "txtTableCount";
            this.txtTableCount.Size = new System.Drawing.Size(181, 20);
            this.txtTableCount.TabIndex = 3;
            this.txtTableCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTableCount_KeyPress);
            // 
            // lblTableCount
            // 
            this.lblTableCount.AutoSize = true;
            this.lblTableCount.Location = new System.Drawing.Point(13, 222);
            this.lblTableCount.Name = "lblTableCount";
            this.lblTableCount.Size = new System.Drawing.Size(82, 13);
            this.lblTableCount.TabIndex = 4;
            this.lblTableCount.Text = "TABLE COUNT";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(16, 111);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(181, 20);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(13, 94);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(39, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "PRICE";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(16, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(181, 20);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 51);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "NAME";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(13, 10);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(88, 13);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "ADD NEW ITEM";
            // 
            // coffeeManagementItemSet
            // 
            this.coffeeManagementItemSet.DataSetName = "CoffeeManagementItemSet";
            this.coffeeManagementItemSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemTableBindingSource
            // 
            this.itemTableBindingSource.DataMember = "ItemTable";
            this.itemTableBindingSource.DataSource = this.coffeeManagementItemSet;
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(184)))), ((int)(((byte)(168)))));
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.MinimumSize = new System.Drawing.Size(1008, 74);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1008, 74);
            this.panel5.TabIndex = 12;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // bttnAdminPage
            // 
            this.bttnAdminPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(110)))), ((int)(((byte)(131)))));
            this.bttnAdminPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttnAdminPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnAdminPage.ForeColor = System.Drawing.Color.White;
            this.bttnAdminPage.Location = new System.Drawing.Point(0, 0);
            this.bttnAdminPage.MaximumSize = new System.Drawing.Size(266, 100);
            this.bttnAdminPage.Name = "bttnAdminPage";
            this.bttnAdminPage.Size = new System.Drawing.Size(266, 100);
            this.bttnAdminPage.TabIndex = 2;
            this.bttnAdminPage.Text = "ADMIN PAGE";
            this.bttnAdminPage.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(211)))), ((int)(((byte)(195)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 100);
            this.panel4.MinimumSize = new System.Drawing.Size(266, 80);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(266, 80);
            this.panel4.TabIndex = 3;
            // 
            // bttnUsetPage
            // 
            this.bttnUsetPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(110)))), ((int)(((byte)(131)))));
            this.bttnUsetPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttnUsetPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnUsetPage.ForeColor = System.Drawing.Color.White;
            this.bttnUsetPage.Location = new System.Drawing.Point(0, 180);
            this.bttnUsetPage.MaximumSize = new System.Drawing.Size(266, 100);
            this.bttnUsetPage.Name = "bttnUsetPage";
            this.bttnUsetPage.Size = new System.Drawing.Size(266, 100);
            this.bttnUsetPage.TabIndex = 5;
            this.bttnUsetPage.Text = "USER PAGE";
            this.bttnUsetPage.UseVisualStyleBackColor = false;
            // 
            // panelSelector
            // 
            this.panelSelector.AutoSize = true;
            this.panelSelector.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(211)))), ((int)(((byte)(195)))));
            this.panelSelector.Controls.Add(this.bttnUsetPage);
            this.panelSelector.Controls.Add(this.panel4);
            this.panelSelector.Controls.Add(this.bttnAdminPage);
            this.panelSelector.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSelector.Location = new System.Drawing.Point(0, 74);
            this.panelSelector.MinimumSize = new System.Drawing.Size(266, 607);
            this.panelSelector.Name = "panelSelector";
            this.panelSelector.Size = new System.Drawing.Size(266, 607);
            this.panelSelector.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.dgwItemTable);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(266, 74);
            this.panel3.MinimumSize = new System.Drawing.Size(739, 607);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(50);
            this.panel3.Size = new System.Drawing.Size(742, 607);
            this.panel3.TabIndex = 14;
            // 
            // lblEditHeader
            // 
            this.lblEditHeader.AutoSize = true;
            this.lblEditHeader.Location = new System.Drawing.Point(4, 4);
            this.lblEditHeader.Name = "lblEditHeader";
            this.lblEditHeader.Size = new System.Drawing.Size(68, 13);
            this.lblEditHeader.TabIndex = 0;
            this.lblEditHeader.Text = "EDIT ITEMS";
            // 
            // lblEditName
            // 
            this.lblEditName.AutoSize = true;
            this.lblEditName.Location = new System.Drawing.Point(7, 21);
            this.lblEditName.Name = "lblEditName";
            this.lblEditName.Size = new System.Drawing.Size(38, 13);
            this.lblEditName.TabIndex = 1;
            this.lblEditName.Text = "NAME";
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(7, 38);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(213, 20);
            this.txtEditName.TabIndex = 5;
            // 
            // lblEditPrice
            // 
            this.lblEditPrice.AutoSize = true;
            this.lblEditPrice.Location = new System.Drawing.Point(7, 60);
            this.lblEditPrice.Name = "lblEditPrice";
            this.lblEditPrice.Size = new System.Drawing.Size(39, 13);
            this.lblEditPrice.TabIndex = 1;
            this.lblEditPrice.Text = "PRICE";
            // 
            // txtEditPrice
            // 
            this.txtEditPrice.Location = new System.Drawing.Point(7, 77);
            this.txtEditPrice.Name = "txtEditPrice";
            this.txtEditPrice.Size = new System.Drawing.Size(166, 20);
            this.txtEditPrice.TabIndex = 6;
            // 
            // bttnDeleteItem
            // 
            this.bttnDeleteItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(110)))), ((int)(((byte)(131)))));
            this.bttnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnDeleteItem.ForeColor = System.Drawing.Color.White;
            this.bttnDeleteItem.Location = new System.Drawing.Point(179, 75);
            this.bttnDeleteItem.Name = "bttnDeleteItem";
            this.bttnDeleteItem.Size = new System.Drawing.Size(147, 23);
            this.bttnDeleteItem.TabIndex = 8;
            this.bttnDeleteItem.Text = "Delete Item";
            this.bttnDeleteItem.UseVisualStyleBackColor = false;
            // 
            // bttnSaveEdit
            // 
            this.bttnSaveEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(110)))), ((int)(((byte)(131)))));
            this.bttnSaveEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSaveEdit.ForeColor = System.Drawing.Color.White;
            this.bttnSaveEdit.Location = new System.Drawing.Point(226, 35);
            this.bttnSaveEdit.Name = "bttnSaveEdit";
            this.bttnSaveEdit.Size = new System.Drawing.Size(100, 23);
            this.bttnSaveEdit.TabIndex = 7;
            this.bttnSaveEdit.Text = "Save";
            this.bttnSaveEdit.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.bttnSaveEdit);
            this.panel2.Controls.Add(this.bttnDeleteItem);
            this.panel2.Controls.Add(this.txtEditPrice);
            this.panel2.Controls.Add(this.lblEditPrice);
            this.panel2.Controls.Add(this.txtEditName);
            this.panel2.Controls.Add(this.lblEditName);
            this.panel2.Controls.Add(this.lblEditHeader);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(269, 445);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 112);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dgwItemTable
            // 
            this.dgwItemTable.AllowDrop = true;
            this.dgwItemTable.AllowUserToAddRows = false;
            this.dgwItemTable.AllowUserToDeleteRows = false;
            this.dgwItemTable.AllowUserToResizeColumns = false;
            this.dgwItemTable.AllowUserToResizeRows = false;
            this.dgwItemTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwItemTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwItemTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwItemTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwItemTable.Location = new System.Drawing.Point(269, 50);
            this.dgwItemTable.MultiSelect = false;
            this.dgwItemTable.Name = "dgwItemTable";
            this.dgwItemTable.ReadOnly = true;
            this.dgwItemTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgwItemTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwItemTable.Size = new System.Drawing.Size(423, 395);
            this.dgwItemTable.TabIndex = 12;
            this.dgwItemTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwItemTable_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::CoffeeManagement.Properties.Resources.YG;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 74);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(237)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelSelector);
            this.Controls.Add(this.panel5);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminPage_FormClosed);
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeManagementItemSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTableBindingSource)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panelSelector.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwItemTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CafebaseDataSet coffeeManagementItemSet;
        private System.Windows.Forms.BindingSource itemTableBindingSource;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Button bttnUserPage;
        private System.Windows.Forms.Button bttnTableCount;
        private System.Windows.Forms.TextBox txtTableCount;
        private System.Windows.Forms.Label lblTableCount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button bttnAdminPage;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bttnUsetPage;
        private System.Windows.Forms.Panel panelSelector;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgwItemTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bttnSaveEdit;
        private System.Windows.Forms.Button bttnDeleteItem;
        private System.Windows.Forms.TextBox txtEditPrice;
        private System.Windows.Forms.Label lblEditPrice;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.Label lblEditName;
        private System.Windows.Forms.Label lblEditHeader;
    }
}