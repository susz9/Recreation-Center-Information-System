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

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

    

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string userType = Convert.ToString(cbUserType.SelectedItem);

            if (username == "" && password == "")
            {
                MessageBox.Show(
                    "Please enter the username and password.",
                    "Invalid input");
            }
            else if (username == "" || password == "")
            {
                MessageBox.Show(
                    "Please enter correct username and password.",
                    "Invalid user credentials.");
            }
            else if (cbUserType.SelectedItem == default)
            {
                MessageBox.Show(
                    "Please select user type.",
                    "Invalid user credentials.");
            }
            else if (username == "admin_susan" && password == "admin" && userType == "Admin")
            {
                MessageBox.Show("welcome");
                Dashboard dashboard = new Dashboard(username, userType);
                this.Hide();
                dashboard.Show();
            }
            else if (username == "staff_susan" && password == "staff" && userType == "Staff")
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
            System.Windows.Forms.Application.Exit();
        }
    }
}
