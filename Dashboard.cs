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
        public static BindingList<Visitors> record = new BindingList<Visitors>(); //initializing new binding list with the type of Visitor
        private BindingList<string> already_opened = new BindingList<string>();

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e) //After Login
        {
            if (File.Exists("Visitor_record.csv")) //checking existing file to load in the GridView
            {
                FileStream fs = new FileStream("Visitor_record.csv", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                record = (BindingList<Visitors>)bf.Deserialize(fs); //Deserializing BindingList
                fs.Close();
            }
            else
            {
                MessageBox.Show("no files found");
            }

            dgvVisitors.DataSource = record; //setting GridView datasource with visitors' record
            //dgvVisitors.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; //gridView column size fill

            dgvVisitors.Columns[0].Width = 40;
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
            if(result == DialogResult.Yes)
                this.Close();
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
                loginForm login = new loginForm();
                login.Show();
            }
        }


        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV File|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (!(already_opened.Contains(ofd.FileName)))
                {

                    string[] lines = File.ReadAllLines(ofd.FileName);
                    // filename for validation 
                    already_opened.Add(ofd.FileName);
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
                                Visitors visitor = new Visitors(Convert.ToInt32(items[0]), items[1], items[2], Convert.ToDouble(items[3]), items[4], items[5], Convert.ToDateTime(items[6]), Convert.ToDateTime(items[7]), Convert.ToDateTime(items[8]), Convert.ToDouble(items[9]), Convert.ToInt32(items[10]), Convert.ToDouble(items[11]));
                                addRecord(visitor);
                            }catch(FormatException)
                            {
                                MessageBox.Show("Please import a valid csv file.", "Invalid file import");
                                break;
                            }
                            
                        }

                    }
                }
                else
                {
                    MessageBox.Show(" ERROR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        public void addRecord(Visitors e)
        {
            record.Add(e);
            dgvVisitors.DataSource = record;
        }

        //Opens AddRecord form to add new record
        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms["AddRecord"] == null)
            {
                AddRecord ar = new AddRecord();
                ar.Show();
            }
            else
            {
                Application.OpenForms["AddRecord"].BringToFront();
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "CSV file|*.csv;";
            save.DefaultExt = ".csv";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter swr = new StreamWriter(save.FileName);
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Ticket No., Name, Address, Phone, Gender, Ticket Type, Date, Entry Time, Exit Time, Total Time, Price, Total Amount");
                foreach (Visitors visitor in record)
                {
                    sb.AppendLine(visitor.ticketNO.ToString() + "," +
                        visitor.name + "," +
                        visitor.address + "," +
                        visitor.phoneNo.ToString() + "," +
                        visitor.gender + "," +
                        visitor.ticketType + "," +
                        visitor.date.ToString() + "," +
                        visitor.entryTime.ToString() + "," +
                        visitor.exitTime.ToString() + "," +
                        visitor.totalTime.ToString() + "," +
                        visitor.price.ToString() + "," +
                        visitor.totalAmount.ToString());
                }
                swr.Write(sb.ToString());
                swr.Close();
                MessageBox.Show("Records saved successfully!");
            }
        }

        public void deleteRecord(int ticketNo) 
        {
            foreach (Visitors e in record)
            {
                if (e.ticketNO == ticketNo)
                {
                    record.Remove(e);
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

        public void editRecord(int ticketNo, String name, String address, Double phoneNo, String gender, String ticketType, DateTime date, DateTime entryTime, DateTime exitTime, Double totalTime, int price, Double totalAmount)
        {
            foreach (Visitors e in record)
            {
                if (e.ticketNO == ticketNo)
                {
                    e.setVisitor(ticketNo, name, address, phoneNo, gender, ticketType, date, entryTime, exitTime, totalTime, price, totalAmount);
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
                    ar.setData(Convert.ToInt32(dgvVisitors.SelectedRows[0].Cells[0].Value), dgvVisitors.SelectedRows[0].Cells[1].Value.ToString(), dgvVisitors.SelectedRows[0].Cells[2].Value.ToString(), Convert.ToDouble(dgvVisitors.SelectedRows[0].Cells[3].Value), dgvVisitors.SelectedRows[0].Cells[4].Value.ToString(), dgvVisitors.SelectedRows[0].Cells[5].Value.ToString(), Convert.ToDateTime(dgvVisitors.SelectedRows[0].Cells[6].Value), Convert.ToDateTime(dgvVisitors.SelectedRows[0].Cells[7].Value), Convert.ToDateTime(dgvVisitors.SelectedRows[0].Cells[8].Value), Convert.ToDouble(dgvVisitors.SelectedRows[0].Cells[9].Value), Convert.ToInt32(dgvVisitors.SelectedRows[0].Cells[10].Value), Convert.ToDouble(dgvVisitors.SelectedRows[0].Cells[11].Value));
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

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblUserType_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerateDaily_Click(object sender, EventArgs e)
        {
            dailyChart.Series["Number of visitors"].Points.Clear();
            genDailyChart(record);
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
            genWeeklyChart(record);
            
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
                    sundayEarning += vis.totalAmount;
                }
                else if (vis.date.DayOfWeek.ToString().Contains(monday))
                {
                    mondayCount++;
                    mondayEarning += vis.totalAmount;
                }
                else if (vis.date.DayOfWeek.ToString().Contains(tuesday))
                {
                    tuesdayCount++;
                    tuesdayEarning += vis.totalAmount;
                }
                else if (vis.date.DayOfWeek.ToString().Contains(wednesday))
                {
                    wednesdayCount++;
                    wednesdayEarning += vis.totalAmount;
                }
                else if (vis.date.DayOfWeek.ToString().Contains(thursday))
                {
                    thursdayCount++;
                    thursdayEarning += vis.totalAmount;
                }
                else if (vis.date.DayOfWeek.ToString().Contains(friday))
                {
                    fridayCount++;
                    fridayEarning += vis.totalAmount;
                }
                else if (vis.date.DayOfWeek.ToString().Contains(saturday))
                {
                    saturdayCount++;
                    saturdayEarning += vis.totalAmount;
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
    public Double totalTime { get; set; }
    public int price { get; set; }
    public Double totalAmount { get; set; }

    //Constructor for setting visitor's details
    public Visitors(int ticketNo, String name, String address, Double phoneNo, String gender, String ticketType, DateTime date, DateTime entryTime, DateTime exitTime, Double totalTime, int price, Double totalAmount)
    {
        setVisitor(ticketNo, name, address, phoneNo, gender, ticketType, date, entryTime, exitTime, totalTime, price, totalAmount);
    }

    //defining setVisitor method to set data in defined attributes.
    public void setVisitor(int ticketNo, String name, String address, Double phoneNo, String gender, String ticketType, DateTime date, DateTime entryTime, DateTime exitTime, Double totalTime, int price, Double totalAmount)
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
        this.totalAmount = totalAmount;
    }

}