using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Connection string to connect to your database
            string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;";

            // SQL command to insert a name into the tbl_sample table
            string query = "INSERT INTO tbl_sample (Name) VALUES (@Name)";

            // Getting the text from textBox1
            string name = textBox1.Text;

            // Ensure textBox1 is not empty
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a name.");
                return;
            }

            // Using statement ensures that the resources are disposed of properly
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Adding parameter to prevent SQL injection
                    command.Parameters.AddWithValue("@Name", name);

                    try
                    {
                        // Open the connection, execute the query, then close the connection
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Name inserted successfully!");
                    }
                    catch (Exception ex)
                    {
                        // Handle any errors that may have occurred
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Optional: Code to execute when the form loads
        }
    }
}
