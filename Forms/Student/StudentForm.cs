using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CISS311GroupProject
{
    public partial class StudentForm : Form
    {
        string connectionString;
        SqlDataAdapter adapter;
        SqlConnection conn;
        int studentId;

        public StudentForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings
    ["CISS311GroupProject.Properties.Settings.TinyCollegeConnectionString"]
    .ConnectionString;
        }

        private void enrollButton_Click(object sender, EventArgs e)
        {
            StudentEnrollCourse studentEnrollCourse = new StudentEnrollCourse(int.Parse(studentIdTextBox.Text));
            studentEnrollCourse.ShowDialog();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            // finds and fills in student information off student Id search
            fillStudentInfo();

        }

        private void fillStudentInfo()
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand(
                "SELECT * from student where studentId = @studentId", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@studentId", studentIdTextBox.Text);

                DataTable studentTable = new DataTable();
                adapter.Fill(studentTable);
                if (studentTable.Rows.Count < 1)
                {
                    MessageBox.Show("No Student Found.");
                }
                else
                {
                    DataRow dr = studentTable.Rows[0];
                    firstNameLabel.Text = dr["firstName"].ToString();
                    lastNameLabel.Text = dr["lastName"].ToString();
                    studentTotalCreditsLabel.Text = dr["credits"].ToString();
                    studentId = int.Parse(studentIdTextBox.Text);
                    checkCreditCount();
                }
            }
        }

            private void checkCreditCount()
        {
            // Find a student and check if they have enough credits to graduate.
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand(
                "SELECT credits from student where studentId = @studentId", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@studentId", studentIdTextBox.Text);
                DataTable studentTable = new DataTable();
                adapter.Fill(studentTable);
                DataRow dr = studentTable.Rows[0];

                if (int.Parse(dr["credits"].ToString()) >= 120)
                {
                    MessageBox.Show("Congratulations! You have enough credits to graduate.");
                }
                else
                {
                    MessageBox.Show("Sorry, you do not have enough credits to graduate. You need at least 120 and you only have " + dr["credits"].ToString() + ".");
                    remainingCreditsLabel.Text = "Remaining Credits: " + (120 - int.Parse(dr["credits"].ToString()));
                }

            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void viewCoursesButton_Click(object sender, EventArgs e)
        {
            Forms.Student.StudentViewCourses studentViewCourses = new Forms.Student.StudentViewCourses(studentId);
            studentViewCourses.ShowDialog();
        }

        private void enrollButton_Click_1(object sender, EventArgs e)
        {
            StudentEnrollCourse studentEnrollCourse = new StudentEnrollCourse(int.Parse(studentIdTextBox.Text));
            studentEnrollCourse.ShowDialog();
        }
    }
}

