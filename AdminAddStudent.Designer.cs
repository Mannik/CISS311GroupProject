namespace CISS311GroupProject
{
    partial class AdminAddStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveButton = new System.Windows.Forms.Button();
            this.saveAddAnotherButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.incomingCreditsCheckBox = new System.Windows.Forms.CheckBox();
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.lbCreditHours = new System.Windows.Forms.Label();
            this.lblAddNewStudent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(36, 323);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(115, 35);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "&Save && Close";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // saveAddAnotherButton
            // 
            this.saveAddAnotherButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAddAnotherButton.Location = new System.Drawing.Point(174, 323);
            this.saveAddAnotherButton.Name = "saveAddAnotherButton";
            this.saveAddAnotherButton.Size = new System.Drawing.Size(115, 35);
            this.saveAddAnotherButton.TabIndex = 1;
            this.saveAddAnotherButton.Text = "Save && &New";
            this.saveAddAnotherButton.UseVisualStyleBackColor = true;
            this.saveAddAnotherButton.Click += new System.EventHandler(this.saveAddAnotherButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(312, 323);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(115, 35);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(146, 73);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(226, 26);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(48, 76);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(77, 19);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(47, 117);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 19);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(146, 114);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(226, 26);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // incomingCreditsCheckBox
            // 
            this.incomingCreditsCheckBox.AutoSize = true;
            this.incomingCreditsCheckBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomingCreditsCheckBox.Location = new System.Drawing.Point(52, 197);
            this.incomingCreditsCheckBox.Name = "incomingCreditsCheckBox";
            this.incomingCreditsCheckBox.Size = new System.Drawing.Size(203, 23);
            this.incomingCreditsCheckBox.TabIndex = 7;
            this.incomingCreditsCheckBox.Text = "Student has incoming credits.";
            this.incomingCreditsCheckBox.UseVisualStyleBackColor = true;
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursTextBox.Location = new System.Drawing.Point(146, 155);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(100, 26);
            this.hoursTextBox.TabIndex = 8;
            // 
            // lbCreditHours
            // 
            this.lbCreditHours.AutoSize = true;
            this.lbCreditHours.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreditHours.Location = new System.Drawing.Point(47, 158);
            this.lbCreditHours.Name = "lbCreditHours";
            this.lbCreditHours.Size = new System.Drawing.Size(88, 19);
            this.lbCreditHours.TabIndex = 9;
            this.lbCreditHours.Text = "Credit Hours";
            // 
            // lblAddNewStudent
            // 
            this.lblAddNewStudent.AutoSize = true;
            this.lblAddNewStudent.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewStudent.Location = new System.Drawing.Point(36, 28);
            this.lblAddNewStudent.Name = "lblAddNewStudent";
            this.lblAddNewStudent.Size = new System.Drawing.Size(210, 31);
            this.lblAddNewStudent.TabIndex = 10;
            this.lblAddNewStudent.Text = "Add New Student";
            // 
            // AdminAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 403);
            this.Controls.Add(this.lblAddNewStudent);
            this.Controls.Add(this.lbCreditHours);
            this.Controls.Add(this.hoursTextBox);
            this.Controls.Add(this.incomingCreditsCheckBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveAddAnotherButton);
            this.Controls.Add(this.saveButton);
            this.Name = "AdminAddStudent";
            this.Text = "Administrator: Add Student";
            this.Load += new System.EventHandler(this.AdminAddStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button saveAddAnotherButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.CheckBox incomingCreditsCheckBox;
        private System.Windows.Forms.TextBox hoursTextBox;
        private System.Windows.Forms.Label lbCreditHours;
        private System.Windows.Forms.Label lblAddNewStudent;
    }
}