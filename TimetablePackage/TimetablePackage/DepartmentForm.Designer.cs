namespace TimetablePackage
{
    partial class DepartmentForm
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
            this.deleteCourseButton = new System.Windows.Forms.Button();
            this.editCourseButton = new System.Windows.Forms.Button();
            this.addCourseButton = new System.Windows.Forms.Button();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ttpDataSet = new TimetablePackage.ttpDataSet();
            this.departmentTableAdapter = new TimetablePackage.ttpDataSetTableAdapters.DepartmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttpDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteCourseButton
            // 
            this.deleteCourseButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deleteCourseButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCourseButton.Image = global::TimetablePackage.Properties.Resources.delete;
            this.deleteCourseButton.Location = new System.Drawing.Point(554, 32);
            this.deleteCourseButton.Name = "deleteCourseButton";
            this.deleteCourseButton.Size = new System.Drawing.Size(103, 43);
            this.deleteCourseButton.TabIndex = 15;
            this.deleteCourseButton.Text = "Remove";
            this.deleteCourseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteCourseButton.UseVisualStyleBackColor = true;
            // 
            // editCourseButton
            // 
            this.editCourseButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.editCourseButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCourseButton.Image = global::TimetablePackage.Properties.Resources.bullet_edit;
            this.editCourseButton.Location = new System.Drawing.Point(445, 32);
            this.editCourseButton.Name = "editCourseButton";
            this.editCourseButton.Size = new System.Drawing.Size(103, 43);
            this.editCourseButton.TabIndex = 14;
            this.editCourseButton.Text = "Edit";
            this.editCourseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editCourseButton.UseVisualStyleBackColor = true;
            // 
            // addCourseButton
            // 
            this.addCourseButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addCourseButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCourseButton.Image = global::TimetablePackage.Properties.Resources.add;
            this.addCourseButton.Location = new System.Drawing.Point(336, 32);
            this.addCourseButton.Name = "addCourseButton";
            this.addCourseButton.Size = new System.Drawing.Size(103, 43);
            this.addCourseButton.TabIndex = 13;
            this.addCourseButton.Text = "Add";
            this.addCourseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addCourseButton.UseVisualStyleBackColor = true;
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
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 372);
            this.Controls.Add(this.deleteCourseButton);
            this.Controls.Add(this.editCourseButton);
            this.Controls.Add(this.addCourseButton);
            this.Name = "DepartmentForm";
            this.Text = "Department";
            this.Load += new System.EventHandler(this.DepartmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttpDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deleteCourseButton;
        private System.Windows.Forms.Button editCourseButton;
        private System.Windows.Forms.Button addCourseButton;
        private ttpDataSet ttpDataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private ttpDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
    }
}