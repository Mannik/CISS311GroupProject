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
    public partial class StudentEnrollCourse : Form
    {
        string connectionString;
        SqlConnection conn;
        int studentId;

        public StudentEnrollCourse(int studentFormId)
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CISS311GroupProject.Properties.Settings.TinyCollegeConnectionString"].ConnectionString;
            studentId = studentFormId;

        }

        private Boolean noOverbooking(string selectedCourseId)
        {
            bool overbooked;

            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("SELECT seats, maxSeats from course where courseId = @courseId", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@courseId", selectedCourseId);
                DataTable checkSeats = new DataTable();
                adapter.Fill(checkSeats);
                DataRow dr = checkSeats.Rows[0];

                if (int.Parse(dr["seats"].ToString()) > int.Parse(dr["maxSeats"].ToString()))
                {
                    overbooked = true;
                    MessageBox.Show("Course is overbooked. Not available for registration.");
                }
                else
                {
                    overbooked = false;
                    MessageBox.Show("Course is not overbooked.");
                }

            }
            return overbooked;
        }

        private void StudentEnrollCourse_Load(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM course", conn))
            {
                DataTable courseTable = new DataTable();
                adapter.Fill(courseTable);
                courseSelectionComboBox.DisplayMember = "title";
                courseSelectionComboBox.ValueMember = "courseId";
                courseSelectionComboBox.DataSource = courseTable;

            }
        }



        private void fillCourseInfo(int selectedcourseId)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("SELECT course.courseId, course.title, course.employeeId, course.seats, course.maxSeats, course.isAvailable, " +
               "employee.employeeId, employee.firstName + ' ' + employee.lastName AS 'Name', employee.isAdmin FROM course JOIN employee " +
               "ON course.employeeId = employee.employeeId WHERE course.courseId = @courseId", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@courseId", selectedcourseId);
                DataTable courseTable = new DataTable();
                adapter.Fill(courseTable);
                DataRow dr = courseTable.Rows[0];
                courseTitleLabel.Text = dr["title"].ToString();
                instructorLabel.Text = dr["Name"].ToString();
                seatCountLabel.Text = dr["seats"].ToString();
                if (int.Parse(dr["seats"].ToString()) > int.Parse(dr["maxSeats"].ToString()))
                {
                    isAvailableLabel.Text = "Closed";
                }
                else
                {
                    isAvailableLabel.Text = "Open";
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clear()
        {
            courseTitleLabel.Text = string.Empty;
            instructorLabel.Text = string.Empty;
            seatCountLabel.Text = string.Empty;
            isAvailableLabel.Text = string.Empty;

        }

        private void enrollCloseButton_Click(object sender, EventArgs e)
        {
            enrollStudent(studentId);
            Close();
        }

        private void enrollNewButton_Click(object sender, EventArgs e)
        {
            enrollStudent(studentId);
            clear();
        }

        private void enrollStudent(int studentId)
        {
            noOverbooking(courseSelectionComboBox.SelectedValue.ToString());

            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand
                ("INSERT INTO coursexstudent (studentId, courseId) VALUES (@studentId, @courseId)", conn))
            {
                conn.Open();
                comd.Parameters.AddWithValue("@studentId", studentId);
                comd.Parameters.AddWithValue("@courseId", courseSelectionComboBox.SelectedValue);
                comd.ExecuteScalar();
                MessageBox.Show("Course enrollment successful.");
            }
            increaseSeatCount();
        }

        private void increaseSeatCount()
        {

            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("Update course SET seats = @seats WHERE courseId = @courseId", conn))
            {
                conn.Open();
                comd.Parameters.AddWithValue("@courseId", courseSelectionComboBox.SelectedValue);
                comd.Parameters.AddWithValue("@seats", (int.Parse(seatCountLabel.Text) + 1));
                comd.ExecuteScalar();
            }
        }

        private void courseSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillCourseInfo(int.Parse(courseSelectionComboBox.SelectedValue.ToString()));
        }
    }
}