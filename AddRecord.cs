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
            TimeSpan time = exitTime.Value - entryTime.Value;

            label1.Text = time.ToString();
            string s = label1.Text;
            string[] temp = label1.Text.Split('.');
            label1.Text = time.Hours.ToString() + " hour " + time.Minutes.ToString() + " minute ";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbAddress.Text == "" || tbPhone.Text == "" || cbGender.Text == "" || cbTicketType.Text == "" || tbTicketNo.Text == "" || datePicker.Text == "" || entryTime.Text == "" || tbPrice.Text == "")
            {
                MessageBox.Show("Please fill the required feilds.", "Invalid Input", MessageBoxButtons.OK);
            }
        }

        public void setData(int ticketNo, String name, String address, Double phoneNo, String gender, String ticketType, DateTime date, DateTime entryTime, DateTime exitTime, Double totalTime, Double totalAmount)
        {
            

        }
    }
}
