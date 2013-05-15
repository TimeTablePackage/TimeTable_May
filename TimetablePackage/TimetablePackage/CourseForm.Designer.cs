namespace TimetablePackage
{
    partial class CourseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CourseGroupBox = new System.Windows.Forms.GroupBox();
            this.CourseDataGridView = new System.Windows.Forms.DataGridView();
            this.DepartmentGroupBox = new System.Windows.Forms.GroupBox();
            this.DepartmentDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteCourseButton = new System.Windows.Forms.Button();
            this.editCourseButton = new System.Windows.Forms.Button();
            this.addCourseButton = new System.Windows.Forms.Button();
            this.removeDepartmentButton = new System.Windows.Forms.Button();
            this.editDepartmentButton = new System.Windows.Forms.Button();
            this.addDepartmentButton = new System.Windows.Forms.Button();
            this.CourseGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataGridView)).BeginInit();
            this.DepartmentGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CourseGroupBox
            // 
            this.CourseGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CourseGroupBox.Controls.Add(this.CourseDataGridView);
            this.CourseGroupBox.Location = new System.Drawing.Point(148, 53);
            this.CourseGroupBox.Name = "CourseGroupBox";
            this.CourseGroupBox.Size = new System.Drawing.Size(414, 267);
            this.CourseGroupBox.TabIndex = 8;
            this.CourseGroupBox.TabStop = false;
            this.CourseGroupBox.Text = "Courses";
            // 
            // CourseDataGridView
            // 
            this.CourseDataGridView.AllowUserToAddRows = false;
            this.CourseDataGridView.AllowUserToDeleteRows = false;
            this.CourseDataGridView.AllowUserToResizeColumns = false;
            this.CourseDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CourseDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CourseDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.CourseDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.CourseDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.CourseDataGridView.ColumnHeadersHeight = 21;
            this.CourseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.CourseDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CourseDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.CourseDataGridView.Location = new System.Drawing.Point(3, 16);
            this.CourseDataGridView.MultiSelect = false;
            this.CourseDataGridView.Name = "CourseDataGridView";
            this.CourseDataGridView.ReadOnly = true;
            this.CourseDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.CourseDataGridView.RowHeadersVisible = false;
            this.CourseDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CourseDataGridView.RowTemplate.ReadOnly = true;
            this.CourseDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CourseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CourseDataGridView.Size = new System.Drawing.Size(408, 248);
            this.CourseDataGridView.TabIndex = 1;
            this.CourseDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.CourseDataGridView_CellEnter);
            // 
            // DepartmentGroupBox
            // 
            this.DepartmentGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DepartmentGroupBox.Controls.Add(this.DepartmentDataGridView);
            this.DepartmentGroupBox.Location = new System.Drawing.Point(636, 53);
            this.DepartmentGroupBox.Name = "DepartmentGroupBox";
            this.DepartmentGroupBox.Size = new System.Drawing.Size(158, 267);
            this.DepartmentGroupBox.TabIndex = 13;
            this.DepartmentGroupBox.TabStop = false;
            this.DepartmentGroupBox.Text = "Departments";
            // 
            // DepartmentDataGridView
            // 
            this.DepartmentDataGridView.AllowUserToAddRows = false;
            this.DepartmentDataGridView.AllowUserToDeleteRows = false;
            this.DepartmentDataGridView.AllowUserToResizeColumns = false;
            this.DepartmentDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DepartmentDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DepartmentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DepartmentDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DepartmentDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DepartmentDataGridView.ColumnHeadersHeight = 21;
            this.DepartmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DepartmentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DepartmentDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.DepartmentDataGridView.Location = new System.Drawing.Point(3, 16);
            this.DepartmentDataGridView.MultiSelect = false;
            this.DepartmentDataGridView.Name = "DepartmentDataGridView";
            this.DepartmentDataGridView.ReadOnly = true;
            this.DepartmentDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DepartmentDataGridView.RowHeadersVisible = false;
            this.DepartmentDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DepartmentDataGridView.RowTemplate.ReadOnly = true;
            this.DepartmentDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DepartmentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DepartmentDataGridView.Size = new System.Drawing.Size(152, 248);
            this.DepartmentDataGridView.TabIndex = 1;
            this.DepartmentDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DepartmentDataGridView_CellEnter);
            // 
            // deleteCourseButton
            // 
            this.deleteCourseButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCourseButton.Image = global::TimetablePackage.Properties.Resources.delete;
            this.deleteCourseButton.Location = new System.Drawing.Point(12, 214);
            this.deleteCourseButton.Name = "deleteCourseButton";
            this.deleteCourseButton.Size = new System.Drawing.Size(103, 43);
            this.deleteCourseButton.TabIndex = 16;
            this.deleteCourseButton.Text = "Remove a Course";
            this.deleteCourseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteCourseButton.UseVisualStyleBackColor = true;
            this.deleteCourseButton.Click += new System.EventHandler(this.deleteCourseButton_Click);
            // 
            // editCourseButton
            // 
            this.editCourseButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCourseButton.Image = global::TimetablePackage.Properties.Resources.bullet_edit;
            this.editCourseButton.Location = new System.Drawing.Point(12, 165);
            this.editCourseButton.Name = "editCourseButton";
            this.editCourseButton.Size = new System.Drawing.Size(103, 43);
            this.editCourseButton.TabIndex = 15;
            this.editCourseButton.Text = "Edit a Course";
            this.editCourseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editCourseButton.UseVisualStyleBackColor = true;
            this.editCourseButton.Click += new System.EventHandler(this.editCourseButton_Click);
            // 
            // addCourseButton
            // 
            this.addCourseButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCourseButton.Image = global::TimetablePackage.Properties.Resources.add;
            this.addCourseButton.Location = new System.Drawing.Point(12, 116);
            this.addCourseButton.Name = "addCourseButton";
            this.addCourseButton.Size = new System.Drawing.Size(103, 43);
            this.addCourseButton.TabIndex = 14;
            this.addCourseButton.Text = "Add a Course";
            this.addCourseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addCourseButton.UseVisualStyleBackColor = true;
            this.addCourseButton.Click += new System.EventHandler(this.addCourseButton_Click);
            // 
            // removeDepartmentButton
            // 
            this.removeDepartmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeDepartmentButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeDepartmentButton.Image = global::TimetablePackage.Properties.Resources.delete;
            this.removeDepartmentButton.Location = new System.Drawing.Point(868, 214);
            this.removeDepartmentButton.Name = "removeDepartmentButton";
            this.removeDepartmentButton.Size = new System.Drawing.Size(112, 43);
            this.removeDepartmentButton.TabIndex = 19;
            this.removeDepartmentButton.Text = "Remove a Department";
            this.removeDepartmentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.removeDepartmentButton.UseVisualStyleBackColor = true;
            // 
            // editDepartmentButton
            // 
            this.editDepartmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editDepartmentButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editDepartmentButton.Image = global::TimetablePackage.Properties.Resources.bullet_edit;
            this.editDepartmentButton.Location = new System.Drawing.Point(868, 165);
            this.editDepartmentButton.Name = "editDepartmentButton";
            this.editDepartmentButton.Size = new System.Drawing.Size(112, 43);
            this.editDepartmentButton.TabIndex = 18;
            this.editDepartmentButton.Text = "Edit a Department";
            this.editDepartmentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editDepartmentButton.UseVisualStyleBackColor = true;
            // 
            // addDepartmentButton
            // 
            this.addDepartmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addDepartmentButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDepartmentButton.Image = global::TimetablePackage.Properties.Resources.add;
            this.addDepartmentButton.Location = new System.Drawing.Point(868, 116);
            this.addDepartmentButton.Name = "addDepartmentButton";
            this.addDepartmentButton.Size = new System.Drawing.Size(112, 43);
            this.addDepartmentButton.TabIndex = 17;
            this.addDepartmentButton.Text = "Add a Department";
            this.addDepartmentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addDepartmentButton.UseVisualStyleBackColor = true;
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 372);
            this.Controls.Add(this.removeDepartmentButton);
            this.Controls.Add(this.editDepartmentButton);
            this.Controls.Add(this.addDepartmentButton);
            this.Controls.Add(this.deleteCourseButton);
            this.Controls.Add(this.editCourseButton);
            this.Controls.Add(this.addCourseButton);
            this.Controls.Add(this.DepartmentGroupBox);
            this.Controls.Add(this.CourseGroupBox);
            this.DockAreas = ((DigitalRune.Windows.Docking.DockAreas)((((((DigitalRune.Windows.Docking.DockAreas.Float | DigitalRune.Windows.Docking.DockAreas.Left) 
            | DigitalRune.Windows.Docking.DockAreas.Right) 
            | DigitalRune.Windows.Docking.DockAreas.Top) 
            | DigitalRune.Windows.Docking.DockAreas.Bottom) 
            | DigitalRune.Windows.Docking.DockAreas.Document)));
            this.Name = "CourseForm";
            this.TabText = "Courses";
            this.Text = "Courses/Departments";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            this.CourseGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataGridView)).EndInit();
            this.DepartmentGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CourseGroupBox;
        private System.Windows.Forms.DataGridView CourseDataGridView;
        private System.Windows.Forms.GroupBox DepartmentGroupBox;
        private System.Windows.Forms.DataGridView DepartmentDataGridView;
        private System.Windows.Forms.Button deleteCourseButton;
        private System.Windows.Forms.Button editCourseButton;
        private System.Windows.Forms.Button addCourseButton;
        private System.Windows.Forms.Button removeDepartmentButton;
        private System.Windows.Forms.Button editDepartmentButton;
        private System.Windows.Forms.Button addDepartmentButton;
    }
}