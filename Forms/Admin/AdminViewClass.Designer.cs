
namespace CISS311GroupProject.Forms.Admin
{
    partial class AdminViewClass
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminViewClass));
            this.gradesDataGrid = new System.Windows.Forms.DataGridView();
            this.tinyCollegeDataSet = new CISS311GroupProject.TinyCollegeDataSet();
            this.tinyCollegeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseXstudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseXstudentTableAdapter = new CISS311GroupProject.TinyCollegeDataSetTableAdapters.courseXstudentTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.instructorLabel = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gradesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinyCollegeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinyCollegeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseXstudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradesDataGrid
            // 
            this.gradesDataGrid.AllowUserToAddRows = false;
            this.gradesDataGrid.AllowUserToDeleteRows = false;
            this.gradesDataGrid.AllowUserToOrderColumns = true;
            this.gradesDataGrid.Location = new System.Drawing.Point(12, 33);
            this.gradesDataGrid.MultiSelect = false;
            this.gradesDataGrid.Name = "gradesDataGrid";
            this.gradesDataGrid.ReadOnly = true;
            this.gradesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gradesDataGrid.Size = new System.Drawing.Size(341, 367);
            this.gradesDataGrid.TabIndex = 0;
            // 
            // tinyCollegeDataSet
            // 
            this.tinyCollegeDataSet.DataSetName = "TinyCollegeDataSet";
            this.tinyCollegeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tinyCollegeDataSetBindingSource
            // 
            this.tinyCollegeDataSetBindingSource.DataSource = this.tinyCollegeDataSet;
            this.tinyCollegeDataSetBindingSource.Position = 0;
            // 
            // courseXstudentBindingSource
            // 
            this.courseXstudentBindingSource.DataMember = "courseXstudent";
            this.courseXstudentBindingSource.DataSource = this.tinyCollegeDataSetBindingSource;
            // 
            // courseXstudentTableAdapter
            // 
            this.courseXstudentTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Instructor:";
            // 
            // instructorLabel
            // 
            this.instructorLabel.AutoSize = true;
            this.instructorLabel.Location = new System.Drawing.Point(70, 9);
            this.instructorLabel.Name = "instructorLabel";
            this.instructorLabel.Size = new System.Drawing.Size(0, 13);
            this.instructorLabel.TabIndex = 2;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchBtn.Location = new System.Drawing.Point(73, 406);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(150, 30);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Search Courses";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Course:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(230, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(0, 13);
            this.titleLabel.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::CISS311GroupProject.Properties.Resources.TinyCollegeShadow;
            this.pictureBox1.InitialImage = global::CISS311GroupProject.Properties.Resources.TinyCollegeShadow;
            this.pictureBox1.Location = new System.Drawing.Point(268, 404);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // AdminViewClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 485);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.instructorLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gradesDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminViewClass";
            this.Text = "Administrator: View Classes";
            this.Load += new System.EventHandler(this.AdminViewClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gradesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinyCollegeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinyCollegeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseXstudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gradesDataGrid;
        private System.Windows.Forms.BindingSource tinyCollegeDataSetBindingSource;
        private TinyCollegeDataSet tinyCollegeDataSet;
        private System.Windows.Forms.BindingSource courseXstudentBindingSource;
        private TinyCollegeDataSetTableAdapters.courseXstudentTableAdapter courseXstudentTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label instructorLabel;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}