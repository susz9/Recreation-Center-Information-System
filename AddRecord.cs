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

namespace Recreation_Center
{
    public partial class AddRecord : Form
    {
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

        

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void tbTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnBill_Click(object sender, EventArgs e)
        {
            

            //TimeSpan time = exitTime.Value - entryTime.Value;
            //label1.Text = time.Hours.ToString() + " hour " + time.Minutes.ToString() + " minute ";

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
                        dtExitTime.Text = DateTime.Now.ToString("h:mm");
                        Visitors visitor = new Visitors(Convert.ToInt32(tbTicketNo.Text),
                            tbName.Text,
                            tbAddress.Text,
                            Convert.ToDouble(tbPhone.Text),
                            cbGender.Text,
                            cbTicketType.Text,
                            datePicker.Value,
                            dtEntryTime.Value,
                            dtExitTime.Value,
                            Convert.ToDouble(tbTotalTIme.Text),
                            Convert.ToInt32(tbPrice.Text),
                            Convert.ToDouble(tbTotalAmount.Text));
                        ((Dashboard)Application.OpenForms["Dashboard"]).addRecord(visitor);
                    }
                    else
                    {
                        ((Dashboard)Application.OpenForms["Dashboard"]).editRecord(Convert.ToInt32(tbTicketNo.Text), tbName.Text, tbAddress.Text, Convert.ToDouble(tbPhone.Text), cbGender.Text, cbTicketType.Text, datePicker.Value, dtEntryTime.Value, dtExitTime.Value, Convert.ToDouble(tbTotalTIme.Text), Convert.ToInt32(tbPrice.Text), Convert.ToDouble(tbTotalAmount.Text));
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
            tbTotalAmount.Text = totalAmount.ToString();


        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbPhone.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter valid phone number", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPhone.Text = tbPhone.Text.Remove(tbPhone.Text.Length - 1);
            }
        }
    }
}
