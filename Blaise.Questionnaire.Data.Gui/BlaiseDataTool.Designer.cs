
namespace Blaise.Questionnaire.Data.Gui
{
    partial class BlaiseDataTool
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
            this.QuestionnaireFileTextBox = new System.Windows.Forms.TextBox();
            this.questionnaireFileLabel = new System.Windows.Forms.Label();
            this.BrowseQuestionnaireFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.numberOfCasesLabel = new System.Windows.Forms.Label();
            this.NumberOfCasesTextBox = new System.Windows.Forms.TextBox();
            this.primaryKeyFromLabel = new System.Windows.Forms.Label();
            this.PrimaryKeyFromTextbox = new System.Windows.Forms.TextBox();
            this.CreateInDatabaseButton = new System.Windows.Forms.Button();
            this.imstrumentNameLabel = new System.Windows.Forms.Label();
            this.serverParkLabel = new System.Windows.Forms.Label();
            this.serverNameLabel = new System.Windows.Forms.Label();
            this.ServerNameTextBox = new System.Windows.Forms.TextBox();
            this.bindingLabel = new System.Windows.Forms.Label();
            this.BindingDropDown = new System.Windows.Forms.ComboBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.caseDetailsLabel = new System.Windows.Forms.Label();
            this.connectionSettings = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.InstallQuestionnaireButton = new System.Windows.Forms.Button();
            this.TestConnectionButton = new System.Windows.Forms.Button();
            this.BrowseCaseFileButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CaseSampleFileTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.InstallQuestionnaireLabel = new System.Windows.Forms.Label();
            this.ServerParkDropDown = new System.Windows.Forms.ComboBox();
            this.RefreshQuestionnairesButton = new System.Windows.Forms.Button();
            this.QuestionnaireDropDown = new System.Windows.Forms.ComboBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.RemotePortLabel = new System.Windows.Forms.Label();
            this.RemotePortTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectServerparkLabel = new System.Windows.Forms.Label();
            this.CraeteCasesFromSample = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CreateFromSampleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuestionnaireFileTextBox
            // 
            this.QuestionnaireFileTextBox.Location = new System.Drawing.Point(160, 400);
            this.QuestionnaireFileTextBox.Name = "QuestionnaireFileTextBox";
            this.QuestionnaireFileTextBox.Size = new System.Drawing.Size(144, 20);
            this.QuestionnaireFileTextBox.TabIndex = 0;
            // 
            // questionnaireFileLabel
            // 
            this.questionnaireFileLabel.AutoSize = true;
            this.questionnaireFileLabel.Location = new System.Drawing.Point(32, 408);
            this.questionnaireFileLabel.Name = "questionnaireFileLabel";
            this.questionnaireFileLabel.Size = new System.Drawing.Size(117, 13);
            this.questionnaireFileLabel.TabIndex = 1;
            this.questionnaireFileLabel.Text = "Questionnaire package";
            // 
            // BrowseQuestionnaireFile
            // 
            this.BrowseQuestionnaireFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseQuestionnaireFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BrowseQuestionnaireFile.Location = new System.Drawing.Point(320, 400);
            this.BrowseQuestionnaireFile.Name = "BrowseQuestionnaireFile";
            this.BrowseQuestionnaireFile.Size = new System.Drawing.Size(43, 22);
            this.BrowseQuestionnaireFile.TabIndex = 2;
            this.BrowseQuestionnaireFile.Text = "...";
            this.BrowseQuestionnaireFile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BrowseQuestionnaireFile.UseVisualStyleBackColor = true;
            this.BrowseQuestionnaireFile.Click += new System.EventHandler(this.Browse_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // numberOfCasesLabel
            // 
            this.numberOfCasesLabel.AutoSize = true;
            this.numberOfCasesLabel.Location = new System.Drawing.Point(32, 592);
            this.numberOfCasesLabel.Name = "numberOfCasesLabel";
            this.numberOfCasesLabel.Size = new System.Drawing.Size(87, 13);
            this.numberOfCasesLabel.TabIndex = 3;
            this.numberOfCasesLabel.Text = "Number of cases";
            // 
            // NumberOfCasesTextBox
            // 
            this.NumberOfCasesTextBox.Location = new System.Drawing.Point(144, 584);
            this.NumberOfCasesTextBox.Name = "NumberOfCasesTextBox";
            this.NumberOfCasesTextBox.Size = new System.Drawing.Size(88, 20);
            this.NumberOfCasesTextBox.TabIndex = 4;
            // 
            // primaryKeyFromLabel
            // 
            this.primaryKeyFromLabel.AutoSize = true;
            this.primaryKeyFromLabel.Location = new System.Drawing.Point(32, 560);
            this.primaryKeyFromLabel.Name = "primaryKeyFromLabel";
            this.primaryKeyFromLabel.Size = new System.Drawing.Size(84, 13);
            this.primaryKeyFromLabel.TabIndex = 5;
            this.primaryKeyFromLabel.Text = "Primary key from";
            // 
            // PrimaryKeyFromTextbox
            // 
            this.PrimaryKeyFromTextbox.Location = new System.Drawing.Point(144, 552);
            this.PrimaryKeyFromTextbox.Name = "PrimaryKeyFromTextbox";
            this.PrimaryKeyFromTextbox.Size = new System.Drawing.Size(88, 20);
            this.PrimaryKeyFromTextbox.TabIndex = 6;
            // 
            // CreateInDatabaseButton
            // 
            this.CreateInDatabaseButton.Location = new System.Drawing.Point(32, 616);
            this.CreateInDatabaseButton.Name = "CreateInDatabaseButton";
            this.CreateInDatabaseButton.Size = new System.Drawing.Size(100, 29);
            this.CreateInDatabaseButton.TabIndex = 11;
            this.CreateInDatabaseButton.Text = "Create";
            this.CreateInDatabaseButton.UseVisualStyleBackColor = true;
            this.CreateInDatabaseButton.Click += new System.EventHandler(this.CreateInDatabaseButton_Click);
            // 
            // imstrumentNameLabel
            // 
            this.imstrumentNameLabel.AutoSize = true;
            this.imstrumentNameLabel.Location = new System.Drawing.Point(32, 528);
            this.imstrumentNameLabel.Name = "imstrumentNameLabel";
            this.imstrumentNameLabel.Size = new System.Drawing.Size(101, 13);
            this.imstrumentNameLabel.TabIndex = 15;
            this.imstrumentNameLabel.Text = "Questionnaire name";
            // 
            // serverParkLabel
            // 
            this.serverParkLabel.AutoSize = true;
            this.serverParkLabel.Location = new System.Drawing.Point(32, 328);
            this.serverParkLabel.Name = "serverParkLabel";
            this.serverParkLabel.Size = new System.Drawing.Size(62, 13);
            this.serverParkLabel.TabIndex = 17;
            this.serverParkLabel.Text = "Server park";
            // 
            // serverNameLabel
            // 
            this.serverNameLabel.AutoSize = true;
            this.serverNameLabel.Location = new System.Drawing.Point(32, 72);
            this.serverNameLabel.Name = "serverNameLabel";
            this.serverNameLabel.Size = new System.Drawing.Size(67, 13);
            this.serverNameLabel.TabIndex = 19;
            this.serverNameLabel.Text = "Server name";
            this.serverNameLabel.Click += new System.EventHandler(this.serverNameLabel_Click);
            // 
            // ServerNameTextBox
            // 
            this.ServerNameTextBox.Location = new System.Drawing.Point(112, 72);
            this.ServerNameTextBox.Name = "ServerNameTextBox";
            this.ServerNameTextBox.Size = new System.Drawing.Size(256, 20);
            this.ServerNameTextBox.TabIndex = 20;
            this.ServerNameTextBox.TextChanged += new System.EventHandler(this.ServerNameTextBox_TextChanged);
            // 
            // bindingLabel
            // 
            this.bindingLabel.AutoSize = true;
            this.bindingLabel.Location = new System.Drawing.Point(32, 40);
            this.bindingLabel.Name = "bindingLabel";
            this.bindingLabel.Size = new System.Drawing.Size(42, 13);
            this.bindingLabel.TabIndex = 21;
            this.bindingLabel.Text = "Binding";
            this.bindingLabel.Click += new System.EventHandler(this.bindingLabel_Click);
            // 
            // BindingDropDown
            // 
            this.BindingDropDown.FormattingEnabled = true;
            this.BindingDropDown.Location = new System.Drawing.Point(112, 40);
            this.BindingDropDown.Name = "BindingDropDown";
            this.BindingDropDown.Size = new System.Drawing.Size(72, 21);
            this.BindingDropDown.TabIndex = 22;
            this.BindingDropDown.TextChanged += new System.EventHandler(this.BindingDropDown_TextChanged);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(32, 104);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(58, 13);
            this.userNameLabel.TabIndex = 23;
            this.userNameLabel.Text = "User name";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(112, 104);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.UserNameTextBox.TabIndex = 24;
            this.UserNameTextBox.TextChanged += new System.EventHandler(this.UserNameTextBox_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(32, 136);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 25;
            this.passwordLabel.Text = "Password";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(112, 136);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(120, 20);
            this.PasswordTextBox.TabIndex = 26;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // caseDetailsLabel
            // 
            this.caseDetailsLabel.AutoSize = true;
            this.caseDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caseDetailsLabel.Location = new System.Drawing.Point(16, 496);
            this.caseDetailsLabel.Name = "caseDetailsLabel";
            this.caseDetailsLabel.Size = new System.Drawing.Size(81, 13);
            this.caseDetailsLabel.TabIndex = 29;
            this.caseDetailsLabel.Text = "Create cases";
            // 
            // connectionSettings
            // 
            this.connectionSettings.AutoSize = true;
            this.connectionSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionSettings.Location = new System.Drawing.Point(12, 9);
            this.connectionSettings.Name = "connectionSettings";
            this.connectionSettings.Size = new System.Drawing.Size(156, 13);
            this.connectionSettings.TabIndex = 33;
            this.connectionSettings.Text = "Blaise connection settings";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(16, 280);
            this.label1.MaximumSize = new System.Drawing.Size(375, 2);
            this.label1.MinimumSize = new System.Drawing.Size(375, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 2);
            this.label1.TabIndex = 35;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // InstallQuestionnaireButton
            // 
            this.InstallQuestionnaireButton.Location = new System.Drawing.Point(32, 432);
            this.InstallQuestionnaireButton.Name = "InstallQuestionnaireButton";
            this.InstallQuestionnaireButton.Size = new System.Drawing.Size(100, 29);
            this.InstallQuestionnaireButton.TabIndex = 36;
            this.InstallQuestionnaireButton.Text = "Install";
            this.InstallQuestionnaireButton.UseVisualStyleBackColor = true;
            this.InstallQuestionnaireButton.Click += new System.EventHandler(this.InstallQuestionnaireButton_Click);
            // 
            // TestConnectionButton
            // 
            this.TestConnectionButton.Location = new System.Drawing.Point(32, 232);
            this.TestConnectionButton.Name = "TestConnectionButton";
            this.TestConnectionButton.Size = new System.Drawing.Size(100, 29);
            this.TestConnectionButton.TabIndex = 37;
            this.TestConnectionButton.Text = "Test connection";
            this.TestConnectionButton.UseVisualStyleBackColor = true;
            this.TestConnectionButton.Click += new System.EventHandler(this.TestConnectionButton_Click);
            // 
            // BrowseCaseFileButton
            // 
            this.BrowseCaseFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseCaseFileButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BrowseCaseFileButton.Location = new System.Drawing.Point(312, 712);
            this.BrowseCaseFileButton.Name = "BrowseCaseFileButton";
            this.BrowseCaseFileButton.Size = new System.Drawing.Size(43, 22);
            this.BrowseCaseFileButton.TabIndex = 38;
            this.BrowseCaseFileButton.Text = "...";
            this.BrowseCaseFileButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BrowseCaseFileButton.UseVisualStyleBackColor = true;
            this.BrowseCaseFileButton.Click += new System.EventHandler(this.BrowseCaseFileButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 712);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Case sample";
            // 
            // CaseSampleFileTextBox
            // 
            this.CaseSampleFileTextBox.Location = new System.Drawing.Point(112, 712);
            this.CaseSampleFileTextBox.Name = "CaseSampleFileTextBox";
            this.CaseSampleFileTextBox.Size = new System.Drawing.Size(184, 20);
            this.CaseSampleFileTextBox.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(16, 480);
            this.label4.MaximumSize = new System.Drawing.Size(375, 2);
            this.label4.MinimumSize = new System.Drawing.Size(375, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(375, 2);
            this.label4.TabIndex = 41;
            // 
            // InstallQuestionnaireLabel
            // 
            this.InstallQuestionnaireLabel.AutoSize = true;
            this.InstallQuestionnaireLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstallQuestionnaireLabel.Location = new System.Drawing.Point(16, 376);
            this.InstallQuestionnaireLabel.Name = "InstallQuestionnaireLabel";
            this.InstallQuestionnaireLabel.Size = new System.Drawing.Size(121, 13);
            this.InstallQuestionnaireLabel.TabIndex = 42;
            this.InstallQuestionnaireLabel.Text = "Install questionnaire";
            // 
            // ServerParkDropDown
            // 
            this.ServerParkDropDown.DropDownWidth = 100;
            this.ServerParkDropDown.FormattingEnabled = true;
            this.ServerParkDropDown.Location = new System.Drawing.Point(104, 320);
            this.ServerParkDropDown.Name = "ServerParkDropDown";
            this.ServerParkDropDown.Size = new System.Drawing.Size(120, 21);
            this.ServerParkDropDown.TabIndex = 43;
            // 
            // RefreshQuestionnairesButton
            // 
            this.RefreshQuestionnairesButton.Location = new System.Drawing.Point(152, 232);
            this.RefreshQuestionnairesButton.Name = "RefreshQuestionnairesButton";
            this.RefreshQuestionnairesButton.Size = new System.Drawing.Size(100, 29);
            this.RefreshQuestionnairesButton.TabIndex = 44;
            this.RefreshQuestionnairesButton.Text = "Refresh";
            this.RefreshQuestionnairesButton.UseVisualStyleBackColor = true;
            this.RefreshQuestionnairesButton.Click += new System.EventHandler(this.RefreshQuestionnairesButton_Click);
            // 
            // QuestionnaireDropDown
            // 
            this.QuestionnaireDropDown.DropDownWidth = 200;
            this.QuestionnaireDropDown.FormattingEnabled = true;
            this.QuestionnaireDropDown.Location = new System.Drawing.Point(144, 520);
            this.QuestionnaireDropDown.Name = "QuestionnaireDropDown";
            this.QuestionnaireDropDown.Size = new System.Drawing.Size(216, 21);
            this.QuestionnaireDropDown.TabIndex = 45;
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(32, 168);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(26, 13);
            this.PortLabel.TabIndex = 46;
            this.PortLabel.Text = "Port";
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(112, 168);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(72, 20);
            this.PortTextBox.TabIndex = 47;
            this.PortTextBox.TextChanged += new System.EventHandler(this.PortTextBox_TextChanged);
            // 
            // RemotePortLabel
            // 
            this.RemotePortLabel.AutoSize = true;
            this.RemotePortLabel.Location = new System.Drawing.Point(32, 200);
            this.RemotePortLabel.Name = "RemotePortLabel";
            this.RemotePortLabel.Size = new System.Drawing.Size(65, 13);
            this.RemotePortLabel.TabIndex = 48;
            this.RemotePortLabel.Text = "Remote port";
            // 
            // RemotePortTextBox
            // 
            this.RemotePortTextBox.Location = new System.Drawing.Point(112, 200);
            this.RemotePortTextBox.Name = "RemotePortTextBox";
            this.RemotePortTextBox.Size = new System.Drawing.Size(72, 20);
            this.RemotePortTextBox.TabIndex = 49;
            this.RemotePortTextBox.TextChanged += new System.EventHandler(this.RemotePortTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(16, 360);
            this.label2.MaximumSize = new System.Drawing.Size(375, 2);
            this.label2.MinimumSize = new System.Drawing.Size(375, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 2);
            this.label2.TabIndex = 50;
            // 
            // SelectServerparkLabel
            // 
            this.SelectServerparkLabel.AutoSize = true;
            this.SelectServerparkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectServerparkLabel.Location = new System.Drawing.Point(16, 296);
            this.SelectServerparkLabel.Name = "SelectServerparkLabel";
            this.SelectServerparkLabel.Size = new System.Drawing.Size(111, 13);
            this.SelectServerparkLabel.TabIndex = 51;
            this.SelectServerparkLabel.Text = "Select server park";
            // 
            // CraeteCasesFromSample
            // 
            this.CraeteCasesFromSample.AutoSize = true;
            this.CraeteCasesFromSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CraeteCasesFromSample.Location = new System.Drawing.Point(16, 680);
            this.CraeteCasesFromSample.Name = "CraeteCasesFromSample";
            this.CraeteCasesFromSample.Size = new System.Drawing.Size(173, 13);
            this.CraeteCasesFromSample.TabIndex = 52;
            this.CraeteCasesFromSample.Text = "Create cases from sample file";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(16, 664);
            this.label6.MaximumSize = new System.Drawing.Size(375, 2);
            this.label6.MinimumSize = new System.Drawing.Size(375, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(375, 2);
            this.label6.TabIndex = 53;
            // 
            // CreateFromSampleButton
            // 
            this.CreateFromSampleButton.Location = new System.Drawing.Point(32, 744);
            this.CreateFromSampleButton.Name = "CreateFromSampleButton";
            this.CreateFromSampleButton.Size = new System.Drawing.Size(100, 29);
            this.CreateFromSampleButton.TabIndex = 54;
            this.CreateFromSampleButton.Text = "Create";
            this.CreateFromSampleButton.UseVisualStyleBackColor = true;
            this.CreateFromSampleButton.Click += new System.EventHandler(this.CreateFromSampleButton_Click);
            // 
            // BlaiseDataTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(403, 785);
            this.Controls.Add(this.CreateFromSampleButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CraeteCasesFromSample);
            this.Controls.Add(this.SelectServerparkLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RemotePortTextBox);
            this.Controls.Add(this.RemotePortLabel);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.QuestionnaireDropDown);
            this.Controls.Add(this.RefreshQuestionnairesButton);
            this.Controls.Add(this.ServerParkDropDown);
            this.Controls.Add(this.InstallQuestionnaireLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CaseSampleFileTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BrowseCaseFileButton);
            this.Controls.Add(this.TestConnectionButton);
            this.Controls.Add(this.InstallQuestionnaireButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connectionSettings);
            this.Controls.Add(this.caseDetailsLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.BindingDropDown);
            this.Controls.Add(this.bindingLabel);
            this.Controls.Add(this.ServerNameTextBox);
            this.Controls.Add(this.serverNameLabel);
            this.Controls.Add(this.serverParkLabel);
            this.Controls.Add(this.imstrumentNameLabel);
            this.Controls.Add(this.CreateInDatabaseButton);
            this.Controls.Add(this.PrimaryKeyFromTextbox);
            this.Controls.Add(this.primaryKeyFromLabel);
            this.Controls.Add(this.NumberOfCasesTextBox);
            this.Controls.Add(this.numberOfCasesLabel);
            this.Controls.Add(this.BrowseQuestionnaireFile);
            this.Controls.Add(this.questionnaireFileLabel);
            this.Controls.Add(this.QuestionnaireFileTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BlaiseDataTool";
            this.Text = "Blaise Questionnaire Data Tool";
            this.Load += new System.EventHandler(this.BlaiseDataTool_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox QuestionnaireFileTextBox;
        private System.Windows.Forms.Label questionnaireFileLabel;
        private System.Windows.Forms.Button BrowseQuestionnaireFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label numberOfCasesLabel;
        private System.Windows.Forms.TextBox NumberOfCasesTextBox;
        private System.Windows.Forms.Label primaryKeyFromLabel;
        private System.Windows.Forms.TextBox PrimaryKeyFromTextbox;
        private System.Windows.Forms.Button CreateInDatabaseButton;
        private System.Windows.Forms.Label imstrumentNameLabel;
        private System.Windows.Forms.Label serverParkLabel;
        private System.Windows.Forms.Label serverNameLabel;
        private System.Windows.Forms.TextBox ServerNameTextBox;
        private System.Windows.Forms.Label bindingLabel;
        private System.Windows.Forms.ComboBox BindingDropDown;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label caseDetailsLabel;
        private System.Windows.Forms.Label connectionSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InstallQuestionnaireButton;
        private System.Windows.Forms.Button TestConnectionButton;
        private System.Windows.Forms.Button BrowseCaseFileButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CaseSampleFileTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label InstallQuestionnaireLabel;
        private System.Windows.Forms.ComboBox ServerParkDropDown;
        private System.Windows.Forms.Button RefreshQuestionnairesButton;
        private System.Windows.Forms.ComboBox QuestionnaireDropDown;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.Label RemotePortLabel;
        private System.Windows.Forms.TextBox RemotePortTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SelectServerparkLabel;
        private System.Windows.Forms.Label CraeteCasesFromSample;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CreateFromSampleButton;
    }
}

