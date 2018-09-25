namespace Gold_Wastage
{
    partial class CustomerWastageListing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnList = new System.Windows.Forms.Button();
            this.CmbItem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbCustomer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.DgvColCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvColItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvColCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvColWastage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Per = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvColMappingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnList);
            this.panel1.Controls.Add(this.CmbItem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CmbCustomer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 96);
            this.panel1.TabIndex = 1;
            // 
            // BtnList
            // 
            this.BtnList.Location = new System.Drawing.Point(703, 53);
            this.BtnList.Margin = new System.Windows.Forms.Padding(5);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(133, 34);
            this.BtnList.TabIndex = 4;
            this.BtnList.Text = "&List";
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // CmbItem
            // 
            this.CmbItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CmbItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbItem.DisplayMember = "ItemName";
            this.CmbItem.FormattingEnabled = true;
            this.CmbItem.Location = new System.Drawing.Point(80, 59);
            this.CmbItem.Margin = new System.Windows.Forms.Padding(5);
            this.CmbItem.Name = "CmbItem";
            this.CmbItem.Size = new System.Drawing.Size(613, 24);
            this.CmbItem.TabIndex = 3;
            this.CmbItem.ValueMember = "ItemID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item";
            // 
            // CmbCustomer
            // 
            this.CmbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CmbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbCustomer.DisplayMember = "CustomerName";
            this.CmbCustomer.FormattingEnabled = true;
            this.CmbCustomer.Location = new System.Drawing.Point(80, 18);
            this.CmbCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.CmbCustomer.Name = "CmbCustomer";
            this.CmbCustomer.Size = new System.Drawing.Size(613, 24);
            this.CmbCustomer.TabIndex = 1;
            this.CmbCustomer.ValueMember = "CustomerID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgvColCustomer,
            this.DgvColItem,
            this.DgvColCustomerID,
            this.DgvColWastage,
            this.Per,
            this.DgvColMappingID});
            this.grid.Location = new System.Drawing.Point(17, 128);
            this.grid.Margin = new System.Windows.Forms.Padding(5);
            this.grid.Name = "grid";
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(868, 414);
            this.grid.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BtnDelete);
            this.panel2.Controls.Add(this.BtnEdit);
            this.panel2.Controls.Add(this.BtnAdd);
            this.panel2.Location = new System.Drawing.Point(17, 551);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(868, 48);
            this.panel2.TabIndex = 3;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(728, 6);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(133, 34);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "&Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(585, 6);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(5);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(133, 34);
            this.BtnEdit.TabIndex = 1;
            this.BtnEdit.Text = "&Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(442, 6);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(133, 34);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "&Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // DgvColCustomer
            // 
            this.DgvColCustomer.DataPropertyName = "CustomerName";
            this.DgvColCustomer.HeaderText = "Customer";
            this.DgvColCustomer.Name = "DgvColCustomer";
            this.DgvColCustomer.ReadOnly = true;
            this.DgvColCustomer.Width = 206;
            // 
            // DgvColItem
            // 
            this.DgvColItem.DataPropertyName = "ItemName";
            this.DgvColItem.HeaderText = "Item";
            this.DgvColItem.Name = "DgvColItem";
            this.DgvColItem.ReadOnly = true;
            this.DgvColItem.Width = 207;
            // 
            // DgvColCustomerID
            // 
            this.DgvColCustomerID.DataPropertyName = "CustomerID";
            this.DgvColCustomerID.HeaderText = "CustomerID";
            this.DgvColCustomerID.Name = "DgvColCustomerID";
            this.DgvColCustomerID.ReadOnly = true;
            this.DgvColCustomerID.Visible = false;
            // 
            // DgvColWastage
            // 
            this.DgvColWastage.DataPropertyName = "Wastage";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N3";
            dataGridViewCellStyle1.NullValue = null;
            this.DgvColWastage.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvColWastage.HeaderText = "Wastage";
            this.DgvColWastage.Name = "DgvColWastage";
            this.DgvColWastage.ReadOnly = true;
            this.DgvColWastage.Width = 206;
            // 
            // Per
            // 
            this.Per.DataPropertyName = "Per";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N3";
            dataGridViewCellStyle2.NullValue = null;
            this.Per.DefaultCellStyle = dataGridViewCellStyle2;
            this.Per.HeaderText = "Per";
            this.Per.Name = "Per";
            this.Per.ReadOnly = true;
            this.Per.Width = 206;
            // 
            // DgvColMappingID
            // 
            this.DgvColMappingID.DataPropertyName = "MappingID";
            this.DgvColMappingID.HeaderText = "Mapping ID";
            this.DgvColMappingID.Name = "DgvColMappingID";
            this.DgvColMappingID.ReadOnly = true;
            this.DgvColMappingID.Visible = false;
            // 
            // CustomerWastageListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 607);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CustomerWastageListing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customer Wastage Listing";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.ComboBox CmbItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvColCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvColItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvColCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvColWastage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Per;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvColMappingID;
    }
}