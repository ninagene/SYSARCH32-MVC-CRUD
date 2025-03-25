using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace CollegeApplication
{
    public partial class Form1 : Form
    {
        private string connectionString = "server=localhost;database=college_db;uid=root;pwd=;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //LoadColleges();
            //LoadDepartments();
            textBox1.TextChanged += textBox1_TextChanged;
            progressBar1.Visible = true;  // Show the progress bar
            timer1.Start();  // Wait a moment before running the database queries

        }
        private void LoadColleges()
        {
            try
            {
                // Show the progress bar before loading
                progressBar1.Visible = true;
                Application.DoEvents(); // Forces UI to refresh before running the database query

                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM Colleges", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    COLLEGEdgv.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading colleges: " + ex.Message);
            }
            finally
            {
                // Hide the progress bar after loading
                progressBar1.Visible = false;
            }
        }

        private void LoadDepartments()

        {
            try
            {
                // Show the progress bar before loading
                progressBar1.Visible = true;
                Application.DoEvents(); // Forces UI to refresh before running the database query

                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"
            SELECT d.DepartmentID, d.DepartmentName, d.DepartmentCode, d.IsActive, 
                   d.CollegeID, c.CollegeName, c.CollegeCode 
            FROM Departments d
            LEFT JOIN Colleges c ON d.CollegeID = c.CollegeID";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        DEPARTMENTdgv.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading departments: " + ex.Message);
            }
            finally
            {
                // Hide the progress bar after loading
                progressBar1.Visible = false; 
            }
        }


        private void COLLEGENAMEtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void COLLEGECODEtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void COLLEGEIDtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void COLLEGEisActivecb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void COLLEGEAddbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(COLLEGEIDtxt.Text) || string.IsNullOrWhiteSpace(COLLEGENAMEtxt.Text))
            {
                MessageBox.Show("Please enter a College ID and Name.");
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(
                        "INSERT INTO Colleges (CollegeID, CollegeName, CollegeCode, IsActive) VALUES (@id, @name, @code, @active)", con))
                    {
                        cmd.Parameters.AddWithValue("@id", COLLEGEIDtxt.Text);  // Ensure ID is set
                        cmd.Parameters.AddWithValue("@name", COLLEGENAMEtxt.Text);
                        cmd.Parameters.AddWithValue("@code", COLLEGECODEtxt.Text);
                        cmd.Parameters.AddWithValue("@active", COLLEGEisActivecb.Checked);
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadColleges();
                MessageBox.Show("College added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding college: " + ex.Message);
            }
        }


        private void COLLEGEEditbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(COLLEGEIDtxt.Text))
            {
                MessageBox.Show("Please select a college to edit.");
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(
                        "UPDATE Colleges SET CollegeName=@name, CollegeCode=@code, IsActive=@active WHERE CollegeID=@id", con))
                    {
                        cmd.Parameters.AddWithValue("@id", COLLEGEIDtxt.Text);
                        cmd.Parameters.AddWithValue("@name", COLLEGENAMEtxt.Text);
                        cmd.Parameters.AddWithValue("@code", COLLEGECODEtxt.Text);
                        cmd.Parameters.AddWithValue("@active", COLLEGEisActivecb.Checked);
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadColleges();
                MessageBox.Show("College updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating college: " + ex.Message);
            }
        }


        private void COLLEGEDeletebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(COLLEGEIDtxt.Text))
            {
                MessageBox.Show("Please select a college to delete.");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this college?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection con = new MySqlConnection(connectionString))
                    {
                        con.Open();
                        using (MySqlCommand cmd = new MySqlCommand("DELETE FROM Colleges WHERE CollegeID=@id", con))
                        {
                            cmd.Parameters.AddWithValue("@id", COLLEGEIDtxt.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    LoadColleges();
                    MessageBox.Show("College deleted successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting college: " + ex.Message);
                }
            }
        }

        private void COLLEGEdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && COLLEGEdgv.Rows[e.RowIndex].Cells["CollegeID"].Value != null)
            {
                DataGridViewRow row = COLLEGEdgv.Rows[e.RowIndex];

                COLLEGEIDtxt.Text = row.Cells["CollegeID"].Value?.ToString() ?? "";
                COLLEGENAMEtxt.Text = row.Cells["CollegeName"].Value?.ToString() ?? "";
                COLLEGECODEtxt.Text = row.Cells["CollegeCode"].Value?.ToString() ?? "";
                COLLEGEisActivecb.Checked = row.Cells["IsActive"].Value != DBNull.Value && Convert.ToBoolean(row.Cells["IsActive"].Value);
            }
        }


        private void DEPARTMENTNAMEtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void DEPARTMENTCODEtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void DEPEARTMENTIDtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void DEPARTEMNTisActivecb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DEPARTMENTADDbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DEPEARTMENTIDtxt.Text) || string.IsNullOrWhiteSpace(DEPARTMENTNAMEtxt.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter a Department ID, Name, and College ID.");
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(
                        "INSERT INTO Departments (DepartmentID, DepartmentName, DepartmentCode, IsActive, CollegeID) VALUES (@id, @name, @code, @active, @collegeID)", con))
                    {
                        cmd.Parameters.AddWithValue("@id", DEPEARTMENTIDtxt.Text);  // Ensure ID is set
                        cmd.Parameters.AddWithValue("@name", DEPARTMENTNAMEtxt.Text);
                        cmd.Parameters.AddWithValue("@code", DEPARTMENTCODEtxt.Text);
                        cmd.Parameters.AddWithValue("@active", DEPARTEMNTisActivecb.Checked);
                        cmd.Parameters.AddWithValue("@collegeID", textBox1.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadDepartments();
                MessageBox.Show("Department added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding department: " + ex.Message);
            }
        }


        private void DEPARTMENTEDITbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DEPEARTMENTIDtxt.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please select a department and its corresponding college.");
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(
                        "UPDATE Departments SET DepartmentName=@name, DepartmentCode=@code, IsActive=@active, CollegeID=@collegeID WHERE DepartmentID=@id", con))
                    {
                        cmd.Parameters.AddWithValue("@name", DEPARTMENTNAMEtxt.Text);
                        cmd.Parameters.AddWithValue("@code", DEPARTMENTCODEtxt.Text);
                        cmd.Parameters.AddWithValue("@active", DEPARTEMNTisActivecb.Checked);
                        cmd.Parameters.AddWithValue("@collegeID", textBox1.Text); // Use textBox1
                        cmd.Parameters.AddWithValue("@id", DEPEARTMENTIDtxt.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadDepartments();
                MessageBox.Show("Department updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating department: " + ex.Message);
            }
        }


        private void DEPARTMENTDELETEbtn_Click(object sender, EventArgs e)
        {
             if (string.IsNullOrWhiteSpace(DEPEARTMENTIDtxt.Text))
    {
        MessageBox.Show("Please select a department to delete.");
        return;
    }

    if (MessageBox.Show("Are you sure you want to delete this department?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
    {
        try
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM Departments WHERE DepartmentID=@id", con))
                {
                    cmd.Parameters.AddWithValue("@id", DEPEARTMENTIDtxt.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            LoadDepartments();
            MessageBox.Show("Department deleted successfully!");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error deleting department: " + ex.Message);
        }
    }
        }

        private void DEPARTMENTdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DEPARTMENTdgv.Rows[e.RowIndex].Cells["DepartmentID"].Value != null)
            {
                DataGridViewRow row = DEPARTMENTdgv.Rows[e.RowIndex];

                DEPEARTMENTIDtxt.Text = row.Cells["DepartmentID"].Value?.ToString() ?? "";
                DEPARTMENTNAMEtxt.Text = row.Cells["DepartmentName"].Value?.ToString() ?? "";
                DEPARTMENTCODEtxt.Text = row.Cells["DepartmentCode"].Value?.ToString() ?? "";
                DEPARTEMNTisActivecb.Checked = row.Cells["IsActive"].Value != DBNull.Value && Convert.ToBoolean(row.Cells["IsActive"].Value);

                textBox1.Text = row.Cells["CollegeID"].Value?.ToString() ?? "";
                COLLEGENAMEtxt.Text = row.Cells["CollegeName"].Value?.ToString() ?? "";
            }
        }

        private void FilterDepartmentsByCollegeID(string collegeID)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = @"
            SELECT d.DepartmentID, d.DepartmentName, d.DepartmentCode, d.IsActive, 
                   d.CollegeID, c.CollegeName, c.CollegeCode 
            FROM Departments d
            LEFT JOIN Colleges c ON d.CollegeID = c.CollegeID
            WHERE d.CollegeID = @collegeID";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@collegeID", collegeID);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        DEPARTMENTdgv.DataSource = dt;
                    }
                }
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                FilterDepartmentsByCollegeID(textBox1.Text);
            }
            else
            {
                LoadDepartments(); // Show all if empty
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();  // Stop the timer after it runs once
            LoadColleges();
            LoadDepartments();
        }
    }
}
