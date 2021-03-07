namespace CISS311GroupProject
{
    partial class StudentEnrollCourse
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.courseTitleLabel = new System.Windows.Forms.Label();
            this.instructorLabel = new System.Windows.Forms.Label();
            this.seatCountLabel = new System.Windows.Forms.Label();
            this.isAvailableLabel = new System.Windows.Forms.Label();
            this.enrollNewButton = new System.Windows.Forms.Button();
            this.enrollCloseButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.courseSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Course Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Instructor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seats:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Availability:";
            // 
            // courseTitleLabel
            // 
            this.courseTitleLabel.AutoSize = true;
            this.courseTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.courseTitleLabel.Location = new System.Drawing.Point(134, 84);
            this.courseTitleLabel.Name = "courseTitleLabel";
            this.courseTitleLabel.Size = new System.Drawing.Size(2, 15);
            this.courseTitleLabel.TabIndex = 6;
            // 
            // instructorLabel
            // 
            this.instructorLabel.AutoSize = true;
            this.instructorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.instructorLabel.Location = new System.Drawing.Point(134, 133);
            this.instructorLabel.Name = "instructorLabel";
            this.instructorLabel.Size = new System.Drawing.Size(2, 15);
            this.instructorLabel.TabIndex = 7;
            // 
            // seatCountLabel
            // 
            this.seatCountLabel.AutoSize = true;
            this.seatCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seatCountLabel.Location = new System.Drawing.Point(134, 181);
            this.seatCountLabel.Name = "seatCountLabel";
            this.seatCountLabel.Size = new System.Drawing.Size(2, 15);
            this.seatCountLabel.TabIndex = 8;
            // 
            // isAvailableLabel
            // 
            this.isAvailableLabel.AutoSize = true;
            this.isAvailableLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.isAvailableLabel.Location = new System.Drawing.Point(134, 230);
            this.isAvailableLabel.Name = "isAvailableLabel";
            this.isAvailableLabel.Size = new System.Drawing.Size(2, 15);
            this.isAvailableLabel.TabIndex = 9;
            // 
            // enrollNewButton
            // 
            this.enrollNewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.enrollNewButton.Location = new System.Drawing.Point(20, 274);
            this.enrollNewButton.Name = "enrollNewButton";
            this.enrollNewButton.Size = new System.Drawing.Size(116, 43);
            this.enrollNewButton.TabIndex = 10;
            this.enrollNewButton.Text = "Enroll && &New";
            this.enrollNewButton.UseVisualStyleBackColor = true;
            this.enrollNewButton.Click += new System.EventHandler(this.enrollNewButton_Click);
            // 
            // enrollCloseButton
            // 
            this.enrollCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.enrollCloseButton.Location = new System.Drawing.Point(142, 274);
            this.enrollCloseButton.Name = "enrollCloseButton";
            this.enrollCloseButton.Size = new System.Drawing.Size(119, 43);
            this.enrollCloseButton.TabIndex = 11;
            this.enrollCloseButton.Text = "&Enroll && Close";
            this.enrollCloseButton.UseVisualStyleBackColor = true;
            this.enrollCloseButton.Click += new System.EventHandler(this.enrollCloseButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.closeButton.Location = new System.Drawing.Point(267, 274);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(83, 43);
            this.closeButton.TabIndex = 12;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // courseSelectionComboBox
            // 
            this.courseSelectionComboBox.FormattingEnabled = true;
            this.courseSelectionComboBox.Location = new System.Drawing.Point(20, 12);
            this.courseSelectionComboBox.Name = "courseSelectionComboBox";
            this.courseSelectionComboBox.Size = new System.Drawing.Size(352, 21);
            this.courseSelectionComboBox.TabIndex = 13;
            this.courseSelectionComboBox.SelectedIndexChanged += new System.EventHandler(this.courseSelectionComboBox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::CISS311GroupProject.Properties.Resources.TinyCollegeShadow;
            this.pictureBox1.InitialImage = global::CISS311GroupProject.Properties.Resources.TinyCollegeShadow;
            this.pictureBox1.Location = new System.Drawing.Point(356, 248);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // StudentEnrollCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 324);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.courseSelectionComboBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.enrollCloseButton);
            this.Controls.Add(this.enrollNewButton);
            this.Controls.Add(this.isAvailableLabel);
            this.Controls.Add(this.seatCountLabel);
            this.Controls.Add(this.instructorLabel);
            this.Controls.Add(this.courseTitleLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentEnrollCourse";
            this.Text = "StudentEnrollCourse";
            this.Load += new System.EventHandler(this.StudentEnrollCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label courseTitleLabel;
        private System.Windows.Forms.Label instructorLabel;
        private System.Windows.Forms.Label seatCountLabel;
        private System.Windows.Forms.Label isAvailableLabel;
        private System.Windows.Forms.Button enrollNewButton;
        private System.Windows.Forms.Button enrollCloseButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ComboBox courseSelectionComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}