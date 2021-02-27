
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
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.courseIdTextBox = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.currentCourseLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newCourseTitleTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.seatsAvailableLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.updatedSeatsTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.yesCheckBox = new System.Windows.Forms.CheckBox();
            this.noCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.noCheckBox);
            this.groupBox1.Controls.Add(this.yesCheckBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.updatedSeatsTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.seatsAvailableLabel);
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
            this.groupBox1.Size = new System.Drawing.Size(456, 303);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Course Information";
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.updateButton.Location = new System.Drawing.Point(13, 322);
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
            this.deleteButton.Location = new System.Drawing.Point(173, 322);
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
            this.exitButton.Location = new System.Drawing.Point(344, 322);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(125, 30);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
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
            // courseIdTextBox
            // 
            this.courseIdTextBox.Location = new System.Drawing.Point(136, 43);
            this.courseIdTextBox.Name = "courseIdTextBox";
            this.courseIdTextBox.Size = new System.Drawing.Size(100, 26);
            this.courseIdTextBox.TabIndex = 1;
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(303, 41);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 30);
            this.findButton.TabIndex = 2;
            this.findButton.Text = "&Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Course Title:";
            // 
            // currentCourseLabel
            // 
            this.currentCourseLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.currentCourseLabel.Location = new System.Drawing.Point(175, 101);
            this.currentCourseLabel.Name = "currentCourseLabel";
            this.currentCourseLabel.Size = new System.Drawing.Size(203, 26);
            this.currentCourseLabel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Change Course Title:";
            // 
            // newCourseTitleTextBox
            // 
            this.newCourseTitleTextBox.Location = new System.Drawing.Point(175, 153);
            this.newCourseTitleTextBox.Name = "newCourseTitleTextBox";
            this.newCourseTitleTextBox.Size = new System.Drawing.Size(203, 26);
            this.newCourseTitleTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Seats Available:";
            // 
            // seatsAvailableLabel
            // 
            this.seatsAvailableLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seatsAvailableLabel.Location = new System.Drawing.Point(175, 206);
            this.seatsAvailableLabel.Name = "seatsAvailableLabel";
            this.seatsAvailableLabel.Size = new System.Drawing.Size(35, 26);
            this.seatsAvailableLabel.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Updated Seats:";
            // 
            // updatedSeatsTextBox
            // 
            this.updatedSeatsTextBox.Location = new System.Drawing.Point(343, 206);
            this.updatedSeatsTextBox.Name = "updatedSeatsTextBox";
            this.updatedSeatsTextBox.Size = new System.Drawing.Size(35, 26);
            this.updatedSeatsTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Course Available:";
            // 
            // yesCheckBox
            // 
            this.yesCheckBox.AutoSize = true;
            this.yesCheckBox.Location = new System.Drawing.Point(175, 255);
            this.yesCheckBox.Name = "yesCheckBox";
            this.yesCheckBox.Size = new System.Drawing.Size(61, 24);
            this.yesCheckBox.TabIndex = 12;
            this.yesCheckBox.Text = "YES";
            this.yesCheckBox.UseVisualStyleBackColor = true;
            // 
            // noCheckBox
            // 
            this.noCheckBox.AutoSize = true;
            this.noCheckBox.Location = new System.Drawing.Point(303, 255);
            this.noCheckBox.Name = "noCheckBox";
            this.noCheckBox.Size = new System.Drawing.Size(51, 24);
            this.noCheckBox.TabIndex = 13;
            this.noCheckBox.Text = "NO";
            this.noCheckBox.UseVisualStyleBackColor = true;
            // 
            // ManageCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 369);
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
        private System.Windows.Forms.CheckBox noCheckBox;
        private System.Windows.Forms.CheckBox yesCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox updatedSeatsTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label seatsAvailableLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newCourseTitleTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label currentCourseLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TextBox courseIdTextBox;
        private System.Windows.Forms.Label label1;
    }
}