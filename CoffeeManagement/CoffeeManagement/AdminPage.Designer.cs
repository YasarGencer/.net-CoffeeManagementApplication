
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
            this.dgwItemTable = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bttnSaveEdit = new System.Windows.Forms.Button();
            this.bttnDeleteItem = new System.Windows.Forms.Button();
            this.txtEditPrice = new System.Windows.Forms.TextBox();
            this.lblEditPrice = new System.Windows.Forms.Label();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.lblEditName = new System.Windows.Forms.Label();
            this.lblEditHeader = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeManagementItemSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwItemTable)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 436);
            this.panel1.TabIndex = 0;
            // 
            // bttnUserPage
            // 
            this.bttnUserPage.Location = new System.Drawing.Point(16, 359);
            this.bttnUserPage.Name = "bttnUserPage";
            this.bttnUserPage.Size = new System.Drawing.Size(181, 62);
            this.bttnUserPage.TabIndex = 9;
            this.bttnUserPage.Text = "OPEN USER PAGE";
            this.bttnUserPage.UseVisualStyleBackColor = true;
            this.bttnUserPage.Click += new System.EventHandler(this.bttnUserPage_Click);
            // 
            // bttnTableCount
            // 
            this.bttnTableCount.Location = new System.Drawing.Point(16, 265);
            this.bttnTableCount.Name = "bttnTableCount";
            this.bttnTableCount.Size = new System.Drawing.Size(181, 62);
            this.bttnTableCount.TabIndex = 4;
            this.bttnTableCount.Text = "SET";
            this.bttnTableCount.UseVisualStyleBackColor = true;
            this.bttnTableCount.Click += new System.EventHandler(this.bttnTableCount_Click);
            // 
            // bttnAdd
            // 
            this.bttnAdd.Location = new System.Drawing.Point(16, 137);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(181, 62);
            this.bttnAdd.TabIndex = 2;
            this.bttnAdd.Text = "ADD";
            this.bttnAdd.UseVisualStyleBackColor = true;
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
            // dgwItemTable
            // 
            this.dgwItemTable.AllowDrop = true;
            this.dgwItemTable.AllowUserToAddRows = false;
            this.dgwItemTable.AllowUserToDeleteRows = false;
            this.dgwItemTable.AllowUserToResizeColumns = false;
            this.dgwItemTable.AllowUserToResizeRows = false;
            this.dgwItemTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwItemTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwItemTable.Location = new System.Drawing.Point(238, 13);
            this.dgwItemTable.MultiSelect = false;
            this.dgwItemTable.Name = "dgwItemTable";
            this.dgwItemTable.ReadOnly = true;
            this.dgwItemTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwItemTable.Size = new System.Drawing.Size(343, 318);
            this.dgwItemTable.TabIndex = 10;
            this.dgwItemTable.SelectionChanged += new System.EventHandler(this.dgwItemTable_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.bttnSaveEdit);
            this.panel2.Controls.Add(this.bttnDeleteItem);
            this.panel2.Controls.Add(this.txtEditPrice);
            this.panel2.Controls.Add(this.lblEditPrice);
            this.panel2.Controls.Add(this.txtEditName);
            this.panel2.Controls.Add(this.lblEditName);
            this.panel2.Controls.Add(this.lblEditHeader);
            this.panel2.Location = new System.Drawing.Point(238, 337);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 112);
            this.panel2.TabIndex = 4;
            // 
            // bttnSaveEdit
            // 
            this.bttnSaveEdit.Location = new System.Drawing.Point(226, 35);
            this.bttnSaveEdit.Name = "bttnSaveEdit";
            this.bttnSaveEdit.Size = new System.Drawing.Size(100, 23);
            this.bttnSaveEdit.TabIndex = 7;
            this.bttnSaveEdit.Text = "Save";
            this.bttnSaveEdit.UseVisualStyleBackColor = true;
            this.bttnSaveEdit.Click += new System.EventHandler(this.bttnSaveEdit_Click);
            // 
            // bttnDeleteItem
            // 
            this.bttnDeleteItem.Location = new System.Drawing.Point(179, 75);
            this.bttnDeleteItem.Name = "bttnDeleteItem";
            this.bttnDeleteItem.Size = new System.Drawing.Size(147, 23);
            this.bttnDeleteItem.TabIndex = 8;
            this.bttnDeleteItem.Text = "Delete Item";
            this.bttnDeleteItem.UseVisualStyleBackColor = true;
            this.bttnDeleteItem.Click += new System.EventHandler(this.bttnDeleteItem_Click);
            // 
            // txtEditPrice
            // 
            this.txtEditPrice.Location = new System.Drawing.Point(7, 77);
            this.txtEditPrice.Name = "txtEditPrice";
            this.txtEditPrice.Size = new System.Drawing.Size(166, 20);
            this.txtEditPrice.TabIndex = 6;
            this.txtEditPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
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
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(7, 38);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(213, 20);
            this.txtEditName.TabIndex = 5;
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
            // lblEditHeader
            // 
            this.lblEditHeader.AutoSize = true;
            this.lblEditHeader.Location = new System.Drawing.Point(4, 4);
            this.lblEditHeader.Name = "lblEditHeader";
            this.lblEditHeader.Size = new System.Drawing.Size(68, 13);
            this.lblEditHeader.TabIndex = 0;
            this.lblEditHeader.Text = "EDIT ITEMS";
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 469);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgwItemTable);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee Management Admin Page by YG";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminPage_FormClosed);
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeManagementItemSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwItemTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView dgwItemTable;
        private System.Windows.Forms.Button bttnUserPage;
        private System.Windows.Forms.Button bttnTableCount;
        private System.Windows.Forms.TextBox txtTableCount;
        private System.Windows.Forms.Label lblTableCount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblEditHeader;
        private System.Windows.Forms.TextBox txtEditPrice;
        private System.Windows.Forms.Label lblEditPrice;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.Label lblEditName;
        private System.Windows.Forms.Button bttnSaveEdit;
        private System.Windows.Forms.Button bttnDeleteItem;
    }
}