using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeApplication
{
    public partial class Registerform : Form
    {
        public Registerform()
        {
            InitializeComponent();
        }

        private void rgstrnametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void rgstrpasstxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void rgstrconfirmtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            // Get values from textboxes
            string username = rgstrnametxt.Text.Trim();
            string password = rgstrpasstxt.Text.Trim();
            string confirmPassword = rgstrconfirmtxt.Text.Trim();

            // Validate fields
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if passwords match
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Simulate registration (store user info - replace this with actual database logic)
            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Optionally clear fields after successful registration
            rgstrnametxt.Clear();
            rgstrpasstxt.Clear();
            rgstrconfirmtxt.Clear();
        }

        private void haveanaccountbtn_Click(object sender, EventArgs e)
        {
            // Navigate to login form (if it exists)
            loginform loginForm = new loginform(); // Make sure LoginForm exists in your project
            loginForm.Show();
            this.Hide(); // Hide registration form
        }
    
    }
}
