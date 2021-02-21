
namespace CISS311GroupProject
{
    partial class AdministratorViewCourses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorViewCourses));
            this.courseListBox = new System.Windows.Forms.ListBox();
            this.addCourseButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.updateCoursesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.seatTextBox = new System.Windows.Forms.TextBox();
            this.instructorTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // courseListBox
            // 
            this.courseListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseListBox.FormattingEnabled = true;
            this.courseListBox.ItemHeight = 25;
            this.courseListBox.Location = new System.Drawing.Point(12, 12);
            this.courseListBox.Name = "courseListBox";
            this.courseListBox.Size = new System.Drawing.Size(299, 279);
            this.courseListBox.TabIndex = 0;
            this.courseListBox.SelectedIndexChanged += new System.EventHandler(this.courseListBox_SelectedIndexChanged);
            // 
            // addCourseButton
            // 
            this.addCourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCourseButton.Location = new System.Drawing.Point(13, 356);
            this.addCourseButton.Name = "addCourseButton";
            this.addCourseButton.Size = new System.Drawing.Size(147, 35);
            this.addCourseButton.TabIndex = 1;
            this.addCourseButton.Text = "&Add Course";
            this.addCourseButton.UseVisualStyleBackColor = true;
            this.addCourseButton.Click += new System.EventHandler(this.addCourseButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(446, 356);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(147, 35);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // updateCoursesButton
            // 
            this.updateCoursesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCoursesButton.Location = new System.Drawing.Point(222, 356);
            this.updateCoursesButton.Name = "updateCoursesButton";
            this.updateCoursesButton.Size = new System.Drawing.Size(170, 35);
            this.updateCoursesButton.TabIndex = 3;
            this.updateCoursesButton.Text = "&Update Courses";
            this.updateCoursesButton.UseVisualStyleBackColor = true;
            this.updateCoursesButton.Click += new System.EventHandler(this.updateCoursesButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.seatTextBox);
            this.groupBox1.Controls.Add(this.instructorTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(336, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 279);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Course";
            // 
            // seatTextBox
            // 
            this.seatTextBox.Location = new System.Drawing.Point(10, 134);
            this.seatTextBox.Name = "seatTextBox";
            this.seatTextBox.ReadOnly = true;
            this.seatTextBox.Size = new System.Drawing.Size(93, 30);
            this.seatTextBox.TabIndex = 3;
            // 
            // instructorTextBox
            // 
            this.instructorTextBox.Location = new System.Drawing.Point(10, 64);
            this.instructorTextBox.Name = "instructorTextBox";
            this.instructorTextBox.ReadOnly = true;
            this.instructorTextBox.Size = new System.Drawing.Size(241, 30);
            this.instructorTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Seat Count:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Instructor:";
            // 
            // AdministratorViewCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 435);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateCoursesButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addCourseButton);
            this.Controls.Add(this.courseListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdministratorViewCourses";
            this.Text = "Tiny College View Courses";
            this.Load += new System.EventHandler(this.AdministratorViewCourses_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox courseListBox;
        private System.Windows.Forms.Button addCourseButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button updateCoursesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox seatTextBox;
        private System.Windows.Forms.TextBox instructorTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}