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
    public partial class ManageCourseForm : Form
    {
        string connectionString;
        SqlDataAdapter adapter;
        SqlConnection conn;
        int courseId;
        public ManageCourseForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings
                ["CISS311GroupProject.Properties.Settings.TinyCollegeConnectionString"]
                .ConnectionString;
        }

        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            //Manage course form SQL statment to fill new istructor combobox
            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(
                "SELECT employeeId, firstName + ' ' + lastName AS 'Name' FROM employee", conn))
            {
                DataTable employeeTable = new DataTable();
                adapter.Fill(employeeTable);
                newInstructorComboBox.DisplayMember = "Name";
                newInstructorComboBox.ValueMember = "employeeId";
                newInstructorComboBox.DataSource = employeeTable;
                // Manage Course Form: Starts the form load with empty combobox
                newInstructorComboBox.Text = string.Empty;
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            findClass();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            // Connection for update statement
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand(
                 "UPDATE course SET title = @title, maxSeats = @maxSeats, isAvailable = @isAvailable, " +
                "employeeId = @employeeId WHERE courseId = @courseId", conn))
            {
                // opens connection
                conn.Open();
                // parameters to pass for update 
                comd.Parameters.AddWithValue("@courseId", courseIdTextBox.Text);
                // If Statement to update title/ if no new title passes parameter from current title label
                // courtesy to Zachary for the help
                if (!string.IsNullOrEmpty(newCourseTitleTextBox.Text))
                {
                    comd.Parameters.AddWithValue("@title", newCourseTitleTextBox.Text);
                }
                else
                {
                    comd.Parameters.AddWithValue("@title", currentCourseLabel.Text);
                }
                // if statement to update maxSeats/ if no new update passes current maxseats
                // courtesy to Zachary for the help
                if (!string.IsNullOrEmpty(updatedmaxSeatingTextBox.Text))
                {
                    comd.Parameters.AddWithValue("@maxSeats", updatedmaxSeatingTextBox.Text);
                }
                else
                {
                    comd.Parameters.AddWithValue("@maxSeats", maxSeatingLabel.Text);
                }

                // Manage course form : updates the is Available radio buttons yes/no
                if (yesRadioButton.Checked)
                {
                    comd.Parameters.AddWithValue("@isAvailable", 1);
                }
                else
                {
                    comd.Parameters.AddWithValue("@isAvailable", 0);
                }
            // manage course form : updates instructor of course
                if (!string.IsNullOrEmpty(newInstructorComboBox.Text))
                {
                    comd.Parameters.AddWithValue("@employeeId", newInstructorComboBox.SelectedValue);
                }
                else
                {
                    comd.Parameters.AddWithValue("@employeeId", employeeIdLabel.Text);
                }
                //executes the command for the sql statement
                comd.ExecuteScalar();
                // resets the form to unenable delete/update buttons
                // and makes textboxes un typable and focus on courseId
            }
            ResetForm();
            newCourseTitleTextBox.Enabled = false;
            updatedmaxSeatingTextBox.Enabled = false;
            newInstructorComboBox.Enabled = false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //Manage Course Form QRY to delete course from courseXstudent Table
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand(
                "DELETE FROM courseXstudent WHERE courseId = @courseId", conn))
            {
                //ManageCourse Form  opens connection, passes parameters for delete
                // to delete a course only.
                conn.Open();
                comd.Parameters.AddWithValue("@courseId", courseIdTextBox.Text);
                comd.ExecuteScalar();
            }
            // Manage Course Form QRY to delete course from course table 
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand(
                "DELETE FROM course WHERE courseId = @courseId", conn))
            {
                // Manage Course Form : opens connection, passes parameters for delete
                // to delete a course only.
                conn.Open();
                comd.Parameters.AddWithValue("@courseId", courseIdTextBox.Text);
                comd.ExecuteScalar();
            }
            ResetForm();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void ResetForm()
        {
            // Items to reset the form for next search update delete
            // clears textboxes and labels to present a new form
            courseIdTextBox.Clear();
            currentCourseLabel.Text = string.Empty;
            newCourseTitleTextBox.Clear();
            maxSeatingLabel.Text = string.Empty;
            updatedmaxSeatingTextBox.Clear();
            yesRadioButton.Checked = false;
            noRadioButton.Checked = false;
            courseIdTextBox.Focus();
            deleteButton.Enabled = false;
            updateButton.Enabled = false;
            newCourseTitleTextBox.Clear();
            updatedmaxSeatingTextBox.Clear();
            employeeIdLabel.Text = string.Empty;
            InstructorNameLabel.Text = string.Empty;
            newInstructorComboBox.Text = string.Empty;
        }

        private void advSearchButton_Click(object sender, EventArgs e)
        {
            {
                //Open search form
                var search = new Forms.Admin.CourseSearchForm();

                //get SelectClicked event result from searchform as int id
                search.SelectClicked += (o, args) =>
                {
                    if (!(o is int id))
                    {
                        return;
                    }

                    courseId = id;
                    
                };

               
                search.ShowDialog(this);
                courseIdTextBox.Text = courseId.ToString();
                findClass();
            }
        }
        private void findClass()
            {
                // Manage Course Form find button connection and Qry
                // finds information off course Id search
                using (conn = new SqlConnection(connectionString))
                using (SqlCommand comd = new SqlCommand(
                    "SELECT course.courseId, course.title, course.employeeId, course.seats, course.maxSeats, course.isAvailable, " +
                   "employee.employeeId, employee.firstName + ' ' + employee.lastName AS 'Name', employee.isAdmin FROM course JOIN employee " +
                   "ON course.employeeId = employee.employeeId WHERE course.courseId = @courseId", conn))
                using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
                {
                    comd.Parameters.AddWithValue("@courseId", courseIdTextBox.Text);
                    DataTable courseTable = new DataTable();
                    adapter.Fill(courseTable);
                    if (courseTable.Rows.Count < 1)
                    {
                        // displays no course found when no course is found and 
                        // unenables textboxes etc. 
                        ResetForm();
                        currentCourseLabel.Text = "No Course Found.";

                    }
                    else
                    {
                        DataRow dr = courseTable.Rows[0];
                        courseId = int.Parse(dr["courseId"].ToString());
                        currentCourseLabel.Text = dr["title"].ToString();
                        maxSeatingLabel.Text = dr["maxSeats"].ToString();
                        employeeIdLabel.Text = dr["employeeId"].ToString();
                        InstructorNameLabel.Text = dr["Name"].ToString();
                        // if statement to display the isAvailable bool to radiobuttons
                        // courtesy to Zachary for the help
                        if (dr["isAvailable"].ToString() == "True")
                        {
                            yesRadioButton.Checked = true;
                        }
                        else
                        {
                            noRadioButton.Checked = true;
                        }
                        // enables textboxes and buttons once it finds a course by Id
                        updatedmaxSeatingTextBox.Enabled = true;
                        newCourseTitleTextBox.Enabled = true;
                        deleteButton.Enabled = true;
                        updateButton.Enabled = true;
                        newInstructorComboBox.Enabled = true;
                    }
                }
            }
        

        private void courseIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void updatedmaxSeatingTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
