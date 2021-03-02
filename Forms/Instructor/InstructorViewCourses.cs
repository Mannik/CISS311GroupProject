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

namespace CISS311GroupProject.Forms.Instructor
{
    public partial class InstructorViewCourses : Form
    {
        string connectionString;
        SqlConnection conn;
        public InstructorViewCourses()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CISS311GroupProject.Properties.Settings.TinyCollegeConnectionString"].ConnectionString;
        }

        private void InstructorViewCourses_Load(object sender, EventArgs e)
        {
            //On load, fill instructor combo box with options so they can select themselves to view their courses.
            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT firstName + ' ' + lastName AS name, employeeId FROM employee", conn))
            {
                DataTable instructorTable = new DataTable();
                adapter.Fill(instructorTable);
                instructorComboBox.DisplayMember = "name";
                instructorComboBox.ValueMember = "employeeID";
                instructorComboBox.DataSource = instructorTable;
            }
        }

        private void instructorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when they change instructor selection, update listbox with correct instructor's classes
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("SELECT * FROM course WHERE employeeId = @employeeId", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@employeeId", instructorComboBox.SelectedValue);
                DataTable courseTable = new DataTable();
                adapter.Fill(courseTable);
                courseListBox.DisplayMember = "Title";
                courseListBox.ValueMember = "CourseID";
                courseListBox.DataSource = courseTable;
            }
        }

        private void courseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when a course in the course listbox is selected, update the selected course info to the proper course
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("SELECT courseId, title, maxSeats, seats AS filledSeats, isAvailable AS Availability FROM course " +
                "WHERE courseId = @courseId", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@courseId", courseListBox.SelectedValue.ToString());
                DataTable selectedCourseTable = new DataTable();
                adapter.Fill(selectedCourseTable);
                DataRow dr = selectedCourseTable.Rows[0];
                courseNameLabel.Text = dr["title"].ToString();
                courseIdLabel.Text = dr["courseId"].ToString();
                if (dr["Availability"].ToString() == "0")
                {
                    enrollmentStatusLabel.Text = "Class enrollment is open.";
                }
                else
                {
                    enrollmentStatusLabel.Text = "Class enrollment is closed.";
                }
                string totalSeatsString = dr["maxSeats"].ToString();
                int totalSeats = int.Parse(totalSeatsString);
                int studentCount = int.Parse(dr["filledSeats"].ToString());
                totalSeatCountLabel.Text = totalSeatsString;
                studentCountLabel.Text = studentCount.ToString();
                openSeatCountLabel.Text = (totalSeats - studentCount).ToString();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
