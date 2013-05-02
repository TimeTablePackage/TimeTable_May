using Domain; 
namespace TimetablePackage
{
    partial class Lecturer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DomainControler controller = DomainControler.getInstance();

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lecturer));
            this.lecturerGroupBox = new System.Windows.Forms.GroupBox();
            this.lecturerDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initialsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxConsecHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minSlotsPerDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slotsOffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ttpDataSet = new TimetablePackage.ttpDataSet();
            this.lecturerTableAdapter = new TimetablePackage.ttpDataSetTableAdapters.LecturerTableAdapter();
            this.lecturerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.addLecturerButton = new System.Windows.Forms.Button();
            this.editLecturerButton = new System.Windows.Forms.Button();
            this.deleteLecturerButton = new System.Windows.Forms.Button();
            this.lecturerModulesButton = new System.Windows.Forms.Button();
            this.lecturerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lecturerGroupBox
            // 
            this.lecturerGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lecturerGroupBox.Controls.Add(this.lecturerDataGridView);
            this.lecturerGroupBox.Location = new System.Drawing.Point(21, 53);
            this.lecturerGroupBox.Name = "lecturerGroupBox";
            this.lecturerGroupBox.Size = new System.Drawing.Size(951, 267);
            this.lecturerGroupBox.TabIndex = 0;
            this.lecturerGroupBox.TabStop = false;
            this.lecturerGroupBox.Text = "Lecturers";
            // 
            // lecturerDataGridView
            // 
            this.lecturerDataGridView.AllowUserToAddRows = false;
            this.lecturerDataGridView.AllowUserToDeleteRows = false;
            this.lecturerDataGridView.AllowUserToResizeColumns = false;
            this.lecturerDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lecturerDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.lecturerDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lecturerDataGridView.AutoGenerateColumns = false;
            this.lecturerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.lecturerDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.lecturerDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.lecturerDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lecturerDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.lecturerDataGridView.ColumnHeadersHeight = 21;
            this.lecturerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.lecturerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.lecNameDataGridViewTextBoxColumn,
            this.initialsDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.maxHoursDataGridViewTextBoxColumn,
            this.maxConsecHoursDataGridViewTextBoxColumn,
            this.minSlotsPerDayDataGridViewTextBoxColumn,
            this.slotsOffDataGridViewTextBoxColumn,
            this.departmentIdDataGridViewTextBoxColumn});
            this.lecturerDataGridView.DataSource = this.lecturerBindingSource;
            this.lecturerDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.lecturerDataGridView.Location = new System.Drawing.Point(3, 16);
            this.lecturerDataGridView.MultiSelect = false;
            this.lecturerDataGridView.Name = "lecturerDataGridView";
            this.lecturerDataGridView.ReadOnly = true;
            this.lecturerDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.lecturerDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.lecturerDataGridView.RowTemplate.ReadOnly = true;
            this.lecturerDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.lecturerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lecturerDataGridView.Size = new System.Drawing.Size(945, 248);
            this.lecturerDataGridView.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.Frozen = true;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 43;
            // 
            // lecNameDataGridViewTextBoxColumn
            // 
            this.lecNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.lecNameDataGridViewTextBoxColumn.DataPropertyName = "Lec_Name";
            this.lecNameDataGridViewTextBoxColumn.Frozen = true;
            this.lecNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.lecNameDataGridViewTextBoxColumn.Name = "lecNameDataGridViewTextBoxColumn";
            this.lecNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lecNameDataGridViewTextBoxColumn.Width = 60;
            // 
            // initialsDataGridViewTextBoxColumn
            // 
            this.initialsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.initialsDataGridViewTextBoxColumn.DataPropertyName = "Initials";
            this.initialsDataGridViewTextBoxColumn.Frozen = true;
            this.initialsDataGridViewTextBoxColumn.HeaderText = "Initials";
            this.initialsDataGridViewTextBoxColumn.Name = "initialsDataGridViewTextBoxColumn";
            this.initialsDataGridViewTextBoxColumn.ReadOnly = true;
            this.initialsDataGridViewTextBoxColumn.Width = 61;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.Frozen = true;
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 60;
            // 
            // maxHoursDataGridViewTextBoxColumn
            // 
            this.maxHoursDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.maxHoursDataGridViewTextBoxColumn.DataPropertyName = "MaxHours";
            this.maxHoursDataGridViewTextBoxColumn.Frozen = true;
            this.maxHoursDataGridViewTextBoxColumn.HeaderText = "Maximum Number of Lecture Hours";
            this.maxHoursDataGridViewTextBoxColumn.Name = "maxHoursDataGridViewTextBoxColumn";
            this.maxHoursDataGridViewTextBoxColumn.ReadOnly = true;
            this.maxHoursDataGridViewTextBoxColumn.Width = 198;
            // 
            // maxConsecHoursDataGridViewTextBoxColumn
            // 
            this.maxConsecHoursDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.maxConsecHoursDataGridViewTextBoxColumn.DataPropertyName = "MaxConsecHours";
            this.maxConsecHoursDataGridViewTextBoxColumn.Frozen = true;
            this.maxConsecHoursDataGridViewTextBoxColumn.HeaderText = "Maximum Consecutive Hours a Day";
            this.maxConsecHoursDataGridViewTextBoxColumn.Name = "maxConsecHoursDataGridViewTextBoxColumn";
            this.maxConsecHoursDataGridViewTextBoxColumn.ReadOnly = true;
            this.maxConsecHoursDataGridViewTextBoxColumn.Width = 200;
            // 
            // minSlotsPerDayDataGridViewTextBoxColumn
            // 
            this.minSlotsPerDayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.minSlotsPerDayDataGridViewTextBoxColumn.DataPropertyName = "MinSlotsPerDay";
            this.minSlotsPerDayDataGridViewTextBoxColumn.Frozen = true;
            this.minSlotsPerDayDataGridViewTextBoxColumn.HeaderText = "Minimum Hours Per Day";
            this.minSlotsPerDayDataGridViewTextBoxColumn.Name = "minSlotsPerDayDataGridViewTextBoxColumn";
            this.minSlotsPerDayDataGridViewTextBoxColumn.ReadOnly = true;
            this.minSlotsPerDayDataGridViewTextBoxColumn.Width = 145;
            // 
            // slotsOffDataGridViewTextBoxColumn
            // 
            this.slotsOffDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.slotsOffDataGridViewTextBoxColumn.DataPropertyName = "SlotsOff";
            this.slotsOffDataGridViewTextBoxColumn.Frozen = true;
            this.slotsOffDataGridViewTextBoxColumn.HeaderText = "Time Off";
            this.slotsOffDataGridViewTextBoxColumn.Name = "slotsOffDataGridViewTextBoxColumn";
            this.slotsOffDataGridViewTextBoxColumn.ReadOnly = true;
            this.slotsOffDataGridViewTextBoxColumn.Width = 72;
            // 
            // departmentIdDataGridViewTextBoxColumn
            // 
            this.departmentIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.departmentIdDataGridViewTextBoxColumn.DataPropertyName = "DepartmentId";
            this.departmentIdDataGridViewTextBoxColumn.Frozen = true;
            this.departmentIdDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentIdDataGridViewTextBoxColumn.Name = "departmentIdDataGridViewTextBoxColumn";
            this.departmentIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.departmentIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.departmentIdDataGridViewTextBoxColumn.Width = 87;
            // 
            // lecturerBindingSource
            // 
            this.lecturerBindingSource.DataMember = "Lecturer";
            this.lecturerBindingSource.DataSource = this.ttpDataSet;
            // 
            // ttpDataSet
            // 
            this.ttpDataSet.DataSetName = "ttpDataSet";
            this.ttpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lecturerTableAdapter
            // 
            this.lecturerTableAdapter.ClearBeforeFill = true;
            // 
            // lecturerBindingSource1
            // 
            this.lecturerBindingSource1.DataMember = "Lecturer";
            this.lecturerBindingSource1.DataSource = this.ttpDataSet;
            // 
            // addLecturerButton
            // 
            this.addLecturerButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addLecturerButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLecturerButton.Image = global::TimetablePackage.Properties.Resources.add;
            this.addLecturerButton.Location = new System.Drawing.Point(281, 12);
            this.addLecturerButton.Name = "addLecturerButton";
            this.addLecturerButton.Size = new System.Drawing.Size(103, 43);
            this.addLecturerButton.TabIndex = 1;
            this.addLecturerButton.Text = "Add";
            this.addLecturerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addLecturerButton.UseVisualStyleBackColor = true;
            this.addLecturerButton.Click += new System.EventHandler(this.addLecturerButton_Click);
            // 
            // editLecturerButton
            // 
            this.editLecturerButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.editLecturerButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editLecturerButton.Image = global::TimetablePackage.Properties.Resources.bullet_edit;
            this.editLecturerButton.Location = new System.Drawing.Point(390, 12);
            this.editLecturerButton.Name = "editLecturerButton";
            this.editLecturerButton.Size = new System.Drawing.Size(103, 43);
            this.editLecturerButton.TabIndex = 2;
            this.editLecturerButton.Text = "Edit";
            this.editLecturerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editLecturerButton.UseVisualStyleBackColor = true;
            // 
            // deleteLecturerButton
            // 
            this.deleteLecturerButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deleteLecturerButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteLecturerButton.Image = global::TimetablePackage.Properties.Resources.delete;
            this.deleteLecturerButton.Location = new System.Drawing.Point(499, 12);
            this.deleteLecturerButton.Name = "deleteLecturerButton";
            this.deleteLecturerButton.Size = new System.Drawing.Size(103, 43);
            this.deleteLecturerButton.TabIndex = 3;
            this.deleteLecturerButton.Text = "Remove";
            this.deleteLecturerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteLecturerButton.UseVisualStyleBackColor = true;
            // 
            // lecturerModulesButton
            // 
            this.lecturerModulesButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lecturerModulesButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturerModulesButton.Image = global::TimetablePackage.Properties.Resources.books_stack1;
            this.lecturerModulesButton.Location = new System.Drawing.Point(608, 12);
            this.lecturerModulesButton.Name = "lecturerModulesButton";
            this.lecturerModulesButton.Size = new System.Drawing.Size(103, 43);
            this.lecturerModulesButton.TabIndex = 4;
            this.lecturerModulesButton.Text = "Modules";
            this.lecturerModulesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.lecturerModulesButton.UseVisualStyleBackColor = true;
            // 
            // Lecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 372);
            this.Controls.Add(this.lecturerModulesButton);
            this.Controls.Add(this.deleteLecturerButton);
            this.Controls.Add(this.editLecturerButton);
            this.Controls.Add(this.addLecturerButton);
            this.Controls.Add(this.lecturerGroupBox);
            this.DockAreas = ((DigitalRune.Windows.Docking.DockAreas)((((((DigitalRune.Windows.Docking.DockAreas.Float | DigitalRune.Windows.Docking.DockAreas.Left) 
            | DigitalRune.Windows.Docking.DockAreas.Right) 
            | DigitalRune.Windows.Docking.DockAreas.Top) 
            | DigitalRune.Windows.Docking.DockAreas.Bottom) 
            | DigitalRune.Windows.Docking.DockAreas.Document)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lecturer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "Timetable Package";
            this.Text = "Timetable Package";
            this.Load += new System.EventHandler(this.Lecturer_Load);
            this.lecturerGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lecturerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox lecturerGroupBox;
        private ttpDataSet ttpDataSet;
        private System.Windows.Forms.BindingSource lecturerBindingSource;
        private ttpDataSetTableAdapters.LecturerTableAdapter lecturerTableAdapter;
        private System.Windows.Forms.BindingSource lecturerBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn initialsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxConsecHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minSlotsPerDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slotsOffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView lecturerDataGridView;
        private System.Windows.Forms.Button addLecturerButton;
        private System.Windows.Forms.Button editLecturerButton;
        private System.Windows.Forms.Button deleteLecturerButton;
        private System.Windows.Forms.Button lecturerModulesButton;



    }
}