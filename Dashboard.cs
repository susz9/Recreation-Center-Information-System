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

namespace Recreation_Center
{
    public partial class Dashboard : Form
    {
        public static BindingList<Visitor> record = new BindingList<Visitor>(); //initializing new binding list with the type of Visitor
        private BindingList<string> already_opened = new BindingList<string>();

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e) //After Login
        {
            if (File.Exists("Visitors_record.csv")) //checking existing file to load in the GridView
            {
                FileStream fs = new FileStream("Visitors_record.csv", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                record = (BindingList<Visitor>)bf.Deserialize(fs); //Deserializing BindingList
                fs.Close();
            }
            else
            {
                MessageBox.Show("no files found");
            }
            dgvVisitors.DataSource = record; //setting GridView datasource with visitors' record
            //dgvVisitors.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; //gridView column size fill

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
                            Visitor visitor = new Visitor(Convert.ToInt32(items[0]), items[1], items[2], Convert.ToDouble(items[3]), items[4], items[5], Convert.ToDateTime(items[6]), Convert.ToDateTime(items[7]), Convert.ToDateTime(items[8]), Convert.ToDouble(items[9]), Convert.ToInt32(items[10]), Convert.ToDouble(items[11]));
                            addRecord(visitor);
                        }

                    }
                    MessageBox.Show("Records loaded successfully");
                }
                else
                {
                    MessageBox.Show(" ERROR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        public void addRecord(Visitor e)
        {
            record.Add(e);
            dgvVisitors.DataSource = record;
        }

        //Opens AddRecord form to add new record
        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            AddRecord ar = new AddRecord(); 
            ar.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        public void deleteRecord(int ticketNo) 
        {
            foreach (Visitor e in record)
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
            deleteRecord(Convert.ToInt32(dgvVisitors.SelectedRows[0].Cells[0].Value)); //for deleting the selected/active row

        }

        public void editRecord(int ticketNo, String name, String address, Double phoneNo, String gender, String ticketType, DateTime date, DateTime entryTime, DateTime exitTime, Double totalTime, int price, Double totalAmount)
        {
            foreach (Visitor e in record)
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
            if (Application.OpenForms["AddRecord"] == null)
            {
                AddRecord ar = new AddRecord();
                ar.editMode = true;
                ar.Text = "Modify Record";
                ar.setData(Convert.ToInt32(dgvVisitors.SelectedRows[0].Cells[0].Value), dgvVisitors.SelectedRows[0].Cells[1].Value.ToString(), dgvVisitors.SelectedRows[0].Cells[2].Value.ToString(), Convert.ToDouble(dgvVisitors.SelectedRows[0].Cells[3].Value), dgvVisitors.SelectedRows[0].Cells[4].Value.ToString(), dgvVisitors.SelectedRows[0].Cells[5].Value.ToString(), Convert.ToDateTime(dgvVisitors.SelectedRows[0].Cells[6].Value), Convert.ToDateTime(dgvVisitors.SelectedRows[0].Cells[7].Value), Convert.ToDateTime(dgvVisitors.SelectedRows[0].Cells[8].Value), Convert.ToDouble(dgvVisitors.SelectedRows[0].Cells[9].Value), Convert.ToDouble(dgvVisitors.SelectedRows[0].Cells[10].Value));
                ar.Show();
            }
            else
            {
                ((AddRecord)Application.OpenForms["AddRecord"]).editMode = true;
                Application.OpenForms["AddRecord"].BringToFront();
            }
        }
    }
}

[Serializable]
public class Visitor  //visitor class for visitor records
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
    public Visitor(int ticketNo, String name, String address, Double phoneNo, String gender, String ticketType, DateTime date, DateTime entryTime, DateTime exitTime, Double totalTime, int price, Double totalAmount)
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