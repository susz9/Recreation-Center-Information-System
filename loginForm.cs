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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //storing windows form values in variables
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string userType = Convert.ToString(cbUserType.SelectedItem);

            if (username == "" && password == "") //checking empty fields
            {
                MessageBox.Show(
                    "Please enter the username and password.",
                    "Invalid input");
            }
            else if (cbUserType.SelectedItem == default) //validating user type
            {
                MessageBox.Show(
                    "Please select user type.",
                    "Invalid user credentials.");
            }
            else if (username == "admin_susan" && password == "admin" && userType == "Admin") //validating user credentials
            {
                Dashboard dashboard = new Dashboard(username, userType); //passing username and usertype values to dashboard form
                this.Hide();
                dashboard.Show();
            }
            else if (username == "staff_susan" && password == "staff" && userType == "Staff") //validating user credentials
            {
                Dashboard dashboard = new Dashboard(username, userType);
                this.Hide();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Please enter the correct login details.", "Invalid login");

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit(); //closing application
        }
    }
}
