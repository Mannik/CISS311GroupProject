
namespace CISS311GroupProject.Forms.Instructor
{
    partial class InstructorViewCourses
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
            this.label1 = new System.Windows.Forms.Label();
            this.instructorComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.courseListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.courseIdLabel = new System.Windows.Forms.Label();
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.openSeatCountLabel = new System.Windows.Forms.Label();
            this.studentCountLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.enrollmentStatusLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalSeatCountLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Instructor:";
            // 
            // instructorComboBox
            // 
            this.instructorComboBox.FormattingEnabled = true;
            this.instructorComboBox.Location = new System.Drawing.Point(168, 16);
            this.instructorComboBox.Name = "instructorComboBox";
            this.instructorComboBox.Size = new System.Drawing.Size(371, 28);
            this.instructorComboBox.TabIndex = 1;
            this.instructorComboBox.SelectedIndexChanged += new System.EventHandler(this.instructorComboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.courseListBox);
            this.groupBox1.Location = new System.Drawing.Point(26, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 212);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Courses Taught";
            // 
            // courseListBox
            // 
            this.courseListBox.FormattingEnabled = true;
            this.courseListBox.ItemHeight = 20;
            this.courseListBox.Location = new System.Drawing.Point(0, 27);
            this.courseListBox.Name = "courseListBox";
            this.courseListBox.Size = new System.Drawing.Size(513, 184);
            this.courseListBox.TabIndex = 0;
            this.courseListBox.SelectedIndexChanged += new System.EventHandler(this.courseListBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.totalSeatCountLabel);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.courseIdLabel);
            this.groupBox2.Controls.Add(this.courseNameLabel);
            this.groupBox2.Controls.Add(this.openSeatCountLabel);
            this.groupBox2.Controls.Add(this.studentCountLabel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.enrollmentStatusLabel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(26, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 175);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Course Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(185, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total Seat Count:";
            // 
            // courseIdLabel
            // 
            this.courseIdLabel.AutoSize = true;
            this.courseIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseIdLabel.Location = new System.Drawing.Point(87, 50);
            this.courseIdLabel.Name = "courseIdLabel";
            this.courseIdLabel.Size = new System.Drawing.Size(0, 17);
            this.courseIdLabel.TabIndex = 8;
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameLabel.Location = new System.Drawing.Point(110, 23);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(0, 17);
            this.courseNameLabel.TabIndex = 7;
            // 
            // openSeatCountLabel
            // 
            this.openSeatCountLabel.AutoSize = true;
            this.openSeatCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openSeatCountLabel.Location = new System.Drawing.Point(133, 108);
            this.openSeatCountLabel.Name = "openSeatCountLabel";
            this.openSeatCountLabel.Size = new System.Drawing.Size(0, 17);
            this.openSeatCountLabel.TabIndex = 6;
            // 
            // studentCountLabel
            // 
            this.studentCountLabel.AutoSize = true;
            this.studentCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentCountLabel.Location = new System.Drawing.Point(185, 80);
            this.studentCountLabel.Name = "studentCountLabel";
            this.studentCountLabel.Size = new System.Drawing.Size(0, 17);
            this.studentCountLabel.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Open Seat Count:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Student Enrollment Count:";
            // 
            // enrollmentStatusLabel
            // 
            this.enrollmentStatusLabel.AutoSize = true;
            this.enrollmentStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrollmentStatusLabel.Location = new System.Drawing.Point(6, 134);
            this.enrollmentStatusLabel.Name = "enrollmentStatusLabel";
            this.enrollmentStatusLabel.Size = new System.Drawing.Size(0, 17);
            this.enrollmentStatusLabel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Course ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Course Name:";
            // 
            // totalSeatCountLabel
            // 
            this.totalSeatCountLabel.AutoSize = true;
            this.totalSeatCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSeatCountLabel.Location = new System.Drawing.Point(309, 50);
            this.totalSeatCountLabel.Name = "totalSeatCountLabel";
            this.totalSeatCountLabel.Size = new System.Drawing.Size(0, 17);
            this.totalSeatCountLabel.TabIndex = 10;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(227, 489);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(125, 54);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // InstructorViewCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 555);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.instructorComboBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "InstructorViewCourses";
            this.Text = "InstructorViewCourses";
            this.Load += new System.EventHandler(this.InstructorViewCourses_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox instructorComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox courseListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label openSeatCountLabel;
        private System.Windows.Forms.Label studentCountLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label enrollmentStatusLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label courseIdLabel;
        private System.Windows.Forms.Label courseNameLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalSeatCountLabel;
        private System.Windows.Forms.Button closeButton;
    }
}