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
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addBuildingButton = new System.Windows.Forms.Button();
            this.editBuildingButton = new System.Windows.Forms.Button();
            this.removeBuildingButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.buildingGroupBox.Location = new System.Drawing.Point(71, 37);
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
            this.buildingDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
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
            this.roomGroupBox.Location = new System.Drawing.Point(311, 37);
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
            this.roomdataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
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
            // addBuildingButton
            // 
            this.addBuildingButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBuildingButton.Image = global::TimetablePackage.Properties.Resources.add;
            this.addBuildingButton.Location = new System.Drawing.Point(5, 53);
            this.addBuildingButton.Name = "addBuildingButton";
            this.addBuildingButton.Size = new System.Drawing.Size(60, 46);
            this.addBuildingButton.TabIndex = 2;
            this.addBuildingButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addBuildingButton.UseVisualStyleBackColor = true;
            this.addBuildingButton.Click += new System.EventHandler(this.addBuildingButton_Click);
            // 
            // editBuildingButton
            // 
            this.editBuildingButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBuildingButton.Image = global::TimetablePackage.Properties.Resources.bullet_edit;
            this.editBuildingButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.editBuildingButton.Location = new System.Drawing.Point(5, 105);
            this.editBuildingButton.Name = "editBuildingButton";
            this.editBuildingButton.Size = new System.Drawing.Size(60, 46);
            this.editBuildingButton.TabIndex = 3;
            this.editBuildingButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editBuildingButton.UseVisualStyleBackColor = true;
            this.editBuildingButton.Click += new System.EventHandler(this.editBuildingButton_Click);
            // 
            // removeBuildingButton
            // 
            this.removeBuildingButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBuildingButton.Image = global::TimetablePackage.Properties.Resources.delete;
            this.removeBuildingButton.Location = new System.Drawing.Point(5, 157);
            this.removeBuildingButton.Name = "removeBuildingButton";
            this.removeBuildingButton.Size = new System.Drawing.Size(60, 46);
            this.removeBuildingButton.TabIndex = 4;
            this.removeBuildingButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.removeBuildingButton.UseVisualStyleBackColor = true;
            this.removeBuildingButton.Click += new System.EventHandler(this.removeBuildingButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::TimetablePackage.Properties.Resources.delete;
            this.button1.Location = new System.Drawing.Point(928, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 46);
            this.button1.TabIndex = 7;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::TimetablePackage.Properties.Resources.bullet_edit;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(928, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 46);
            this.button2.TabIndex = 6;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::TimetablePackage.Properties.Resources.add;
            this.button3.Location = new System.Drawing.Point(928, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 46);
            this.button3.TabIndex = 5;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BuildingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 372);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.removeBuildingButton);
            this.Controls.Add(this.editBuildingButton);
            this.Controls.Add(this.addBuildingButton);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slotsOffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button addBuildingButton;
        private System.Windows.Forms.Button editBuildingButton;
        private System.Windows.Forms.Button removeBuildingButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}