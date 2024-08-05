using Microsoft.Data.SqlClient;
using System.Data;

namespace Student_Management
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
            LoadStudentDropdown();
        }

        private void LoadStudentDropdown()
        {
            string connectionString = @"Data Source=LAPTOP-816BTNJC\SQLEXPRESS;Initial Catalog=sample_student;Integrated Security=True;Encrypt=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Query to fetch student names and their corresponding results
                string query = @"
                    SELECT ns.stud_id, ns.stud_name 
                    FROM tbl_newstudent ns
                    INNER JOIN tbl_result tr ON ns.stud_id = tr.stud_id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        // Bind the DataTable to the ComboBox
                        comboBoxStudents.DisplayMember = "stud_name";
                        comboBoxStudents.ValueMember = "stud_id";
                        comboBoxStudents.DataSource = dt;
                    }
                }
            }
        }

        private void ButtonViewResult_Click(object sender, EventArgs e)
        {
            if (comboBoxStudents.SelectedValue != null)
            {
                int stud_id = (int)comboBoxStudents.SelectedValue;
                string connectionString = @"Data Source=LAPTOP-816BTNJC\SQLEXPRESS;Initial Catalog=sample_student;Integrated Security=True;Encrypt=False";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to fetch student marks
                    string query = "SELECT stud_marks FROM tbl_result WHERE stud_id = @stud_id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@stud_id", stud_id);
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            float stud_marks = Convert.ToSingle(result);
                            labelResult.Text = $"Name: {comboBoxStudents.Text}, Marks: {stud_marks}";
                        }
                        else
                        {
                            labelResult.Text = "No results found for the selected student.";
                        }
                    }
                }
            }
        }
    }
}