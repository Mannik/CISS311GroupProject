using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace CISS311GroupProject.Forms.Admin
{
    public partial class EmployeeSearchForm : Form
    {
        string connectionstring;
        SqlConnection conn;
        int employeeId;
        //event SelectClicked is used to collect data when an employee is selected.
        public event EventHandler SelectClicked;
        public EmployeeSearchForm()
        {
            InitializeComponent();
            connectionstring = ConfigurationManager.ConnectionStrings["CISS311GroupProject.Properties.Settings.TinyCollegeConnectionString"].ConnectionString;
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {

            //SelectClicked event invoke When select button is pushed get employeeId from selected row, and send to AdminAddInstructor.cs
            SelectClicked?.Invoke(employeeId, e);
            Close();
        }

        private void EmployeeSearchForm_Load(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionstring))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM employee", conn))
            {
                DataTable employeeTable = new DataTable();
                adapter.Fill(employeeTable);
                employeeDataGrid.DataSource = employeeTable;
            }
        }

        //Call selectionChanged for datagridview, get employeeId value from selected row, and set int employeeId to value.
        private void employeeDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (employeeDataGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = employeeDataGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = employeeDataGrid.Rows[selectedrowindex];
                employeeId = int.Parse(Convert.ToString(selectedRow.Cells["employeeId"].Value));
            }
        }
    }
}
