
namespace CISS311GroupProject.Forms.Admin
{
    partial class CourseSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseSearchForm));
            this.courseDataGrid = new System.Windows.Forms.DataGridView();
            this.selectBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // courseDataGrid
            // 
            this.courseDataGrid.AllowUserToAddRows = false;
            this.courseDataGrid.AllowUserToDeleteRows = false;
            this.courseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseDataGrid.Location = new System.Drawing.Point(12, 12);
            this.courseDataGrid.MultiSelect = false;
            this.courseDataGrid.Name = "courseDataGrid";
            this.courseDataGrid.ReadOnly = true;
            this.courseDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.courseDataGrid.Size = new System.Drawing.Size(348, 533);
            this.courseDataGrid.TabIndex = 26;
            this.courseDataGrid.SelectionChanged += new System.EventHandler(this.courseDataGrid_SelectionChanged);
            // 
            // selectBtn
            // 
            this.selectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.selectBtn.Location = new System.Drawing.Point(231, 551);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(129, 28);
            this.selectBtn.TabIndex = 25;
            this.selectBtn.Text = "Use Selection";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // CourseSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 586);
            this.Controls.Add(this.courseDataGrid);
            this.Controls.Add(this.selectBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CourseSearchForm";
            this.Text = "Course Search";
            this.Load += new System.EventHandler(this.CourseSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView courseDataGrid;
        private System.Windows.Forms.Button selectBtn;
    }
}