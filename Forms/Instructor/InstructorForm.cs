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
    public partial class InstructorForm : Form
    {
        public InstructorForm()
        {
            InitializeComponent();
        }

        private void viewCoursesBtn_Click(object sender, EventArgs e)
        {
            Forms.Instructor.InstructorViewCourses viewCourses = new Forms.Instructor.InstructorViewCourses();
            viewCourses.ShowDialog();
        }

        private void updateGradesButton_Click(object sender, EventArgs e)
        {
            Forms.Instructor.InstructorUpdateGrades updateGrades = new Forms.Instructor.InstructorUpdateGrades();
            updateGrades.ShowDialog();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
