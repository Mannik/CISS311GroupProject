namespace CISS311GroupProject
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.remainingCreditsLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.studentTotalCreditsLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.viewCoursesButton = new System.Windows.Forms.Button();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.studentIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enrollButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // remainingCreditsLabel
            // 
            this.remainingCreditsLabel.AutoSize = true;
            this.remainingCreditsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.remainingCreditsLabel.Location = new System.Drawing.Point(533, 28);
            this.remainingCreditsLabel.Name = "remainingCreditsLabel";
            this.remainingCreditsLabel.Size = new System.Drawing.Size(2, 15);
            this.remainingCreditsLabel.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Remaining Credits:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::CISS311GroupProject.Properties.Resources.TinyCollegeShadow;
            this.pictureBox1.InitialImage = global::CISS311GroupProject.Properties.Resources.TinyCollegeShadow;
            this.pictureBox1.Location = new System.Drawing.Point(614, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.closeButton.Location = new System.Drawing.Point(637, 156);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(129, 46);
            this.closeButton.TabIndex = 26;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // studentTotalCreditsLabel
            // 
            this.studentTotalCreditsLabel.AutoSize = true;
            this.studentTotalCreditsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.studentTotalCreditsLabel.Location = new System.Drawing.Point(533, 9);
            this.studentTotalCreditsLabel.Name = "studentTotalCreditsLabel";
            this.studentTotalCreditsLabel.Size = new System.Drawing.Size(2, 15);
            this.studentTotalCreditsLabel.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Total Credits:";
            // 
            // viewCoursesButton
            // 
            this.viewCoursesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.viewCoursesButton.Location = new System.Drawing.Point(12, 47);
            this.viewCoursesButton.Name = "viewCoursesButton";
            this.viewCoursesButton.Size = new System.Drawing.Size(596, 72);
            this.viewCoursesButton.TabIndex = 23;
            this.viewCoursesButton.Text = "Vi&ew Courses";
            this.viewCoursesButton.UseVisualStyleBackColor = true;
            this.viewCoursesButton.Click += new System.EventHandler(this.viewCoursesButton_Click);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lastNameLabel.Location = new System.Drawing.Point(333, 28);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(2, 15);
            this.lastNameLabel.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.firstNameLabel.Location = new System.Drawing.Point(333, 9);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(2, 15);
            this.firstNameLabel.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "First Name:";
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(186, 18);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 18;
            this.findButton.Text = "&Find";
            this.findButton.UseVisualStyleBackColor = true;
            // 
            // studentIdTextBox
            // 
            this.studentIdTextBox.Location = new System.Drawing.Point(80, 20);
            this.studentIdTextBox.Name = "studentIdTextBox";
            this.studentIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentIdTextBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Student ID:";
            // 
            // enrollButton
            // 
            this.enrollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.enrollButton.Location = new System.Drawing.Point(12, 145);
            this.enrollButton.Name = "enrollButton";
            this.enrollButton.Size = new System.Drawing.Size(596, 72);
            this.enrollButton.TabIndex = 15;
            this.enrollButton.Text = "&Enroll";
            this.enrollButton.UseVisualStyleBackColor = true;
            this.enrollButton.Click += new System.EventHandler(this.enrollButton_Click_1);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 402);
            this.Controls.Add(this.remainingCreditsLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.studentTotalCreditsLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.viewCoursesButton);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.studentIdTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enrollButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label remainingCreditsLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label studentTotalCreditsLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button viewCoursesButton;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TextBox studentIdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enrollButton;
    }
}