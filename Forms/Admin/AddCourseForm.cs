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
            //Fill instructor combo box with all instructors from the employee table
            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT firstName + ' ' + lastName AS Name, employeeID FROM employee", conn))
            {
                DataTable instructorTable = new DataTable();
                adapter.Fill(instructorTable);
                instructorComboBox.DisplayMember = "Name";
                instructorComboBox.ValueMember = "EmployeeID";
                instructorComboBox.DataSource = instructorTable;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //if the new course text box isn't empty, check if the seats textbox has a valid number. If the number is valid, query the course table to see if a course
            //with the same name as in the new course textbox already exists. If not, write the new course to the table
            if (!(String.IsNullOrWhiteSpace(courseTextBox.Text)))
            {
                int result;
                if (int.TryParse(seatsTextBox.Text, out result))
                {
                    using (conn = new SqlConnection(connectionString))
                    using (SqlCommand checkComd = new SqlCommand("SELECT title FROM course WHERE title = @Title", conn))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(checkComd))
                    {
                        checkComd.Parameters.AddWithValue("@Title", courseTextBox.Text);
                        DataTable existingCourse = new DataTable();
                        adapter.Fill(existingCourse);
                        if(existingCourse.Rows.Count < 1)
                        {
                            using (SqlCommand comd = new SqlCommand("INSERT INTO course (title, maxSeats, employeeId, isAvailable) VALUES (@Title, @maxSeats, @InstructorID, 0)", conn))
                            {
                                comd.Parameters.AddWithValue("@Title", courseTextBox.Text);
                                comd.Parameters.AddWithValue("@maxSeats", result);
                                comd.Parameters.AddWithValue("@InstructorID", instructorComboBox.SelectedValue);
                                conn.Open();
                                comd.ExecuteScalar();
                                MessageBox.Show("Course added successfully.");
                                courseTextBox.Clear();
                                seatsTextBox.Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show("A Course with this name already exists.");
                            courseTextBox.Clear();
                        }
                    }
                   
                }
                else
                {
                    MessageBox.Show("Please enter a valid number of seats.");
                    seatsTextBox.Clear();
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
