
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.tcReport = new System.Windows.Forms.TabControl();
            this.tpDaily = new System.Windows.Forms.TabPage();
            this.btnGenerateDaily = new System.Windows.Forms.Button();
            this.lblDailyTitle = new System.Windows.Forms.Label();
            this.dailyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tpWeekly = new System.Windows.Forms.TabPage();
            this.lblWeeklyEarning = new System.Windows.Forms.Label();
            this.lblWeeklyVisitor = new System.Windows.Forms.Label();
            this.btnGenerateWeekly = new System.Windows.Forms.Button();
            this.weeklyChartEarning = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.weeklyChartVisitor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ticket = new System.Windows.Forms.TabPage();
            this.dgvTicket = new System.Windows.Forms.DataGridView();
            this.btnVisitorPanel = new System.Windows.Forms.Button();
            this.btnReportPanel = new System.Windows.Forms.Button();
            this.btnTicketPanel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUserType = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.ttClose = new System.Windows.Forms.ToolTip(this.components);
            this.lblDashboard = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.visitors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitors)).BeginInit();
            this.report.SuspendLayout();
            this.tcReport.SuspendLayout();
            this.tpDaily.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dailyChart)).BeginInit();
            this.tpWeekly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyChartEarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyChartVisitor)).BeginInit();
            this.ticket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.visitors);
            this.mainPanel.Controls.Add(this.report);
            this.mainPanel.Controls.Add(this.ticket);
            this.mainPanel.Location = new System.Drawing.Point(137, 67);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.SelectedIndex = 0;
            this.mainPanel.Size = new System.Drawing.Size(1126, 581);
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
            this.visitors.Location = new System.Drawing.Point(4, 31);
            this.visitors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.visitors.Name = "visitors";
            this.visitors.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.visitors.Size = new System.Drawing.Size(1118, 546);
            this.visitors.TabIndex = 0;
            this.visitors.Text = "Visitors Record";
            this.visitors.UseVisualStyleBackColor = true;
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Location = new System.Drawing.Point(809, 11);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(51, 22);
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
            this.cbSortBy.Location = new System.Drawing.Point(861, 7);
            this.cbSortBy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSortBy.Name = "cbSortBy";
            this.cbSortBy.Size = new System.Drawing.Size(87, 31);
            this.cbSortBy.TabIndex = 2;
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Location = new System.Drawing.Point(839, 502);
            this.btnDeleteRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(109, 29);
            this.btnDeleteRecord.TabIndex = 1;
            this.btnDeleteRecord.Text = "Delete Record";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // btnEditRecord
            // 
            this.btnEditRecord.Location = new System.Drawing.Point(716, 502);
            this.btnEditRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditRecord.Name = "btnEditRecord";
            this.btnEditRecord.Size = new System.Drawing.Size(109, 29);
            this.btnEditRecord.TabIndex = 1;
            this.btnEditRecord.Text = "Edit Record";
            this.btnEditRecord.UseVisualStyleBackColor = true;
            this.btnEditRecord.Click += new System.EventHandler(this.btnEditRecord_Click);
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(593, 502);
            this.btnAddRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(109, 29);
            this.btnAddRecord.TabIndex = 1;
            this.btnAddRecord.Text = "Add Record";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(129, 8);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 29);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(6, 8);
            this.btnImport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(109, 29);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "Import File";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // dgvVisitors
            // 
            this.dgvVisitors.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvVisitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVisitors.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVisitors.Location = new System.Drawing.Point(6, 49);
            this.dgvVisitors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvVisitors.Name = "dgvVisitors";
            this.dgvVisitors.Size = new System.Drawing.Size(945, 439);
            this.dgvVisitors.TabIndex = 0;
            // 
            // report
            // 
            this.report.Controls.Add(this.tcReport);
            this.report.Location = new System.Drawing.Point(4, 31);
            this.report.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.report.Name = "report";
            this.report.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.report.Size = new System.Drawing.Size(1118, 546);
            this.report.TabIndex = 1;
            this.report.Text = "Report";
            this.report.UseVisualStyleBackColor = true;
            // 
            // tcReport
            // 
            this.tcReport.Controls.Add(this.tpDaily);
            this.tcReport.Controls.Add(this.tpWeekly);
            this.tcReport.Location = new System.Drawing.Point(3, 3);
            this.tcReport.Name = "tcReport";
            this.tcReport.SelectedIndex = 0;
            this.tcReport.Size = new System.Drawing.Size(1115, 540);
            this.tcReport.TabIndex = 1;
            // 
            // tpDaily
            // 
            this.tpDaily.Controls.Add(this.btnGenerateDaily);
            this.tpDaily.Controls.Add(this.lblDailyTitle);
            this.tpDaily.Controls.Add(this.dailyChart);
            this.tpDaily.Location = new System.Drawing.Point(4, 31);
            this.tpDaily.Name = "tpDaily";
            this.tpDaily.Padding = new System.Windows.Forms.Padding(3);
            this.tpDaily.Size = new System.Drawing.Size(1107, 505);
            this.tpDaily.TabIndex = 0;
            this.tpDaily.Text = "Daily Report";
            this.tpDaily.UseVisualStyleBackColor = true;
            // 
            // btnGenerateDaily
            // 
            this.btnGenerateDaily.Location = new System.Drawing.Point(972, 415);
            this.btnGenerateDaily.Name = "btnGenerateDaily";
            this.btnGenerateDaily.Size = new System.Drawing.Size(114, 33);
            this.btnGenerateDaily.TabIndex = 2;
            this.btnGenerateDaily.Text = "Generate Chart";
            this.btnGenerateDaily.UseVisualStyleBackColor = true;
            this.btnGenerateDaily.Click += new System.EventHandler(this.btnGenerateDaily_Click);
            // 
            // lblDailyTitle
            // 
            this.lblDailyTitle.AutoSize = true;
            this.lblDailyTitle.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDailyTitle.Location = new System.Drawing.Point(460, 3);
            this.lblDailyTitle.Name = "lblDailyTitle";
            this.lblDailyTitle.Size = new System.Drawing.Size(158, 28);
            this.lblDailyTitle.TabIndex = 2;
            this.lblDailyTitle.Text = "Number of visitors ";
            // 
            // dailyChart
            // 
            chartArea1.Name = "ChartArea1";
            this.dailyChart.ChartAreas.Add(chartArea1);
            this.dailyChart.Location = new System.Drawing.Point(135, 6);
            this.dailyChart.Name = "dailyChart";
            this.dailyChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Name = "Number of visitors";
            this.dailyChart.Series.Add(series1);
            this.dailyChart.Size = new System.Drawing.Size(790, 498);
            this.dailyChart.TabIndex = 0;
            this.dailyChart.Text = "Number of Visitors";
            // 
            // tpWeekly
            // 
            this.tpWeekly.Controls.Add(this.lblWeeklyEarning);
            this.tpWeekly.Controls.Add(this.lblWeeklyVisitor);
            this.tpWeekly.Controls.Add(this.btnGenerateWeekly);
            this.tpWeekly.Controls.Add(this.weeklyChartEarning);
            this.tpWeekly.Controls.Add(this.weeklyChartVisitor);
            this.tpWeekly.Location = new System.Drawing.Point(4, 31);
            this.tpWeekly.Name = "tpWeekly";
            this.tpWeekly.Padding = new System.Windows.Forms.Padding(3);
            this.tpWeekly.Size = new System.Drawing.Size(1107, 505);
            this.tpWeekly.TabIndex = 1;
            this.tpWeekly.Text = "Weekly Report";
            this.tpWeekly.UseVisualStyleBackColor = true;
            // 
            // lblWeeklyEarning
            // 
            this.lblWeeklyEarning.AutoSize = true;
            this.lblWeeklyEarning.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeeklyEarning.Location = new System.Drawing.Point(244, 9);
            this.lblWeeklyEarning.Name = "lblWeeklyEarning";
            this.lblWeeklyEarning.Size = new System.Drawing.Size(126, 28);
            this.lblWeeklyEarning.TabIndex = 4;
            this.lblWeeklyEarning.Text = "Total earnings";
            // 
            // lblWeeklyVisitor
            // 
            this.lblWeeklyVisitor.AutoSize = true;
            this.lblWeeklyVisitor.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeeklyVisitor.Location = new System.Drawing.Point(736, 9);
            this.lblWeeklyVisitor.Name = "lblWeeklyVisitor";
            this.lblWeeklyVisitor.Size = new System.Drawing.Size(158, 28);
            this.lblWeeklyVisitor.TabIndex = 4;
            this.lblWeeklyVisitor.Text = "Number of visitors ";
            // 
            // btnGenerateWeekly
            // 
            this.btnGenerateWeekly.Location = new System.Drawing.Point(972, 415);
            this.btnGenerateWeekly.Name = "btnGenerateWeekly";
            this.btnGenerateWeekly.Size = new System.Drawing.Size(114, 33);
            this.btnGenerateWeekly.TabIndex = 3;
            this.btnGenerateWeekly.Text = "Generate Chart";
            this.btnGenerateWeekly.UseVisualStyleBackColor = true;
            this.btnGenerateWeekly.Click += new System.EventHandler(this.btnGenerateWeekly_Click);
            // 
            // weeklyChartEarning
            // 
            chartArea2.Name = "ChartArea1";
            this.weeklyChartEarning.ChartAreas.Add(chartArea2);
            this.weeklyChartEarning.Location = new System.Drawing.Point(1, 20);
            this.weeklyChartEarning.Name = "weeklyChartEarning";
            this.weeklyChartEarning.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Name = "Earnings";
            this.weeklyChartEarning.Series.Add(series2);
            this.weeklyChartEarning.Size = new System.Drawing.Size(612, 479);
            this.weeklyChartEarning.TabIndex = 0;
            // 
            // weeklyChartVisitor
            // 
            chartArea3.Name = "ChartArea1";
            this.weeklyChartVisitor.ChartAreas.Add(chartArea3);
            legend1.Name = "Legend1";
            this.weeklyChartVisitor.Legends.Add(legend1);
            this.weeklyChartVisitor.Location = new System.Drawing.Point(656, 3);
            this.weeklyChartVisitor.Name = "weeklyChartVisitor";
            this.weeklyChartVisitor.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.Legend = "Legend1";
            series3.Name = "Visitors";
            series3.YValuesPerPoint = 2;
            this.weeklyChartVisitor.Series.Add(series3);
            this.weeklyChartVisitor.Size = new System.Drawing.Size(448, 445);
            this.weeklyChartVisitor.TabIndex = 0;
            // 
            // ticket
            // 
            this.ticket.Controls.Add(this.dgvTicket);
            this.ticket.Location = new System.Drawing.Point(4, 31);
            this.ticket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ticket.Name = "ticket";
            this.ticket.Size = new System.Drawing.Size(1118, 546);
            this.ticket.TabIndex = 2;
            this.ticket.Text = "Ticket";
            this.ticket.UseVisualStyleBackColor = true;
            // 
            // dgvTicket
            // 
            this.dgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicket.Location = new System.Drawing.Point(3, 7);
            this.dgvTicket.Name = "dgvTicket";
            this.dgvTicket.Size = new System.Drawing.Size(948, 385);
            this.dgvTicket.TabIndex = 0;
            // 
            // btnVisitorPanel
            // 
            this.btnVisitorPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitorPanel.Location = new System.Drawing.Point(10, 104);
            this.btnVisitorPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVisitorPanel.Name = "btnVisitorPanel";
            this.btnVisitorPanel.Size = new System.Drawing.Size(122, 54);
            this.btnVisitorPanel.TabIndex = 2;
            this.btnVisitorPanel.Text = "Visitors";
            this.btnVisitorPanel.UseVisualStyleBackColor = true;
            this.btnVisitorPanel.Click += new System.EventHandler(this.btnVisitorPanel_Click);
            // 
            // btnReportPanel
            // 
            this.btnReportPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportPanel.Location = new System.Drawing.Point(10, 167);
            this.btnReportPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReportPanel.Name = "btnReportPanel";
            this.btnReportPanel.Size = new System.Drawing.Size(122, 54);
            this.btnReportPanel.TabIndex = 2;
            this.btnReportPanel.Text = "Report";
            this.btnReportPanel.UseVisualStyleBackColor = true;
            this.btnReportPanel.Click += new System.EventHandler(this.btnReportPanel_Click);
            // 
            // btnTicketPanel
            // 
            this.btnTicketPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicketPanel.Location = new System.Drawing.Point(10, 231);
            this.btnTicketPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTicketPanel.Name = "btnTicketPanel";
            this.btnTicketPanel.Size = new System.Drawing.Size(122, 54);
            this.btnTicketPanel.TabIndex = 2;
            this.btnTicketPanel.Text = "Ticket";
            this.btnTicketPanel.UseVisualStyleBackColor = true;
            this.btnTicketPanel.Click += new System.EventHandler(this.btnTicketPanel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lblUserType);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1267, 66);
            this.panel1.TabIndex = 3;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.Location = new System.Drawing.Point(1029, 30);
            this.lblUserType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(61, 22);
            this.lblUserType.TabIndex = 0;
            this.lblUserType.Text = "usertype";
            this.lblUserType.Click += new System.EventHandler(this.lblUserType_Click);
            // 
            // logo
            // 
            this.logo.Image = global::Recreation_Center.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(15, 11);
            this.logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(47, 45);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(67, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(477, 42);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Recreation Center Information System";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(1027, 11);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(89, 26);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "username";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Gold;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(1189, 14);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(28, 30);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ttClose.SetToolTip(this.btnMinimize, "Minimize");
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Recreation_Center.Properties.Resources.user_icon_150670;
            this.pictureBox2.Location = new System.Drawing.Point(990, 14);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Snow;
            this.btnClose.Location = new System.Drawing.Point(1225, 14);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ttClose.SetToolTip(this.btnClose, "Close");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLogOut.BackgroundImage = global::Recreation_Center.Properties.Resources.logout;
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnLogOut.Location = new System.Drawing.Point(1124, 14);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLogOut.Size = new System.Drawing.Size(30, 33);
            this.btnLogOut.TabIndex = 1;
            this.ttClose.SetToolTip(this.btnLogOut, "Log out");
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // ttClose
            // 
            this.ttClose.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.Location = new System.Drawing.Point(10, 67);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(121, 34);
            this.lblDashboard.TabIndex = 2;
            this.lblDashboard.Text = "Dashboard";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1262, 651);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDashboard);
            this.Controls.Add(this.btnTicketPanel);
            this.Controls.Add(this.btnReportPanel);
            this.Controls.Add(this.btnVisitorPanel);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.report.ResumeLayout(false);
            this.tcReport.ResumeLayout(false);
            this.tpDaily.ResumeLayout(false);
            this.tpDaily.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dailyChart)).EndInit();
            this.tpWeekly.ResumeLayout(false);
            this.tpWeekly.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyChartEarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyChartVisitor)).EndInit();
            this.ticket.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.TabControl tcReport;
        private System.Windows.Forms.TabPage tpDaily;
        private System.Windows.Forms.DataVisualization.Charting.Chart dailyChart;
        private System.Windows.Forms.TabPage tpWeekly;
        private System.Windows.Forms.DataGridView dgvTicket;
        private System.Windows.Forms.Button btnGenerateDaily;
        private System.Windows.Forms.Label lblDailyTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart weeklyChartVisitor;
        private System.Windows.Forms.Button btnGenerateWeekly;
        private System.Windows.Forms.DataVisualization.Charting.Chart weeklyChartEarning;
        private System.Windows.Forms.Label lblWeeklyEarning;
        private System.Windows.Forms.Label lblWeeklyVisitor;
    }
}