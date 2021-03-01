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
    public partial class StudentEnrollCourse : Form
    {
        string connectionString;
        SqlConnection conn;

        public StudentEnrollCourse()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CISS311GroupProject.Properties.Settings.TinyCollegeConnectionString"].ConnectionString;
        }

        private Boolean noOverbooking()
        {
            bool overbooked;

            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("SELECT seats, maxSeats from course where courseId = @courseId", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@courseId", courseTitleComboBox.SelectedValue);
                DataTable checkSeats = new DataTable();
                adapter.Fill(checkSeats);
                DataRow dr = checkSeats.Rows[0];

                if (int.Parse(dr["seats"].ToString()) > int.Parse(dr["maxSeats"].ToString()))
                {
                    overbooked = true;
                    MessageBox.Show("Course is overbooked. Not available for registration.");
                }
                else
                {
                    overbooked = false;
                    MessageBox.Show("Course is not overbooked.");
                }

            }


                return overbooked;
        }

        private void StudentEnrollCourse_Load(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM course", conn))
            {
                DataTable courseTable = new DataTable();
                adapter.Fill(courseTable);
                courseTitleComboBox.DisplayMember = "title";
                courseTitleComboBox.ValueMember = "courseId";
                courseTitleComboBox.DataSource = courseTable;
            }
        }

        private void courseTitleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkAvailabilityButton_Click(object sender, EventArgs e)
        {
            noOverbooking();
        }
    }
}