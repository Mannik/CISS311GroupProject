using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace CISS311GroupProject.Forms.Admin
{
    public partial class AdminAddInstructor : Form
    {
        string connectionstring;
        SqlConnection conn;
        int employeeId = 0;
        public AdminAddInstructor()
        {
            InitializeComponent();
            connectionstring = ConfigurationManager.ConnectionStrings["CISS311GroupProject.Properties.Settings.TinyCollegeConnectionString"].ConnectionString;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionstring))

                //IF Creating new employee, id label will be empty, check if id label is empty, INSERT new row
                if (idLabel.Text == string.Empty)
                {
                    using (SqlCommand comd = new SqlCommand("INSERT INTO employee(firstName, lastName, isAdmin) VALUES(@firstName, @lastName, @isAdmin);", conn))
                    {
                        if (isAdminCheck.Checked)
                        {
                            comd.Parameters.AddWithValue("@isAdmin", 1);
                        }
                        else
                        {
                            comd.Parameters.AddWithValue("@isAdmin", 0);
                        }
                        conn.Open();
                        comd.Parameters.AddWithValue("@firstName", firstNameTxbx.Text);
                        comd.Parameters.AddWithValue("@lastName", lastNameTxbx.Text);
                        comd.ExecuteScalar();
                        MessageBox.Show("New employee added.");

                    }
                }
            //else id label = employee id, UPDATE instead of INSERT
                else
                {
                    using (SqlCommand comd = new SqlCommand("UPDATE employee SET firstName = @firstName, lastName = @lastName, isAdmin = @isAdmin WHERE employeeId = @employeeId", conn))
                    {
                        conn.Open();
                        if (isAdminCheck.Checked)
                        {
                            comd.Parameters.AddWithValue("@isAdmin", 1);
                        }
                        else
                        {
                            comd.Parameters.AddWithValue("@isAdmin", 0);
                        }
                        comd.Parameters.AddWithValue("@firstName", firstNameTxbx.Text);
                        comd.Parameters.AddWithValue("@lastName", lastNameTxbx.Text);
                        comd.Parameters.AddWithValue("@employeeId", employeeId);
                        comd.ExecuteScalar();
                        MessageBox.Show("Employee Updated.");
                    }
                }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            //Open search form
            var search = new EmployeeSearchForm();

            //get SelectClicked event result from searchform as int id
            search.SelectClicked += (o, args) =>
            {
                if (!(o is int id))
                {
                    return;
                }

                //id = employeeId
                employeeId = id;
                idLabel.Text = employeeId.ToString();
                //fill out form info
                using (conn = new SqlConnection(connectionstring))
                using (SqlCommand comd = new SqlCommand("SELECT firstName, lastName, isAdmin FROM employee WHERE employeeId = @employeeId", conn))
                using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
                {
                    comd.Parameters.AddWithValue("@employeeId", employeeId);
                    DataTable searchTable = new DataTable();
                    adapter.Fill(searchTable);
                    DataRow dr = searchTable.Rows[0];
                    firstNameTxbx.Text = dr["firstName"].ToString();
                    lastNameTxbx.Text = dr["lastName"].ToString();
                    string CheckIsAdmin = dr["isAdmin"].ToString();
                    if (CheckIsAdmin == "False")
                    {
                        isAdminCheck.Checked = false;
                    }
                    else
                    {
                        isAdminCheck.Checked = true;
                    }

                }

            };

            search.ShowDialog(this);
        }

        private void AdminAddInstructor_Load(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            
            //set employeeId to 0 to not accidently UPDATE existing employee
            employeeId = 0;
            //clear all fields
            idLabel.Text = string.Empty;
            firstNameTxbx.Text = string.Empty;
            lastNameTxbx.Text = string.Empty;
            isAdminCheck.Checked = false;
        }

        
    }
}
