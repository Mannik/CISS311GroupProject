using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace CISS311GroupProject.Forms.Admin
{
    public partial class CourseSearchForm : Form
    {
        string connectionstring;
        SqlConnection conn;
        int courseId;
        //event SelectClicked is used to collect data when an employee is selected.
        public event EventHandler SelectClicked;
        public CourseSearchForm()
        {
            InitializeComponent();
            connectionstring = ConfigurationManager.ConnectionStrings["CISS311GroupProject.Properties.Settings.TinyCollegeConnectionString"].ConnectionString;
        }

        private void CourseSearchForm_Load(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionstring))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT courseId, title, employeeId FROM course", conn))
            {
                DataTable courseTable = new DataTable();
                adapter.Fill(courseTable);
                courseDataGrid.DataSource = courseTable;
            }
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            //SelectClicked event invoke When select button is pushed get employeeId from selected row, and send to AdminAddInstructor.cs
            SelectClicked?.Invoke(courseId, e);
            Close();
        }

        private void courseDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (courseDataGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = courseDataGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = courseDataGrid.Rows[selectedrowindex];
                courseId = int.Parse(Convert.ToString(selectedRow.Cells["courseId"].Value));
            }
        }

        private void courseDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (courseDataGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = courseDataGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = courseDataGrid.Rows[selectedrowindex];
                courseId = int.Parse(Convert.ToString(selectedRow.Cells["courseId"].Value));
            }
            //SelectClicked event invoke When select button is pushed get employeeId from selected row, and send to AdminAddInstructor.cs
            SelectClicked?.Invoke(courseId, e);
            Close();
        }
    }
}
