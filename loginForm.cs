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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
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
            else if (username == "admin" && password == "admin" && cbUserType.Text == "Admin")
            {
                MessageBox.Show("welcome");
                Dashboard dashboard = new Dashboard();
                this.Hide();
                dashboard.Show();
            }
            else if (username == "staff" && password == "staff" && cbUserType.Text == "Staff")
            {
                MessageBox.Show("welcome");
                Dashboard dashboard = new Dashboard();
                this.Hide();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Please enter the correct login details.", "Invalid login");

            }


        }
    }
}
