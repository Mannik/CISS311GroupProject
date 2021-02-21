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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //initiate Admin Main Form
            AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();
        }

        private void instructorBtn_Click(object sender, EventArgs e)
        {
            //initiate Instructor Main Form
            InstructorForm instructorForm = new InstructorForm();
            instructorForm.ShowDialog();
        }

        private void studentBtn_Click(object sender, EventArgs e)
        {
            //initiate Student Main Form
            StudentForm studentForm = new StudentForm();
            studentForm.ShowDialog();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            //close application
            Close();
        }
    }
}
