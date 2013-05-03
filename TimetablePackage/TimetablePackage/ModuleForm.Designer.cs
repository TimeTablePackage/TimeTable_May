namespace TimetablePackage
{
    partial class ModuleForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.deleteModuleButton = new System.Windows.Forms.Button();
            this.editModuleButton = new System.Windows.Forms.Button();
            this.addModuleButton = new System.Windows.Forms.Button();
            this.ModuleGroupBox = new System.Windows.Forms.GroupBox();
            this.ModulesDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moduleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.practicalDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hoursPerWeekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxConsecSlotsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doubleSlotsDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.courseCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ttpDataSet = new TimetablePackage.ttpDataSet();
            this.moduleTableAdapter = new TimetablePackage.ttpDataSetTableAdapters.ModuleTableAdapter();
            this.ModuleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModulesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttpDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteModuleButton
            // 
            this.deleteModuleButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deleteModuleButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteModuleButton.Image = global::TimetablePackage.Properties.Resources.delete;
            this.deleteModuleButton.Location = new System.Drawing.Point(499, 32);
            this.deleteModuleButton.Name = "deleteModuleButton";
            this.deleteModuleButton.Size = new System.Drawing.Size(103, 43);
            this.deleteModuleButton.TabIndex = 7;
            this.deleteModuleButton.Text = "Remove";
            this.deleteModuleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteModuleButton.UseVisualStyleBackColor = true;
            // 
            // editModuleButton
            // 
            this.editModuleButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.editModuleButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editModuleButton.Image = global::TimetablePackage.Properties.Resources.bullet_edit;
            this.editModuleButton.Location = new System.Drawing.Point(390, 32);
            this.editModuleButton.Name = "editModuleButton";
            this.editModuleButton.Size = new System.Drawing.Size(103, 43);
            this.editModuleButton.TabIndex = 6;
            this.editModuleButton.Text = "Edit";
            this.editModuleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editModuleButton.UseVisualStyleBackColor = true;
            // 
            // addModuleButton
            // 
            this.addModuleButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addModuleButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addModuleButton.Image = global::TimetablePackage.Properties.Resources.add;
            this.addModuleButton.Location = new System.Drawing.Point(281, 32);
            this.addModuleButton.Name = "addModuleButton";
            this.addModuleButton.Size = new System.Drawing.Size(103, 43);
            this.addModuleButton.TabIndex = 5;
            this.addModuleButton.Text = "Add";
            this.addModuleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addModuleButton.UseVisualStyleBackColor = true;
            // 
            // ModuleGroupBox
            // 
            this.ModuleGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModuleGroupBox.Controls.Add(this.ModulesDataGridView);
            this.ModuleGroupBox.Location = new System.Drawing.Point(21, 73);
            this.ModuleGroupBox.Name = "ModuleGroupBox";
            this.ModuleGroupBox.Size = new System.Drawing.Size(951, 267);
            this.ModuleGroupBox.TabIndex = 4;
            this.ModuleGroupBox.TabStop = false;
            this.ModuleGroupBox.Text = "Modules";
            // 
            // ModulesDataGridView
            // 
            this.ModulesDataGridView.AllowUserToAddRows = false;
            this.ModulesDataGridView.AllowUserToDeleteRows = false;
            this.ModulesDataGridView.AllowUserToResizeColumns = false;
            this.ModulesDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ModulesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ModulesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModulesDataGridView.AutoGenerateColumns = false;
            this.ModulesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ModulesDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ModulesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ModulesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ModulesDataGridView.ColumnHeadersHeight = 21;
            this.ModulesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ModulesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.moduleNameDataGridViewTextBoxColumn,
            this.practicalDataGridViewCheckBoxColumn,
            this.hoursPerWeekDataGridViewTextBoxColumn,
            this.roomTypeDataGridViewTextBoxColumn,
            this.maxConsecSlotsDataGridViewTextBoxColumn,
            this.doubleSlotsDataGridViewCheckBoxColumn,
            this.courseCodeDataGridViewTextBoxColumn});
            this.ModulesDataGridView.DataSource = this.moduleBindingSource;
            this.ModulesDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.ModulesDataGridView.Location = new System.Drawing.Point(44, 16);
            this.ModulesDataGridView.MultiSelect = false;
            this.ModulesDataGridView.Name = "ModulesDataGridView";
            this.ModulesDataGridView.ReadOnly = true;
            this.ModulesDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ModulesDataGridView.RowHeadersVisible = false;
            this.ModulesDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ModulesDataGridView.RowTemplate.ReadOnly = true;
            this.ModulesDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ModulesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ModulesDataGridView.Size = new System.Drawing.Size(860, 248);
            this.ModulesDataGridView.TabIndex = 0;
            this.ModulesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ModulesDataGridView_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 43;
            // 
            // moduleNameDataGridViewTextBoxColumn
            // 
            this.moduleNameDataGridViewTextBoxColumn.DataPropertyName = "Module_Name";
            this.moduleNameDataGridViewTextBoxColumn.HeaderText = "Module Name";
            this.moduleNameDataGridViewTextBoxColumn.Name = "moduleNameDataGridViewTextBoxColumn";
            this.moduleNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.moduleNameDataGridViewTextBoxColumn.Width = 98;
            // 
            // practicalDataGridViewCheckBoxColumn
            // 
            this.practicalDataGridViewCheckBoxColumn.DataPropertyName = "Practical";
            this.practicalDataGridViewCheckBoxColumn.HeaderText = "Practical";
            this.practicalDataGridViewCheckBoxColumn.Name = "practicalDataGridViewCheckBoxColumn";
            this.practicalDataGridViewCheckBoxColumn.ReadOnly = true;
            this.practicalDataGridViewCheckBoxColumn.Width = 54;
            // 
            // hoursPerWeekDataGridViewTextBoxColumn
            // 
            this.hoursPerWeekDataGridViewTextBoxColumn.DataPropertyName = "HoursPerWeek";
            this.hoursPerWeekDataGridViewTextBoxColumn.HeaderText = "Number of Weekly Hours";
            this.hoursPerWeekDataGridViewTextBoxColumn.Name = "hoursPerWeekDataGridViewTextBoxColumn";
            this.hoursPerWeekDataGridViewTextBoxColumn.ReadOnly = true;
            this.hoursPerWeekDataGridViewTextBoxColumn.Width = 151;
            // 
            // roomTypeDataGridViewTextBoxColumn
            // 
            this.roomTypeDataGridViewTextBoxColumn.DataPropertyName = "RoomType";
            this.roomTypeDataGridViewTextBoxColumn.HeaderText = "Required Room Type";
            this.roomTypeDataGridViewTextBoxColumn.Name = "roomTypeDataGridViewTextBoxColumn";
            this.roomTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomTypeDataGridViewTextBoxColumn.Width = 133;
            // 
            // maxConsecSlotsDataGridViewTextBoxColumn
            // 
            this.maxConsecSlotsDataGridViewTextBoxColumn.DataPropertyName = "MaxConsecSlots";
            this.maxConsecSlotsDataGridViewTextBoxColumn.HeaderText = "Maximum Consecutive Hours";
            this.maxConsecSlotsDataGridViewTextBoxColumn.Name = "maxConsecSlotsDataGridViewTextBoxColumn";
            this.maxConsecSlotsDataGridViewTextBoxColumn.ReadOnly = true;
            this.maxConsecSlotsDataGridViewTextBoxColumn.Width = 169;
            // 
            // doubleSlotsDataGridViewCheckBoxColumn
            // 
            this.doubleSlotsDataGridViewCheckBoxColumn.DataPropertyName = "DoubleSlots";
            this.doubleSlotsDataGridViewCheckBoxColumn.HeaderText = "Allow Double Lectures";
            this.doubleSlotsDataGridViewCheckBoxColumn.Name = "doubleSlotsDataGridViewCheckBoxColumn";
            this.doubleSlotsDataGridViewCheckBoxColumn.ReadOnly = true;
            this.doubleSlotsDataGridViewCheckBoxColumn.Width = 119;
            // 
            // courseCodeDataGridViewTextBoxColumn
            // 
            this.courseCodeDataGridViewTextBoxColumn.DataPropertyName = "CourseCode";
            this.courseCodeDataGridViewTextBoxColumn.HeaderText = "Course Code";
            this.courseCodeDataGridViewTextBoxColumn.Name = "courseCodeDataGridViewTextBoxColumn";
            this.courseCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.courseCodeDataGridViewTextBoxColumn.Width = 93;
            // 
            // moduleBindingSource
            // 
            this.moduleBindingSource.DataMember = "Module";
            this.moduleBindingSource.DataSource = this.ttpDataSet;
            // 
            // ttpDataSet
            // 
            this.ttpDataSet.DataSetName = "ttpDataSet";
            this.ttpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moduleTableAdapter
            // 
            this.moduleTableAdapter.ClearBeforeFill = true;
            // 
            // ModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 372);
            this.Controls.Add(this.deleteModuleButton);
            this.Controls.Add(this.editModuleButton);
            this.Controls.Add(this.addModuleButton);
            this.Controls.Add(this.ModuleGroupBox);
            this.DockAreas = ((DigitalRune.Windows.Docking.DockAreas)((((((DigitalRune.Windows.Docking.DockAreas.Float | DigitalRune.Windows.Docking.DockAreas.Left) 
            | DigitalRune.Windows.Docking.DockAreas.Right) 
            | DigitalRune.Windows.Docking.DockAreas.Top) 
            | DigitalRune.Windows.Docking.DockAreas.Bottom) 
            | DigitalRune.Windows.Docking.DockAreas.Document)));
            this.Name = "ModuleForm";
            this.TabText = "Modules";
            this.Text = "Modules";
            this.Load += new System.EventHandler(this.ModuleForm_Load);
            this.ModuleGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ModulesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttpDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deleteModuleButton;
        private System.Windows.Forms.Button editModuleButton;
        private System.Windows.Forms.Button addModuleButton;
        private System.Windows.Forms.GroupBox ModuleGroupBox;
        private System.Windows.Forms.DataGridView ModulesDataGridView;
        private ttpDataSet ttpDataSet;
        private System.Windows.Forms.BindingSource moduleBindingSource;
        private ttpDataSetTableAdapters.ModuleTableAdapter moduleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moduleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn practicalDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursPerWeekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxConsecSlotsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn doubleSlotsDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseCodeDataGridViewTextBoxColumn;
    }
}