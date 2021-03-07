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

        //check to see if the course is overbooked
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

        //initial load of course information for the course combobox
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


        //fill the course data upon a combobox selection; fill the course form labels with select data
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


        //clear course form labels
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

        //perform checks and enroll student in course
        private void enrollStudent(int studentId)
        {
            if (isStudentAlreadyEnrolled(studentId, int.Parse(courseSelectionComboBox.SelectedValue.ToString())) == false)
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
            else
            {
                MessageBox.Show("You're already registered for this class. Please choose another one.");
            }
            
        }

        //check to see if the student is already enrolled in the selected course
        private Boolean isStudentAlreadyEnrolled(int formStudentId, int formCourseId)
        {
            bool queryResult;

            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand
                ("SELECT * FROM coursexstudent WHERE studentId = @studentId AND courseId = @courseId", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@courseId", formCourseId);
                comd.Parameters.AddWithValue("@studentId", formStudentId);
                DataTable courseXstudentTable = new DataTable();
                adapter.Fill(courseXstudentTable);

                if (courseXstudentTable.Rows.Count > 0)
                {
                    queryResult = true;
                }
                else
                {
                    queryResult = false;
                }
            }
            return queryResult;
        }

        //add one to the seat total for the course to keep track of enrolled students
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