
namespace Recreation_Center
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.mainPanel = new System.Windows.Forms.TabControl();
            this.visitors = new System.Windows.Forms.TabPage();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.cbSortBy = new System.Windows.Forms.ComboBox();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.btnEditRecord = new System.Windows.Forms.Button();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.dgvVisitors = new System.Windows.Forms.DataGridView();
            this.report = new System.Windows.Forms.TabPage();
            this.ticket = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVisitorPanel = new System.Windows.Forms.Button();
            this.btnReportPanel = new System.Windows.Forms.Button();
            this.btnTicketPanel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUserType = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ttClose = new System.Windows.Forms.ToolTip(this.components);
            this.lblDashboard = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.visitors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitors)).BeginInit();
            this.ticket.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.visitors);
            this.mainPanel.Controls.Add(this.report);
            this.mainPanel.Controls.Add(this.ticket);
            this.mainPanel.Location = new System.Drawing.Point(157, 70);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.SelectedIndex = 0;
            this.mainPanel.Size = new System.Drawing.Size(1102, 475);
            this.mainPanel.TabIndex = 1;
            // 
            // visitors
            // 
            this.visitors.Controls.Add(this.lblSortBy);
            this.visitors.Controls.Add(this.cbSortBy);
            this.visitors.Controls.Add(this.btnDeleteRecord);
            this.visitors.Controls.Add(this.btnEditRecord);
            this.visitors.Controls.Add(this.btnAddRecord);
            this.visitors.Controls.Add(this.btnSave);
            this.visitors.Controls.Add(this.btnImport);
            this.visitors.Controls.Add(this.dgvVisitors);
            this.visitors.Location = new System.Drawing.Point(4, 32);
            this.visitors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.visitors.Name = "visitors";
            this.visitors.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.visitors.Size = new System.Drawing.Size(1094, 439);
            this.visitors.TabIndex = 0;
            this.visitors.Text = "Visitors Record";
            this.visitors.UseVisualStyleBackColor = true;
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Location = new System.Drawing.Point(928, 11);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(55, 23);
            this.lblSortBy.TabIndex = 3;
            this.lblSortBy.Text = "Sort by";
            // 
            // cbSortBy
            // 
            this.cbSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSortBy.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSortBy.FormattingEnabled = true;
            this.cbSortBy.Items.AddRange(new object[] {
            "Name",
            "Date"});
            this.cbSortBy.Location = new System.Drawing.Point(988, 7);
            this.cbSortBy.Name = "cbSortBy";
            this.cbSortBy.Size = new System.Drawing.Size(99, 31);
            this.cbSortBy.TabIndex = 2;
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Location = new System.Drawing.Point(960, 392);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(125, 30);
            this.btnDeleteRecord.TabIndex = 1;
            this.btnDeleteRecord.Text = "Delete Record";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // btnEditRecord
            // 
            this.btnEditRecord.Location = new System.Drawing.Point(819, 392);
            this.btnEditRecord.Name = "btnEditRecord";
            this.btnEditRecord.Size = new System.Drawing.Size(125, 30);
            this.btnEditRecord.TabIndex = 1;
            this.btnEditRecord.Text = "Edit Record";
            this.btnEditRecord.UseVisualStyleBackColor = true;
            this.btnEditRecord.Click += new System.EventHandler(this.btnEditRecord_Click);
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(678, 392);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(125, 30);
            this.btnAddRecord.TabIndex = 1;
            this.btnAddRecord.Text = "Add Record";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(147, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 30);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(7, 9);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(125, 30);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "Import File";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // dgvVisitors
            // 
            this.dgvVisitors.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvVisitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisitors.Location = new System.Drawing.Point(7, 51);
            this.dgvVisitors.Name = "dgvVisitors";
            this.dgvVisitors.Size = new System.Drawing.Size(1080, 327);
            this.dgvVisitors.TabIndex = 0;
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(4, 32);
            this.report.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.report.Name = "report";
            this.report.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.report.Size = new System.Drawing.Size(945, 439);
            this.report.TabIndex = 1;
            this.report.Text = "Report";
            this.report.UseVisualStyleBackColor = true;
            // 
            // ticket
            // 
            this.ticket.Controls.Add(this.label3);
            this.ticket.Location = new System.Drawing.Point(4, 32);
            this.ticket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ticket.Name = "ticket";
            this.ticket.Size = new System.Drawing.Size(945, 439);
            this.ticket.TabIndex = 2;
            this.ticket.Text = "Ticket";
            this.ticket.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "customer data";
            // 
            // btnVisitorPanel
            // 
            this.btnVisitorPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitorPanel.Location = new System.Drawing.Point(9, 110);
            this.btnVisitorPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVisitorPanel.Name = "btnVisitorPanel";
            this.btnVisitorPanel.Size = new System.Drawing.Size(140, 56);
            this.btnVisitorPanel.TabIndex = 2;
            this.btnVisitorPanel.Text = "Visitors";
            this.btnVisitorPanel.UseVisualStyleBackColor = true;
            this.btnVisitorPanel.Click += new System.EventHandler(this.btnVisitorPanel_Click);
            // 
            // btnReportPanel
            // 
            this.btnReportPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportPanel.Location = new System.Drawing.Point(9, 176);
            this.btnReportPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReportPanel.Name = "btnReportPanel";
            this.btnReportPanel.Size = new System.Drawing.Size(140, 56);
            this.btnReportPanel.TabIndex = 2;
            this.btnReportPanel.Text = "Report";
            this.btnReportPanel.UseVisualStyleBackColor = true;
            this.btnReportPanel.Click += new System.EventHandler(this.btnReportPanel_Click);
            // 
            // btnTicketPanel
            // 
            this.btnTicketPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicketPanel.Location = new System.Drawing.Point(9, 242);
            this.btnTicketPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTicketPanel.Name = "btnTicketPanel";
            this.btnTicketPanel.Size = new System.Drawing.Size(140, 56);
            this.btnTicketPanel.TabIndex = 2;
            this.btnTicketPanel.Text = "Ticket";
            this.btnTicketPanel.UseVisualStyleBackColor = true;
            this.btnTicketPanel.Click += new System.EventHandler(this.btnTicketPanel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lblUserType);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1277, 69);
            this.panel1.TabIndex = 3;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.Location = new System.Drawing.Point(914, 32);
            this.lblUserType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(61, 22);
            this.lblUserType.TabIndex = 0;
            this.lblUserType.Text = "usertype";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(911, 14);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(89, 26);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "username";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Recreation_Center.Properties.Resources.user_icon_150670;
            this.pictureBox2.Location = new System.Drawing.Point(868, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // logo
            // 
            this.logo.Image = global::Recreation_Center.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(17, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(54, 47);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(77, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(501, 42);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Recreation Center Management System";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLogOut.BackgroundImage = global::Recreation_Center.Properties.Resources.logout;
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnLogOut.Location = new System.Drawing.Point(1005, 14);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLogOut.Size = new System.Drawing.Size(36, 36);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Gold;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(1123, 14);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 32);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ttClose.SetToolTip(this.btnMinimize, "Minimize");
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Snow;
            this.btnClose.Location = new System.Drawing.Point(1163, 14);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 0;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ttClose.SetToolTip(this.btnClose, "Close");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ttClose
            // 
            this.ttClose.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.Location = new System.Drawing.Point(12, 70);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(121, 34);
            this.lblDashboard.TabIndex = 2;
            this.lblDashboard.Text = "Dashboard";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1272, 627);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDashboard);
            this.Controls.Add(this.btnTicketPanel);
            this.Controls.Add(this.btnReportPanel);
            this.Controls.Add(this.btnVisitorPanel);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.mainPanel.ResumeLayout(false);
            this.visitors.ResumeLayout(false);
            this.visitors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitors)).EndInit();
            this.ticket.ResumeLayout(false);
            this.ticket.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainPanel;
        private System.Windows.Forms.TabPage visitors;
        private System.Windows.Forms.TabPage report;
        private System.Windows.Forms.TabPage ticket;
        private System.Windows.Forms.Button btnVisitorPanel;
        private System.Windows.Forms.Button btnReportPanel;
        private System.Windows.Forms.Button btnTicketPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.ToolTip ttClose;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.DataGridView dgvVisitors;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.Button btnEditRecord;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.ComboBox cbSortBy;
        private System.Windows.Forms.Label lblSortBy;
    }
}