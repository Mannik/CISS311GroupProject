namespace CISS311GroupProject
{
    partial class AdminAddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAddStudent));
            this.saveButton = new System.Windows.Forms.Button();
            this.saveAddAnotherButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.incomingCreditsCheckBox = new System.Windows.Forms.CheckBox();
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.lbCreditHours = new System.Windows.Forms.Label();
            this.studentCountLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.saveButton.Location = new System.Drawing.Point(7, 159);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(115, 35);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "&Save && Close";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // saveAddAnotherButton
            // 
            this.saveAddAnotherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.saveAddAnotherButton.Location = new System.Drawing.Point(128, 159);
            this.saveAddAnotherButton.Name = "saveAddAnotherButton";
            this.saveAddAnotherButton.Size = new System.Drawing.Size(115, 35);
            this.saveAddAnotherButton.TabIndex = 1;
            this.saveAddAnotherButton.Text = "Save && &New";
            this.saveAddAnotherButton.UseVisualStyleBackColor = true;
            this.saveAddAnotherButton.Click += new System.EventHandler(this.saveAddAnotherButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancelButton.Location = new System.Drawing.Point(249, 159);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(115, 35);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.firstNameTextBox.Location = new System.Drawing.Point(75, 16);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(226, 20);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFirstName.Location = new System.Drawing.Point(12, 19);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblLastName.Location = new System.Drawing.Point(11, 54);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lastNameTextBox.Location = new System.Drawing.Point(75, 51);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(226, 20);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // incomingCreditsCheckBox
            // 
            this.incomingCreditsCheckBox.AutoSize = true;
            this.incomingCreditsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.incomingCreditsCheckBox.Location = new System.Drawing.Point(7, 121);
            this.incomingCreditsCheckBox.Name = "incomingCreditsCheckBox";
            this.incomingCreditsCheckBox.Size = new System.Drawing.Size(165, 17);
            this.incomingCreditsCheckBox.TabIndex = 7;
            this.incomingCreditsCheckBox.Text = "Student has incoming credits.";
            this.incomingCreditsCheckBox.UseVisualStyleBackColor = true;
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.hoursTextBox.Location = new System.Drawing.Point(75, 86);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(100, 20);
            this.hoursTextBox.TabIndex = 8;
            this.hoursTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hoursTextBox_KeyPress);
            // 
            // lbCreditHours
            // 
            this.lbCreditHours.AutoSize = true;
            this.lbCreditHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbCreditHours.Location = new System.Drawing.Point(4, 89);
            this.lbCreditHours.Name = "lbCreditHours";
            this.lbCreditHours.Size = new System.Drawing.Size(65, 13);
            this.lbCreditHours.TabIndex = 9;
            this.lbCreditHours.Text = "Credit Hours";
            // 
            // studentCountLabel
            // 
            this.studentCountLabel.AutoSize = true;
            this.studentCountLabel.Location = new System.Drawing.Point(398, 19);
            this.studentCountLabel.Name = "studentCountLabel";
            this.studentCountLabel.Size = new System.Drawing.Size(28, 13);
            this.studentCountLabel.TabIndex = 11;
            this.studentCountLabel.Text = "data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Student Count:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::CISS311GroupProject.Properties.Resources.TinyCollegeShadow;
            this.pictureBox1.InitialImage = global::CISS311GroupProject.Properties.Resources.TinyCollegeShadow;
            this.pictureBox1.Location = new System.Drawing.Point(373, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // AdminAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 209);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentCountLabel);
            this.Controls.Add(this.lbCreditHours);
            this.Controls.Add(this.hoursTextBox);
            this.Controls.Add(this.incomingCreditsCheckBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveAddAnotherButton);
            this.Controls.Add(this.saveButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminAddStudent";
            this.Text = "Administrator: Add New Student";
            this.Load += new System.EventHandler(this.AdminAddStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button saveAddAnotherButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.CheckBox incomingCreditsCheckBox;
        private System.Windows.Forms.TextBox hoursTextBox;
        private System.Windows.Forms.Label lbCreditHours;
        private System.Windows.Forms.Label studentCountLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}