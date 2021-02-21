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
using System.Configuration;

namespace CISS311GroupProject
{
    public partial class AddCourseForm : Form
    {
        string connectionString;
        SqlConnection conn;
        public AddCourseForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CISS311GroupProject.Properties.Settings.TinyCollegeConnectionString"].ConnectionString;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddCourseForm_Load(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT FirstName, LastName, EmployeeID FROM Employee = ", conn))
            {
                DataTable courseTable = new DataTable();
                adapter.Fill(courseTable);
                instructorComboBox.DisplayMember = String.Format($"{0} {1}", "FirstName", "LastName");
                instructorComboBox.ValueMember = "EmployeeID";
                instructorComboBox.DataSource = courseTable;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrWhiteSpace(courseTextBox.Text)))
            {
                int result;
                if (int.TryParse(seatsTextBox.Text, out result))
                {
                    using (conn = new SqlConnection(connectionString))
                    using (SqlCommand comd = new SqlCommand("INSERT INTO Course (Title, Seats, Instructor) VALUES (@Title, @Seats, @InstructorID)", conn))
                    {
                        comd.Parameters.AddWithValue("@Title", courseTextBox.Text);
                        comd.Parameters.AddWithValue("@Seats", result);
                        comd.Parameters.AddWithValue("@InstructorID", instructorComboBox.SelectedValue);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid number of seats.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a course name.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
