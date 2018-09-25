namespace Gold_Wastage
{
    partial class Entry
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbInEntryno = new System.Windows.Forms.ComboBox();
            this.lblFromEntryNo = new System.Windows.Forms.Label();
            this.grpType = new System.Windows.Forms.GroupBox();
            this.radOut = new System.Windows.Forms.RadioButton();
            this.radIn = new System.Windows.Forms.RadioButton();
            this.txtEntryNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DtEntry = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbReceivedFrom = new System.Windows.Forms.ComboBox();
            this.CmbItem = new System.Windows.Forms.ComboBox();
            this.CmbCustomer = new System.Windows.Forms.ComboBox();
            this.lblReceivedFrom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.grpType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmbInEntryno);
            this.groupBox1.Controls.Add(this.lblFromEntryNo);
            this.groupBox1.Controls.Add(this.grpType);
            this.groupBox1.Controls.Add(this.txtEntryNo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.DtEntry);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtWeight);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CmbReceivedFrom);
            this.groupBox1.Controls.Add(this.CmbItem);
            this.groupBox1.Controls.Add(this.CmbCustomer);
            this.groupBox1.Controls.Add(this.lblReceivedFrom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnSave);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(555, 342);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // CmbInEntryno
            // 
            this.CmbInEntryno.DisplayMember = "EntryNo";
            this.CmbInEntryno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbInEntryno.FormattingEnabled = true;
            this.CmbInEntryno.Location = new System.Drawing.Point(127, 117);
            this.CmbInEntryno.Name = "CmbInEntryno";
            this.CmbInEntryno.Size = new System.Drawing.Size(404, 24);
            this.CmbInEntryno.TabIndex = 19;
            this.CmbInEntryno.ValueMember = "CustomerEntryID";
            this.CmbInEntryno.Visible = false;
            this.CmbInEntryno.SelectedIndexChanged += new System.EventHandler(this.CmbInEntryno_SelectedIndexChanged);
            // 
            // lblFromEntryNo
            // 
            this.lblFromEntryNo.AutoSize = true;
            this.lblFromEntryNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromEntryNo.Location = new System.Drawing.Point(15, 120);
            this.lblFromEntryNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFromEntryNo.Name = "lblFromEntryNo";
            this.lblFromEntryNo.Size = new System.Drawing.Size(93, 16);
            this.lblFromEntryNo.TabIndex = 18;
            this.lblFromEntryNo.Text = "From Entry No";
            this.lblFromEntryNo.Visible = false;
            // 
            // grpType
            // 
            this.grpType.Controls.Add(this.radOut);
            this.grpType.Controls.Add(this.radIn);
            this.grpType.Location = new System.Drawing.Point(320, 60);
            this.grpType.Name = "grpType";
            this.grpType.Size = new System.Drawing.Size(211, 42);
            this.grpType.TabIndex = 17;
            this.grpType.TabStop = false;
            // 
            // radOut
            // 
            this.radOut.AutoSize = true;
            this.radOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOut.Location = new System.Drawing.Point(145, 15);
            this.radOut.Name = "radOut";
            this.radOut.Size = new System.Drawing.Size(46, 20);
            this.radOut.TabIndex = 1;
            this.radOut.Text = "Out";
            this.radOut.UseVisualStyleBackColor = true;
            this.radOut.CheckedChanged += new System.EventHandler(this.radOut_CheckedChanged);
            // 
            // radIn
            // 
            this.radIn.AutoSize = true;
            this.radIn.Checked = true;
            this.radIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radIn.Location = new System.Drawing.Point(7, 15);
            this.radIn.Name = "radIn";
            this.radIn.Size = new System.Drawing.Size(36, 20);
            this.radIn.TabIndex = 0;
            this.radIn.TabStop = true;
            this.radIn.Text = "In";
            this.radIn.UseVisualStyleBackColor = true;
            // 
            // txtEntryNo
            // 
            this.txtEntryNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntryNo.Location = new System.Drawing.Point(127, 25);
            this.txtEntryNo.Name = "txtEntryNo";
            this.txtEntryNo.ReadOnly = true;
            this.txtEntryNo.Size = new System.Drawing.Size(404, 22);
            this.txtEntryNo.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Entry No";
            // 
            // DtEntry
            // 
            this.DtEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtEntry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtEntry.Location = new System.Drawing.Point(127, 71);
            this.DtEntry.Name = "DtEntry";
            this.DtEntry.Size = new System.Drawing.Size(175, 22);
            this.DtEntry.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Date";
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(127, 260);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtWeight.MaxLength = 200;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(404, 22);
            this.txtWeight.TabIndex = 11;
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 263);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Wastage *";
            // 
            // CmbReceivedFrom
            // 
            this.CmbReceivedFrom.DisplayMember = "ReceivedName";
            this.CmbReceivedFrom.FormattingEnabled = true;
            this.CmbReceivedFrom.Location = new System.Drawing.Point(127, 119);
            this.CmbReceivedFrom.Name = "CmbReceivedFrom";
            this.CmbReceivedFrom.Size = new System.Drawing.Size(404, 21);
            this.CmbReceivedFrom.TabIndex = 10;
            this.CmbReceivedFrom.ValueMember = "ReceivedCode";
            // 
            // CmbItem
            // 
            this.CmbItem.DisplayMember = "ItemName";
            this.CmbItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbItem.FormattingEnabled = true;
            this.CmbItem.Location = new System.Drawing.Point(127, 166);
            this.CmbItem.Name = "CmbItem";
            this.CmbItem.Size = new System.Drawing.Size(404, 24);
            this.CmbItem.TabIndex = 9;
            this.CmbItem.ValueMember = "ItemId";
            // 
            // CmbCustomer
            // 
            this.CmbCustomer.DisplayMember = "CustomerName";
            this.CmbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCustomer.FormattingEnabled = true;
            this.CmbCustomer.Location = new System.Drawing.Point(127, 212);
            this.CmbCustomer.Name = "CmbCustomer";
            this.CmbCustomer.Size = new System.Drawing.Size(404, 24);
            this.CmbCustomer.TabIndex = 8;
            this.CmbCustomer.ValueMember = "CustomerID";
            // 
            // lblReceivedFrom
            // 
            this.lblReceivedFrom.AutoSize = true;
            this.lblReceivedFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceivedFrom.Location = new System.Drawing.Point(15, 120);
            this.lblReceivedFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceivedFrom.Name = "lblReceivedFrom";
            this.lblReceivedFrom.Size = new System.Drawing.Size(101, 16);
            this.lblReceivedFrom.TabIndex = 6;
            this.lblReceivedFrom.Text = "Received From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Item";
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(431, 302);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(100, 28);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 213);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customer *";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 357);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Entry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Entry";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpType.ResumeLayout(false);
            this.grpType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblReceivedFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbItem;
        private System.Windows.Forms.ComboBox CmbCustomer;
        private System.Windows.Forms.ComboBox CmbReceivedFrom;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtEntry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEntryNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpType;
        private System.Windows.Forms.RadioButton radOut;
        private System.Windows.Forms.RadioButton radIn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblFromEntryNo;
        private System.Windows.Forms.ComboBox CmbInEntryno;
    }
}