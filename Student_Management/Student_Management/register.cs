using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Student_Management
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
            // Add the event handler for the submit button
            submit.Click += Submit_Click;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            // Gather data from form fields
            string name = text_name.Text;
            string department = checkBox1.Checked ? "CS" : checkBox2.Checked ? "Commerce" : "";
            string gender = radioButton1.Checked ? "Male" : "Female";
            string address = text_address.Text;
            DateTime dob = this.dob.Value;
            decimal mobile = decimal.Parse(text_number.Text);
            string email = text_username.Text;
            string password = text_password.Text;

            // Define the connection string
            string connectionString = @"Data Source=LAPTOP-816BTNJC\SQLEXPRESS;Initial Catalog=sample_student;Integrated Security=True;Encrypt=False";

            // SQL insert query
            string query = "INSERT INTO tbl_newstudent (stud_name, depart_id, stud_gender, stud_address, stud_dob, stud_mobile, stud_email, stud_password) " +
                           "VALUES (@name, @depart_id, @gender, @address, @dob, @mobile, @email, @password)";

            // Use a try-catch block to handle exceptions
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Define the parameters and assign values
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@depart_id", department == "CS" ? 1 : 2); // Example department IDs

                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@dob", dob);
                        cmd.Parameters.AddWithValue("@mobile", mobile);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password);

                        // Open the connection, execute the query, and close the connection
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Student registered successfully!");
                        login log = new login();
                        log.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Your existing code
        }

        private void label7_Click(object sender, EventArgs e)
        {
            // Your existing code
        }

        private void clear_Click(object sender, EventArgs e)
        {
            // Clear all TextBox fields
            text_name.Text = string.Empty;
            text_number.Text = string.Empty;
            text_username.Text = string.Empty;
            text_password.Text = string.Empty;

            // Clear RichTextBox field
            text_address.Clear();

            // Reset RadioButton fields
            radioButton1.Checked = false; // Male
            radioButton2.Checked = false; // Female

            // Reset CheckBox fields
            checkBox1.Checked = false; // CS
            checkBox2.Checked = false; // Commerce

            // Reset DateTimePicker field to the current date
            dob.Value = DateTime.Now;
        }

    }
}