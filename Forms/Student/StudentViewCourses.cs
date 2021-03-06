using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CISS311GroupProject.Forms.Student
{
    public partial class StudentViewCourses : Form
    {

        string connectionString;
        SqlConnection conn;
        int studentId;

        public StudentViewCourses(int studentFormId)
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CISS311GroupProject.Properties.Settings.TinyCollegeConnectionString"].ConnectionString;
            studentId = studentFormId;
        }

        private void StudentViewCourses_Load(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand(
                "SELECT * from student where studentId = @studentId", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@studentId", studentId);

                DataTable studentTable = new DataTable();
                adapter.Fill(studentTable);
                DataRow dr = studentTable.Rows[0];
                firstNameLabel.Text = dr["firstName"].ToString();
                lastNameLabel.Text = dr["lastName"].ToString();
                studentTotalCreditsLabel.Text = dr["credits"].ToString();

            }

            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("SELECT course.title, employee.firstName + ' ' + employee.lastName AS [instructor], courseXstudent.grade FROM courseXstudent " +
                                           "JOIN course ON course.courseId = courseXstudent.courseId JOIN employee ON employee.employeeId = course.employeeId WHERE studentId = @studentId", conn))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
                {
                    comd.Parameters.AddWithValue("@studentId", studentId);
                    DataTable courseTable = new DataTable();
                    adapter.Fill(courseTable);
                    courseDataGrid.DataSource = courseTable;

                }


            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
