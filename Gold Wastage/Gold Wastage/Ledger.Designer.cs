namespace Gold_Wastage
{
    partial class Ledger
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnList = new System.Windows.Forms.Button();
            this.CmbItem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbCustomer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.DgvColEntryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvColEntryNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvColEntryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvColCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvColItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvColInWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvColOutWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvColLoss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.DtFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DtTo = new System.Windows.Forms.DateTimePicker();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.BtnExportPDF = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.DtTo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.DtFrom);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BtnList);
            this.panel1.Controls.Add(this.CmbItem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CmbCustomer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 131);
            this.panel1.TabIndex = 3;
            // 
            // BtnList
            // 
            this.BtnList.Location = new System.Drawing.Point(928, 84);
            this.BtnList.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(102, 37);
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
            this.CmbItem.Location = new System.Drawing.Point(120, 58);
            this.CmbItem.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.CmbItem.Name = "CmbItem";
            this.CmbItem.Size = new System.Drawing.Size(772, 24);
            this.CmbItem.TabIndex = 3;
            this.CmbItem.ValueMember = "ItemID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
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
            this.CmbCustomer.Location = new System.Drawing.Point(120, 18);
            this.CmbCustomer.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.CmbCustomer.Name = "CmbCustomer";
            this.CmbCustomer.Size = new System.Drawing.Size(772, 24);
            this.CmbCustomer.TabIndex = 1;
            this.CmbCustomer.ValueMember = "CustomerID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
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
            this.DgvColEntryID,
            this.DgvColEntryNo,
            this.DgvColEntryDate,
            this.DgvColCustomer,
            this.DgvColItem,
            this.DgvColInWeight,
            this.DgvColOutWeight,
            this.DgvColLoss});
            this.grid.Location = new System.Drawing.Point(12, 146);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1039, 460);
            this.grid.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BtnExportPDF);
            this.panel2.Controls.Add(this.BtnPrint);
            this.panel2.Location = new System.Drawing.Point(12, 614);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1039, 48);
            this.panel2.TabIndex = 5;
            // 
            // BtnPrint
            // 
            this.BtnPrint.Location = new System.Drawing.Point(897, 6);
            this.BtnPrint.Margin = new System.Windows.Forms.Padding(5);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(133, 34);
            this.BtnPrint.TabIndex = 2;
            this.BtnPrint.Text = "&Print";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // DgvColEntryID
            // 
            this.DgvColEntryID.DataPropertyName = "CustomerEntryID";
            this.DgvColEntryID.HeaderText = "EntryID";
            this.DgvColEntryID.Name = "DgvColEntryID";
            this.DgvColEntryID.ReadOnly = true;
            this.DgvColEntryID.Visible = false;
            // 
            // DgvColEntryNo
            // 
            this.DgvColEntryNo.DataPropertyName = "EntryNo";
            this.DgvColEntryNo.HeaderText = "EntryNo";
            this.DgvColEntryNo.Name = "DgvColEntryNo";
            this.DgvColEntryNo.ReadOnly = true;
            this.DgvColEntryNo.Width = 150;
            // 
            // DgvColEntryDate
            // 
            this.DgvColEntryDate.DataPropertyName = "EntryDate";
            this.DgvColEntryDate.HeaderText = "Entry Date";
            this.DgvColEntryDate.Name = "DgvColEntryDate";
            this.DgvColEntryDate.ReadOnly = true;
            this.DgvColEntryDate.Width = 150;
            // 
            // DgvColCustomer
            // 
            this.DgvColCustomer.DataPropertyName = "CustomerName";
            this.DgvColCustomer.HeaderText = "Customer";
            this.DgvColCustomer.Name = "DgvColCustomer";
            this.DgvColCustomer.ReadOnly = true;
            this.DgvColCustomer.Width = 200;
            // 
            // DgvColItem
            // 
            this.DgvColItem.DataPropertyName = "ItemName";
            this.DgvColItem.HeaderText = "Item";
            this.DgvColItem.Name = "DgvColItem";
            this.DgvColItem.ReadOnly = true;
            this.DgvColItem.Width = 150;
            // 
            // DgvColInWeight
            // 
            this.DgvColInWeight.DataPropertyName = "inWeight";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N3";
            dataGridViewCellStyle1.NullValue = null;
            this.DgvColInWeight.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvColInWeight.HeaderText = "In Weight";
            this.DgvColInWeight.Name = "DgvColInWeight";
            this.DgvColInWeight.ReadOnly = true;
            // 
            // DgvColOutWeight
            // 
            this.DgvColOutWeight.DataPropertyName = "outWeight";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N3";
            dataGridViewCellStyle2.NullValue = null;
            this.DgvColOutWeight.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvColOutWeight.HeaderText = "Out Weight";
            this.DgvColOutWeight.Name = "DgvColOutWeight";
            this.DgvColOutWeight.ReadOnly = true;
            // 
            // DgvColLoss
            // 
            this.DgvColLoss.DataPropertyName = "loss";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N3";
            dataGridViewCellStyle3.NullValue = null;
            this.DgvColLoss.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvColLoss.HeaderText = "Loss";
            this.DgvColLoss.Name = "DgvColLoss";
            this.DgvColLoss.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "From Date";
            // 
            // DtFrom
            // 
            this.DtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtFrom.Location = new System.Drawing.Point(120, 99);
            this.DtFrom.Name = "DtFrom";
            this.DtFrom.Size = new System.Drawing.Size(200, 22);
            this.DtFrom.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "To Date";
            // 
            // DtTo
            // 
            this.DtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtTo.Location = new System.Drawing.Point(494, 99);
            this.DtTo.Name = "DtTo";
            this.DtTo.Size = new System.Drawing.Size(200, 22);
            this.DtTo.TabIndex = 8;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // BtnExportPDF
            // 
            this.BtnExportPDF.Location = new System.Drawing.Point(754, 6);
            this.BtnExportPDF.Margin = new System.Windows.Forms.Padding(5);
            this.BtnExportPDF.Name = "BtnExportPDF";
            this.BtnExportPDF.Size = new System.Drawing.Size(133, 34);
            this.BtnExportPDF.TabIndex = 3;
            this.BtnExportPDF.Text = "&Export to PDF";
            this.BtnExportPDF.UseVisualStyleBackColor = true;
            this.BtnExportPDF.Click += new System.EventHandler(this.BtnExportPDF_Click);
            // 
            // Ledger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 676);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Ledger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ledger";
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
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvColEntryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvColEntryNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvColEntryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvColCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvColItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvColInWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvColOutWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvColLoss;
        private System.Windows.Forms.DateTimePicker DtTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtFrom;
        private System.Windows.Forms.Label label3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button BtnExportPDF;
    }
}