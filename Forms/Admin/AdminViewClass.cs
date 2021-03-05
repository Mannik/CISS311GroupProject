using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
//Load and searchbtn click are exactly the same. We load the search function at the very start to pick a class
//the search button then allows us to look up a different class later
namespace CISS311GroupProject.Forms.Admin
{
    public partial class AdminViewClass : Form
    {
        string connectionstring;
        SqlConnection conn;
        int courseId;
        public AdminViewClass()
        {
            InitializeComponent();
            connectionstring = ConfigurationManager.ConnectionStrings["CISS311GroupProject.Properties.Settings.TinyCollegeConnectionString"].ConnectionString;
        }

        private void AdminViewClass_Load(object sender, EventArgs e)
        {
            {
                //Open search form
                var search = new CourseSearchForm();

                //get SelectClicked event result from searchform as int id
                search.SelectClicked += (o, args) =>
                {
                    if (!(o is int id))
                    {
                        return;
                    }

                //id = courseId
                courseId = id;
                    instructorLabel.Text = courseId.ToString();
                    // First comd is used to get instructor name and course title for labels above the datagridview
                    using (conn = new SqlConnection(connectionstring))
                    using (SqlCommand comd = new SqlCommand("SELECT employee.employeeId as [eId], firstName + ' ' + lastName AS [instructorName], course.title FROM employee " +
                                                   "JOIN course ON course.employeeId = employee.employeeId WHERE courseId = @courseId", conn))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
                    {
                        comd.Parameters.AddWithValue("@courseId", courseId);
                        DataTable gradesTable = new DataTable();
                        adapter.Fill(gradesTable);
                        DataRow dr = gradesTable.Rows[0];
                        instructorLabel.Text = dr["eId"].ToString() + " " + dr["instructorName"].ToString();
                        titleLabel.Text = dr["title"].ToString();
                    }
                    //second comd is used to populate datagridview with student names and grades
                    using (conn = new SqlConnection(connectionstring))
                    using (SqlCommand comd = new SqlCommand("SELECT courseXstudent.studentId as [Student ID], student.firstName + ' ' + student.lastName AS [Student Name], grade FROM courseXstudent " +
                                                   "JOIN student ON courseXstudent.studentId = student.studentId WHERE courseId = @courseId", conn))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
                    {
                        comd.Parameters.AddWithValue("@courseId", courseId);
                        DataTable gradesTable = new DataTable();
                        adapter.Fill(gradesTable);
                        gradesDataGrid.DataSource = gradesTable;

                    }

                };

                search.ShowDialog(this);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            {
                //Open search form
                var search = new CourseSearchForm();

                //get SelectClicked event result from searchform as int id
                search.SelectClicked += (o, args) =>
                {
                    if (!(o is int id))
                    {
                        return;
                    }

                    //id = courseId
                    courseId = id;
                    instructorLabel.Text = courseId.ToString();
                    // First comd is used to get instructor name and course title for labels above the datagridview
                    using (conn = new SqlConnection(connectionstring))
                    using (SqlCommand comd = new SqlCommand("SELECT employee.employeeId as [eId], firstName + ' ' + lastName AS [instructorName], course.title FROM employee " +
                                                   "JOIN course ON course.employeeId = employee.employeeId WHERE courseId = @courseId", conn))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
                    {
                        comd.Parameters.AddWithValue("@courseId", courseId);
                        DataTable gradesTable = new DataTable();
                        adapter.Fill(gradesTable);
                        DataRow dr = gradesTable.Rows[0];
                        instructorLabel.Text = dr["eId"].ToString() + " " + dr["instructorName"].ToString();
                        titleLabel.Text = dr["title"].ToString();
                    }
                    //second comd is used to populate datagridview with student names and grades
                    using (conn = new SqlConnection(connectionstring))
                    using (SqlCommand comd = new SqlCommand("SELECT courseXstudent.studentId as [Student ID], student.firstName + ' ' + student.lastName AS [Student Name], grade FROM courseXstudent " +
                                                   "JOIN student ON courseXstudent.studentId = student.studentId WHERE courseId = @courseId", conn))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
                    {
                        comd.Parameters.AddWithValue("@courseId", courseId);
                        DataTable gradesTable = new DataTable();
                        adapter.Fill(gradesTable);
                        gradesDataGrid.DataSource = gradesTable;

                    }

                };

                search.ShowDialog(this);
            }
        }
    }
}
