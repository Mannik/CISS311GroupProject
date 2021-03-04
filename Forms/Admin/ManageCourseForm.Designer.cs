
namespace CISS311GroupProject
{
    partial class ManageCourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCourseForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.noRadioButton = new System.Windows.Forms.RadioButton();
            this.yesRadioButton = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.updatedmaxSeatingTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maxSeatingLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.newCourseTitleTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.currentCourseLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.courseIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.employeeIdLabel = new System.Windows.Forms.Label();
            this.InstructorNameLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.newInstructorComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newInstructorComboBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.InstructorNameLabel);
            this.groupBox1.Controls.Add(this.employeeIdLabel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.noRadioButton);
            this.groupBox1.Controls.Add(this.yesRadioButton);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.updatedmaxSeatingTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.maxSeatingLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.newCourseTitleTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.currentCourseLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.findButton);
            this.groupBox1.Controls.Add(this.courseIdTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 408);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Course Information";
            // 
            // noRadioButton
            // 
            this.noRadioButton.AutoSize = true;
            this.noRadioButton.Location = new System.Drawing.Point(303, 257);
            this.noRadioButton.Name = "noRadioButton";
            this.noRadioButton.Size = new System.Drawing.Size(50, 24);
            this.noRadioButton.TabIndex = 13;
            this.noRadioButton.TabStop = true;
            this.noRadioButton.Text = "NO";
            this.noRadioButton.UseVisualStyleBackColor = true;
            // 
            // yesRadioButton
            // 
            this.yesRadioButton.AutoSize = true;
            this.yesRadioButton.Location = new System.Drawing.Point(175, 257);
            this.yesRadioButton.Name = "yesRadioButton";
            this.yesRadioButton.Size = new System.Drawing.Size(60, 24);
            this.yesRadioButton.TabIndex = 12;
            this.yesRadioButton.TabStop = true;
            this.yesRadioButton.Text = "YES";
            this.yesRadioButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Course Available:";
            // 
            // updatedmaxSeatingTextBox
            // 
            this.updatedmaxSeatingTextBox.Enabled = false;
            this.updatedmaxSeatingTextBox.Location = new System.Drawing.Point(356, 206);
            this.updatedmaxSeatingTextBox.Name = "updatedmaxSeatingTextBox";
            this.updatedmaxSeatingTextBox.Size = new System.Drawing.Size(35, 26);
            this.updatedmaxSeatingTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Updated Seating:";
            // 
            // maxSeatingLabel
            // 
            this.maxSeatingLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.maxSeatingLabel.Location = new System.Drawing.Point(175, 206);
            this.maxSeatingLabel.Name = "maxSeatingLabel";
            this.maxSeatingLabel.Size = new System.Drawing.Size(35, 26);
            this.maxSeatingLabel.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Seating Capacity:";
            // 
            // newCourseTitleTextBox
            // 
            this.newCourseTitleTextBox.Enabled = false;
            this.newCourseTitleTextBox.Location = new System.Drawing.Point(175, 153);
            this.newCourseTitleTextBox.Name = "newCourseTitleTextBox";
            this.newCourseTitleTextBox.Size = new System.Drawing.Size(216, 26);
            this.newCourseTitleTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Change Course Title:";
            // 
            // currentCourseLabel
            // 
            this.currentCourseLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.currentCourseLabel.Location = new System.Drawing.Point(175, 96);
            this.currentCourseLabel.Name = "currentCourseLabel";
            this.currentCourseLabel.Size = new System.Drawing.Size(216, 26);
            this.currentCourseLabel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Course Title:";
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(316, 41);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 30);
            this.findButton.TabIndex = 2;
            this.findButton.Text = "&Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // courseIdTextBox
            // 
            this.courseIdTextBox.Location = new System.Drawing.Point(135, 43);
            this.courseIdTextBox.Name = "courseIdTextBox";
            this.courseIdTextBox.Size = new System.Drawing.Size(100, 26);
            this.courseIdTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course ID:";
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.updateButton.Location = new System.Drawing.Point(12, 427);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(125, 30);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "&Update Course";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deleteButton.Location = new System.Drawing.Point(175, 427);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(125, 30);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "&Delete Course";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.exitButton.Location = new System.Drawing.Point(341, 427);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(125, 30);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Current Instructor:";
            // 
            // employeeIdLabel
            // 
            this.employeeIdLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.employeeIdLabel.Location = new System.Drawing.Point(171, 310);
            this.employeeIdLabel.Name = "employeeIdLabel";
            this.employeeIdLabel.Size = new System.Drawing.Size(54, 26);
            this.employeeIdLabel.TabIndex = 15;
            // 
            // InstructorNameLabel
            // 
            this.InstructorNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.InstructorNameLabel.Location = new System.Drawing.Point(231, 309);
            this.InstructorNameLabel.Name = "InstructorNameLabel";
            this.InstructorNameLabel.Size = new System.Drawing.Size(160, 26);
            this.InstructorNameLabel.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Update Instructor:";
            // 
            // newInstructorComboBox
            // 
            this.newInstructorComboBox.Enabled = false;
            this.newInstructorComboBox.FormattingEnabled = true;
            this.newInstructorComboBox.Location = new System.Drawing.Point(171, 360);
            this.newInstructorComboBox.Name = "newInstructorComboBox";
            this.newInstructorComboBox.Size = new System.Drawing.Size(220, 28);
            this.newInstructorComboBox.TabIndex = 18;
            // 
            // ManageCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 469);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageCourseForm";
            this.Text = "Manage Course Form";
            this.Load += new System.EventHandler(this.ManageCourseForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox updatedmaxSeatingTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label maxSeatingLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newCourseTitleTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label currentCourseLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TextBox courseIdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton noRadioButton;
        private System.Windows.Forms.RadioButton yesRadioButton;
        private System.Windows.Forms.ComboBox newInstructorComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label InstructorNameLabel;
        private System.Windows.Forms.Label employeeIdLabel;
        private System.Windows.Forms.Label label7;
    }
}