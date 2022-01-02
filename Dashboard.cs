//Written by: Susan Shrestha
//Date: 29 December, 2021

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms.DataVisualization.Charting;

namespace Recreation_Center
{
    public partial class Dashboard : Form
    {
        //for visitor records
        public static BindingList<Visitors> visitorRecord = new BindingList<Visitors>(); //initializing new binding list with the type of Visitor
        private BindingList<string> alreadyOpenedVisitor = new BindingList<string>();
        
        //for ticket rate
        public static BindingList<TicketRate> ticketRecord = new BindingList<TicketRate>(); //initializing new binding list with the type of Visitor
        private BindingList<string> alreadyOpenedTicket = new BindingList<string>();

        string username;
        string usertType;
        public Dashboard(string getUsername, string getUserType)
        {
            InitializeComponent();
            //retriving username and usertype values from LoginForm
            this.username = getUsername;
            this.usertType = getUserType;
        }

        private void Dashboard_Load(object sender, EventArgs e) //After Login
        {
            //setting defaults on form load event
            lblUsername.Text = username;
            lblUserType.Text = usertType;
            tbIndex.Visible = false;

            try {
                if (File.Exists("Visitor_record.csv")) //checking existing visitor record file to load in the GridView
                {
                    FileStream fs = new FileStream("Visitor_record.csv", FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();
                    visitorRecord = (BindingList<Visitors>)bf.Deserialize(fs); //Deserializing BindingList
                    lblFileName.Text = "File name: " + "Visitor_record.csv"; //setting default filename
                    fs.Close();
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); } //excepting handling for possible errors

            //granting access to admin and user
            if (lblUserType.Text == "Admin")
            {
                btnTicketPanel.Visible = true;
            }
            else
            {
                btnTicketPanel.Visible = false;
                mainPanel.TabPages.Remove(ticket);

            }

            //loading ticket rate record in datagridview
            try
            {
                if (File.Exists("Ticket_rate.csv")) //checking existing file to load in the GridView
                {
                    FileStream fst = new FileStream("Ticket_rate.csv", FileMode.Open);
                    BinaryFormatter bft = new BinaryFormatter();
                    ticketRecord = (BindingList<TicketRate>)bft.Deserialize(fst); //Deserializing BindingList
                    lblFileNameT.Text = "File name: " + "Ticket_rate.csv"; //setting default filename
                    fst.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            dgvVisitors.DataSource = visitorRecord;
            dgvVisitors.Columns["ticketNo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; //gridView column size fill

            dgvTicketRate.DataSource = ticketRecord; //setting GridView datasource with ticketrate' record
            //dgvTicketRate.Columns["Index"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        //Switching between tabs with button control
        private void btnTicketPanel_Click(object sender, EventArgs e)
        {
            mainPanel.SelectedTab = mainPanel.TabPages[2];
        }
        private void btnReportPanel_Click(object sender, EventArgs e)
        {
            mainPanel.SelectedTab = mainPanel.TabPages[1];
        }
        private void btnVisitorPanel_Click(object sender, EventArgs e)
        {
            mainPanel.SelectedTab = mainPanel.TabPages[0];
        }

        //closing the program
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Exit?", "Exit?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                System.Windows.Forms.Application.Exit();
        }

        //minimize window (form)
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //asking user to log out when clicked
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to log out?", "Log out?", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm login = new LoginForm();
                login.Show();
            }
        }

        private void btnImport_Click(object sender, EventArgs e) //importing file from local folder
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV File|*.csv"; //filtering files
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (!(alreadyOpenedVisitor.Contains(ofd.FileName)))
                {
                    string[] lines = File.ReadAllLines(ofd.FileName); //retriving csv file in lines to lines array
                    // filename for validation 
                    alreadyOpenedVisitor.Add(ofd.FileName);
                    string[] items;
                    bool firstline = true;

                    lines.Skip<string>(1); //skipping header line

                    foreach (string line in lines) //retriving each lines from lines array
                    {
                        items = line.Split(','); //spliting each items
                        if (firstline == true)
                        {
                            firstline = false;
                        }
                        else
                        {
                            try
                            {
                                Visitors visitor = new Visitors(Convert.ToInt32(items[0]), items[1], items[2], Convert.ToDouble(items[3]), items[4], items[5], Convert.ToDateTime(items[6]), Convert.ToDateTime(items[7]), Convert.ToDateTime(items[8]), items[9], Convert.ToInt32(items[10]));
                                addVisitorRecord(visitor); //passing instance of an object to add visitor record
                            }
                            catch(FormatException)
                            {
                                MessageBox.Show("Please import a valid CSV file.", "Invalid file import");
                                break;
                            }
                            
                        }

                    }
                    lblFileName.Text = "File name: " + ofd.SafeFileName; //setting file name
                }
                else
                {
                    MessageBox.Show("ERROR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void addVisitorRecord(Visitors e)
        {
            visitorRecord.Add(e); //adding record to list
            dgvVisitors.DataSource = visitorRecord; //setting datasource for datagridview
        }

        //Opens AddRecord form to add new record
        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms["AddRecord"] == null)
            {
                AddRecord ar = new AddRecord(); //creating object for AddRecord form
                ar.Show(); //opening AddRecord form using object instance
            }
            else
            {
                Application.OpenForms["AddRecord"].BringToFront();
            }
        }

        //saving file in local directory
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "CSV file|*.csv;";
            save.DefaultExt = ".csv";
            save.FileName = "Visitors " + DateTime.Now.ToString("dd-MM-yyyy");
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter swr = new StreamWriter(save.FileName); //creating streamWriter object
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Ticket No., Name, Address, Phone, Gender, Ticket Type, Date, Entry Time, Exit Time, Total Time, Price, Total Amount"); 
                foreach (Visitors visitor in visitorRecord)
                {
                    //appending rows using StringBuilder
                    sb.AppendLine(visitor.ticketNO.ToString() + "," +
                        visitor.name + "," +
                        visitor.address + "," +
                        visitor.phoneNo.ToString() + "," +
                        visitor.gender + "," +
                        visitor.ticketType + "," +
                        visitor.date.ToString() + "," +
                        visitor.entryTime.ToString() + "," +
                        visitor.exitTime.ToString() + "," +
                        visitor.totalTime + "," +
                        visitor.price.ToString());
                }
                swr.Write(sb.ToString()); //writing to csb file
                swr.Close();
                MessageBox.Show("Visitor records saved successfully.","Saved",MessageBoxButtons.OK);
            }
        }

