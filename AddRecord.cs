﻿//Written by: Susan Shrestha
//Date: 29 December, 2021
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recreation_Center
{
    public partial class AddRecord : Form
    {
        public static BindingList<TicketRate> ticketRecord = new BindingList<TicketRate>(); //initializing new binding list with the type of Visitor
        private BindingList<string> alreadyOpenedTicket = new BindingList<string>();

        public bool editMode { get; set; }

        public Double totalTime = 0;
        public int totalAmount = 0;

        public AddRecord()
        {
            InitializeComponent();
        }

        private void lblExitTime_Click(object sender, EventArgs e)
        {

        }



        private void lblTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void tbTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbAddress.Text == "" || tbPhone.Text == "" || cbGender.Text == "" || cbTicketType.Text == "" || tbTicketNo.Text == "" || datePicker.Text == "" || dtEntryTime.Text == "" || tbPrice.Text == "")
            {
                MessageBox.Show("Please fill the required (*) feilds.", "Invalid Input", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    if(editMode == false)
                    {
                        dtExitTime.Text = DateTime.Now.ToString("h");
                        Visitors visitor = new Visitors(Convert.ToInt32(tbTicketNo.Text),
                            tbName.Text,
                            tbAddress.Text,
                            Convert.ToDouble(tbPhone.Text),
                            cbGender.Text,
                            cbTicketType.Text,
                            datePicker.Value,
                            dtEntryTime.Value,
                            dtExitTime.Value,
                            tbTotalTIme.Text,
                            Convert.ToInt32(tbPrice.Text));
                        ((Dashboard)Application.OpenForms["Dashboard"]).addVisitorRecord(visitor);
                        tbTicketNo.Text = "";
                        tbName.Text = "";
                        tbAddress.Text = "";
                        tbPhone.Text = "";
                        cbGender.Text = "";
                        cbTicketType.Text = "";
                        tbPrice.Text = "";
                    }
                    else
                    {
                        ((Dashboard)Application.OpenForms["Dashboard"]).editVisitorRecord(Convert.ToInt32(tbTicketNo.Text), tbName.Text, tbAddress.Text, Convert.ToDouble(tbPhone.Text), cbGender.Text, cbTicketType.Text, datePicker.Value, dtEntryTime.Value, dtExitTime.Value, tbTotalTIme.Text, Convert.ToInt32(tbPrice.Text));
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error");
                }
            }
        }

        public void setData(int ticketNo, String name, String address, Double phoneNo, String gender, String ticketType, DateTime date, DateTime entryTime, DateTime exitTime, Double totalTime, int price, Double totalAmount)
        {
            tbTicketNo.Text = ticketNo.ToString();
            tbTicketNo.ReadOnly = true;
            tbName.Text = name;
            tbAddress.Text = address;
            tbPhone.Text = phoneNo.ToString();
            cbGender.Text = gender;
            cbTicketType.Text = ticketType;
            datePicker.Value = date;
            dtEntryTime.Value = entryTime;
            dtExitTime.Value = exitTime;
            tbTotalTIme.Text = totalTime.ToString();
            tbPrice.Text = price.ToString();


        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbPhone.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter valid phone number.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPhone.Text = tbPhone.Text.Remove(tbPhone.Text.Length - 1);
            }
        }

        private void AddRecord_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("Ticket_rate.csv")) //checking existing file to load in the GridView
                {
                    FileStream fst = new FileStream("Ticket_rate.csv", FileMode.Open);
                    BinaryFormatter bft = new BinaryFormatter();
                    ticketRecord = (BindingList<TicketRate>)bft.Deserialize(fst); //Deserializing BindingList
                    fst.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            dgvTicketList.DataSource = ticketRecord;
            dgvTicketList.Columns["Index"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            if (!editMode)
                btnSave.Text = "Add Record";
            else
                btnSave.Text = "Edit Record";
        }

        private void tbTicketNo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbTicketNo.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter valid ticket number.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbTicketNo.Text = tbTicketNo.Text.Remove(tbTicketNo.Text.Length - 1);
            }
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbPrice.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter valid price amount.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPrice.Text = tbPrice.Text.Remove(tbPrice.Text.Length - 1);
            }
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            tbName.Text = "";
            tbAddress.Text = "";
            tbPhone.Text = "";
            cbGender.Text = default;
            cbTicketType.Text = default;
            tbTicketNo.Text = "";
            tbTotalTIme.Text = "0 hr";
            tbPrice.Text = "";
        }

        private void chbDiscount_CheckedChanged(object sender, EventArgs e)
        {
            int getPrice = Convert.ToInt32(tbPrice.Text);
            if(chbDiscount.Checked == true)
            {
                int discount = Convert.ToInt32(0.1 * getPrice);
                int discountedPrice = getPrice - discount;
                tbPrice.Text = discountedPrice.ToString();
            }
            else
            {
                tbPrice.Text = getPrice.ToString();
            }
        }

        private void tbPrice_Click(object sender, EventArgs e)
        {
            chbDiscount.Checked = false;

        }
    }
}
