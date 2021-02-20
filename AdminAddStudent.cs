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
    public partial class AdminAddStudent : Form
    {
        public AdminAddStudent()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //todo 
            //call save method then close or cancel back to administrator form
            SaveFormData();
            ExitForm();
        }

        private void btnSaveAddAnother_Click(object sender, EventArgs e)
        {
            //todo 
            //call save method then clear form
            SaveFormData();
            ClearForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //todo 
            //cancel back to the administrator form
            ExitForm();
        }

        private void SaveFormData()
        {
            //todo 
            //collect form data and input it to the database
        }

        private void ClearForm()
        {
            //todo 
            //clear data from the form
        }

        private void ExitForm()
        {
            //todo 
            //cancel or unload form and return to the administrator form
        }
    }
}