        public void deleteRecord(int ticketNo) 
        {
            foreach (Visitors e in visitorRecord)
            {
                if (e.ticketNO == ticketNo) //selecting key as ticketNo to delete selected row from record
                {
                    visitorRecord.Remove(e); //removing from binding list
                    dgvVisitors.Refresh();
                    return;
                }
            }
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            try
            {
                deleteRecord(Convert.ToInt32(dgvVisitors.SelectedRows[0].Cells[0].Value)); //for deleting the selected/active row
            }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("No rows selected.","Invalid delete"); }
        }

        public void editVisitorRecord(int ticketNo, String name, String address, Double phoneNo, String gender, String ticketType, DateTime date, DateTime entryTime, DateTime exitTime, String totalTime, int price)
        {
            foreach (Visitors e in visitorRecord)
            {
                if (e.ticketNO == ticketNo)
                {
                    e.setVisitor(ticketNo, name, address, phoneNo, gender, ticketType, date, entryTime, exitTime, totalTime, price);
                    dgvVisitors.Refresh();
                    return;
                }
            }
        }

        private void btnEditRecord_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["AddRecord"] == null)
                {
                    AddRecord ar = new AddRecord();
                    ar.editMode = true;
                    ar.Text = "Edit Record";
                    ar.setData(Convert.ToInt32(dgvVisitors.SelectedRows[0].Cells[0].Value),
                        dgvVisitors.SelectedRows[0].Cells[1].Value.ToString(),
                        dgvVisitors.SelectedRows[0].Cells[2].Value.ToString(),
                        Convert.ToDouble(dgvVisitors.SelectedRows[0].Cells[3].Value),
                        dgvVisitors.SelectedRows[0].Cells[4].Value.ToString(),
                        dgvVisitors.SelectedRows[0].Cells[5].Value.ToString(),
                        Convert.ToDateTime(dgvVisitors.SelectedRows[0].Cells[6].Value),
                        Convert.ToDateTime(dgvVisitors.SelectedRows[0].Cells[7].Value),
                        Convert.ToDateTime(dgvVisitors.SelectedRows[0].Cells[8].Value),
                        dgvVisitors.SelectedRows[0].Cells[9].Value.ToString(),
                        Convert.ToInt32(dgvVisitors.SelectedRows[0].Cells[10].Value)
                    );
                    ar.Show();
                }
                else
                {
                    ((AddRecord)Application.OpenForms["AddRecord"]).editMode = true;
                    Application.OpenForms["AddRecord"].BringToFront();
                }
            }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("No rows selected.", "Invalid action"); }
            
        }

        //Report section coding: Chart generation
        private void btnGenerateDaily_Click(object sender, EventArgs e)
        {
            dailyChart.Series["Number of visitors"].Points.Clear();
            genDailyChart(visitorRecord);
        }

        public void genDailyChart(BindingList<Visitors> record)
        {
            int childCount = 0;
            int adultCount = 0;
            int groupOf5Count = 0;
            int groupOf10Count = 0;
            int groupOf15Count = 0;
            string child = "Child";
            string adult = "Adult";
            string groupOf5 = "Group of 5";
            string groupOf10 = "Group of 10";
            string groupOf15 = "Group of 15";

            foreach (Visitors vis in record)
            {
                if (vis.ticketType.ToUpper().Contains(child.ToUpper()))
                {
                    childCount++;
                }
                else if (vis.ticketType.ToUpper().Contains(adult.ToUpper()))
                {
                    adultCount++;
                }
                else if (vis.ticketType.ToUpper().Contains(groupOf5.ToUpper()))
                {
                    groupOf5Count += 5;
                }
                else if (vis.ticketType.ToUpper().Contains(groupOf10.ToUpper()))
                {
                    groupOf10Count += 10;
                }
                else if(vis.ticketType.ToUpper().Contains(groupOf15.ToUpper()))
                {
                    groupOf15Count += 15;
                }
            }

            dailyChart.Series[0].Points.AddXY("Child", childCount);
            dailyChart.Series[0].Points.AddXY("Adult", adultCount);
            dailyChart.Series[0].Points.AddXY("Group of 5", groupOf5Count);
            dailyChart.Series[0].Points.AddXY("Group of 10", groupOf10Count);
            dailyChart.Series[0].Points.AddXY("Group of 15", groupOf15Count);
            dailyChart.Series[0].IsValueShownAsLabel = true;
            dailyChart.Series[0].IsVisibleInLegend = true;
            //dailyChart.Series[0].ChartType = SeriesChartType.Pie;
        }

        private void btnGenerateWeekly_Click(object sender, EventArgs e)
        {
            weeklyChartVisitor.Series["Visitors"].Points.Clear();
            weeklyChartEarning.Series["Earnings"].Points.Clear();
            genWeeklyChart(visitorRecord);
        }

        public void genWeeklyChart(BindingList<Visitors> record)
        {
            int sundayCount = 0;
            int mondayCount = 0;
            int tuesdayCount = 0;
            int wednesdayCount = 0;
            int thursdayCount = 0;
            int fridayCount = 0;
            int saturdayCount = 0;

            double sundayEarning = 0;
            double mondayEarning = 0;
            double tuesdayEarning = 0;
            double wednesdayEarning = 0;
            double thursdayEarning = 0;
            double fridayEarning = 0;
            double saturdayEarning = 0;

            string sunday = "Sunday";
            string monday = "Monday";
            string tuesday = "Tuesday";
            string wednesday = "Wednesday";
            string thursday = "Thursday";
            string friday = "Friday";
            string saturday = "Saturday";

            foreach (Visitors vis in record)
            {
                if (vis.date.DayOfWeek.ToString().Contains(sunday))
                {
                    sundayCount++;
                    sundayEarning += vis.price;
                }
                else if (vis.date.DayOfWeek.ToString().Contains(monday))
                {
                    mondayCount++;
                    mondayEarning += vis.price;
                }
                else if (vis.date.DayOfWeek.ToString().Contains(tuesday))
                {
                    tuesdayCount++;
                    tuesdayEarning += vis.price;
                }
                else if (vis.date.DayOfWeek.ToString().Contains(wednesday))
                {
                    wednesdayCount++;
                    wednesdayEarning += vis.price;
                }
                else if (vis.date.DayOfWeek.ToString().Contains(thursday))
                {
                    thursdayCount++;
                    thursdayEarning += vis.price;
                }
                else if (vis.date.DayOfWeek.ToString().Contains(friday))
                {
                    fridayCount++;
                    fridayEarning += vis.price;
                }
                else if (vis.date.DayOfWeek.ToString().Contains(saturday))
                {
                    saturdayCount++;
                    saturdayEarning += vis.price;
                }
            }

            weeklyChartVisitor.Series[0].Points.AddXY("Sunday", sundayCount);
            weeklyChartVisitor.Series[0].Points.AddXY("Monday", mondayCount);
            weeklyChartVisitor.Series[0].Points.AddXY("Tuesday", tuesdayCount);
            weeklyChartVisitor.Series[0].Points.AddXY("Wednesday", wednesdayCount);
            weeklyChartVisitor.Series[0].Points.AddXY("Thursday", thursdayCount);
            weeklyChartVisitor.Series[0].Points.AddXY("Friday", fridayCount);
            weeklyChartVisitor.Series[0].Points.AddXY("Saturday", saturdayCount);

            weeklyChartVisitor.Series[0].IsValueShownAsLabel = true;
            weeklyChartVisitor.Series[0].IsVisibleInLegend = true;
            weeklyChartVisitor.Series[0].ChartType = SeriesChartType.Pie;

            weeklyChartEarning.Series[0].Points.AddXY("Sunday", sundayEarning);
            weeklyChartEarning.Series[0].Points.AddXY("Monday", mondayEarning);
            weeklyChartEarning.Series[0].Points.AddXY("Tuesday", tuesdayEarning);
            weeklyChartEarning.Series[0].Points.AddXY("Wednesday", wednesdayEarning);
            weeklyChartEarning.Series[0].Points.AddXY("Thursday", thursdayEarning);
            weeklyChartEarning.Series[0].Points.AddXY("Friday", fridayEarning);
            weeklyChartEarning.Series[0].Points.AddXY("Saturday", saturdayEarning);

            weeklyChartEarning.Series[0].IsValueShownAsLabel = true;
            weeklyChartEarning.Series[0].IsVisibleInLegend = true;
            weeklyChartEarning.Series[0].ChartType = SeriesChartType.SplineArea;
        }

        //clearing form
        private void btnClearTicket_Click(object sender, EventArgs e)
        {
            cbCategory.Text = default;
            tb1Hr.Text = "";
            tb2Hrs.Text = "";
            tb3Hrs.Text = "";
            tb4Hrs.Text = "";
            tbWholeDay.Text = "";
        }

        //unloading dataGridView
        private void btnUnload_Click(object sender, EventArgs e)
        {
            lblFileName.Text = "File name: ";
            dgvVisitors.Rows.Clear();
            dgvVisitors.Refresh();
        }

        //TicketRate code starts here
        public int index = 1;
        private bool editMode { get; set; }
        private void btnAddTicket_Click(object sender, EventArgs e)
        {
            if (cbCategory.Text == "" || tb1Hr.Text == "" || tb2Hrs.Text == "" || tb3Hrs.Text == "" || tb4Hrs.Text == "" || tbWholeDay.Text == "")
            {
                MessageBox.Show("Please fill the required (*) feilds.", "Invalid Input", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    TicketRate ticket = new TicketRate(
                        index++,
                        cbCategory.Text,
                        Convert.ToInt32(tb1Hr.Text),
                        Convert.ToInt32(tb2Hrs.Text),
                        Convert.ToInt32(tb3Hrs.Text),
                        Convert.ToInt32(tb4Hrs.Text),
                        Convert.ToInt32(tbWholeDay.Text));
                    addTicketRecord(ticket);
                    cbCategory.Text = default;
                    tb1Hr.Text = "";
                    tb2Hrs.Text = "";
                    tb3Hrs.Text = "";
                    tb4Hrs.Text = "";
                    tbWholeDay.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void btnLoadEdit_Click(object sender, EventArgs e)
        {
            try
            {
                setTicketData(
                    Convert.ToInt32(dgvTicketRate.SelectedRows[0].Cells[0].Value),
                    dgvTicketRate.SelectedRows[0].Cells[1].Value.ToString(),
                    Convert.ToInt32(dgvTicketRate.SelectedRows[0].Cells[2].Value),
                    Convert.ToInt32(dgvTicketRate.SelectedRows[0].Cells[3].Value),
                    Convert.ToInt32(dgvTicketRate.SelectedRows[0].Cells[4].Value),
                    Convert.ToInt32(dgvTicketRate.SelectedRows[0].Cells[5].Value),
                    Convert.ToInt32(dgvTicketRate.SelectedRows[0].Cells[6].Value)
                );
                
            }
            catch (Exception) { MessageBox.Show("No rows selected.", "Error"); }
        }

        public void setTicketData(int index, String category, int oneHr, int twoHrs, int threeHrs, int fourHrs, int wholeday)
        {
            tbIndex.Text = index.ToString();
            cbCategory.Text = category;
            tb1Hr.Text = oneHr.ToString();
            tb2Hrs.Text = twoHrs.ToString();
            tb3Hrs.Text = threeHrs.ToString();
            tb4Hrs.Text = fourHrs.ToString();
            tbWholeDay.Text = wholeday.ToString();
        }

        private void btnEditTicket_Click(object sender, EventArgs e)
        {
            try
            {
                editTicketRecord(
                    Convert.ToInt32(tbIndex.Text),
                    cbCategory.Text,
                    Convert.ToInt32(tb1Hr.Text),
                    Convert.ToInt32(tb2Hrs.Text),
                    Convert.ToInt32(tb3Hrs.Text),
                    Convert.ToInt32(tb4Hrs.Text),
                    Convert.ToInt32(tbWholeDay.Text)
                );

            }
            catch (Exception)
            {
                MessageBox.Show("No rows selected.", "Error");
            }

        }


        private void btnDeleteTicket_Click(object sender, EventArgs e)
        {
            try
            {
                deleteTicketRecord(Convert.ToInt32(dgvTicketRate.SelectedRows[0].Cells[0].Value));

            }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("No rows selected.", "Invalid delete"); }
        }

        public void deleteTicketRecord(int index)
        {
            foreach (TicketRate e in ticketRecord)
            {
                if (e.Index == index)
                {
                    ticketRecord.Remove(e);
                    dgvTicketRate.Refresh();
                    return;
                }
            }
        }

        private void btnImportTicket_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV File|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (!(alreadyOpenedTicket.Contains(ofd.FileName)))
                {

                    string[] lines = File.ReadAllLines(ofd.FileName);
                    // filename for validation 
                    alreadyOpenedTicket.Add(ofd.FileName);
                    string[] items;
                    bool firstline = true;

                    lines.Skip<string>(1);

                    foreach (string line in lines)
                    {
                        items = line.Split(',');
                        if (firstline == true)
                        {
                            firstline = false;
                        }
                        else
                        {
                            try
                            {
                                TicketRate ticket = new TicketRate(Convert.ToInt32(items[0]), items[1], Convert.ToInt32(items[2]), Convert.ToInt32(items[3]), Convert.ToInt32(items[4]), Convert.ToInt32(items[5]), Convert.ToInt32(items[6]));
                                addTicketRecord(ticket);
                                dgvTicketRate.Columns["Index"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                lblFileNameT.Text = "File name: " + ofd.SafeFileName;
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Please import a valid CSV file.", "Invalid file import", MessageBoxButtons.OK);
                                break;
                            }

                        }

                    }
                }
                else
                {
                    MessageBox.Show("ERROR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        public void addTicketRecord(TicketRate e)
        {
            ticketRecord.Add(e);
            dgvTicketRate.DataSource = ticketRecord;
        }

        private void editTicketRecord(int index, String category, int oneHr, int twoHrs, int threeHrs, int fourHrs, int wholeDay)
        {
            foreach (TicketRate e in ticketRecord)
            {
                if (e.Index == index)
                { 
                    e.setTicketRate(index, category, oneHr, twoHrs, threeHrs, fourHrs, wholeDay);
                    dgvTicketRate.Refresh();
                    return;
                }
            }
        }

        private void btnSaveTicket_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "CSV file|*.csv;";
            save.DefaultExt = ".csv";
            save.FileName = "Ticket Rate " + DateTime.Now.ToString("dd-MM-yyyy");
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter swr = new StreamWriter(save.FileName);
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Category, 1Hr, 2Hrs, 3Hrs, 4Hrs, Whole Day");
                foreach (TicketRate ticket in ticketRecord)
                {
                    sb.AppendLine(index + "," + ticket.category + "," +
                        ticket.oneHr.ToString() + "," +
                        ticket.twoHrs.ToString() + "," +
                        ticket.threeHrs.ToString() + "," +
                        ticket.fourHrs.ToString() + "," +
                        ticket.wholeDay.ToString());
                }

                swr.Write(sb.ToString());
                swr.Close();
                MessageBox.Show("Ticket rate saved successfully.", "Saved", MessageBoxButtons.OK);

            }
        }

        private void btnUnloadT_Click(object sender, EventArgs e)
        {
            lblFileNameT.Text = "File name: ";
            dgvTicketRate.Rows.Clear();
            dgvTicketRate.Refresh();
        }

        private void Dashboard_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            FileStream fs = new FileStream("Visitor_record.csv", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, visitorRecord);
            fs.Close();

            FileStream fst = new FileStream("Ticket_rate.csv", FileMode.Create);
            BinaryFormatter bft = new BinaryFormatter();
            bft.Serialize(fst, ticketRecord);
            fst.Close();
        }

        private void cbSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortRecord();
        }

        private void sortRecord()
        {

            for (int i = 0; i < visitorRecord.Count - 1; i++)
                for (int j = 0; j < visitorRecord.Count - 1; j++)
                {
                    switch (cbSortBy.SelectedIndex)
                    {

                        case 0:
                            if (visitorRecord[j].name.CompareTo(visitorRecord[j + 1].name) > 0)
                            {
                                swap(j, j + 1);
                            }
                            break;

                        case 1:
                            if (visitorRecord[j].date.CompareTo(visitorRecord[j + 1].date) > 0)
                            {
                                swap(j, j + 1);
                            }
                            break;
                    }

                }
            dgvVisitors.DataSource = visitorRecord;
        }

        private void swap(int i, int j)
        {
            Visitors temp;
            temp = visitorRecord[i];
            visitorRecord[i] = visitorRecord[j];
            visitorRecord[j] = temp;
        }
    }
}

