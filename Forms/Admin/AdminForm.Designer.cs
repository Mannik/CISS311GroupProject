namespace CISS311GroupProject
{
    partial class AdminForm
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
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.addCourseBtn = new System.Windows.Forms.Button();
            this.addEmployeeBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.viewCoursesBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentBtn.Location = new System.Drawing.Point(12, 12);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(596, 72);
            this.addStudentBtn.TabIndex = 0;
            this.addStudentBtn.Text = "Add New Student";
            this.addStudentBtn.UseVisualStyleBackColor = true;
            this.addStudentBtn.Click += new System.EventHandler(this.addStudentBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.closeBtn.Location = new System.Drawing.Point(637, 156);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(129, 46);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "&Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // addCourseBtn
            // 
            this.addCourseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCourseBtn.Location = new System.Drawing.Point(12, 168);
            this.addCourseBtn.Name = "addCourseBtn";
            this.addCourseBtn.Size = new System.Drawing.Size(596, 72);
            this.addCourseBtn.TabIndex = 2;
            this.addCourseBtn.Text = "Add New Course";
            this.addCourseBtn.UseVisualStyleBackColor = true;
            // 
            // addEmployeeBtn
            // 
            this.addEmployeeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeBtn.Location = new System.Drawing.Point(12, 90);
            this.addEmployeeBtn.Name = "addEmployeeBtn";
            this.addEmployeeBtn.Size = new System.Drawing.Size(596, 72);
            this.addEmployeeBtn.TabIndex = 3;
            this.addEmployeeBtn.Text = "Add New Instructor";
            this.addEmployeeBtn.UseVisualStyleBackColor = true;
            this.addEmployeeBtn.Click += new System.EventHandler(this.button2_Click);
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
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // viewCoursesBtn
            // 
            this.viewCoursesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCoursesBtn.Location = new System.Drawing.Point(12, 246);
            this.viewCoursesBtn.Name = "viewCoursesBtn";
            this.viewCoursesBtn.Size = new System.Drawing.Size(596, 72);
            this.viewCoursesBtn.TabIndex = 5;
            this.viewCoursesBtn.Text = "View Course Grades";
            this.viewCoursesBtn.UseVisualStyleBackColor = true;
            this.viewCoursesBtn.Click += new System.EventHandler(this.viewCoursesBtn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 324);
            this.Controls.Add(this.viewCoursesBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addEmployeeBtn);
            this.Controls.Add(this.addCourseBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.addStudentBtn);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button addCourseBtn;
        private System.Windows.Forms.Button addEmployeeBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button viewCoursesBtn;
    }
}