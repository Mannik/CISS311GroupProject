namespace CISS311GroupProject
{
    partial class InstructorForm
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
            this.viewCoursesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewCoursesBtn
            // 
            this.viewCoursesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCoursesBtn.Location = new System.Drawing.Point(209, 12);
            this.viewCoursesBtn.Name = "viewCoursesBtn";
            this.viewCoursesBtn.Size = new System.Drawing.Size(361, 58);
            this.viewCoursesBtn.TabIndex = 1;
            this.viewCoursesBtn.Text = "View Courses";
            this.viewCoursesBtn.UseVisualStyleBackColor = true;
            this.viewCoursesBtn.Click += new System.EventHandler(this.viewCoursesBtn_Click);
            // 
            // InstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewCoursesBtn);
            this.Name = "InstructorForm";
            this.Text = "InstructorForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewCoursesBtn;
    }
}