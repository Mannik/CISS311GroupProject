
namespace CISS311GroupProject.Forms.Admin
{
    partial class EmployeeSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeSearchForm));
            this.selectBtn = new System.Windows.Forms.Button();
            this.employeeDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // selectBtn
            // 
            this.selectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.selectBtn.Location = new System.Drawing.Point(296, 551);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(129, 28);
            this.selectBtn.TabIndex = 23;
            this.selectBtn.Text = "Use Selection";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // employeeDataGrid
            // 
            this.employeeDataGrid.AllowUserToAddRows = false;
            this.employeeDataGrid.AllowUserToDeleteRows = false;
            this.employeeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGrid.Location = new System.Drawing.Point(12, 12);
            this.employeeDataGrid.MultiSelect = false;
            this.employeeDataGrid.Name = "employeeDataGrid";
            this.employeeDataGrid.ReadOnly = true;
            this.employeeDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeDataGrid.Size = new System.Drawing.Size(413, 533);
            this.employeeDataGrid.TabIndex = 24;
            this.employeeDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeDataGrid_CellDoubleClick);
            this.employeeDataGrid.SelectionChanged += new System.EventHandler(this.employeeDataGrid_SelectionChanged);
            // 
            // EmployeeSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 586);
            this.Controls.Add(this.employeeDataGrid);
            this.Controls.Add(this.selectBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeSearchForm";
            this.Text = "Employee Search";
            this.Load += new System.EventHandler(this.EmployeeSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.DataGridView employeeDataGrid;
    }
}