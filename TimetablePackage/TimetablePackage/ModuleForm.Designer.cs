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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.deleteModuleButton = new System.Windows.Forms.Button();
            this.editModuleButton = new System.Windows.Forms.Button();
            this.addModuleButton = new System.Windows.Forms.Button();
            this.ModuleGroupBox = new System.Windows.Forms.GroupBox();
            this.ModulesDataGridView = new System.Windows.Forms.DataGridView();
            this.ModuleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModulesDataGridView)).BeginInit();
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
            this.editModuleButton.Click += new System.EventHandler(this.editModuleButton_Click);
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
            this.addModuleButton.Click += new System.EventHandler(this.addModuleButton_Click);
            // 
            // ModuleGroupBox
            // 
            this.ModuleGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModuleGroupBox.Controls.Add(this.ModulesDataGridView);
            this.ModuleGroupBox.Location = new System.Drawing.Point(21, 73);
            this.ModuleGroupBox.Name = "ModuleGroupBox";
            this.ModuleGroupBox.Size = new System.Drawing.Size(951, 284);
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
            this.ModulesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ModulesDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ModulesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ModulesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ModulesDataGridView.ColumnHeadersHeight = 21;
            this.ModulesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
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
            this.ModulesDataGridView.Size = new System.Drawing.Size(860, 265);
            this.ModulesDataGridView.TabIndex = 0;
            this.ModulesDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ModulesDataGridView_CellEnter);
            // 
            // ModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 389);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deleteModuleButton;
        private System.Windows.Forms.Button editModuleButton;
        private System.Windows.Forms.Button addModuleButton;
        private System.Windows.Forms.GroupBox ModuleGroupBox;
        private System.Windows.Forms.DataGridView ModulesDataGridView;
    }
}