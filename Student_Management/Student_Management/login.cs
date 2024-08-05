using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace Student_Management
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-816BTNJC\SQLEXPRESS;Initial Catalog=sample_student;Integrated Security=True;Encrypt=False");

        private void button1_Click(object sender, EventArgs e)
        {
            String username, userpassword;
            username = text_username.Text;
            userpassword = text_password.Text;
            try
            {
                string query = "SELECT * FROM tbl_newstudent WHERE stud_email ='" + username + "' AND stud_password = '" + userpassword + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    username = text_username.Text;
                    userpassword = text_password.Text;
                    Homepage home = new Homepage();
                    home.Show();
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                    text_password.Clear();
                    text_username.Clear();
                    text_username.Focus();

                }
            }
            catch
            {
                MessageBox.Show("invalid");
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            text_username.Text = string.Empty;
            text_password.Text = string.Empty;


        }
    }
}
//LAPTOP-816BTNJC\SQLEXPRESS