namespace Gold_Wastage
{
    partial class CustomerListing
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbCustomer = new System.Windows.Forms.ComboBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbMobile = new System.Windows.Forms.ComboBox();
            this.BtnList = new System.Windows.Forms.Button();
            this.DgvColCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvColMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvColCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnList);
            this.panel1.Controls.Add(this.CmbMobile);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CmbCustomer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 92);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            // 
            // CmbCustomer
            // 
            this.CmbCustomer.DisplayMember = "CustomerName";
            this.CmbCustomer.FormattingEnabled = true;
            this.CmbCustomer.Location = new System.Drawing.Point(97, 15);
            this.CmbCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbCustomer.Name = "CmbCustomer";
            this.CmbCustomer.Size = new System.Drawing.Size(461, 24);
            this.CmbCustomer.TabIndex = 1;
            this.CmbCustomer.ValueMember = "CustomerID";
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgvColCustomer,
            this.DgvColMobile,
            this.DgvColCustomerID,
            this.DgvColEmail});
            this.grid.Location = new System.Drawing.Point(17, 114);
            this.grid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grid.Name = "grid";
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(891, 336);
            this.grid.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BtnDelete);
            this.panel2.Controls.Add(this.BtnEdit);
            this.panel2.Controls.Add(this.BtnAdd);
            this.panel2.Location = new System.Drawing.Point(16, 458);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(891, 39);
            this.panel2.TabIndex = 2;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(559, 5);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(100, 28);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "&Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(667, 5);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(100, 28);
            this.BtnEdit.TabIndex = 1;
            this.BtnEdit.Text = "&Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(775, 5);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(100, 28);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "&Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mobile";
            // 
            // CmbMobile
            // 
            this.CmbMobile.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CmbMobile.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbMobile.DisplayMember = "Mobile";
            this.CmbMobile.FormattingEnabled = true;
            this.CmbMobile.Location = new System.Drawing.Point(97, 57);
            this.CmbMobile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbMobile.Name = "CmbMobile";
            this.CmbMobile.Size = new System.Drawing.Size(461, 24);
            this.CmbMobile.TabIndex = 3;
            this.CmbMobile.ValueMember = "CustomerID";
            // 
            // BtnList
            // 
            this.BtnList.Location = new System.Drawing.Point(775, 54);
            this.BtnList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(100, 28);
            this.BtnList.TabIndex = 4;
            this.BtnList.Text = "&List";
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // DgvColCustomer
            // 
            this.DgvColCustomer.DataPropertyName = "CustomerName";
            this.DgvColCustomer.HeaderText = "Customer";
            this.DgvColCustomer.Name = "DgvColCustomer";
            this.DgvColCustomer.ReadOnly = true;
            this.DgvColCustomer.Width = 300;
            // 
            // DgvColMobile
            // 
            this.DgvColMobile.DataPropertyName = "Mobile";
            this.DgvColMobile.HeaderText = "Mobile";
            this.DgvColMobile.Name = "DgvColMobile";
            this.DgvColMobile.ReadOnly = true;
            this.DgvColMobile.Width = 250;
            // 
            // DgvColCustomerID
            // 
            this.DgvColCustomerID.DataPropertyName = "CustomerID";
            this.DgvColCustomerID.HeaderText = "CustomerID";
            this.DgvColCustomerID.Name = "DgvColCustomerID";
            this.DgvColCustomerID.ReadOnly = true;
            this.DgvColCustomerID.Visible = false;
            // 
            // DgvColEmail
            // 
            this.DgvColEmail.DataPropertyName = "Email";
            this.DgvColEmail.HeaderText = "Email";
            this.DgvColEmail.Name = "DgvColEmail";
            this.DgvColEmail.ReadOnly = true;
            this.DgvColEmail.Width = 200;
            // 
            // CustomerListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 505);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "CustomerListing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customer Listing";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbCustomer;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ComboBox CmbMobile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvColCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvColMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvColCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvColEmail;
    }
}