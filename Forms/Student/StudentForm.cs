﻿using System;
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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void enrollButton_Click(object sender, EventArgs e)
        {
            StudentEnrollCourse studentEnrollCourse = new StudentEnrollCourse();
            studentEnrollCourse.ShowDialog();
        }
    }
}