[Serializable]
public class Visitors  //visitor class for visitor records
{
    //defining Visitor class attributes with getter and setter methods.
    private int ticketNo;
    public int ticketNO
    {
        get {
            return ticketNo;
        }
        set {
            ticketNo = value;
        }
    }
    public String name { get; set; }
    public String address { get; set; }
    public Double phoneNo { get; set; }
    public String gender { get; set; }
    public String ticketType { get; set; }
    public DateTime date { get; set; }
    public DateTime entryTime { get; set; }
    public DateTime exitTime { get; set; }
    public String totalTime { get; set; }
    public int price { get; set; }

    //Constructor for setting visitor's details
    public Visitors(int ticketNo, String name, String address, Double phoneNo, String gender, String ticketType, DateTime date, DateTime entryTime, DateTime exitTime, String totalTime, int price)
    {
        setVisitor(ticketNo, name, address, phoneNo, gender, ticketType, date, entryTime, exitTime, totalTime, price);
    }

    //defining setVisitor method to set data in defined attributes.
    public void setVisitor(int ticketNo, String name, String address, Double phoneNo, String gender, String ticketType, DateTime date, DateTime entryTime, DateTime exitTime, String totalTime, int price)
    {
        this.ticketNo = ticketNo;
        this.name = name;
        this.address = address;
        this.phoneNo = phoneNo;
        this.gender = gender;
        this.ticketType = ticketType;
        this.date = date;
        this.entryTime = entryTime;
        this.exitTime = exitTime;
        this.totalTime = totalTime;
        this.price = price;
    }

}

[Serializable]
public class TicketRate  //TicketRate class for Tickets Price
{
    //defining TicketRate class attributes with getter and setter methods.  
    private int index;
    public int Index
    {
        get
        {
            return index;
        }
        set
        {
            index = value;
        }
    }
    public String category { get; set; }
    public int oneHr { get; set; }
    public int twoHrs { get; set; }
    public int threeHrs { get; set; }
    public int fourHrs { get; set; }
    public int wholeDay { get; set; }

    //Constructor for setting TicketRate details
    public TicketRate(int index, String category, int oneHr, int twoHrs, int threeHrs, int fourHrs, int wholeDay)
    {
        setTicketRate(index, category, oneHr, twoHrs, threeHrs, fourHrs, wholeDay);
    }

    //defining setVisitor method to set data in defined attributes.
    public void setTicketRate(int index, String category, int oneHr, int twoHrs, int threeHrs, int fourHrs, int wholeDay)
    {
        this.index = index;
        this.category = category;
        this.oneHr = oneHr;
        this.twoHrs = twoHrs;
        this.threeHrs = threeHrs;
        this.fourHrs = fourHrs;
        this.wholeDay = wholeDay;
    }

}