
namespace Recreation_Center
{
    partial class AddRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRecord));
            this.btnBill = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.tbTotalAmount = new System.Windows.Forms.TextBox();
            this.lblEntryTime = new System.Windows.Forms.Label();
            this.lblExitTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.entryTime = new System.Windows.Forms.DateTimePicker();
            this.exitTime = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblTicketType = new System.Windows.Forms.Label();
            this.cbTicketType = new System.Windows.Forms.ComboBox();
            this.lblTotalTIme = new System.Windows.Forms.Label();
            this.tbTotalTIme = new System.Windows.Forms.TextBox();
            this.chbDiscount = new System.Windows.Forms.CheckBox();
            this.gbVisitorDetails = new System.Windows.Forms.GroupBox();
            this.tbTicketNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbVisitorDetails.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBill
            // 
            this.btnBill.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.Location = new System.Drawing.Point(744, 262);
            this.btnBill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(125, 36);
            this.btnBill.TabIndex = 0;
            this.btnBill.Text = "Calculate Bill";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(112, 40);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(151, 27);
            this.tbName.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(25, 84);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 23);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(112, 81);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(151, 27);
            this.tbAddress.TabIndex = 2;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(25, 125);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(73, 23);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Phone No.";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(112, 122);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(151, 27);
            this.tbPhone.TabIndex = 2;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(25, 166);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(58, 23);
            this.lblGender.TabIndex = 1;
            this.lblGender.Text = "Gender";
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbGender.Location = new System.Drawing.Point(112, 163);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(151, 31);
            this.cbGender.TabIndex = 3;
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(423, 40);
            this.datePicker.Name = "datePicker";
            this.datePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datePicker.Size = new System.Drawing.Size(151, 27);
            this.datePicker.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(321, 43);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 23);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(321, 259);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(96, 23);
            this.lblTotalAmount.TabIndex = 1;
            this.lblTotalAmount.Text = "Total Amount";
            this.lblTotalAmount.Click += new System.EventHandler(this.lblTotalPrice_Click);
            // 
            // tbTotalAmount
            // 
            this.tbTotalAmount.Location = new System.Drawing.Point(423, 256);
            this.tbTotalAmount.Name = "tbTotalAmount";
            this.tbTotalAmount.ReadOnly = true;
            this.tbTotalAmount.Size = new System.Drawing.Size(151, 27);
            this.tbTotalAmount.TabIndex = 2;
            this.tbTotalAmount.TextChanged += new System.EventHandler(this.tbTotalPrice_TextChanged);
            // 
            // lblEntryTime
            // 
            this.lblEntryTime.AutoSize = true;
            this.lblEntryTime.Location = new System.Drawing.Point(321, 84);
            this.lblEntryTime.Name = "lblEntryTime";
            this.lblEntryTime.Size = new System.Drawing.Size(76, 23);
            this.lblEntryTime.TabIndex = 1;
            this.lblEntryTime.Text = "Entry Time";
            // 
            // lblExitTime
            // 
            this.lblExitTime.AutoSize = true;
            this.lblExitTime.Location = new System.Drawing.Point(321, 125);
            this.lblExitTime.Name = "lblExitTime";
            this.lblExitTime.Size = new System.Drawing.Size(65, 23);
            this.lblExitTime.TabIndex = 1;
            this.lblExitTime.Text = "Exit TIme";
            this.lblExitTime.Click += new System.EventHandler(this.lblExitTime_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(830, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "time";
            this.label1.Click += new System.EventHandler(this.lblExitTime_Click);
            // 
            // entryTime
            // 
            this.entryTime.CustomFormat = "hh:mm tt";
            this.entryTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.entryTime.Location = new System.Drawing.Point(423, 80);
            this.entryTime.Name = "entryTime";
            this.entryTime.Size = new System.Drawing.Size(151, 27);
            this.entryTime.TabIndex = 5;
            // 
            // exitTime
            // 
            this.exitTime.CustomFormat = "hh:mm tt";
            this.exitTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.exitTime.Location = new System.Drawing.Point(423, 121);
            this.exitTime.Name = "exitTime";
            this.exitTime.Size = new System.Drawing.Size(151, 27);
            this.exitTime.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(449, 299);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 36);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save Record";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Age",
            "Days",
            "Group"});
            this.comboBox1.Location = new System.Drawing.Point(445, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 31);
            this.comboBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(590, 226);
            this.dataGridView1.TabIndex = 6;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(368, 18);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(71, 23);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "Category";
            // 
            // lblTicketType
            // 
            this.lblTicketType.AutoSize = true;
            this.lblTicketType.Location = new System.Drawing.Point(25, 212);
            this.lblTicketType.Name = "lblTicketType";
            this.lblTicketType.Size = new System.Drawing.Size(82, 23);
            this.lblTicketType.TabIndex = 1;
            this.lblTicketType.Text = "Ticket Type";
            // 
            // cbTicketType
            // 
            this.cbTicketType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTicketType.FormattingEnabled = true;
            this.cbTicketType.Items.AddRange(new object[] {
            "Child",
            "Adult",
            "Group of 5",
            "Group of 10",
            "Group of 15"});
            this.cbTicketType.Location = new System.Drawing.Point(112, 209);
            this.cbTicketType.Name = "cbTicketType";
            this.cbTicketType.Size = new System.Drawing.Size(151, 31);
            this.cbTicketType.TabIndex = 3;
            // 
            // lblTotalTIme
            // 
            this.lblTotalTIme.AutoSize = true;
            this.lblTotalTIme.Location = new System.Drawing.Point(321, 167);
            this.lblTotalTIme.Name = "lblTotalTIme";
            this.lblTotalTIme.Size = new System.Drawing.Size(76, 23);
            this.lblTotalTIme.TabIndex = 1;
            this.lblTotalTIme.Text = "Total Time";
            // 
            // tbTotalTIme
            // 
            this.tbTotalTIme.Location = new System.Drawing.Point(423, 167);
            this.tbTotalTIme.Name = "tbTotalTIme";
            this.tbTotalTIme.ReadOnly = true;
            this.tbTotalTIme.Size = new System.Drawing.Size(151, 27);
            this.tbTotalTIme.TabIndex = 2;
            // 
            // chbDiscount
            // 
            this.chbDiscount.AutoSize = true;
            this.chbDiscount.Location = new System.Drawing.Point(112, 289);
            this.chbDiscount.Name = "chbDiscount";
            this.chbDiscount.Size = new System.Drawing.Size(166, 27);
            this.chbDiscount.TabIndex = 9;
            this.chbDiscount.Text = "Holiday Discount(5%)";
            this.chbDiscount.UseVisualStyleBackColor = true;
            this.chbDiscount.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // gbVisitorDetails
            // 
            this.gbVisitorDetails.BackColor = System.Drawing.SystemColors.Control;
            this.gbVisitorDetails.Controls.Add(this.chbDiscount);
            this.gbVisitorDetails.Controls.Add(this.tbTicketNo);
            this.gbVisitorDetails.Controls.Add(this.tbName);
            this.gbVisitorDetails.Controls.Add(this.label2);
            this.gbVisitorDetails.Controls.Add(this.btnSave);
            this.gbVisitorDetails.Controls.Add(this.lblName);
            this.gbVisitorDetails.Controls.Add(this.exitTime);
            this.gbVisitorDetails.Controls.Add(this.entryTime);
            this.gbVisitorDetails.Controls.Add(this.tbTotalAmount);
            this.gbVisitorDetails.Controls.Add(this.datePicker);
            this.gbVisitorDetails.Controls.Add(this.lblTotalTIme);
            this.gbVisitorDetails.Controls.Add(this.tbTotalTIme);
            this.gbVisitorDetails.Controls.Add(this.cbTicketType);
            this.gbVisitorDetails.Controls.Add(this.lblEntryTime);
            this.gbVisitorDetails.Controls.Add(this.cbGender);
            this.gbVisitorDetails.Controls.Add(this.lblExitTime);
            this.gbVisitorDetails.Controls.Add(this.lblTicketType);
            this.gbVisitorDetails.Controls.Add(this.lblPrice);
            this.gbVisitorDetails.Controls.Add(this.lblPhone);
            this.gbVisitorDetails.Controls.Add(this.lblDate);
            this.gbVisitorDetails.Controls.Add(this.lblAddress);
            this.gbVisitorDetails.Controls.Add(this.lblGender);
            this.gbVisitorDetails.Controls.Add(this.tbPrice);
            this.gbVisitorDetails.Controls.Add(this.tbPhone);
            this.gbVisitorDetails.Controls.Add(this.tbAddress);
            this.gbVisitorDetails.Controls.Add(this.lblTotalAmount);
            this.gbVisitorDetails.Location = new System.Drawing.Point(16, 15);
            this.gbVisitorDetails.Name = "gbVisitorDetails";
            this.gbVisitorDetails.Size = new System.Drawing.Size(602, 355);
            this.gbVisitorDetails.TabIndex = 11;
            this.gbVisitorDetails.TabStop = false;
            this.gbVisitorDetails.Text = "Visitor Details";
            // 
            // tbTicketNo
            // 
            this.tbTicketNo.Location = new System.Drawing.Point(112, 256);
            this.tbTicketNo.Name = "tbTicketNo";
            this.tbTicketNo.Size = new System.Drawing.Size(151, 27);
            this.tbTicketNo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ticket No.";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.lblCategory);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(16, 392);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 284);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ticket Price Rate";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(423, 213);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(151, 27);
            this.tbPrice.TabIndex = 2;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(321, 216);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(83, 23);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Ticket Price";
            // 
            // AddRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(940, 688);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.gbVisitorDetails);
            this.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "AddRecord";
            this.Text = "Add Record";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbVisitorDetails.ResumeLayout(false);
            this.gbVisitorDetails.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox tbTotalAmount;
        private System.Windows.Forms.Label lblEntryTime;
        private System.Windows.Forms.Label lblExitTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker entryTime;
        private System.Windows.Forms.DateTimePicker exitTime;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbTicketType;
        private System.Windows.Forms.Label lblTicketType;
        private System.Windows.Forms.Label lblTotalTIme;
        private System.Windows.Forms.TextBox tbTotalTIme;
        private System.Windows.Forms.CheckBox chbDiscount;
        private System.Windows.Forms.GroupBox gbVisitorDetails;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbTicketNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox tbPrice;
    }
}