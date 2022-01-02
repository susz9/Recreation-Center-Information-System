
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
            this.btnClearForm = new System.Windows.Forms.Button();
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
            this.lblEntryTime = new System.Windows.Forms.Label();
            this.lblExitTime = new System.Windows.Forms.Label();
            this.dtEntryTime = new System.Windows.Forms.DateTimePicker();
            this.dtExitTime = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvTicketList = new System.Windows.Forms.DataGridView();
            this.lblTicketType = new System.Windows.Forms.Label();
            this.cbTicketType = new System.Windows.Forms.ComboBox();
            this.lblTotalTIme = new System.Windows.Forms.Label();
            this.tbTotalTIme = new System.Windows.Forms.TextBox();
            this.chbDiscount = new System.Windows.Forms.CheckBox();
            this.gbVisitorDetails = new System.Windows.Forms.GroupBox();
            this.tbTicketNo = new System.Windows.Forms.TextBox();
            this.lblTicketNo = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.gbTicketRate = new System.Windows.Forms.GroupBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnUnload = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicketList)).BeginInit();
            this.gbVisitorDetails.SuspendLayout();
            this.gbTicketRate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClearForm
            // 
            this.btnClearForm.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearForm.Location = new System.Drawing.Point(383, 298);
            this.btnClearForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(125, 35);
            this.btnClearForm.TabIndex = 0;
            this.btnClearForm.Text = "Clear Form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(48, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name*";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(149, 40);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(151, 27);
            this.tbName.TabIndex = 1;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(48, 84);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(70, 23);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address*";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(149, 81);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(151, 27);
            this.tbAddress.TabIndex = 2;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(48, 126);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(79, 23);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Phone No.*";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(149, 122);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(151, 27);
            this.tbPhone.TabIndex = 3;
            this.tbPhone.TextChanged += new System.EventHandler(this.tbPhone_TextChanged);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(48, 166);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(64, 23);
            this.lblGender.TabIndex = 1;
            this.lblGender.Text = "Gender*";
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbGender.Location = new System.Drawing.Point(149, 163);
            this.cbGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(151, 31);
            this.cbGender.TabIndex = 4;
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "dd/MM/yyyy";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(499, 39);
            this.datePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datePicker.Name = "datePicker";
            this.datePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datePicker.Size = new System.Drawing.Size(151, 27);
            this.datePicker.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(389, 42);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(47, 23);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date*";
            // 
            // lblEntryTime
            // 
            this.lblEntryTime.AutoSize = true;
            this.lblEntryTime.Location = new System.Drawing.Point(389, 82);
            this.lblEntryTime.Name = "lblEntryTime";
            this.lblEntryTime.Size = new System.Drawing.Size(82, 23);
            this.lblEntryTime.TabIndex = 1;
            this.lblEntryTime.Text = "Entry Time*";
            // 
            // lblExitTime
            // 
            this.lblExitTime.AutoSize = true;
            this.lblExitTime.Location = new System.Drawing.Point(389, 125);
            this.lblExitTime.Name = "lblExitTime";
            this.lblExitTime.Size = new System.Drawing.Size(65, 23);
            this.lblExitTime.TabIndex = 1;
            this.lblExitTime.Text = "Exit TIme";
            // 
            // dtEntryTime
            // 
            this.dtEntryTime.CustomFormat = "hh:mm tt";
            this.dtEntryTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEntryTime.Location = new System.Drawing.Point(499, 80);
            this.dtEntryTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtEntryTime.Name = "dtEntryTime";
            this.dtEntryTime.Size = new System.Drawing.Size(151, 27);
            this.dtEntryTime.TabIndex = 5;
            this.dtEntryTime.Value = new System.DateTime(2022, 1, 1, 17, 30, 0, 0);
            // 
            // dtExitTime
            // 
            this.dtExitTime.CustomFormat = "hh:mm tt";
            this.dtExitTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtExitTime.Location = new System.Drawing.Point(499, 121);
            this.dtExitTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtExitTime.Name = "dtExitTime";
            this.dtExitTime.Size = new System.Drawing.Size(151, 27);
            this.dtExitTime.TabIndex = 5;
            this.dtExitTime.ValueChanged += new System.EventHandler(this.dtExitTime_ValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(525, 298);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 35);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save Record";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvTicketList
            // 
            this.dgvTicketList.AllowUserToAddRows = false;
            this.dgvTicketList.AllowUserToDeleteRows = false;
            this.dgvTicketList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicketList.Location = new System.Drawing.Point(6, 60);
            this.dgvTicketList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTicketList.MultiSelect = false;
            this.dgvTicketList.Name = "dgvTicketList";
            this.dgvTicketList.ReadOnly = true;
            this.dgvTicketList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTicketList.Size = new System.Drawing.Size(702, 189);
            this.dgvTicketList.TabIndex = 6;
            // 
            // lblTicketType
            // 
            this.lblTicketType.AutoSize = true;
            this.lblTicketType.Location = new System.Drawing.Point(48, 212);
            this.lblTicketType.Name = "lblTicketType";
            this.lblTicketType.Size = new System.Drawing.Size(88, 23);
            this.lblTicketType.TabIndex = 1;
            this.lblTicketType.Text = "Ticket Type*";
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
            this.cbTicketType.Location = new System.Drawing.Point(149, 209);
            this.cbTicketType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTicketType.Name = "cbTicketType";
            this.cbTicketType.Size = new System.Drawing.Size(151, 31);
            this.cbTicketType.TabIndex = 5;
            // 
            // lblTotalTIme
            // 
            this.lblTotalTIme.AutoSize = true;
            this.lblTotalTIme.Location = new System.Drawing.Point(389, 166);
            this.lblTotalTIme.Name = "lblTotalTIme";
            this.lblTotalTIme.Size = new System.Drawing.Size(76, 23);
            this.lblTotalTIme.TabIndex = 1;
            this.lblTotalTIme.Text = "Total Time";
            // 
            // tbTotalTIme
            // 
            this.tbTotalTIme.Location = new System.Drawing.Point(499, 166);
            this.tbTotalTIme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTotalTIme.Name = "tbTotalTIme";
            this.tbTotalTIme.ReadOnly = true;
            this.tbTotalTIme.Size = new System.Drawing.Size(151, 27);
            this.tbTotalTIme.TabIndex = 2;
            this.tbTotalTIme.Text = "0 hr";
            // 
            // chbDiscount
            // 
            this.chbDiscount.AutoSize = true;
            this.chbDiscount.Location = new System.Drawing.Point(482, 255);
            this.chbDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbDiscount.Name = "chbDiscount";
            this.chbDiscount.Size = new System.Drawing.Size(170, 27);
            this.chbDiscount.TabIndex = 9;
            this.chbDiscount.Text = "Holiday Discount(10%)";
            this.chbDiscount.UseVisualStyleBackColor = true;
            this.chbDiscount.CheckedChanged += new System.EventHandler(this.chbDiscount_CheckedChanged);
            // 
            // gbVisitorDetails
            // 
            this.gbVisitorDetails.BackColor = System.Drawing.SystemColors.Control;
            this.gbVisitorDetails.Controls.Add(this.chbDiscount);
            this.gbVisitorDetails.Controls.Add(this.tbTicketNo);
            this.gbVisitorDetails.Controls.Add(this.btnClearForm);
            this.gbVisitorDetails.Controls.Add(this.tbName);
            this.gbVisitorDetails.Controls.Add(this.lblTicketNo);
            this.gbVisitorDetails.Controls.Add(this.btnSave);
            this.gbVisitorDetails.Controls.Add(this.lblName);
            this.gbVisitorDetails.Controls.Add(this.dtExitTime);
            this.gbVisitorDetails.Controls.Add(this.dtEntryTime);
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
            this.gbVisitorDetails.Location = new System.Drawing.Point(16, 15);
            this.gbVisitorDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbVisitorDetails.Name = "gbVisitorDetails";
            this.gbVisitorDetails.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbVisitorDetails.Size = new System.Drawing.Size(714, 356);
            this.gbVisitorDetails.TabIndex = 1;
            this.gbVisitorDetails.TabStop = false;
            this.gbVisitorDetails.Text = "Visitor Details";
            // 
            // tbTicketNo
            // 
            this.tbTicketNo.Location = new System.Drawing.Point(149, 257);
            this.tbTicketNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTicketNo.Name = "tbTicketNo";
            this.tbTicketNo.Size = new System.Drawing.Size(151, 27);
            this.tbTicketNo.TabIndex = 2;
            // 
            // lblTicketNo
            // 
            this.lblTicketNo.AutoSize = true;
            this.lblTicketNo.Location = new System.Drawing.Point(48, 259);
            this.lblTicketNo.Name = "lblTicketNo";
            this.lblTicketNo.Size = new System.Drawing.Size(77, 23);
            this.lblTicketNo.TabIndex = 1;
            this.lblTicketNo.Text = "Ticket No.*";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(389, 215);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(89, 23);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Ticket Price*";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(499, 212);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(151, 27);
            this.tbPrice.TabIndex = 2;
            this.tbPrice.Click += new System.EventHandler(this.tbPrice_Click);
            this.tbPrice.TextChanged += new System.EventHandler(this.tbPrice_TextChanged);
            // 
            // gbTicketRate
            // 
            this.gbTicketRate.BackColor = System.Drawing.SystemColors.Control;
            this.gbTicketRate.Controls.Add(this.lblFileName);
            this.gbTicketRate.Controls.Add(this.btnUnload);
            this.gbTicketRate.Controls.Add(this.btnImport);
            this.gbTicketRate.Controls.Add(this.dgvTicketList);
            this.gbTicketRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbTicketRate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbTicketRate.Location = new System.Drawing.Point(16, 379);
            this.gbTicketRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbTicketRate.Name = "gbTicketRate";
            this.gbTicketRate.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbTicketRate.Size = new System.Drawing.Size(714, 257);
            this.gbTicketRate.TabIndex = 12;
            this.gbTicketRate.TabStop = false;
            this.gbTicketRate.Text = "Ticket Price Rate";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(16, 27);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(75, 23);
            this.lblFileName.TabIndex = 8;
            this.lblFileName.Text = "File name:";
            // 
            // btnUnload
            // 
            this.btnUnload.Location = new System.Drawing.Point(633, 23);
            this.btnUnload.Name = "btnUnload";
            this.btnUnload.Size = new System.Drawing.Size(75, 30);
            this.btnUnload.TabIndex = 7;
            this.btnUnload.Text = "Unload";
            this.btnUnload.UseVisualStyleBackColor = true;
            this.btnUnload.Click += new System.EventHandler(this.btnUnload_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(552, 23);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 30);
            this.btnImport.TabIndex = 7;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // AddRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(747, 645);
            this.Controls.Add(this.gbTicketRate);
            this.Controls.Add(this.gbVisitorDetails);
            this.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "AddRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Record";
            this.Load += new System.EventHandler(this.AddRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicketList)).EndInit();
            this.gbVisitorDetails.ResumeLayout(false);
            this.gbVisitorDetails.PerformLayout();
            this.gbTicketRate.ResumeLayout(false);
            this.gbTicketRate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClearForm;
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
        private System.Windows.Forms.Label lblEntryTime;
        private System.Windows.Forms.Label lblExitTime;
        private System.Windows.Forms.DateTimePicker dtEntryTime;
        private System.Windows.Forms.DateTimePicker dtExitTime;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvTicketList;
        private System.Windows.Forms.ComboBox cbTicketType;
        private System.Windows.Forms.Label lblTicketType;
        private System.Windows.Forms.Label lblTotalTIme;
        private System.Windows.Forms.TextBox tbTotalTIme;
        private System.Windows.Forms.CheckBox chbDiscount;
        private System.Windows.Forms.GroupBox gbVisitorDetails;
        private System.Windows.Forms.GroupBox gbTicketRate;
        private System.Windows.Forms.TextBox tbTicketNo;
        private System.Windows.Forms.Label lblTicketNo;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Button btnUnload;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label lblFileName;
    }
}