
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
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnUnload = new System.Windows.Forms.Button();
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
            this.btnUnloadT = new System.Windows.Forms.Button();
            this.lblFileNameT = new System.Windows.Forms.Label();
            this.gbTicketDetails = new System.Windows.Forms.GroupBox();
            this.btnLoadEdit = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnDeleteTicket = new System.Windows.Forms.Button();
            this.lbl1Hr = new System.Windows.Forms.Label();
            this.tb1Hr = new System.Windows.Forms.TextBox();
            this.lbl2Hr = new System.Windows.Forms.Label();
            this.btnClearTicket = new System.Windows.Forms.Button();
            this.tb2Hrs = new System.Windows.Forms.TextBox();
            this.btnEditTicket = new System.Windows.Forms.Button();
            this.lbl3Hr = new System.Windows.Forms.Label();
            this.btnAddTicket = new System.Windows.Forms.Button();
            this.tb3Hrs = new System.Windows.Forms.TextBox();
            this.tbWholeDay = new System.Windows.Forms.TextBox();
            this.lbl4Hr = new System.Windows.Forms.Label();
            this.lblWholeDay = new System.Windows.Forms.Label();
            this.tb4Hrs = new System.Windows.Forms.TextBox();
            this.btnSaveTicket = new System.Windows.Forms.Button();
            this.btnImportTicket = new System.Windows.Forms.Button();
            this.dgvTicketRate = new System.Windows.Forms.DataGridView();
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
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
            this.gbTicketDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicketRate)).BeginInit();
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
            this.visitors.Controls.Add(this.lblFileName);
            this.visitors.Controls.Add(this.btnUnload);
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
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Poppins", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(7, 507);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(80, 23);
            this.lblFileName.TabIndex = 5;
            this.lblFileName.Text = "File name: ";
            // 
            // btnUnload
            // 
            this.btnUnload.Location = new System.Drawing.Point(253, 8);
            this.btnUnload.Name = "btnUnload";
            this.btnUnload.Size = new System.Drawing.Size(109, 29);
            this.btnUnload.TabIndex = 4;
            this.btnUnload.Text = "Unload";
            this.btnUnload.UseVisualStyleBackColor = true;
            this.btnUnload.Click += new System.EventHandler(this.btnUnload_Click);
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Location = new System.Drawing.Point(972, 12);
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
            this.cbSortBy.Location = new System.Drawing.Point(1024, 8);
            this.cbSortBy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSortBy.Name = "cbSortBy";
            this.cbSortBy.Size = new System.Drawing.Size(87, 31);
            this.cbSortBy.TabIndex = 2;
            this.cbSortBy.SelectedIndexChanged += new System.EventHandler(this.cbSortBy_SelectedIndexChanged);
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Location = new System.Drawing.Point(999, 501);
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
            this.btnEditRecord.Location = new System.Drawing.Point(876, 501);
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
            this.btnAddRecord.Location = new System.Drawing.Point(753, 501);
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
            this.dgvVisitors.AllowUserToAddRows = false;
            this.dgvVisitors.AllowUserToDeleteRows = false;
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
            this.dgvVisitors.MultiSelect = false;
            this.dgvVisitors.Name = "dgvVisitors";
            this.dgvVisitors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisitors.Size = new System.Drawing.Size(1105, 439);
            this.dgvVisitors.TabIndex = 1;
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
            this.ticket.Controls.Add(this.btnUnloadT);
            this.ticket.Controls.Add(this.lblFileNameT);
            this.ticket.Controls.Add(this.gbTicketDetails);
            this.ticket.Controls.Add(this.btnSaveTicket);
            this.ticket.Controls.Add(this.btnImportTicket);
            this.ticket.Controls.Add(this.dgvTicketRate);
            this.ticket.Location = new System.Drawing.Point(4, 31);
            this.ticket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ticket.Name = "ticket";
            this.ticket.Size = new System.Drawing.Size(1118, 546);
            this.ticket.TabIndex = 2;
            this.ticket.Text = "Ticket Rate";
            this.ticket.UseVisualStyleBackColor = true;
            // 
            // btnUnloadT
            // 
            this.btnUnloadT.Location = new System.Drawing.Point(755, 497);
            this.btnUnloadT.Name = "btnUnloadT";
            this.btnUnloadT.Size = new System.Drawing.Size(98, 29);
            this.btnUnloadT.TabIndex = 12;
            this.btnUnloadT.Text = "Unload";
            this.btnUnloadT.UseVisualStyleBackColor = true;
            this.btnUnloadT.Click += new System.EventHandler(this.btnUnloadT_Click);
            // 
            // lblFileNameT
            // 
            this.lblFileNameT.AutoSize = true;
            this.lblFileNameT.Font = new System.Drawing.Font("Poppins", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileNameT.Location = new System.Drawing.Point(363, 499);
            this.lblFileNameT.Name = "lblFileNameT";
            this.lblFileNameT.Size = new System.Drawing.Size(80, 23);
            this.lblFileNameT.TabIndex = 11;
            this.lblFileNameT.Text = "File name: ";
            // 
            // gbTicketDetails
            // 
            this.gbTicketDetails.Controls.Add(this.btnLoadEdit);
            this.gbTicketDetails.Controls.Add(this.cbCategory);
            this.gbTicketDetails.Controls.Add(this.lblCategory);
            this.gbTicketDetails.Controls.Add(this.btnDeleteTicket);
            this.gbTicketDetails.Controls.Add(this.lbl1Hr);
            this.gbTicketDetails.Controls.Add(this.tb1Hr);
            this.gbTicketDetails.Controls.Add(this.lbl2Hr);
            this.gbTicketDetails.Controls.Add(this.btnClearTicket);
            this.gbTicketDetails.Controls.Add(this.tb2Hrs);
            this.gbTicketDetails.Controls.Add(this.btnEditTicket);
            this.gbTicketDetails.Controls.Add(this.lbl3Hr);
            this.gbTicketDetails.Controls.Add(this.btnAddTicket);
            this.gbTicketDetails.Controls.Add(this.tb3Hrs);
            this.gbTicketDetails.Controls.Add(this.tbWholeDay);
            this.gbTicketDetails.Controls.Add(this.lbl4Hr);
            this.gbTicketDetails.Controls.Add(this.lblWholeDay);
            this.gbTicketDetails.Controls.Add(this.tb4Hrs);
            this.gbTicketDetails.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTicketDetails.Location = new System.Drawing.Point(17, 19);
            this.gbTicketDetails.Name = "gbTicketDetails";
            this.gbTicketDetails.Size = new System.Drawing.Size(309, 457);
            this.gbTicketDetails.TabIndex = 10;
            this.gbTicketDetails.TabStop = false;
            this.gbTicketDetails.Text = "Ticket Details";
            // 
            // btnLoadEdit
            // 
            this.btnLoadEdit.Location = new System.Drawing.Point(15, 401);
            this.btnLoadEdit.Name = "btnLoadEdit";
            this.btnLoadEdit.Size = new System.Drawing.Size(186, 33);
            this.btnLoadEdit.TabIndex = 11;
            this.btnLoadEdit.Text = "Edit Selected";
            this.btnLoadEdit.UseVisualStyleBackColor = true;
            this.btnLoadEdit.Click += new System.EventHandler(this.btnLoadEdit_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Child",
            "Adult",
            "Group of 5",
            "Group of 10",
            "Group of 15"});
            this.cbCategory.Location = new System.Drawing.Point(121, 45);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(151, 30);
            this.cbCategory.TabIndex = 9;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(41, 48);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(74, 22);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Category *";
            // 
            // btnDeleteTicket
            // 
            this.btnDeleteTicket.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTicket.Location = new System.Drawing.Point(111, 350);
            this.btnDeleteTicket.Name = "btnDeleteTicket";
            this.btnDeleteTicket.Size = new System.Drawing.Size(90, 33);
            this.btnDeleteTicket.TabIndex = 8;
            this.btnDeleteTicket.Text = "Delete";
            this.btnDeleteTicket.UseVisualStyleBackColor = true;
            this.btnDeleteTicket.Click += new System.EventHandler(this.btnDeleteTicket_Click);
            // 
            // lbl1Hr
            // 
            this.lbl1Hr.AutoSize = true;
            this.lbl1Hr.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Hr.Location = new System.Drawing.Point(41, 100);
            this.lbl1Hr.Name = "lbl1Hr";
            this.lbl1Hr.Size = new System.Drawing.Size(54, 22);
            this.lbl1Hr.TabIndex = 3;
            this.lbl1Hr.Text = "1 Hour *";
            // 
            // tb1Hr
            // 
            this.tb1Hr.BackColor = System.Drawing.Color.White;
            this.tb1Hr.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1Hr.Location = new System.Drawing.Point(121, 97);
            this.tb1Hr.Name = "tb1Hr";
            this.tb1Hr.Size = new System.Drawing.Size(151, 25);
            this.tb1Hr.TabIndex = 4;
            // 
            // lbl2Hr
            // 
            this.lbl2Hr.AutoSize = true;
            this.lbl2Hr.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Hr.Location = new System.Drawing.Point(42, 147);
            this.lbl2Hr.Name = "lbl2Hr";
            this.lbl2Hr.Size = new System.Drawing.Size(63, 22);
            this.lbl2Hr.TabIndex = 3;
            this.lbl2Hr.Text = "2 Hours *";
            // 
            // btnClearTicket
            // 
            this.btnClearTicket.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearTicket.Location = new System.Drawing.Point(207, 350);
            this.btnClearTicket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearTicket.Name = "btnClearTicket";
            this.btnClearTicket.Size = new System.Drawing.Size(90, 33);
            this.btnClearTicket.TabIndex = 5;
            this.btnClearTicket.Text = "Clear";
            this.btnClearTicket.UseVisualStyleBackColor = true;
            this.btnClearTicket.Click += new System.EventHandler(this.btnClearTicket_Click);
            // 
            // tb2Hrs
            // 
            this.tb2Hrs.BackColor = System.Drawing.Color.White;
            this.tb2Hrs.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb2Hrs.Location = new System.Drawing.Point(121, 144);
            this.tb2Hrs.Name = "tb2Hrs";
            this.tb2Hrs.Size = new System.Drawing.Size(151, 25);
            this.tb2Hrs.TabIndex = 4;
            // 
            // btnEditTicket
            // 
            this.btnEditTicket.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTicket.Location = new System.Drawing.Point(207, 401);
            this.btnEditTicket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditTicket.Name = "btnEditTicket";
            this.btnEditTicket.Size = new System.Drawing.Size(90, 33);
            this.btnEditTicket.TabIndex = 5;
            this.btnEditTicket.Text = "Edit";
            this.btnEditTicket.UseVisualStyleBackColor = true;
            this.btnEditTicket.Click += new System.EventHandler(this.btnEditTicket_Click);
            // 
            // lbl3Hr
            // 
            this.lbl3Hr.AutoSize = true;
            this.lbl3Hr.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Hr.Location = new System.Drawing.Point(41, 194);
            this.lbl3Hr.Name = "lbl3Hr";
            this.lbl3Hr.Size = new System.Drawing.Size(63, 22);
            this.lbl3Hr.TabIndex = 3;
            this.lbl3Hr.Text = "3 Hours *";
            // 
            // btnAddTicket
            // 
            this.btnAddTicket.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTicket.Location = new System.Drawing.Point(15, 350);
            this.btnAddTicket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddTicket.Name = "btnAddTicket";
            this.btnAddTicket.Size = new System.Drawing.Size(90, 33);
            this.btnAddTicket.TabIndex = 5;
            this.btnAddTicket.Text = "Add";
            this.btnAddTicket.UseVisualStyleBackColor = true;
            this.btnAddTicket.Click += new System.EventHandler(this.btnAddTicket_Click);
            // 
            // tb3Hrs
            // 
            this.tb3Hrs.BackColor = System.Drawing.Color.White;
            this.tb3Hrs.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb3Hrs.Location = new System.Drawing.Point(121, 191);
            this.tb3Hrs.Name = "tb3Hrs";
            this.tb3Hrs.Size = new System.Drawing.Size(151, 25);
            this.tb3Hrs.TabIndex = 4;
            // 
            // tbWholeDay
            // 
            this.tbWholeDay.BackColor = System.Drawing.Color.White;
            this.tbWholeDay.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWholeDay.Location = new System.Drawing.Point(121, 285);
            this.tbWholeDay.Name = "tbWholeDay";
            this.tbWholeDay.Size = new System.Drawing.Size(151, 25);
            this.tbWholeDay.TabIndex = 4;
            // 
            // lbl4Hr
            // 
            this.lbl4Hr.AutoSize = true;
            this.lbl4Hr.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Hr.Location = new System.Drawing.Point(41, 241);
            this.lbl4Hr.Name = "lbl4Hr";
            this.lbl4Hr.Size = new System.Drawing.Size(64, 22);
            this.lbl4Hr.TabIndex = 3;
            this.lbl4Hr.Text = "4 Hours *";
            // 
            // lblWholeDay
            // 
            this.lblWholeDay.AutoSize = true;
            this.lblWholeDay.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWholeDay.Location = new System.Drawing.Point(41, 288);
            this.lblWholeDay.Name = "lblWholeDay";
            this.lblWholeDay.Size = new System.Drawing.Size(83, 22);
            this.lblWholeDay.TabIndex = 3;
            this.lblWholeDay.Text = "Whole Day *";
            // 
            // tb4Hrs
            // 
            this.tb4Hrs.BackColor = System.Drawing.Color.White;
            this.tb4Hrs.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb4Hrs.Location = new System.Drawing.Point(121, 238);
            this.tb4Hrs.Name = "tb4Hrs";
            this.tb4Hrs.Size = new System.Drawing.Size(151, 25);
            this.tb4Hrs.TabIndex = 4;
            // 
            // btnSaveTicket
            // 
            this.btnSaveTicket.Location = new System.Drawing.Point(991, 497);
            this.btnSaveTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveTicket.Name = "btnSaveTicket";
            this.btnSaveTicket.Size = new System.Drawing.Size(109, 29);
            this.btnSaveTicket.TabIndex = 6;
            this.btnSaveTicket.Text = "Save File";
            this.btnSaveTicket.UseVisualStyleBackColor = true;
            this.btnSaveTicket.Click += new System.EventHandler(this.btnSaveTicket_Click);
            // 
            // btnImportTicket
            // 
            this.btnImportTicket.Location = new System.Drawing.Point(868, 497);
            this.btnImportTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImportTicket.Name = "btnImportTicket";
            this.btnImportTicket.Size = new System.Drawing.Size(109, 29);
            this.btnImportTicket.TabIndex = 7;
            this.btnImportTicket.Text = "Import File";
            this.btnImportTicket.UseVisualStyleBackColor = true;
            this.btnImportTicket.Click += new System.EventHandler(this.btnImportTicket_Click);
            // 
            // dgvTicketRate
            // 
            this.dgvTicketRate.AllowUserToAddRows = false;
            this.dgvTicketRate.AllowUserToDeleteRows = false;
            this.dgvTicketRate.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTicketRate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicketRate.Location = new System.Drawing.Point(358, 29);
            this.dgvTicketRate.MultiSelect = false;
            this.dgvTicketRate.Name = "dgvTicketRate";
            this.dgvTicketRate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTicketRate.Size = new System.Drawing.Size(742, 447);
            this.dgvTicketRate.TabIndex = 0;
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
            this.lblUserType.Size = new System.Drawing.Size(49, 22);
            this.lblUserType.TabIndex = 0;
            this.lblUserType.Text = "Admin";
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
            this.lblUsername.Size = new System.Drawing.Size(88, 26);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "admin009";
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing_1);
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
            this.ticket.PerformLayout();
            this.gbTicketDetails.ResumeLayout(false);
            this.gbTicketDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicketRate)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvTicketRate;
        private System.Windows.Forms.Button btnGenerateDaily;
        private System.Windows.Forms.Label lblDailyTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart weeklyChartVisitor;
        private System.Windows.Forms.Button btnGenerateWeekly;
        private System.Windows.Forms.DataVisualization.Charting.Chart weeklyChartEarning;
        private System.Windows.Forms.Label lblWeeklyEarning;
        private System.Windows.Forms.Label lblWeeklyVisitor;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox tbWholeDay;
        private System.Windows.Forms.Label lblWholeDay;
        private System.Windows.Forms.TextBox tb4Hrs;
        private System.Windows.Forms.Label lbl4Hr;
        private System.Windows.Forms.TextBox tb3Hrs;
        private System.Windows.Forms.Label lbl3Hr;
        private System.Windows.Forms.TextBox tb2Hrs;
        private System.Windows.Forms.Label lbl2Hr;
        private System.Windows.Forms.TextBox tb1Hr;
        private System.Windows.Forms.Label lbl1Hr;
        private System.Windows.Forms.Button btnClearTicket;
        private System.Windows.Forms.Button btnAddTicket;
        private System.Windows.Forms.Button btnEditTicket;
        private System.Windows.Forms.Button btnSaveTicket;
        private System.Windows.Forms.Button btnImportTicket;
        private System.Windows.Forms.Button btnUnload;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnDeleteTicket;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.GroupBox gbTicketDetails;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnLoadEdit;
        private System.Windows.Forms.Label lblFileNameT;
        private System.Windows.Forms.Button btnUnloadT;
    }
}