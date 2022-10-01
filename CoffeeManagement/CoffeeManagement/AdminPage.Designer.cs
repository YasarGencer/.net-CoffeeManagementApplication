
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.coffeeManagementItemSet = new CoffeeManagement.CoffeeManagementItemSet();
            this.itemTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemTableTableAdapter = new CoffeeManagement.CoffeeManagementItemSetTableAdapters.ItemTableTableAdapter();
            this.tableAdapterManager = new CoffeeManagement.CoffeeManagementItemSetTableAdapters.TableAdapterManager();
            this.dgwItemTable = new System.Windows.Forms.DataGridView();
            this.bttnUserPage = new System.Windows.Forms.Button();
            this.lblTableCount = new System.Windows.Forms.Label();
            this.txtTableCount = new System.Windows.Forms.TextBox();
            this.bttnTableCount = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeManagementItemSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwItemTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
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
            // bttnAdd
            // 
            this.bttnAdd.Location = new System.Drawing.Point(16, 137);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(181, 62);
            this.bttnAdd.TabIndex = 6;
            this.bttnAdd.Text = "ADD";
            this.bttnAdd.UseVisualStyleBackColor = true;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(16, 111);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(181, 20);
            this.txtPrice.TabIndex = 5;
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
            this.txtName.TabIndex = 5;
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
            // itemTableTableAdapter
            // 
            this.itemTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ItemTableTableAdapter = this.itemTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = CoffeeManagement.CoffeeManagementItemSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserInfoTableAdapter = null;
            // 
            // dgwItemTable
            // 
            this.dgwItemTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwItemTable.Location = new System.Drawing.Point(238, 13);
            this.dgwItemTable.Name = "dgwItemTable";
            this.dgwItemTable.Size = new System.Drawing.Size(343, 436);
            this.dgwItemTable.TabIndex = 3;
            // 
            // bttnUserPage
            // 
            this.bttnUserPage.Location = new System.Drawing.Point(16, 359);
            this.bttnUserPage.Name = "bttnUserPage";
            this.bttnUserPage.Size = new System.Drawing.Size(181, 62);
            this.bttnUserPage.TabIndex = 6;
            this.bttnUserPage.Text = "OPEN USER PAGE";
            this.bttnUserPage.UseVisualStyleBackColor = true;
            this.bttnUserPage.Click += new System.EventHandler(this.bttnUserPage_Click);
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
            // txtTableCount
            // 
            this.txtTableCount.Location = new System.Drawing.Point(16, 239);
            this.txtTableCount.Name = "txtTableCount";
            this.txtTableCount.Size = new System.Drawing.Size(181, 20);
            this.txtTableCount.TabIndex = 5;
            // 
            // bttnTableCount
            // 
            this.bttnTableCount.Location = new System.Drawing.Point(16, 265);
            this.bttnTableCount.Name = "bttnTableCount";
            this.bttnTableCount.Size = new System.Drawing.Size(181, 62);
            this.bttnTableCount.TabIndex = 6;
            this.bttnTableCount.Text = "SET";
            this.bttnTableCount.UseVisualStyleBackColor = true;
            this.bttnTableCount.Click += new System.EventHandler(this.bttnTableCount_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 469);
            this.Controls.Add(this.dgwItemTable);
            this.Controls.Add(this.panel1);
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminPage_FormClosed);
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeManagementItemSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwItemTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CoffeeManagementItemSet coffeeManagementItemSet;
        private System.Windows.Forms.BindingSource itemTableBindingSource;
        private CoffeeManagementItemSetTableAdapters.ItemTableTableAdapter itemTableTableAdapter;
        private CoffeeManagementItemSetTableAdapters.TableAdapterManager tableAdapterManager;
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
    }
}