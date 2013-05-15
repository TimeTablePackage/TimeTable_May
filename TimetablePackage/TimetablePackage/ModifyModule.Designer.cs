namespace TimetablePackage
{
    partial class ModifyModule
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
            this.modifyModuleGroupBox = new System.Windows.Forms.GroupBox();
            this.allowDoubleComboBox = new System.Windows.Forms.ComboBox();
            this.requiredRoomTypeComboBox = new System.Windows.Forms.ComboBox();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ttpDataSet = new TimetablePackage.ttpDataSet();
            this.isPracticalComboBox = new System.Windows.Forms.ComboBox();
            this.courseNameComboBox = new System.Windows.Forms.ComboBox();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isPracticalModuleLabel = new System.Windows.Forms.Label();
            this.moduleCourseNameLabel = new System.Windows.Forms.Label();
            this.allowDoubleLabel = new System.Windows.Forms.Label();
            this.moduleMaxConTextBox = new System.Windows.Forms.TextBox();
            this.moduleMaxConLabel = new System.Windows.Forms.Label();
            this.reqRoomTypeLabel = new System.Windows.Forms.Label();
            this.moduleHoursTextBox = new System.Windows.Forms.TextBox();
            this.moduleHoursPerWeek = new System.Windows.Forms.Label();
            this.moduleNameTextBox = new System.Windows.Forms.TextBox();
            this.ModuleNameLabel = new System.Windows.Forms.Label();
            this.moduleCancelButton = new System.Windows.Forms.Button();
            this.moduleOkayButton = new System.Windows.Forms.Button();
            this.courseTableAdapter = new TimetablePackage.ttpDataSetTableAdapters.CourseTableAdapter();
            this.roomTableAdapter = new TimetablePackage.ttpDataSetTableAdapters.RoomTableAdapter();
            this.moduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moduleTableAdapter = new TimetablePackage.ttpDataSetTableAdapters.ModuleTableAdapter();
            this.modifyModuleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // modifyModuleGroupBox
            // 
            this.modifyModuleGroupBox.Controls.Add(this.allowDoubleComboBox);
            this.modifyModuleGroupBox.Controls.Add(this.requiredRoomTypeComboBox);
            this.modifyModuleGroupBox.Controls.Add(this.isPracticalComboBox);
            this.modifyModuleGroupBox.Controls.Add(this.courseNameComboBox);
            this.modifyModuleGroupBox.Controls.Add(this.isPracticalModuleLabel);
            this.modifyModuleGroupBox.Controls.Add(this.moduleCourseNameLabel);
            this.modifyModuleGroupBox.Controls.Add(this.allowDoubleLabel);
            this.modifyModuleGroupBox.Controls.Add(this.moduleMaxConTextBox);
            this.modifyModuleGroupBox.Controls.Add(this.moduleMaxConLabel);
            this.modifyModuleGroupBox.Controls.Add(this.reqRoomTypeLabel);
            this.modifyModuleGroupBox.Controls.Add(this.moduleHoursTextBox);
            this.modifyModuleGroupBox.Controls.Add(this.moduleHoursPerWeek);
            this.modifyModuleGroupBox.Controls.Add(this.moduleNameTextBox);
            this.modifyModuleGroupBox.Controls.Add(this.ModuleNameLabel);
            this.modifyModuleGroupBox.Location = new System.Drawing.Point(12, 25);
            this.modifyModuleGroupBox.Name = "modifyModuleGroupBox";
            this.modifyModuleGroupBox.Size = new System.Drawing.Size(509, 315);
            this.modifyModuleGroupBox.TabIndex = 0;
            this.modifyModuleGroupBox.TabStop = false;
            this.modifyModuleGroupBox.Text = "Add Module";
            // 
            // allowDoubleComboBox
            // 
            this.allowDoubleComboBox.DisplayMember = "Dept_Name";
            this.allowDoubleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.allowDoubleComboBox.FormattingEnabled = true;
            this.allowDoubleComboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.allowDoubleComboBox.Location = new System.Drawing.Point(274, 214);
            this.allowDoubleComboBox.Name = "allowDoubleComboBox";
            this.allowDoubleComboBox.Size = new System.Drawing.Size(152, 21);
            this.allowDoubleComboBox.TabIndex = 33;
            this.allowDoubleComboBox.ValueMember = "ID";
            // 
            // requiredRoomTypeComboBox
            // 
            this.requiredRoomTypeComboBox.DataSource = this.roomBindingSource;
            this.requiredRoomTypeComboBox.DisplayMember = "RoomType";
            this.requiredRoomTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.requiredRoomTypeComboBox.FormattingEnabled = true;
            this.requiredRoomTypeComboBox.Location = new System.Drawing.Point(274, 145);
            this.requiredRoomTypeComboBox.Name = "requiredRoomTypeComboBox";
            this.requiredRoomTypeComboBox.Size = new System.Drawing.Size(152, 21);
            this.requiredRoomTypeComboBox.TabIndex = 32;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.ttpDataSet;
            // 
            // ttpDataSet
            // 
            this.ttpDataSet.DataSetName = "ttpDataSet";
            this.ttpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // isPracticalComboBox
            // 
            this.isPracticalComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.moduleBindingSource, "Practical", true));
            this.isPracticalComboBox.DataSource = this.moduleBindingSource;
            this.isPracticalComboBox.DisplayMember = "Practical";
            this.isPracticalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.isPracticalComboBox.FormattingEnabled = true;
            this.isPracticalComboBox.Location = new System.Drawing.Point(272, 76);
            this.isPracticalComboBox.Name = "isPracticalComboBox";
            this.isPracticalComboBox.Size = new System.Drawing.Size(152, 21);
            this.isPracticalComboBox.TabIndex = 31;
            this.isPracticalComboBox.ValueMember = "Practical";
            // 
            // courseNameComboBox
            // 
            this.courseNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.courseBindingSource, "Id", true));
            this.courseNameComboBox.DataSource = this.courseBindingSource;
            this.courseNameComboBox.DisplayMember = "CourseName";
            this.courseNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseNameComboBox.FormattingEnabled = true;
            this.courseNameComboBox.Location = new System.Drawing.Point(273, 249);
            this.courseNameComboBox.Name = "courseNameComboBox";
            this.courseNameComboBox.Size = new System.Drawing.Size(152, 21);
            this.courseNameComboBox.TabIndex = 26;
            this.courseNameComboBox.ValueMember = "ID";
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.ttpDataSet;
            // 
            // isPracticalModuleLabel
            // 
            this.isPracticalModuleLabel.AutoSize = true;
            this.isPracticalModuleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isPracticalModuleLabel.Location = new System.Drawing.Point(85, 82);
            this.isPracticalModuleLabel.Name = "isPracticalModuleLabel";
            this.isPracticalModuleLabel.Size = new System.Drawing.Size(102, 15);
            this.isPracticalModuleLabel.TabIndex = 30;
            this.isPracticalModuleLabel.Text = "Practical Module:";
            // 
            // moduleCourseNameLabel
            // 
            this.moduleCourseNameLabel.AutoSize = true;
            this.moduleCourseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moduleCourseNameLabel.Location = new System.Drawing.Point(83, 257);
            this.moduleCourseNameLabel.Name = "moduleCourseNameLabel";
            this.moduleCourseNameLabel.Size = new System.Drawing.Size(86, 15);
            this.moduleCourseNameLabel.TabIndex = 29;
            this.moduleCourseNameLabel.Text = "Course Name:";
            // 
            // allowDoubleLabel
            // 
            this.allowDoubleLabel.AutoSize = true;
            this.allowDoubleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allowDoubleLabel.Location = new System.Drawing.Point(83, 222);
            this.allowDoubleLabel.Name = "allowDoubleLabel";
            this.allowDoubleLabel.Size = new System.Drawing.Size(112, 15);
            this.allowDoubleLabel.TabIndex = 27;
            this.allowDoubleLabel.Text = "Allow Double Slots:";
            // 
            // moduleMaxConTextBox
            // 
            this.moduleMaxConTextBox.Location = new System.Drawing.Point(273, 180);
            this.moduleMaxConTextBox.MaxLength = 2;
            this.moduleMaxConTextBox.Name = "moduleMaxConTextBox";
            this.moduleMaxConTextBox.Size = new System.Drawing.Size(151, 20);
            this.moduleMaxConTextBox.TabIndex = 23;
            this.moduleMaxConTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.moduleMaxConTextBox_KeyPress);
            this.moduleMaxConTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.moduleMaxConTextBox_Validating);
            // 
            // moduleMaxConLabel
            // 
            this.moduleMaxConLabel.AutoSize = true;
            this.moduleMaxConLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moduleMaxConLabel.Location = new System.Drawing.Point(83, 187);
            this.moduleMaxConLabel.Name = "moduleMaxConLabel";
            this.moduleMaxConLabel.Size = new System.Drawing.Size(142, 15);
            this.moduleMaxConLabel.TabIndex = 25;
            this.moduleMaxConLabel.Text = "Max. Consecutive Hours:";
            // 
            // reqRoomTypeLabel
            // 
            this.reqRoomTypeLabel.AutoSize = true;
            this.reqRoomTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqRoomTypeLabel.Location = new System.Drawing.Point(83, 152);
            this.reqRoomTypeLabel.Name = "reqRoomTypeLabel";
            this.reqRoomTypeLabel.Size = new System.Drawing.Size(127, 15);
            this.reqRoomTypeLabel.TabIndex = 22;
            this.reqRoomTypeLabel.Text = "Required Room Type:";
            // 
            // moduleHoursTextBox
            // 
            this.moduleHoursTextBox.Location = new System.Drawing.Point(274, 111);
            this.moduleHoursTextBox.MaxLength = 2;
            this.moduleHoursTextBox.Name = "moduleHoursTextBox";
            this.moduleHoursTextBox.Size = new System.Drawing.Size(151, 20);
            this.moduleHoursTextBox.TabIndex = 19;
            this.moduleHoursTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.moduleHoursTextBox_KeyPress);
            this.moduleHoursTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.moduleHoursTextBox_Validating);
            // 
            // moduleHoursPerWeek
            // 
            this.moduleHoursPerWeek.AutoSize = true;
            this.moduleHoursPerWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moduleHoursPerWeek.Location = new System.Drawing.Point(83, 117);
            this.moduleHoursPerWeek.Name = "moduleHoursPerWeek";
            this.moduleHoursPerWeek.Size = new System.Drawing.Size(99, 15);
            this.moduleHoursPerWeek.TabIndex = 20;
            this.moduleHoursPerWeek.Text = "Hours Per Week:";
            // 
            // moduleNameTextBox
            // 
            this.moduleNameTextBox.Location = new System.Drawing.Point(274, 42);
            this.moduleNameTextBox.Name = "moduleNameTextBox";
            this.moduleNameTextBox.Size = new System.Drawing.Size(151, 20);
            this.moduleNameTextBox.TabIndex = 16;
            this.moduleNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.moduleNameTextBox_KeyPress);
            this.moduleNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.moduleNameTextBox_Validating);
            // 
            // ModuleNameLabel
            // 
            this.ModuleNameLabel.AutoSize = true;
            this.ModuleNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModuleNameLabel.Location = new System.Drawing.Point(85, 47);
            this.ModuleNameLabel.Name = "ModuleNameLabel";
            this.ModuleNameLabel.Size = new System.Drawing.Size(89, 15);
            this.ModuleNameLabel.TabIndex = 17;
            this.ModuleNameLabel.Text = "Module Name:";
            // 
            // moduleCancelButton
            // 
            this.moduleCancelButton.Location = new System.Drawing.Point(446, 346);
            this.moduleCancelButton.Name = "moduleCancelButton";
            this.moduleCancelButton.Size = new System.Drawing.Size(75, 23);
            this.moduleCancelButton.TabIndex = 0;
            this.moduleCancelButton.Text = "Cancel";
            this.moduleCancelButton.UseVisualStyleBackColor = true;
            // 
            // moduleOkayButton
            // 
            this.moduleOkayButton.Location = new System.Drawing.Point(365, 346);
            this.moduleOkayButton.Name = "moduleOkayButton";
            this.moduleOkayButton.Size = new System.Drawing.Size(75, 23);
            this.moduleOkayButton.TabIndex = 1;
            this.moduleOkayButton.Text = "Okay";
            this.moduleOkayButton.UseVisualStyleBackColor = true;
            this.moduleOkayButton.Click += new System.EventHandler(this.moduleOkayButton_Click);
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // moduleBindingSource
            // 
            this.moduleBindingSource.DataMember = "Module";
            this.moduleBindingSource.DataSource = this.ttpDataSet;
            // 
            // moduleTableAdapter
            // 
            this.moduleTableAdapter.ClearBeforeFill = true;
            // 
            // ModifyModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 381);
            this.Controls.Add(this.moduleOkayButton);
            this.Controls.Add(this.moduleCancelButton);
            this.Controls.Add(this.modifyModuleGroupBox);
            this.DockAreas = ((DigitalRune.Windows.Docking.DockAreas)((((((DigitalRune.Windows.Docking.DockAreas.Float | DigitalRune.Windows.Docking.DockAreas.Left) 
            | DigitalRune.Windows.Docking.DockAreas.Right) 
            | DigitalRune.Windows.Docking.DockAreas.Top) 
            | DigitalRune.Windows.Docking.DockAreas.Bottom) 
            | DigitalRune.Windows.Docking.DockAreas.Document)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(549, 419);
            this.MinimumSize = new System.Drawing.Size(549, 419);
            this.Name = "ModifyModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabText = "Add Module";
            this.Text = "Add Module";
            this.Load += new System.EventHandler(this.ModifyModule_Load);
            this.modifyModuleGroupBox.ResumeLayout(false);
            this.modifyModuleGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox modifyModuleGroupBox;
        private System.Windows.Forms.Button moduleCancelButton;
        private System.Windows.Forms.Button moduleOkayButton;
        private System.Windows.Forms.ComboBox allowDoubleComboBox;
        private System.Windows.Forms.ComboBox requiredRoomTypeComboBox;
        private System.Windows.Forms.ComboBox isPracticalComboBox;
        private System.Windows.Forms.ComboBox courseNameComboBox;
        private System.Windows.Forms.Label isPracticalModuleLabel;
        private System.Windows.Forms.Label moduleCourseNameLabel;
        private System.Windows.Forms.Label allowDoubleLabel;
        private System.Windows.Forms.TextBox moduleMaxConTextBox;
        private System.Windows.Forms.Label moduleMaxConLabel;
        private System.Windows.Forms.Label reqRoomTypeLabel;
        private System.Windows.Forms.TextBox moduleHoursTextBox;
        private System.Windows.Forms.Label moduleHoursPerWeek;
        private System.Windows.Forms.TextBox moduleNameTextBox;
        private System.Windows.Forms.Label ModuleNameLabel;
        private ttpDataSet ttpDataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private ttpDataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private ttpDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.BindingSource moduleBindingSource;
        private ttpDataSetTableAdapters.ModuleTableAdapter moduleTableAdapter;
    }
}