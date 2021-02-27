using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CISS311GroupProject
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            AdminAddStudent adminAddStudent = new AdminAddStudent();
            adminAddStudent.ShowDialog();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            //close form
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forms.Admin.AdminAddInstructor adminAddInstructor = new Forms.Admin.AdminAddInstructor();
            adminAddInstructor.ShowDialog();
        }

        private void viewCoursesBtn_Click(object sender, EventArgs e)
        {
            Forms.Admin.AdminViewClass adminViewClass = new Forms.Admin.AdminViewClass();
            adminViewClass.ShowDialog();
        }
    }
}
