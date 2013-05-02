namespace TimetablePackage
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.Language = new System.Windows.Forms.TabControl();
            this.insDetailsTab = new System.Windows.Forms.TabPage();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.academicYearTextBox = new System.Windows.Forms.TextBox();
            this.websiteTextBox = new System.Windows.Forms.TextBox();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.addLine3TextBox = new System.Windows.Forms.TextBox();
            this.addLine2TextBox = new System.Windows.Forms.TextBox();
            this.addLine1TextBox = new System.Windows.Forms.TextBox();
            this.insNameTextBox = new System.Windows.Forms.TextBox();
            this.academicYearLabel = new System.Windows.Forms.Label();
            this.websiteInfoLabel = new System.Windows.Forms.Label();
            this.telephoneLabel = new System.Windows.Forms.Label();
            this.countryNameLabel = new System.Windows.Forms.Label();
            this.cityNameLabel = new System.Windows.Forms.Label();
            this.addLine3 = new System.Windows.Forms.Label();
            this.addLine2 = new System.Windows.Forms.Label();
            this.addLine1 = new System.Windows.Forms.Label();
            this.insNameLabel = new System.Windows.Forms.Label();
            this.languageTab = new System.Windows.Forms.TabPage();
            this.languageSelectLabel = new System.Windows.Forms.Label();
            this.languageSelect = new System.Windows.Forms.GroupBox();
            this.languagesFlagsPictureBox = new System.Windows.Forms.PictureBox();
            this.frenchRadioButton = new System.Windows.Forms.RadioButton();
            this.languageSelectionImages = new System.Windows.Forms.ImageList(this.components);
            this.turkishRadioButton = new System.Windows.Forms.RadioButton();
            this.englishRadioButton = new System.Windows.Forms.RadioButton();
            this.settingsFormSaveButton = new System.Windows.Forms.Button();
            this.settingsFormCancelButton = new System.Windows.Forms.Button();
            this.Language.SuspendLayout();
            this.insDetailsTab.SuspendLayout();
            this.languageTab.SuspendLayout();
            this.languageSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.languagesFlagsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Language
            // 
            this.Language.Controls.Add(this.insDetailsTab);
            this.Language.Controls.Add(this.languageTab);
            this.Language.ImageList = this.languageSelectionImages;
            resources.ApplyResources(this.Language, "Language");
            this.Language.Name = "Language";
            this.Language.SelectedIndex = 0;
            // 
            // insDetailsTab
            // 
            this.insDetailsTab.BackColor = System.Drawing.SystemColors.Control;
            this.insDetailsTab.Controls.Add(this.countryComboBox);
            this.insDetailsTab.Controls.Add(this.academicYearTextBox);
            this.insDetailsTab.Controls.Add(this.websiteTextBox);
            this.insDetailsTab.Controls.Add(this.telephoneTextBox);
            this.insDetailsTab.Controls.Add(this.cityTextBox);
            this.insDetailsTab.Controls.Add(this.addLine3TextBox);
            this.insDetailsTab.Controls.Add(this.addLine2TextBox);
            this.insDetailsTab.Controls.Add(this.addLine1TextBox);
            this.insDetailsTab.Controls.Add(this.insNameTextBox);
            this.insDetailsTab.Controls.Add(this.academicYearLabel);
            this.insDetailsTab.Controls.Add(this.websiteInfoLabel);
            this.insDetailsTab.Controls.Add(this.telephoneLabel);
            this.insDetailsTab.Controls.Add(this.countryNameLabel);
            this.insDetailsTab.Controls.Add(this.cityNameLabel);
            this.insDetailsTab.Controls.Add(this.addLine3);
            this.insDetailsTab.Controls.Add(this.addLine2);
            this.insDetailsTab.Controls.Add(this.addLine1);
            this.insDetailsTab.Controls.Add(this.insNameLabel);
            resources.ApplyResources(this.insDetailsTab, "insDetailsTab");
            this.insDetailsTab.Name = "insDetailsTab";
            this.insDetailsTab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // countryComboBox
            // 
            this.countryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryComboBox.Items.AddRange(new object[] {
            resources.GetString("countryComboBox.Items"),
            resources.GetString("countryComboBox.Items1"),
            resources.GetString("countryComboBox.Items2"),
            resources.GetString("countryComboBox.Items3"),
            resources.GetString("countryComboBox.Items4"),
            resources.GetString("countryComboBox.Items5"),
            resources.GetString("countryComboBox.Items6"),
            resources.GetString("countryComboBox.Items7"),
            resources.GetString("countryComboBox.Items8"),
            resources.GetString("countryComboBox.Items9"),
            resources.GetString("countryComboBox.Items10"),
            resources.GetString("countryComboBox.Items11"),
            resources.GetString("countryComboBox.Items12"),
            resources.GetString("countryComboBox.Items13"),
            resources.GetString("countryComboBox.Items14"),
            resources.GetString("countryComboBox.Items15"),
            resources.GetString("countryComboBox.Items16"),
            resources.GetString("countryComboBox.Items17"),
            resources.GetString("countryComboBox.Items18"),
            resources.GetString("countryComboBox.Items19"),
            resources.GetString("countryComboBox.Items20"),
            resources.GetString("countryComboBox.Items21"),
            resources.GetString("countryComboBox.Items22"),
            resources.GetString("countryComboBox.Items23"),
            resources.GetString("countryComboBox.Items24"),
            resources.GetString("countryComboBox.Items25"),
            resources.GetString("countryComboBox.Items26"),
            resources.GetString("countryComboBox.Items27"),
            resources.GetString("countryComboBox.Items28"),
            resources.GetString("countryComboBox.Items29"),
            resources.GetString("countryComboBox.Items30"),
            resources.GetString("countryComboBox.Items31"),
            resources.GetString("countryComboBox.Items32"),
            resources.GetString("countryComboBox.Items33"),
            resources.GetString("countryComboBox.Items34"),
            resources.GetString("countryComboBox.Items35"),
            resources.GetString("countryComboBox.Items36"),
            resources.GetString("countryComboBox.Items37"),
            resources.GetString("countryComboBox.Items38"),
            resources.GetString("countryComboBox.Items39"),
            resources.GetString("countryComboBox.Items40"),
            resources.GetString("countryComboBox.Items41"),
            resources.GetString("countryComboBox.Items42"),
            resources.GetString("countryComboBox.Items43"),
            resources.GetString("countryComboBox.Items44"),
            resources.GetString("countryComboBox.Items45"),
            resources.GetString("countryComboBox.Items46"),
            resources.GetString("countryComboBox.Items47"),
            resources.GetString("countryComboBox.Items48"),
            resources.GetString("countryComboBox.Items49"),
            resources.GetString("countryComboBox.Items50"),
            resources.GetString("countryComboBox.Items51"),
            resources.GetString("countryComboBox.Items52"),
            resources.GetString("countryComboBox.Items53"),
            resources.GetString("countryComboBox.Items54"),
            resources.GetString("countryComboBox.Items55"),
            resources.GetString("countryComboBox.Items56"),
            resources.GetString("countryComboBox.Items57"),
            resources.GetString("countryComboBox.Items58"),
            resources.GetString("countryComboBox.Items59"),
            resources.GetString("countryComboBox.Items60"),
            resources.GetString("countryComboBox.Items61"),
            resources.GetString("countryComboBox.Items62"),
            resources.GetString("countryComboBox.Items63"),
            resources.GetString("countryComboBox.Items64"),
            resources.GetString("countryComboBox.Items65"),
            resources.GetString("countryComboBox.Items66"),
            resources.GetString("countryComboBox.Items67"),
            resources.GetString("countryComboBox.Items68"),
            resources.GetString("countryComboBox.Items69"),
            resources.GetString("countryComboBox.Items70"),
            resources.GetString("countryComboBox.Items71"),
            resources.GetString("countryComboBox.Items72"),
            resources.GetString("countryComboBox.Items73"),
            resources.GetString("countryComboBox.Items74"),
            resources.GetString("countryComboBox.Items75"),
            resources.GetString("countryComboBox.Items76"),
            resources.GetString("countryComboBox.Items77"),
            resources.GetString("countryComboBox.Items78"),
            resources.GetString("countryComboBox.Items79"),
            resources.GetString("countryComboBox.Items80"),
            resources.GetString("countryComboBox.Items81"),
            resources.GetString("countryComboBox.Items82"),
            resources.GetString("countryComboBox.Items83"),
            resources.GetString("countryComboBox.Items84"),
            resources.GetString("countryComboBox.Items85"),
            resources.GetString("countryComboBox.Items86"),
            resources.GetString("countryComboBox.Items87"),
            resources.GetString("countryComboBox.Items88"),
            resources.GetString("countryComboBox.Items89"),
            resources.GetString("countryComboBox.Items90"),
            resources.GetString("countryComboBox.Items91"),
            resources.GetString("countryComboBox.Items92"),
            resources.GetString("countryComboBox.Items93"),
            resources.GetString("countryComboBox.Items94"),
            resources.GetString("countryComboBox.Items95"),
            resources.GetString("countryComboBox.Items96"),
            resources.GetString("countryComboBox.Items97"),
            resources.GetString("countryComboBox.Items98"),
            resources.GetString("countryComboBox.Items99"),
            resources.GetString("countryComboBox.Items100"),
            resources.GetString("countryComboBox.Items101"),
            resources.GetString("countryComboBox.Items102"),
            resources.GetString("countryComboBox.Items103"),
            resources.GetString("countryComboBox.Items104"),
            resources.GetString("countryComboBox.Items105"),
            resources.GetString("countryComboBox.Items106"),
            resources.GetString("countryComboBox.Items107"),
            resources.GetString("countryComboBox.Items108"),
            resources.GetString("countryComboBox.Items109"),
            resources.GetString("countryComboBox.Items110"),
            resources.GetString("countryComboBox.Items111"),
            resources.GetString("countryComboBox.Items112"),
            resources.GetString("countryComboBox.Items113"),
            resources.GetString("countryComboBox.Items114"),
            resources.GetString("countryComboBox.Items115"),
            resources.GetString("countryComboBox.Items116"),
            resources.GetString("countryComboBox.Items117"),
            resources.GetString("countryComboBox.Items118"),
            resources.GetString("countryComboBox.Items119"),
            resources.GetString("countryComboBox.Items120"),
            resources.GetString("countryComboBox.Items121"),
            resources.GetString("countryComboBox.Items122"),
            resources.GetString("countryComboBox.Items123"),
            resources.GetString("countryComboBox.Items124"),
            resources.GetString("countryComboBox.Items125"),
            resources.GetString("countryComboBox.Items126"),
            resources.GetString("countryComboBox.Items127"),
            resources.GetString("countryComboBox.Items128"),
            resources.GetString("countryComboBox.Items129"),
            resources.GetString("countryComboBox.Items130"),
            resources.GetString("countryComboBox.Items131"),
            resources.GetString("countryComboBox.Items132"),
            resources.GetString("countryComboBox.Items133"),
            resources.GetString("countryComboBox.Items134"),
            resources.GetString("countryComboBox.Items135"),
            resources.GetString("countryComboBox.Items136"),
            resources.GetString("countryComboBox.Items137"),
            resources.GetString("countryComboBox.Items138"),
            resources.GetString("countryComboBox.Items139"),
            resources.GetString("countryComboBox.Items140"),
            resources.GetString("countryComboBox.Items141"),
            resources.GetString("countryComboBox.Items142"),
            resources.GetString("countryComboBox.Items143"),
            resources.GetString("countryComboBox.Items144"),
            resources.GetString("countryComboBox.Items145"),
            resources.GetString("countryComboBox.Items146"),
            resources.GetString("countryComboBox.Items147"),
            resources.GetString("countryComboBox.Items148"),
            resources.GetString("countryComboBox.Items149"),
            resources.GetString("countryComboBox.Items150"),
            resources.GetString("countryComboBox.Items151"),
            resources.GetString("countryComboBox.Items152"),
            resources.GetString("countryComboBox.Items153"),
            resources.GetString("countryComboBox.Items154"),
            resources.GetString("countryComboBox.Items155"),
            resources.GetString("countryComboBox.Items156"),
            resources.GetString("countryComboBox.Items157"),
            resources.GetString("countryComboBox.Items158"),
            resources.GetString("countryComboBox.Items159"),
            resources.GetString("countryComboBox.Items160"),
            resources.GetString("countryComboBox.Items161"),
            resources.GetString("countryComboBox.Items162"),
            resources.GetString("countryComboBox.Items163"),
            resources.GetString("countryComboBox.Items164"),
            resources.GetString("countryComboBox.Items165"),
            resources.GetString("countryComboBox.Items166"),
            resources.GetString("countryComboBox.Items167"),
            resources.GetString("countryComboBox.Items168"),
            resources.GetString("countryComboBox.Items169"),
            resources.GetString("countryComboBox.Items170"),
            resources.GetString("countryComboBox.Items171"),
            resources.GetString("countryComboBox.Items172"),
            resources.GetString("countryComboBox.Items173"),
            resources.GetString("countryComboBox.Items174"),
            resources.GetString("countryComboBox.Items175"),
            resources.GetString("countryComboBox.Items176"),
            resources.GetString("countryComboBox.Items177"),
            resources.GetString("countryComboBox.Items178"),
            resources.GetString("countryComboBox.Items179"),
            resources.GetString("countryComboBox.Items180"),
            resources.GetString("countryComboBox.Items181"),
            resources.GetString("countryComboBox.Items182"),
            resources.GetString("countryComboBox.Items183"),
            resources.GetString("countryComboBox.Items184"),
            resources.GetString("countryComboBox.Items185"),
            resources.GetString("countryComboBox.Items186"),
            resources.GetString("countryComboBox.Items187"),
            resources.GetString("countryComboBox.Items188"),
            resources.GetString("countryComboBox.Items189"),
            resources.GetString("countryComboBox.Items190"),
            resources.GetString("countryComboBox.Items191"),
            resources.GetString("countryComboBox.Items192"),
            resources.GetString("countryComboBox.Items193"),
            resources.GetString("countryComboBox.Items194"),
            resources.GetString("countryComboBox.Items195"),
            resources.GetString("countryComboBox.Items196"),
            resources.GetString("countryComboBox.Items197"),
            resources.GetString("countryComboBox.Items198"),
            resources.GetString("countryComboBox.Items199"),
            resources.GetString("countryComboBox.Items200"),
            resources.GetString("countryComboBox.Items201"),
            resources.GetString("countryComboBox.Items202"),
            resources.GetString("countryComboBox.Items203"),
            resources.GetString("countryComboBox.Items204"),
            resources.GetString("countryComboBox.Items205"),
            resources.GetString("countryComboBox.Items206"),
            resources.GetString("countryComboBox.Items207"),
            resources.GetString("countryComboBox.Items208"),
            resources.GetString("countryComboBox.Items209"),
            resources.GetString("countryComboBox.Items210"),
            resources.GetString("countryComboBox.Items211"),
            resources.GetString("countryComboBox.Items212"),
            resources.GetString("countryComboBox.Items213"),
            resources.GetString("countryComboBox.Items214"),
            resources.GetString("countryComboBox.Items215"),
            resources.GetString("countryComboBox.Items216"),
            resources.GetString("countryComboBox.Items217"),
            resources.GetString("countryComboBox.Items218"),
            resources.GetString("countryComboBox.Items219"),
            resources.GetString("countryComboBox.Items220"),
            resources.GetString("countryComboBox.Items221"),
            resources.GetString("countryComboBox.Items222"),
            resources.GetString("countryComboBox.Items223"),
            resources.GetString("countryComboBox.Items224"),
            resources.GetString("countryComboBox.Items225"),
            resources.GetString("countryComboBox.Items226"),
            resources.GetString("countryComboBox.Items227"),
            resources.GetString("countryComboBox.Items228"),
            resources.GetString("countryComboBox.Items229"),
            resources.GetString("countryComboBox.Items230"),
            resources.GetString("countryComboBox.Items231"),
            resources.GetString("countryComboBox.Items232"),
            resources.GetString("countryComboBox.Items233"),
            resources.GetString("countryComboBox.Items234"),
            resources.GetString("countryComboBox.Items235"),
            resources.GetString("countryComboBox.Items236"),
            resources.GetString("countryComboBox.Items237"),
            resources.GetString("countryComboBox.Items238"),
            resources.GetString("countryComboBox.Items239"),
            resources.GetString("countryComboBox.Items240"),
            resources.GetString("countryComboBox.Items241"),
            resources.GetString("countryComboBox.Items242"),
            resources.GetString("countryComboBox.Items243")});
            resources.ApplyResources(this.countryComboBox, "countryComboBox");
            this.countryComboBox.Name = "countryComboBox";
            // 
            // academicYearTextBox
            // 
            resources.ApplyResources(this.academicYearTextBox, "academicYearTextBox");
            this.academicYearTextBox.Name = "academicYearTextBox";
            // 
            // websiteTextBox
            // 
            resources.ApplyResources(this.websiteTextBox, "websiteTextBox");
            this.websiteTextBox.Name = "websiteTextBox";
            // 
            // telephoneTextBox
            // 
            resources.ApplyResources(this.telephoneTextBox, "telephoneTextBox");
            this.telephoneTextBox.Name = "telephoneTextBox";
            // 
            // cityTextBox
            // 
            resources.ApplyResources(this.cityTextBox, "cityTextBox");
            this.cityTextBox.Name = "cityTextBox";
            // 
            // addLine3TextBox
            // 
            resources.ApplyResources(this.addLine3TextBox, "addLine3TextBox");
            this.addLine3TextBox.Name = "addLine3TextBox";
            // 
            // addLine2TextBox
            // 
            resources.ApplyResources(this.addLine2TextBox, "addLine2TextBox");
            this.addLine2TextBox.Name = "addLine2TextBox";
            // 
            // addLine1TextBox
            // 
            resources.ApplyResources(this.addLine1TextBox, "addLine1TextBox");
            this.addLine1TextBox.Name = "addLine1TextBox";
            // 
            // insNameTextBox
            // 
            resources.ApplyResources(this.insNameTextBox, "insNameTextBox");
            this.insNameTextBox.Name = "insNameTextBox";
            // 
            // academicYearLabel
            // 
            resources.ApplyResources(this.academicYearLabel, "academicYearLabel");
            this.academicYearLabel.Name = "academicYearLabel";
            // 
            // websiteInfoLabel
            // 
            resources.ApplyResources(this.websiteInfoLabel, "websiteInfoLabel");
            this.websiteInfoLabel.Name = "websiteInfoLabel";
            // 
            // telephoneLabel
            // 
            resources.ApplyResources(this.telephoneLabel, "telephoneLabel");
            this.telephoneLabel.Name = "telephoneLabel";
            // 
            // countryNameLabel
            // 
            resources.ApplyResources(this.countryNameLabel, "countryNameLabel");
            this.countryNameLabel.Name = "countryNameLabel";
            // 
            // cityNameLabel
            // 
            resources.ApplyResources(this.cityNameLabel, "cityNameLabel");
            this.cityNameLabel.Name = "cityNameLabel";
            // 
            // addLine3
            // 
            resources.ApplyResources(this.addLine3, "addLine3");
            this.addLine3.Name = "addLine3";
            // 
            // addLine2
            // 
            resources.ApplyResources(this.addLine2, "addLine2");
            this.addLine2.Name = "addLine2";
            // 
            // addLine1
            // 
            resources.ApplyResources(this.addLine1, "addLine1");
            this.addLine1.Name = "addLine1";
            // 
            // insNameLabel
            // 
            resources.ApplyResources(this.insNameLabel, "insNameLabel");
            this.insNameLabel.Name = "insNameLabel";
            // 
            // languageTab
            // 
            this.languageTab.BackColor = System.Drawing.SystemColors.Control;
            this.languageTab.Controls.Add(this.languageSelectLabel);
            this.languageTab.Controls.Add(this.languageSelect);
            resources.ApplyResources(this.languageTab, "languageTab");
            this.languageTab.Name = "languageTab";
            // 
            // languageSelectLabel
            // 
            resources.ApplyResources(this.languageSelectLabel, "languageSelectLabel");
            this.languageSelectLabel.Name = "languageSelectLabel";
            // 
            // languageSelect
            // 
            this.languageSelect.BackColor = System.Drawing.Color.Transparent;
            this.languageSelect.Controls.Add(this.languagesFlagsPictureBox);
            this.languageSelect.Controls.Add(this.frenchRadioButton);
            this.languageSelect.Controls.Add(this.turkishRadioButton);
            this.languageSelect.Controls.Add(this.englishRadioButton);
            resources.ApplyResources(this.languageSelect, "languageSelect");
            this.languageSelect.Name = "languageSelect";
            this.languageSelect.TabStop = false;
            // 
            // languagesFlagsPictureBox
            // 
            this.languagesFlagsPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.languagesFlagsPictureBox.Image = global::TimetablePackage.Properties.Resources.flags_globe;
            resources.ApplyResources(this.languagesFlagsPictureBox, "languagesFlagsPictureBox");
            this.languagesFlagsPictureBox.InitialImage = global::TimetablePackage.Properties.Resources.flags_globe;
            this.languagesFlagsPictureBox.Name = "languagesFlagsPictureBox";
            this.languagesFlagsPictureBox.TabStop = false;
            // 
            // frenchRadioButton
            // 
            resources.ApplyResources(this.frenchRadioButton, "frenchRadioButton");
            this.frenchRadioButton.ImageList = this.languageSelectionImages;
            this.frenchRadioButton.Name = "frenchRadioButton";
            this.frenchRadioButton.TabStop = true;
            this.frenchRadioButton.UseVisualStyleBackColor = true;
            // 
            // languageSelectionImages
            // 
            this.languageSelectionImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("languageSelectionImages.ImageStream")));
            this.languageSelectionImages.TransparentColor = System.Drawing.Color.Transparent;
            this.languageSelectionImages.Images.SetKeyName(0, "flag_turkey.png");
            this.languageSelectionImages.Images.SetKeyName(1, "flag_france.png");
            this.languageSelectionImages.Images.SetKeyName(2, "flag_ireland.png");
            // 
            // turkishRadioButton
            // 
            resources.ApplyResources(this.turkishRadioButton, "turkishRadioButton");
            this.turkishRadioButton.ImageList = this.languageSelectionImages;
            this.turkishRadioButton.Name = "turkishRadioButton";
            this.turkishRadioButton.TabStop = true;
            this.turkishRadioButton.UseVisualStyleBackColor = true;
            // 
            // englishRadioButton
            // 
            resources.ApplyResources(this.englishRadioButton, "englishRadioButton");
            this.englishRadioButton.ImageList = this.languageSelectionImages;
            this.englishRadioButton.Name = "englishRadioButton";
            this.englishRadioButton.TabStop = true;
            this.englishRadioButton.UseVisualStyleBackColor = true;
            // 
            // settingsFormSaveButton
            // 
            resources.ApplyResources(this.settingsFormSaveButton, "settingsFormSaveButton");
            this.settingsFormSaveButton.Name = "settingsFormSaveButton";
            this.settingsFormSaveButton.UseVisualStyleBackColor = true;
            this.settingsFormSaveButton.Click += new System.EventHandler(this.settingsFormSaveButton_Click);
            // 
            // settingsFormCancelButton
            // 
            this.settingsFormCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.settingsFormCancelButton, "settingsFormCancelButton");
            this.settingsFormCancelButton.Name = "settingsFormCancelButton";
            this.settingsFormCancelButton.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.settingsFormCancelButton;
            this.Controls.Add(this.settingsFormSaveButton);
            this.Controls.Add(this.Language);
            this.Controls.Add(this.settingsFormCancelButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.Language.ResumeLayout(false);
            this.insDetailsTab.ResumeLayout(false);
            this.insDetailsTab.PerformLayout();
            this.languageTab.ResumeLayout(false);
            this.languageTab.PerformLayout();
            this.languageSelect.ResumeLayout(false);
            this.languageSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.languagesFlagsPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Language;
        private System.Windows.Forms.TabPage insDetailsTab;
        private System.Windows.Forms.TabPage languageTab;
        private System.Windows.Forms.Button settingsFormSaveButton;
        private System.Windows.Forms.Button settingsFormCancelButton;
        private System.Windows.Forms.Label websiteInfoLabel;
        private System.Windows.Forms.Label telephoneLabel;
        private System.Windows.Forms.Label countryNameLabel;
        private System.Windows.Forms.Label cityNameLabel;
        private System.Windows.Forms.Label addLine3;
        private System.Windows.Forms.Label addLine2;
        private System.Windows.Forms.Label addLine1;
        private System.Windows.Forms.Label insNameLabel;
        private System.Windows.Forms.Label academicYearLabel;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.TextBox academicYearTextBox;
        private System.Windows.Forms.TextBox websiteTextBox;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox addLine3TextBox;
        private System.Windows.Forms.TextBox addLine2TextBox;
        private System.Windows.Forms.TextBox addLine1TextBox;
        private System.Windows.Forms.TextBox insNameTextBox;
        private System.Windows.Forms.Label languageSelectLabel;
        private System.Windows.Forms.GroupBox languageSelect;
        private System.Windows.Forms.RadioButton turkishRadioButton;
        private System.Windows.Forms.RadioButton englishRadioButton;
        private System.Windows.Forms.ImageList languageSelectionImages;
        private System.Windows.Forms.RadioButton frenchRadioButton;
        private System.Windows.Forms.PictureBox languagesFlagsPictureBox;
    }
}