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
            this.courseTitleComboBox = new System.Windows.Forms.ComboBox();
            this.checkAvailabilityButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // courseTitleComboBox
            // 
            this.courseTitleComboBox.FormattingEnabled = true;
            this.courseTitleComboBox.Location = new System.Drawing.Point(130, 291);
            this.courseTitleComboBox.Name = "courseTitleComboBox";
            this.courseTitleComboBox.Size = new System.Drawing.Size(121, 21);
            this.courseTitleComboBox.TabIndex = 0;
            this.courseTitleComboBox.SelectedIndexChanged += new System.EventHandler(this.courseTitleComboBox_SelectedIndexChanged);
            // 
            // checkAvailabilityButton
            // 
            this.checkAvailabilityButton.Location = new System.Drawing.Point(130, 357);
            this.checkAvailabilityButton.Name = "checkAvailabilityButton";
            this.checkAvailabilityButton.Size = new System.Drawing.Size(121, 23);
            this.checkAvailabilityButton.TabIndex = 1;
            this.checkAvailabilityButton.Text = "Check Availability";
            this.checkAvailabilityButton.UseVisualStyleBackColor = true;
            this.checkAvailabilityButton.Click += new System.EventHandler(this.checkAvailabilityButton_Click);
            // 
            // StudentEnrollCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkAvailabilityButton);
            this.Controls.Add(this.courseTitleComboBox);
            this.Name = "StudentEnrollCourse";
            this.Text = "StudentEnrollCourse";
            this.Load += new System.EventHandler(this.StudentEnrollCourse_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox courseTitleComboBox;
        private System.Windows.Forms.Button checkAvailabilityButton;
    }
}