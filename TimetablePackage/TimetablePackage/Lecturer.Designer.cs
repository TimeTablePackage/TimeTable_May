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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lecturer));
            this.lecturerGroupBox = new System.Windows.Forms.GroupBox();
            this.lecturerDataGridView = new System.Windows.Forms.DataGridView();
            this.addLecturerButton = new System.Windows.Forms.Button();
            this.editLecturerButton = new System.Windows.Forms.Button();
            this.deleteLecturerButton = new System.Windows.Forms.Button();
            this.lecturerModulesButton = new System.Windows.Forms.Button();
            this.lecturerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lecturerGroupBox
            // 
            this.lecturerGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lecturerGroupBox.Controls.Add(this.lecturerDataGridView);
            this.lecturerGroupBox.Location = new System.Drawing.Point(19, 53);
            this.lecturerGroupBox.Name = "lecturerGroupBox";
            this.lecturerGroupBox.Size = new System.Drawing.Size(955, 267);
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
            this.lecturerDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.lecturerDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.lecturerDataGridView.ColumnHeadersHeight = 21;
            this.lecturerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.lecturerDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.lecturerDataGridView.Location = new System.Drawing.Point(80, 16);
            this.lecturerDataGridView.MultiSelect = false;
            this.lecturerDataGridView.Name = "lecturerDataGridView";
            this.lecturerDataGridView.ReadOnly = true;
            this.lecturerDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.lecturerDataGridView.RowHeadersVisible = false;
            this.lecturerDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.lecturerDataGridView.RowTemplate.ReadOnly = true;
            this.lecturerDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.lecturerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lecturerDataGridView.Size = new System.Drawing.Size(794, 248);
            this.lecturerDataGridView.TabIndex = 0;
            this.lecturerDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.lecturerDataGridView_CellEnter);
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
            this.editLecturerButton.Click += new System.EventHandler(this.editLecturerButton_Click);
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
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lecturer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabText = "Timetable Package";
            this.Text = "Timetable Package";
            this.Load += new System.EventHandler(this.Lecturer_Load);
            this.lecturerGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lecturerDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox lecturerGroupBox;
        private System.Windows.Forms.DataGridView lecturerDataGridView;
        private System.Windows.Forms.Button addLecturerButton;
        private System.Windows.Forms.Button editLecturerButton;
        private System.Windows.Forms.Button deleteLecturerButton;
        private System.Windows.Forms.Button lecturerModulesButton;



    }
}