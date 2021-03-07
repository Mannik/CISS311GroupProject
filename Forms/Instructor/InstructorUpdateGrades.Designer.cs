
namespace CISS311GroupProject.Forms.Instructor
{
    partial class InstructorUpdateGrades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructorUpdateGrades));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newGradeComboBox = new System.Windows.Forms.ComboBox();
            this.currentGradeLabel = new System.Windows.Forms.Label();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.instructorComboBox = new System.Windows.Forms.ComboBox();
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.studentListBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Instructor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newGradeComboBox);
            this.groupBox1.Controls.Add(this.currentGradeLabel);
            this.groupBox1.Controls.Add(this.studentNameLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(18, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 115);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Student";
            // 
            // newGradeComboBox
            // 
            this.newGradeComboBox.FormattingEnabled = true;
            this.newGradeComboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "F"});
            this.newGradeComboBox.Location = new System.Drawing.Point(106, 84);
            this.newGradeComboBox.Name = "newGradeComboBox";
            this.newGradeComboBox.Size = new System.Drawing.Size(95, 21);
            this.newGradeComboBox.TabIndex = 9;
            this.newGradeComboBox.Text = "--SELECT--";
            // 
            // currentGradeLabel
            // 
            this.currentGradeLabel.AutoSize = true;
            this.currentGradeLabel.Location = new System.Drawing.Point(102, 56);
            this.currentGradeLabel.Name = "currentGradeLabel";
            this.currentGradeLabel.Size = new System.Drawing.Size(0, 13);
            this.currentGradeLabel.TabIndex = 8;
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Location = new System.Drawing.Point(102, 29);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(0, 13);
            this.studentNameLabel.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Updated Grade:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(237, 78);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 30);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "&Save Entry";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Current Grade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Student Name:";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(144, 429);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 43);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // instructorComboBox
            // 
            this.instructorComboBox.FormattingEnabled = true;
            this.instructorComboBox.Location = new System.Drawing.Point(80, 13);
            this.instructorComboBox.Name = "instructorComboBox";
            this.instructorComboBox.Size = new System.Drawing.Size(172, 21);
            this.instructorComboBox.TabIndex = 6;
            this.instructorComboBox.SelectedIndexChanged += new System.EventHandler(this.instructorComboBox_SelectedIndexChanged);
            // 
            // courseComboBox
            // 
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.Location = new System.Drawing.Point(67, 42);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(185, 21);
            this.courseComboBox.TabIndex = 7;
            this.courseComboBox.SelectedIndexChanged += new System.EventHandler(this.courseComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Enrolled Students:";
            // 
            // studentListBox
            // 
            this.studentListBox.FormattingEnabled = true;
            this.studentListBox.Location = new System.Drawing.Point(19, 100);
            this.studentListBox.Name = "studentListBox";
            this.studentListBox.Size = new System.Drawing.Size(333, 160);
            this.studentListBox.TabIndex = 9;
            this.studentListBox.SelectedIndexChanged += new System.EventHandler(this.studentListBox_SelectedIndexChanged);
            // 
            // InstructorUpdateGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 485);
            this.Controls.Add(this.studentListBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.courseComboBox);
            this.Controls.Add(this.instructorComboBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InstructorUpdateGrades";
            this.Text = "InstructorUpdateGrades";
            this.Load += new System.EventHandler(this.InstructorUpdateGrades_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label currentGradeLabel;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ComboBox instructorComboBox;
        private System.Windows.Forms.ComboBox courseComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox studentListBox;
        private System.Windows.Forms.ComboBox newGradeComboBox;
    }
}