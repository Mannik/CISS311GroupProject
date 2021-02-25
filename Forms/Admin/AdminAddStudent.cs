using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CISS311GroupProject
{
    public partial class AdminAddStudent : Form
    {
        //create variables for a connection to SQL server
        string connString;
        SqlConnection conn;

        public AdminAddStudent()
        {
            InitializeComponent();

            //todo replace the connection string with the correct one for our project
            //setup the connection string
            connString = ConfigurationManager.ConnectionStrings
                ["CISS311GroupProject.Properties.Settings.TinyCollegeConnectionString"].ConnectionString;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //call save method then close or cancel back to administrator form
            SaveFormData();
            ExitForm();
        }

        private void saveAddAnotherButton_Click(object sender, EventArgs e)
        {
            //call save method then clear form
            SaveFormData();
            ClearForm();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        { 
            //call cancel method
            ExitForm();
        }

        private void SaveFormData()
        {
            //collect form data and input it to the database
            using (conn = new SqlConnection(connString))
            using (SqlCommand comd = new SqlCommand
                ("INSERT INTO student (firstName, lastName, credits) VALUES (@firstName, @lastName, @hours)", conn))
            {
                conn.Open();
                comd.Parameters.AddWithValue("@firstName", firstNameTextBox.Text);
                comd.Parameters.AddWithValue("@lastName", lastNameTextBox.Text);
                if (incomingCreditsCheckBox.Checked == true)
                {
                    comd.Parameters.AddWithValue("@hours", hoursTextBox.Text);
                }
                else
                {
                    comd.Parameters.AddWithValue("@hours", 0);
                }
            }
        }

        private void ClearForm()
        {
            //clear data from the form
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            incomingCreditsCheckBox.Checked = false;
            hoursTextBox.Clear();
        }

        private void ExitForm()
        {
            //cancel or unload form and return to the administrator form
            Close();
        }

        private void AdminAddStudent_Load(object sender, EventArgs e)
        {
            //place any code here that needs to be ran on form load
        }
    }
}
