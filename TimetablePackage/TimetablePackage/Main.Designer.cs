
namespace TimetablePackage
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.DockTabPanel = new DigitalRune.Windows.Docking.DockPanel();
            this.ribbonbar = new System.Windows.Forms.Ribbon();
            this.Home = new System.Windows.Forms.RibbonTab();
            this.homePanel = new System.Windows.Forms.RibbonPanel();
            this.openButton = new System.Windows.Forms.RibbonButton();
            this.newButton = new System.Windows.Forms.RibbonButton();
            this.printButton = new System.Windows.Forms.RibbonButton();
            this.settingButton = new System.Windows.Forms.RibbonButton();
            this.timetableTab = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.generateButton = new System.Windows.Forms.RibbonButton();
            this.lecturerTab = new System.Windows.Forms.RibbonTab();
            this.lecturerPanel = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.addLecturer = new System.Windows.Forms.RibbonButton();
            this.departmentTab = new System.Windows.Forms.RibbonTab();
            this.departmentPanel = new System.Windows.Forms.RibbonPanel();
            this.deptListButton = new System.Windows.Forms.RibbonButton();
            this.addDeptButton = new System.Windows.Forms.RibbonButton();
            this.coursePanel = new System.Windows.Forms.RibbonPanel();
            this.courseListButton = new System.Windows.Forms.RibbonButton();
            this.addCourseButton = new System.Windows.Forms.RibbonButton();
            this.modulePanel = new System.Windows.Forms.RibbonPanel();
            this.moduleListButton = new System.Windows.Forms.RibbonButton();
            this.addModuleButton = new System.Windows.Forms.RibbonButton();
            this.buildingTab = new System.Windows.Forms.RibbonTab();
            this.buildingPanel = new System.Windows.Forms.RibbonPanel();
            this.buildingListButton = new System.Windows.Forms.RibbonButton();
            this.AddBuildingButton = new System.Windows.Forms.RibbonButton();
            this.roomPanel = new System.Windows.Forms.RibbonPanel();
            this.roomList = new System.Windows.Forms.RibbonButton();
            this.addRoomButton = new System.Windows.Forms.RibbonButton();
            this.helpTab = new System.Windows.Forms.RibbonTab();
            this.helpPanel = new System.Windows.Forms.RibbonPanel();
            this.aboutButton = new System.Windows.Forms.RibbonButton();
            this.manualButton = new System.Windows.Forms.RibbonButton();
            this.printManualButton = new System.Windows.Forms.RibbonButton();
            this.ribbonOrbMenuItem1 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.SuspendLayout();
            // 
            // DockTabPanel
            // 
            this.DockTabPanel.ActiveAutoHideContent = null;
            this.DockTabPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DockTabPanel.DefaultFloatingWindowSize = new System.Drawing.Size(300, 300);
            this.DockTabPanel.Location = new System.Drawing.Point(0, 146);
            this.DockTabPanel.Name = "DockTabPanel";
            this.DockTabPanel.Size = new System.Drawing.Size(1008, 416);
            this.DockTabPanel.TabIndex = 2;
            // 
            // ribbonbar
            // 
            this.ribbonbar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbonbar.Location = new System.Drawing.Point(0, 0);
            this.ribbonbar.Minimized = false;
            this.ribbonbar.Name = "ribbonbar";
            // 
            // 
            // 
            this.ribbonbar.OrbDropDown.BorderRoundness = 8;
            this.ribbonbar.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbonbar.OrbDropDown.Name = "";
            this.ribbonbar.OrbDropDown.Size = new System.Drawing.Size(0, 72);
            this.ribbonbar.OrbDropDown.TabIndex = 0;
            this.ribbonbar.OrbImage = global::TimetablePackage.Properties.Resources.icon3;
            this.ribbonbar.OrbVisible = false;
            this.ribbonbar.Size = new System.Drawing.Size(1008, 146);
            this.ribbonbar.TabIndex = 4;
            this.ribbonbar.Tabs.Add(this.Home);
            this.ribbonbar.Tabs.Add(this.timetableTab);
            this.ribbonbar.Tabs.Add(this.lecturerTab);
            this.ribbonbar.Tabs.Add(this.departmentTab);
            this.ribbonbar.Tabs.Add(this.buildingTab);
            this.ribbonbar.Tabs.Add(this.helpTab);
            this.ribbonbar.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbonbar.Text = "ribbon1";
            // 
            // Home
            // 
            this.Home.Panels.Add(this.homePanel);
            this.Home.Text = "Home";
            // 
            // homePanel
            // 
            this.homePanel.Items.Add(this.openButton);
            this.homePanel.Items.Add(this.newButton);
            this.homePanel.Items.Add(this.printButton);
            this.homePanel.Items.Add(this.settingButton);
            this.homePanel.Text = "Home";
            // 
            // openButton
            // 
            this.openButton.Image = global::TimetablePackage.Properties.Resources.open_folder;
            this.openButton.MaximumSize = new System.Drawing.Size(0, 0);
            this.openButton.MinimumSize = new System.Drawing.Size(0, 0);
            this.openButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("openButton.SmallImage")));
            this.openButton.Text = "Open";
            // 
            // newButton
            // 
            this.newButton.Image = global::TimetablePackage.Properties.Resources.document_empty;
            this.newButton.MaximumSize = new System.Drawing.Size(0, 0);
            this.newButton.MinimumSize = new System.Drawing.Size(0, 0);
            this.newButton.SmallImage = global::TimetablePackage.Properties.Resources.document_empty;
            this.newButton.Text = "New";
            // 
            // printButton
            // 
            this.printButton.Image = global::TimetablePackage.Properties.Resources.printer;
            this.printButton.MaximumSize = new System.Drawing.Size(0, 0);
            this.printButton.MinimumSize = new System.Drawing.Size(0, 0);
            this.printButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("printButton.SmallImage")));
            this.printButton.Text = "Print";
            // 
            // settingButton
            // 
            this.settingButton.Image = global::TimetablePackage.Properties.Resources.setting_tools;
            this.settingButton.MaximumSize = new System.Drawing.Size(0, 0);
            this.settingButton.MinimumSize = new System.Drawing.Size(0, 0);
            this.settingButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("settingButton.SmallImage")));
            this.settingButton.Text = "Settings";
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // timetableTab
            // 
            this.timetableTab.Panels.Add(this.ribbonPanel1);
            this.timetableTab.Text = "Timetable ";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.generateButton);
            this.ribbonPanel1.Text = "Timetable";
            // 
            // generateButton
            // 
            this.generateButton.Image = global::TimetablePackage.Properties.Resources.book_keeping;
            this.generateButton.MaximumSize = new System.Drawing.Size(0, 0);
            this.generateButton.MinimumSize = new System.Drawing.Size(0, 0);
            this.generateButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("generateButton.SmallImage")));
            this.generateButton.Text = "Generate";
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // lecturerTab
            // 
            this.lecturerTab.Panels.Add(this.lecturerPanel);
            this.lecturerTab.Text = "Lecturer";
            // 
            // lecturerPanel
            // 
            this.lecturerPanel.Items.Add(this.ribbonButton1);
            this.lecturerPanel.Items.Add(this.addLecturer);
            this.lecturerPanel.Text = "Lecturer";
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = global::TimetablePackage.Properties.Resources.group;
            this.ribbonButton1.MaximumSize = new System.Drawing.Size(0, 0);
            this.ribbonButton1.MinimumSize = new System.Drawing.Size(0, 0);
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "Lecturer List";
            this.ribbonButton1.Click += new System.EventHandler(this.ribbonButton1_Click);
            // 
            // addLecturer
            // 
            this.addLecturer.Image = global::TimetablePackage.Properties.Resources.group_add;
            this.addLecturer.MaximumSize = new System.Drawing.Size(0, 0);
            this.addLecturer.MinimumSize = new System.Drawing.Size(0, 0);
            this.addLecturer.SmallImage = ((System.Drawing.Image)(resources.GetObject("addLecturer.SmallImage")));
            this.addLecturer.Text = "Add a Lecturer";
            this.addLecturer.Click += new System.EventHandler(this.addLecturer_Click);
            // 
            // departmentTab
            // 
            this.departmentTab.Panels.Add(this.departmentPanel);
            this.departmentTab.Panels.Add(this.coursePanel);
            this.departmentTab.Panels.Add(this.modulePanel);
            this.departmentTab.Text = "Department";
            // 
            // departmentPanel
            // 
            this.departmentPanel.Items.Add(this.deptListButton);
            this.departmentPanel.Items.Add(this.addDeptButton);
            this.departmentPanel.Text = "Department";
            // 
            // deptListButton
            // 
            this.deptListButton.Image = global::TimetablePackage.Properties.Resources.table;
            this.deptListButton.MaximumSize = new System.Drawing.Size(0, 0);
            this.deptListButton.MinimumSize = new System.Drawing.Size(0, 0);
            this.deptListButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("deptListButton.SmallImage")));
            this.deptListButton.Text = "Department List";
            // 
            // addDeptButton
            // 
            this.addDeptButton.Image = global::TimetablePackage.Properties.Resources.table_add;
            this.addDeptButton.MaximumSize = new System.Drawing.Size(0, 0);
            this.addDeptButton.MinimumSize = new System.Drawing.Size(0, 0);
            this.addDeptButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("addDeptButton.SmallImage")));
            this.addDeptButton.Text = "Add a Department";
            // 
            // coursePanel
            // 
            this.coursePanel.Items.Add(this.courseListButton);
            this.coursePanel.Items.Add(this.addCourseButton);
            this.coursePanel.Text = "Course";
            // 
            // courseListButton
            // 
            this.courseListButton.Image = global::TimetablePackage.Properties.Resources.report;
            this.courseListButton.MaximumSize = new System.Drawing.Size(0, 0);
            this.courseListButton.MinimumSize = new System.Drawing.Size(0, 0);
            this.courseListButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("courseListButton.SmallImage")));
            this.courseListButton.Text = "Course List";
            this.courseListButton.Click += new System.EventHandler(this.courseListButton_Click);
            // 
            // addCourseButton
            // 
            this.addCourseButton.Image = global::TimetablePackage.Properties.Resources.report_add;
            this.addCourseButton.MaximumSize = new System.Drawing.Size(0, 0);
            this.addCourseButton.MinimumSize = new System.Drawing.Size(0, 0);
            this.addCourseButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("addCourseButton.SmallImage")));
            this.addCourseButton.Text = "Add a Course";
            this.addCourseButton.Click += new System.EventHandler(this.addCourseButton_Click);
            // 
            // modulePanel
            // 
            this.modulePanel.Items.Add(this.moduleListButton);
            this.modulePanel.Items.Add(this.addModuleButton);
            this.modulePanel.Text = "Module";
            // 
            // moduleListButton
            // 
            this.moduleListButton.Image = global::TimetablePackage.Properties.Resources.books;
            this.moduleListButton.MaximumSize = new System.Drawing.Size(0, 0);
            this.moduleListButton.MinimumSize = new System.Drawing.Size(0, 0);
            this.moduleListButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("moduleListButton.SmallImage")));
            this.moduleListButton.Text = "Module List";
            this.moduleListButton.Click += new System.EventHandler(this.moduleListButton_Click);
            // 
            // addModuleButton
            // 
            this.addModuleButton.Image = global::TimetablePackage.Properties.Resources.book_add;
            this.addModuleButton.MaximumSize = new System.Drawing.Size(0, 0);
            this.addModuleButton.MinimumSize = new System.Drawing.Size(0, 0);
            this.addModuleButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("addModuleButton.SmallImage")));
            this.addModuleButton.Text = "Add a Module";
            // 
            // buildingTab
            // 
            this.buildingTab.Panels.Add(this.buildingPanel);
            this.buildingTab.Panels.Add(this.roomPanel);
            this.buildingTab.Text = "Building";
            // 
            // buildingPanel
            // 
            this.buildingPanel.Items.Add(this.buildingListButton);
            this.buildingPanel.Items.Add(this.AddBuildingButton);
            this.buildingPanel.Text = "Building";
            // 
            // buildingListButton
            // 
            this.buildingListButton.Image = global::TimetablePackage.Properties.Resources.building;
            this.buildingListButton.MaximumSize = new System.Drawing.Size(0, 0);
            this.buildingListButton.MinimumSize = new System.Drawing.Size(0, 0);
            this.buildingListButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("buildingListButton.SmallImage")));
            this.buildingListButton.Text = "Building List";
            this.buildingListButton.Click += new System.EventHandler(this.buildingListButton_Click_1);
            // 
            // AddBuildingButton
            // 
            this.AddBuildingButton.Image = global::TimetablePackage.Properties.Resources.building_add;
            this.AddBuildingButton.MaximumSize = new System.Drawing.Size(0, 0);
            this.AddBuildingButton.MinimumSize = new System.Drawing.Size(0, 0);
            this.AddBuildingButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("AddBuildingButton.SmallImage")));
            this.AddBuildingButton.Text = "Add a Building";
            // 
            // roomPanel
            // 
            this.roomPanel.Items.Add(this.roomList);
            this.roomPanel.Items.Add(this.addRoomButton);
            this.roomPanel.Text = "Room";
            // 
            // roomList
            // 
            this.roomList.Image = global::TimetablePackage.Properties.Resources.bell;
            this.roomList.MaximumSize = new System.Drawing.Size(0, 0);
            this.roomList.MinimumSize = new System.Drawing.Size(0, 0);
            this.roomList.SmallImage = ((System.Drawing.Image)(resources.GetObject("roomList.SmallImage")));
            this.roomList.Text = "Room List";
            // 
            // addRoomButton
            // 
            this.addRoomButton.Image = global::TimetablePackage.Properties.Resources.bell_add;
            this.addRoomButton.MaximumSize = new System.Drawing.Size(0, 0);
            this.addRoomButton.MinimumSize = new System.Drawing.Size(0, 0);
            this.addRoomButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("addRoomButton.SmallImage")));
            this.addRoomButton.Text = "Add a Room";
            // 
            // helpTab
            // 
            this.helpTab.Panels.Add(this.helpPanel);
            this.helpTab.Text = "Help";
            // 
            // helpPanel
            // 
            this.helpPanel.Items.Add(this.aboutButton);
            this.helpPanel.Items.Add(this.manualButton);
            this.helpPanel.Items.Add(this.printManualButton);
            this.helpPanel.Text = "Help";
            // 
            // aboutButton
            // 
            this.aboutButton.Image = global::TimetablePackage.Properties.Resources.information;
            this.aboutButton.MaximumSize = new System.Drawing.Size(0, 0);
            this.aboutButton.MinimumSize = new System.Drawing.Size(0, 0);
            this.aboutButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("aboutButton.SmallImage")));
            this.aboutButton.Text = "About";
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // manualButton
            // 
            this.manualButton.Image = global::TimetablePackage.Properties.Resources.help;
            this.manualButton.MaximumSize = new System.Drawing.Size(0, 0);
            this.manualButton.MinimumSize = new System.Drawing.Size(0, 0);
            this.manualButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("manualButton.SmallImage")));
            this.manualButton.Text = "User Manual";
            // 
            // printManualButton
            // 
            this.printManualButton.Image = global::TimetablePackage.Properties.Resources.printer_empty;
            this.printManualButton.MaximumSize = new System.Drawing.Size(0, 0);
            this.printManualButton.MinimumSize = new System.Drawing.Size(0, 0);
            this.printManualButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("printManualButton.SmallImage")));
            this.printManualButton.Text = "Print Manual";
            // 
            // ribbonOrbMenuItem1
            // 
            this.ribbonOrbMenuItem1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.Image")));
            this.ribbonOrbMenuItem1.MaximumSize = new System.Drawing.Size(0, 0);
            this.ribbonOrbMenuItem1.MinimumSize = new System.Drawing.Size(0, 0);
            this.ribbonOrbMenuItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.SmallImage")));
            this.ribbonOrbMenuItem1.Text = "ribbonOrbMenuItem1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 562);
            this.Controls.Add(this.ribbonbar);
            this.Controls.Add(this.DockTabPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timetable Package";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

       
        private DigitalRune.Windows.Docking.DockPanel DockTabPanel;
        private System.Windows.Forms.Ribbon ribbonbar;
        private System.Windows.Forms.RibbonTab Home;
        private System.Windows.Forms.RibbonPanel homePanel;
        private System.Windows.Forms.RibbonTab timetableTab;
        private System.Windows.Forms.RibbonTab lecturerTab;
        private System.Windows.Forms.RibbonTab departmentTab;
        private System.Windows.Forms.RibbonTab buildingTab;
        private System.Windows.Forms.RibbonTab helpTab;
        private System.Windows.Forms.RibbonButton openButton;
        private System.Windows.Forms.RibbonButton newButton;
        private System.Windows.Forms.RibbonButton printButton;
        private System.Windows.Forms.RibbonButton settingButton;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton generateButton;
        private System.Windows.Forms.RibbonPanel lecturerPanel;
        private System.Windows.Forms.RibbonButton addLecturer;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonPanel departmentPanel;
        private System.Windows.Forms.RibbonButton deptListButton;
        private System.Windows.Forms.RibbonButton addDeptButton;
        private System.Windows.Forms.RibbonPanel modulePanel;
        private System.Windows.Forms.RibbonButton moduleListButton;
        private System.Windows.Forms.RibbonButton addModuleButton;
        private System.Windows.Forms.RibbonPanel coursePanel;
        private System.Windows.Forms.RibbonButton courseListButton;
        private System.Windows.Forms.RibbonButton addCourseButton;
        private System.Windows.Forms.RibbonPanel buildingPanel;
        private System.Windows.Forms.RibbonButton buildingListButton;
        private System.Windows.Forms.RibbonButton AddBuildingButton;
        private System.Windows.Forms.RibbonPanel roomPanel;
        private System.Windows.Forms.RibbonButton roomList;
        private System.Windows.Forms.RibbonButton addRoomButton;
        private System.Windows.Forms.RibbonPanel helpPanel;
        private System.Windows.Forms.RibbonButton aboutButton;
        private System.Windows.Forms.RibbonButton manualButton;
        private System.Windows.Forms.RibbonButton printManualButton;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem1;
       



     
    }
}