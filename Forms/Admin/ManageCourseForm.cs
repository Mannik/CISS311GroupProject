﻿using System;
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

        }

        private void findButton_Click(object sender, EventArgs e)
        {
            // find button connection and QRY statement
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand(
                "SELECT * FROM course WHERE courseId = @courseId", conn))
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
                    if (yesRadioButton.Checked)
                    {
                       
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
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            // Connection for update statement
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand(
                "UPDATE course SET title = @title, maxSeats = @maxSeats, isAvailable = @isAvailable " +
                "WHERE courseId = @courseId", conn))
            {
                // opens connection
                conn.Open();
                // parameters to pass for update 
                comd.Parameters.AddWithValue("@courseId", courseId);
                comd.Parameters.AddWithValue("@title", newCourseTitleTextBox.Text);
                comd.Parameters.AddWithValue("@maxSeats", updatedmaxSeatingTextBox.Text);
                if (yesRadioButton.Checked)
                {
                    comd.Parameters.AddWithValue("@isAvailable", 1);
                }
                else
                {
                    comd.Parameters.AddWithValue("@isAvailable", 0);
                }
                comd.ExecuteScalar();
                ResetForm();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // delete connection and delete Query
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand(
                "DELETE FROM course WHERE courseId = @courseId", conn))
            {
                // opens connection, passes parameters for delete
                conn.Open();
                comd.Parameters.AddWithValue("@courseId", courseId);
                comd.ExecuteScalar();
                ResetForm();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void ResetForm()
        {
            // Items to reset the form for next search update delete
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
        }
    }
}
