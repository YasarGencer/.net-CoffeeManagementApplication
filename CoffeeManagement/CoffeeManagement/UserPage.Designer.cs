
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.bttnPay = new System.Windows.Forms.Button();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.lblBillInfo = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bttnTransfer = new System.Windows.Forms.Button();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttnRemove = new System.Windows.Forms.Button();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.dgwPayementTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwItemTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTableTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwContentTable)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPayementTable)).BeginInit();
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
            this.dgwItemTable.Size = new System.Drawing.Size(356, 711);
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
            this.dgwTableTable.Location = new System.Drawing.Point(393, 12);
            this.dgwTableTable.MultiSelect = false;
            this.dgwTableTable.Name = "dgwTableTable";
            this.dgwTableTable.ReadOnly = true;
            this.dgwTableTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgwTableTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwTableTable.Size = new System.Drawing.Size(122, 711);
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
            this.dgwContentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwContentTable.Location = new System.Drawing.Point(552, 12);
            this.dgwContentTable.MultiSelect = false;
            this.dgwContentTable.Name = "dgwContentTable";
            this.dgwContentTable.ReadOnly = true;
            this.dgwContentTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwContentTable.Size = new System.Drawing.Size(347, 517);
            this.dgwContentTable.TabIndex = 12;
            this.dgwContentTable.SelectionChanged += new System.EventHandler(this.dgwContentTable_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(552, 535);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 188);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.bttnPay);
            this.panel3.Controls.Add(this.txtBill);
            this.panel3.Controls.Add(this.lblBillInfo);
            this.panel3.Location = new System.Drawing.Point(3, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(692, 80);
            this.panel3.TabIndex = 13;
            // 
            // bttnPay
            // 
            this.bttnPay.Location = new System.Drawing.Point(6, 53);
            this.bttnPay.Name = "bttnPay";
            this.bttnPay.Size = new System.Drawing.Size(681, 23);
            this.bttnPay.TabIndex = 2;
            this.bttnPay.Text = "PAY";
            this.bttnPay.UseVisualStyleBackColor = true;
            this.bttnPay.Click += new System.EventHandler(this.bttnPay_Click);
            // 
            // txtBill
            // 
            this.txtBill.Enabled = false;
            this.txtBill.Location = new System.Drawing.Point(6, 27);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(681, 20);
            this.txtBill.TabIndex = 15;
            // 
            // lblBillInfo
            // 
            this.lblBillInfo.AutoSize = true;
            this.lblBillInfo.Location = new System.Drawing.Point(290, 11);
            this.lblBillInfo.Name = "lblBillInfo";
            this.lblBillInfo.Size = new System.Drawing.Size(99, 13);
            this.lblBillInfo.TabIndex = 0;
            this.lblBillInfo.Text = "MAKE PAYEMENT";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.bttnTransfer);
            this.panel4.Controls.Add(this.txtName2);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(365, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(330, 80);
            this.panel4.TabIndex = 13;
            // 
            // bttnTransfer
            // 
            this.bttnTransfer.Location = new System.Drawing.Point(3, 52);
            this.bttnTransfer.Name = "bttnTransfer";
            this.bttnTransfer.Size = new System.Drawing.Size(321, 23);
            this.bttnTransfer.TabIndex = 2;
            this.bttnTransfer.Text = "TRANSFER";
            this.bttnTransfer.UseVisualStyleBackColor = true;
            this.bttnTransfer.Click += new System.EventHandler(this.bttnTransfer_Click);
            // 
            // txtName2
            // 
            this.txtName2.Enabled = false;
            this.txtName2.Location = new System.Drawing.Point(6, 26);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(318, 20);
            this.txtName2.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ITEM NAME";
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
            // dgwPayementTable
            // 
            this.dgwPayementTable.AllowDrop = true;
            this.dgwPayementTable.AllowUserToAddRows = false;
            this.dgwPayementTable.AllowUserToDeleteRows = false;
            this.dgwPayementTable.AllowUserToResizeColumns = false;
            this.dgwPayementTable.AllowUserToResizeRows = false;
            this.dgwPayementTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPayementTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgwPayementTable.Location = new System.Drawing.Point(905, 12);
            this.dgwPayementTable.MultiSelect = false;
            this.dgwPayementTable.Name = "dgwPayementTable";
            this.dgwPayementTable.ReadOnly = true;
            this.dgwPayementTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwPayementTable.Size = new System.Drawing.Size(347, 517);
            this.dgwPayementTable.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ITEM NAME";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ITEM PRICE";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ITEM COUNT";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 729);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgwPayementTable);
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPayementTable)).EndInit();
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bttnPay;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Label lblBillInfo;
        private System.Windows.Forms.DataGridView dgwPayementTable;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bttnTransfer;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}