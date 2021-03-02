using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace CISS311GroupProject
{
    public partial class AdministratorViewCourses : Form
    {
        string connectionString;
        SqlConnection conn;
        public AdministratorViewCourses()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CISS311GroupProject.Properties.Settings.TinyCollegeConnectionString"].ConnectionString;
        }

        //When the form loads, fill the listbox with all current courses
        private void AdministratorViewCourses_Load(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Course", conn))
            {
                DataTable courseTable = new DataTable();
                adapter.Fill(courseTable);
                courseListBox.DisplayMember = "Title";
                courseListBox.ValueMember = "CourseID";
                courseListBox.DataSource = courseTable;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        //When the user clicks on a course in the listbox, change the values shown in the isntructor and seats textboxes.
        private void courseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            //Query to get Instructor's first and last and the seat count for the selected course
            //I think the below SQL statement should be right, but I'm currently having a few problems with the database not showing up, 
            //so I'm not sure if it's actually correct since I can't test
            using (SqlCommand comd = new SqlCommand("SELECT Employee.FirstName + ' ' + Employee.LastName AS Name, Course.maxSeats AS maxSeats FROM Employee JOIN Course ON Employee.EmployeeID = Course.Instructor WHERE Course.CourseID = @CourseID", conn))
            //found something similar to this on Stack Overflow to set textbox text based on database values
            //https://stackoverflow.com/questions/4298631/how-to-fill-textbox-from-dataset
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd)) 
            {
                //Sets parameters for the query above
                comd.Parameters.AddWithValue("@CourseID", courseListBox.SelectedValue);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                DataRow dr = dt.Rows[0];

                //NOT USING ANYMORE
                //I had to look up what the ? operator does. It essentially serves as an if/else, followed by the value/action if true : value/action if false
                //So what the below line is doing is having the datareader read the results, and if it reads successfully, set the textbox value to "FirstName LastName" or
                //else return an empty string. More Info: http://www.vcskicks.com/question-mark-operator.php#:~:text=Question-Mark%20Operator.%20A%20C%23%20operator%20is%20symbols%20used,%28Here%20is%20a%20complete%20list%20of%20C%23%20operators%29.
                //instructorTextBox.Text = reader.Read() ? reader["Employee.FirstName"].ToString() + " " + reader["Employee.LastName"].ToString() : string.Empty;

                //instead of using the reader commented out above, made better sql query that combines first and last as name, fills table, and pulls value from table
                instructorTextBox.Text = dr["Name"].ToString();

                seatTextBox.Text = dr["maxSeats"].ToString();
            }
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            AddCourseForm addCourseForm = new AddCourseForm();
            addCourseForm.ShowDialog();
        }

        private void updateCoursesButton_Click(object sender, EventArgs e)
        {
            //Go to Mark's Manage Class Form
        }
    }
}
