
namespace CoffeeManagement
{
    partial class UserPage
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
            this.dgwItemTable = new System.Windows.Forms.DataGridView();
            this.dgwTableTable = new System.Windows.Forms.DataGridView();
            this.Tables = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgwContentTable = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttnRemove = new System.Windows.Forms.Button();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwItemTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTableTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwContentTable)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwItemTable
            // 
            this.dgwItemTable.AllowDrop = true;
            this.dgwItemTable.AllowUserToAddRows = false;
            this.dgwItemTable.AllowUserToDeleteRows = false;
            this.dgwItemTable.AllowUserToResizeColumns = false;
            this.dgwItemTable.AllowUserToResizeRows = false;
            this.dgwItemTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwItemTable.Location = new System.Drawing.Point(12, 12);
            this.dgwItemTable.MultiSelect = false;
            this.dgwItemTable.Name = "dgwItemTable";
            this.dgwItemTable.ReadOnly = true;
            this.dgwItemTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwItemTable.Size = new System.Drawing.Size(356, 581);
            this.dgwItemTable.TabIndex = 11;
            this.dgwItemTable.SelectionChanged += new System.EventHandler(this.dgwItemTable_SelectionChanged);
            // 
            // dgwTableTable
            // 
            this.dgwTableTable.AllowDrop = true;
            this.dgwTableTable.AllowUserToAddRows = false;
            this.dgwTableTable.AllowUserToDeleteRows = false;
            this.dgwTableTable.AllowUserToResizeColumns = false;
            this.dgwTableTable.AllowUserToResizeRows = false;
            this.dgwTableTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTableTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tables});
            this.dgwTableTable.Location = new System.Drawing.Point(374, 12);
            this.dgwTableTable.MultiSelect = false;
            this.dgwTableTable.Name = "dgwTableTable";
            this.dgwTableTable.ReadOnly = true;
            this.dgwTableTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgwTableTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwTableTable.Size = new System.Drawing.Size(122, 581);
            this.dgwTableTable.TabIndex = 11;
            this.dgwTableTable.SelectionChanged += new System.EventHandler(this.dgwTableTable_SelectionChanged);
            // 
            // Tables
            // 
            this.Tables.FillWeight = 10000F;
            this.Tables.HeaderText = "Tables";
            this.Tables.Name = "Tables";
            this.Tables.ReadOnly = true;
            this.Tables.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Tables.Width = 50;
            // 
            // dgwContentTable
            // 
            this.dgwContentTable.AllowDrop = true;
            this.dgwContentTable.AllowUserToAddRows = false;
            this.dgwContentTable.AllowUserToDeleteRows = false;
            this.dgwContentTable.AllowUserToResizeColumns = false;
            this.dgwContentTable.AllowUserToResizeRows = false;
            this.dgwContentTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwContentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwContentTable.Location = new System.Drawing.Point(502, 12);
            this.dgwContentTable.MultiSelect = false;
            this.dgwContentTable.Name = "dgwContentTable";
            this.dgwContentTable.ReadOnly = true;
            this.dgwContentTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwContentTable.Size = new System.Drawing.Size(347, 327);
            this.dgwContentTable.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(502, 345);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 248);
            this.panel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bttnRemove);
            this.panel1.Controls.Add(this.bttnAdd);
            this.panel1.Controls.Add(this.txtCount);
            this.panel1.Controls.Add(this.lblCount);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 80);
            this.panel1.TabIndex = 13;
            // 
            // bttnRemove
            // 
            this.bttnRemove.Location = new System.Drawing.Point(172, 53);
            this.bttnRemove.Name = "bttnRemove";
            this.bttnRemove.Size = new System.Drawing.Size(150, 23);
            this.bttnRemove.TabIndex = 2;
            this.bttnRemove.Text = "REMOVE";
            this.bttnRemove.UseVisualStyleBackColor = true;
            this.bttnRemove.Click += new System.EventHandler(this.bttnRemove_Click);
            // 
            // bttnAdd
            // 
            this.bttnAdd.Location = new System.Drawing.Point(3, 52);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(163, 23);
            this.bttnAdd.TabIndex = 2;
            this.bttnAdd.Text = "ADD";
            this.bttnAdd.UseVisualStyleBackColor = true;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(77, 27);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(248, 20);
            this.txtCount.TabIndex = 1;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(3, 30);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(74, 13);
            this.lblCount.TabIndex = 0;
            this.lblCount.Text = "ITEM COUNT";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(76, 1);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(249, 20);
            this.txtName.TabIndex = 15;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 4);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "ITEM NAME";
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 605);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgwContentTable);
            this.Controls.Add(this.dgwItemTable);
            this.Controls.Add(this.dgwTableTable);
            this.Name = "UserPage";
            this.Text = "UserPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserPage_FormClosed);
            this.Load += new System.EventHandler(this.UserPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwItemTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTableTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwContentTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwItemTable;
        private System.Windows.Forms.DataGridView dgwTableTable;
        private System.Windows.Forms.DataGridView dgwContentTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Button bttnRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tables;
    }
}