using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBConnectForm
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Enter Valid Username");
            }
            else if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Enter Valid Password");
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"server=DESKTOP-0B8UT7K\SQLEXPRESS;Initial Catalog=root_db;Integrated Security=True;Encrypt=False");
                try
                {
                    conn.Open();
                    string username = textBox1.Text.Trim();
                    string password = textBox2.Text.Trim();
                    string query = "INSERT INTO log_tbl (Username, Password) VALUES (@Username, @Password)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User registered successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Registration failed. Please try again.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
