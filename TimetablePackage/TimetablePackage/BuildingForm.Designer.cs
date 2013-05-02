namespace TimetablePackage
{
    partial class BuildingForm
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
            this.buildingGroupBox = new System.Windows.Forms.GroupBox();
            this.buildingDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ttpDataSet = new TimetablePackage.ttpDataSet();
            this.roomGroupBox = new System.Windows.Forms.GroupBox();
            this.roomdataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slotsOffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomTableAdapter = new TimetablePackage.ttpDataSetTableAdapters.RoomTableAdapter();
            this.buildingTableAdapter = new TimetablePackage.ttpDataSetTableAdapters.BuildingTableAdapter();
            this.buildingGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buildingDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttpDataSet)).BeginInit();
            this.roomGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buildingGroupBox
            // 
            this.buildingGroupBox.Controls.Add(this.buildingDataGridView);
            this.buildingGroupBox.Location = new System.Drawing.Point(74, 37);
            this.buildingGroupBox.Name = "buildingGroupBox";
            this.buildingGroupBox.Size = new System.Drawing.Size(210, 299);
            this.buildingGroupBox.TabIndex = 0;
            this.buildingGroupBox.TabStop = false;
            this.buildingGroupBox.Text = "Buildings";
            // 
            // buildingDataGridView
            // 
            this.buildingDataGridView.AllowUserToAddRows = false;
            this.buildingDataGridView.AllowUserToDeleteRows = false;
            this.buildingDataGridView.AllowUserToOrderColumns = true;
            this.buildingDataGridView.AllowUserToResizeColumns = false;
            this.buildingDataGridView.AllowUserToResizeRows = false;
            this.buildingDataGridView.AutoGenerateColumns = false;
            this.buildingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buildingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.buildingNameDataGridViewTextBoxColumn});
            this.buildingDataGridView.DataSource = this.buildingBindingSource;
            this.buildingDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buildingDataGridView.Location = new System.Drawing.Point(3, 16);
            this.buildingDataGridView.MultiSelect = false;
            this.buildingDataGridView.Name = "buildingDataGridView";
            this.buildingDataGridView.ReadOnly = true;
            this.buildingDataGridView.RowHeadersVisible = false;
            this.buildingDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.buildingDataGridView.Size = new System.Drawing.Size(204, 280);
            this.buildingDataGridView.TabIndex = 0;
            this.buildingDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.buildingDataGridView_CellEnter);
         //   this.buildingDataGridView.SelectionChanged += new System.EventHandler(this.buildingDataGridView_SelectionChanged);
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // buildingNameDataGridViewTextBoxColumn
            // 
            this.buildingNameDataGridViewTextBoxColumn.DataPropertyName = "Building_Name";
            this.buildingNameDataGridViewTextBoxColumn.HeaderText = "Building Name";
            this.buildingNameDataGridViewTextBoxColumn.Name = "buildingNameDataGridViewTextBoxColumn";
            this.buildingNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buildingBindingSource
            // 
            this.buildingBindingSource.DataMember = "Building";
            this.buildingBindingSource.DataSource = this.ttpDataSet;
            // 
            // ttpDataSet
            // 
            this.ttpDataSet.DataSetName = "ttpDataSet";
            this.ttpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomGroupBox
            // 
            this.roomGroupBox.Controls.Add(this.roomdataGridView);
            this.roomGroupBox.Location = new System.Drawing.Point(314, 37);
            this.roomGroupBox.Name = "roomGroupBox";
            this.roomGroupBox.Size = new System.Drawing.Size(611, 299);
            this.roomGroupBox.TabIndex = 1;
            this.roomGroupBox.TabStop = false;
            this.roomGroupBox.Text = "Rooms";
            // 
            // roomdataGridView
            // 
            this.roomdataGridView.AllowUserToAddRows = false;
            this.roomdataGridView.AllowUserToDeleteRows = false;
            this.roomdataGridView.AllowUserToOrderColumns = true;
            this.roomdataGridView.AllowUserToResizeColumns = false;
            this.roomdataGridView.AllowUserToResizeRows = false;
            this.roomdataGridView.AutoGenerateColumns = false;
            this.roomdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.buildingIDDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.roomTypeDataGridViewTextBoxColumn,
            this.slotsOffDataGridViewTextBoxColumn});
            this.roomdataGridView.DataSource = this.roomBindingSource;
            this.roomdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomdataGridView.Location = new System.Drawing.Point(3, 16);
            this.roomdataGridView.MultiSelect = false;
            this.roomdataGridView.Name = "roomdataGridView";
            this.roomdataGridView.ReadOnly = true;
            this.roomdataGridView.RowHeadersVisible = false;
            this.roomdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.roomdataGridView.Size = new System.Drawing.Size(605, 280);
            this.roomdataGridView.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buildingIDDataGridViewTextBoxColumn
            // 
            this.buildingIDDataGridViewTextBoxColumn.DataPropertyName = "BuildingID";
            this.buildingIDDataGridViewTextBoxColumn.HeaderText = "Building ID";
            this.buildingIDDataGridViewTextBoxColumn.Name = "buildingIDDataGridViewTextBoxColumn";
            this.buildingIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "Capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "Capacity";
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            this.capacityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomTypeDataGridViewTextBoxColumn
            // 
            this.roomTypeDataGridViewTextBoxColumn.DataPropertyName = "RoomType";
            this.roomTypeDataGridViewTextBoxColumn.HeaderText = "Room Type";
            this.roomTypeDataGridViewTextBoxColumn.Name = "roomTypeDataGridViewTextBoxColumn";
            this.roomTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // slotsOffDataGridViewTextBoxColumn
            // 
            this.slotsOffDataGridViewTextBoxColumn.DataPropertyName = "SlotsOff";
            this.slotsOffDataGridViewTextBoxColumn.HeaderText = "Time Off";
            this.slotsOffDataGridViewTextBoxColumn.Name = "slotsOffDataGridViewTextBoxColumn";
            this.slotsOffDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.ttpDataSet;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // buildingTableAdapter
            // 
            this.buildingTableAdapter.ClearBeforeFill = true;
            // 
            // BuildingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 372);
            this.Controls.Add(this.roomGroupBox);
            this.Controls.Add(this.buildingGroupBox);
            this.DockAreas = ((DigitalRune.Windows.Docking.DockAreas)((((((DigitalRune.Windows.Docking.DockAreas.Float | DigitalRune.Windows.Docking.DockAreas.Left) 
            | DigitalRune.Windows.Docking.DockAreas.Right) 
            | DigitalRune.Windows.Docking.DockAreas.Top) 
            | DigitalRune.Windows.Docking.DockAreas.Bottom) 
            | DigitalRune.Windows.Docking.DockAreas.Document)));
            this.Name = "BuildingForm";
            this.TabText = "BuildingForm";
            this.Text = "BuildingForm";
            this.Load += new System.EventHandler(this.BuildingForm_Load);
            this.buildingGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buildingDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttpDataSet)).EndInit();
            this.roomGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox buildingGroupBox;
        private System.Windows.Forms.DataGridView buildingDataGridView;
        private System.Windows.Forms.GroupBox roomGroupBox;
        private System.Windows.Forms.DataGridView roomdataGridView;
        private ttpDataSet ttpDataSet;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private ttpDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.BindingSource buildingBindingSource;
        private ttpDataSetTableAdapters.BuildingTableAdapter buildingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slotsOffDataGridViewTextBoxColumn;
    }
}