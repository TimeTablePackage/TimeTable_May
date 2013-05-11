namespace TimetablePackage
{
    partial class AddEditCourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditCourseForm));
            this.addEditCourseGroupBox = new System.Windows.Forms.GroupBox();
            this.addEditCourseComboBox = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ttpDataSet = new TimetablePackage.ttpDataSet();
            this.courseNameTextBox = new System.Windows.Forms.TextBox();
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.numOfStudentsTextBox = new System.Windows.Forms.TextBox();
            this.numOfStudentsLabel = new System.Windows.Forms.Label();
            this.courseCodeTextBox = new System.Windows.Forms.TextBox();
            this.courseCodeLabel = new System.Windows.Forms.Label();
            this.courseOkButton = new System.Windows.Forms.Button();
            this.courseCanButton = new System.Windows.Forms.Button();
            this.departmentTableAdapter = new TimetablePackage.ttpDataSetTableAdapters.DepartmentTableAdapter();
            this.addEditCourseGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttpDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // addEditCourseGroupBox
            // 
            this.addEditCourseGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addEditCourseGroupBox.Controls.Add(this.addEditCourseComboBox);
            this.addEditCourseGroupBox.Controls.Add(this.courseNameTextBox);
            this.addEditCourseGroupBox.Controls.Add(this.courseNameLabel);
            this.addEditCourseGroupBox.Controls.Add(this.departmentLabel);
            this.addEditCourseGroupBox.Controls.Add(this.numOfStudentsTextBox);
            this.addEditCourseGroupBox.Controls.Add(this.numOfStudentsLabel);
            this.addEditCourseGroupBox.Controls.Add(this.courseCodeTextBox);
            this.addEditCourseGroupBox.Controls.Add(this.courseCodeLabel);
            this.addEditCourseGroupBox.Location = new System.Drawing.Point(12, 25);
            this.addEditCourseGroupBox.Name = "addEditCourseGroupBox";
            this.addEditCourseGroupBox.Size = new System.Drawing.Size(422, 240);
            this.addEditCourseGroupBox.TabIndex = 0;
            this.addEditCourseGroupBox.TabStop = false;
            this.addEditCourseGroupBox.Text = "Add a Course";
            // 
            // addEditCourseComboBox
            // 
            this.addEditCourseComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.departmentBindingSource, "ID", true));
            this.addEditCourseComboBox.DataSource = this.departmentBindingSource;
            this.addEditCourseComboBox.DisplayMember = "Dept_Name";
            this.addEditCourseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addEditCourseComboBox.FormattingEnabled = true;
            this.addEditCourseComboBox.Location = new System.Drawing.Point(231, 160);
            this.addEditCourseComboBox.Name = "addEditCourseComboBox";
            this.addEditCourseComboBox.Size = new System.Drawing.Size(151, 21);
            this.addEditCourseComboBox.TabIndex = 24;
            this.addEditCourseComboBox.ValueMember = "ID";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.ttpDataSet;
            // 
            // ttpDataSet
            // 
            this.ttpDataSet.DataSetName = "ttpDataSet";
            this.ttpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseNameTextBox
            // 
            this.courseNameTextBox.Location = new System.Drawing.Point(231, 91);
            this.courseNameTextBox.Name = "courseNameTextBox";
            this.courseNameTextBox.Size = new System.Drawing.Size(151, 20);
            this.courseNameTextBox.TabIndex = 18;
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameLabel.Location = new System.Drawing.Point(42, 96);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(86, 15);
            this.courseNameLabel.TabIndex = 23;
            this.courseNameLabel.Text = "Course Name:";
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentLabel.Location = new System.Drawing.Point(42, 166);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(75, 15);
            this.departmentLabel.TabIndex = 22;
            this.departmentLabel.Text = "Department:";
            // 
            // numOfStudentsTextBox
            // 
            this.numOfStudentsTextBox.Location = new System.Drawing.Point(231, 126);
            this.numOfStudentsTextBox.MaxLength = 4;
            this.numOfStudentsTextBox.Name = "numOfStudentsTextBox";
            this.numOfStudentsTextBox.Size = new System.Drawing.Size(151, 20);
            this.numOfStudentsTextBox.TabIndex = 19;
            // 
            // numOfStudentsLabel
            // 
            this.numOfStudentsLabel.AutoSize = true;
            this.numOfStudentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfStudentsLabel.Location = new System.Drawing.Point(42, 131);
            this.numOfStudentsLabel.Name = "numOfStudentsLabel";
            this.numOfStudentsLabel.Size = new System.Drawing.Size(119, 15);
            this.numOfStudentsLabel.TabIndex = 20;
            this.numOfStudentsLabel.Text = "Number of Students:";
            // 
            // courseCodeTextBox
            // 
            this.courseCodeTextBox.Location = new System.Drawing.Point(231, 56);
            this.courseCodeTextBox.Name = "courseCodeTextBox";
            this.courseCodeTextBox.Size = new System.Drawing.Size(151, 20);
            this.courseCodeTextBox.TabIndex = 16;
            // 
            // courseCodeLabel
            // 
            this.courseCodeLabel.AutoSize = true;
            this.courseCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseCodeLabel.Location = new System.Drawing.Point(42, 61);
            this.courseCodeLabel.Name = "courseCodeLabel";
            this.courseCodeLabel.Size = new System.Drawing.Size(81, 15);
            this.courseCodeLabel.TabIndex = 17;
            this.courseCodeLabel.Text = "Course Code:";
            // 
            // courseOkButton
            // 
            this.courseOkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.courseOkButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.courseOkButton.Location = new System.Drawing.Point(278, 271);
            this.courseOkButton.Name = "courseOkButton";
            this.courseOkButton.Size = new System.Drawing.Size(75, 23);
            this.courseOkButton.TabIndex = 10;
            this.courseOkButton.Text = "&Ok";
            this.courseOkButton.UseVisualStyleBackColor = true;
            // 
            // courseCanButton
            // 
            this.courseCanButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.courseCanButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.courseCanButton.Location = new System.Drawing.Point(359, 271);
            this.courseCanButton.Name = "courseCanButton";
            this.courseCanButton.Size = new System.Drawing.Size(75, 23);
            this.courseCanButton.TabIndex = 11;
            this.courseCanButton.Text = "&Cancel";
            this.courseCanButton.UseVisualStyleBackColor = true;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // AddEditCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.courseCanButton;
            this.ClientSize = new System.Drawing.Size(446, 302);
            this.Controls.Add(this.courseOkButton);
            this.Controls.Add(this.courseCanButton);
            this.Controls.Add(this.addEditCourseGroupBox);
            this.DockAreas = ((DigitalRune.Windows.Docking.DockAreas)((((((DigitalRune.Windows.Docking.DockAreas.Float | DigitalRune.Windows.Docking.DockAreas.Left) 
            | DigitalRune.Windows.Docking.DockAreas.Right) 
            | DigitalRune.Windows.Docking.DockAreas.Top) 
            | DigitalRune.Windows.Docking.DockAreas.Bottom) 
            | DigitalRune.Windows.Docking.DockAreas.Document)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(462, 340);
            this.MinimumSize = new System.Drawing.Size(462, 340);
            this.Name = "AddEditCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddEditCourseForm_Load);
            this.addEditCourseGroupBox.ResumeLayout(false);
            this.addEditCourseGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttpDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addEditCourseGroupBox;
        private System.Windows.Forms.Button courseOkButton;
        private System.Windows.Forms.Button courseCanButton;
        private System.Windows.Forms.TextBox courseNameTextBox;
        private System.Windows.Forms.Label courseNameLabel;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.TextBox numOfStudentsTextBox;
        private System.Windows.Forms.Label numOfStudentsLabel;
        private System.Windows.Forms.TextBox courseCodeTextBox;
        private System.Windows.Forms.Label courseCodeLabel;
        private System.Windows.Forms.ComboBox addEditCourseComboBox;
        private ttpDataSet ttpDataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private ttpDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
    }
}