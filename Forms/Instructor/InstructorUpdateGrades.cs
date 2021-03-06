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
using System.Collections;

namespace CISS311GroupProject.Forms.Instructor
{
   
    public partial class InstructorUpdateGrades : Form
    {
        string connectionString;
        SqlConnection conn;
        public InstructorUpdateGrades()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CISS311GroupProject.Properties.Settings.TinyCollegeConnectionString"].ConnectionString;
        }

        private void InstructorUpdateGrades_Load(object sender, EventArgs e)
        {
            //On load, fill instructor combo box with options so they can select themselves to view their courses.
            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT firstName + ' ' + lastName AS name, employeeId FROM employee;", conn))
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
            //When the instructor combo box selection is changed, update the options in the course combo box
            if (!(String.IsNullOrEmpty(instructorComboBox.SelectedItem.ToString()))){
                using (conn = new SqlConnection(connectionString))
                using (SqlCommand comd = new SqlCommand("SELECT courseId, title FROM course WHERE employeeId = @employeeId;", conn))
                using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
                {
                    DataTable courseTable = new DataTable();
                    comd.Parameters.AddWithValue("@employeeId", instructorComboBox.SelectedValue);
                    adapter.Fill(courseTable);
                    courseComboBox.DisplayMember = "title";
                    courseComboBox.ValueMember = "courseId";
                    courseComboBox.DataSource = courseTable;
                }
            }      
        }

        //When the course combo box value changes, update the student list to the correct class
        private void courseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("SELECT courseXstudent.studentId AS studentId, student.firstName + ' ' + student.lastName AS studentName " +
                "FROM courseXstudent JOIN student ON (courseXstudent.studentId =  student.studentId) WHERE courseXstudent.courseId = @courseId;", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                DataTable studentGradesTable = new DataTable();
                comd.Parameters.AddWithValue("@courseId", courseComboBox.SelectedValue);
                adapter.Fill(studentGradesTable);
                studentListBox.DisplayMember = "studentName";
                studentListBox.ValueMember = "studentId";
                studentListBox.DataSource = studentGradesTable;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        //When selected student is changed, update selected student data fields
        private void studentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("SELECT  courseXstudent.studentId, courseXstudent.grade AS currentGrade, student.firstName + ' ' + student.lastName AS studentName " +
                "FROM courseXstudent JOIN student ON (courseXstudent.studentID = student.studentId) " +
                "WHERE courseXstudent.courseId = @courseId AND courseXstudent.studentId = @studentId;", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                DataTable selectedStudentTable = new DataTable();
                comd.Parameters.AddWithValue("@courseId", courseComboBox.SelectedValue);
                comd.Parameters.AddWithValue("@studentId", studentListBox.SelectedValue);
                adapter.Fill(selectedStudentTable);
                if (selectedStudentTable.Rows.Count > 0)
                {
                    DataRow dr = selectedStudentTable.Rows[0];
                    studentNameLabel.Text = dr["studentName"].ToString();
                    currentGradeLabel.Text = dr["currentGrade"].ToString();
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //check if new grade has been selected
            if(newGradeComboBox.Text != "--SELECT--")
            {
                //Write new grade to db
                using (conn = new SqlConnection(connectionString))
                using (SqlCommand comd = new SqlCommand("UPDATE courseXstudent SET grade = @updatedGrade WHERE courseId = @courseId AND studentId = @studentId;", conn))
                {
                    conn.Open();
                    comd.Parameters.AddWithValue("@updatedGrade", newGradeComboBox.SelectedItem.ToString());
                    comd.Parameters.AddWithValue("@courseId", courseComboBox.SelectedValue);
                    comd.Parameters.AddWithValue("@studentId", studentListBox.SelectedValue);
                    comd.ExecuteScalar();
                }
                //move to next student in list or if last student, move back to top index
                if(studentListBox.SelectedIndex >= (studentListBox.Items.Count - 1)){
                    studentListBox.SelectedIndex = studentListBox.TopIndex;
                }
                else
                {
                    studentListBox.SelectedIndex++;
                }
                //set new grade combo box back to SELECT
                newGradeComboBox.Text = "--SELECT--";
            }
            //no grade selected error
            else
            {
                MessageBox.Show("Please Select A Grade");
            }

        }
    }
}
