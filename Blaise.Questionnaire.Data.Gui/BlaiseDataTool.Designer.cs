
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
            this.txtQuestionnaireFile = new System.Windows.Forms.TextBox();
            this.lblQuestionnairePackage = new System.Windows.Forms.Label();
            this.btnBrowseQuestionnaireFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblNumberOfCases = new System.Windows.Forms.Label();
            this.txtNumberOfCases = new System.Windows.Forms.TextBox();
            this.lblPrimaryKeyFrom = new System.Windows.Forms.Label();
            this.txtPrimaryKeyFrom = new System.Windows.Forms.TextBox();
            this.btnCreateCases = new System.Windows.Forms.Button();
            this.lblQuestionnaireName = new System.Windows.Forms.Label();
            this.lblServerPark = new System.Windows.Forms.Label();
            this.lblServerHostname = new System.Windows.Forms.Label();
            this.txtServerHostname = new System.Windows.Forms.TextBox();
            this.lblBinding = new System.Windows.Forms.Label();
            this.drpBinding = new System.Windows.Forms.ComboBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblCreateCases = new System.Windows.Forms.Label();
            this.lblBlaiseConnectionSettings = new System.Windows.Forms.Label();
            this.line1 = new System.Windows.Forms.Label();
            this.btnInstallQuestionnaire = new System.Windows.Forms.Button();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.btnBrowseCaseFile = new System.Windows.Forms.Button();
            this.lblCaseSample = new System.Windows.Forms.Label();
            this.txtCaseFile = new System.Windows.Forms.TextBox();
            this.line3 = new System.Windows.Forms.Label();
            this.lblInstallQuestionnaire = new System.Windows.Forms.Label();
            this.drpServerPark = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.drpQuestionnaireName = new System.Windows.Forms.ComboBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblRemotePort = new System.Windows.Forms.Label();
            this.txtRemotePort = new System.Windows.Forms.TextBox();
            this.line2 = new System.Windows.Forms.Label();
            this.lblSelectServerPark = new System.Windows.Forms.Label();
            this.lblCreateCasesFromSampleFile = new System.Windows.Forms.Label();
            this.line4 = new System.Windows.Forms.Label();
            this.btnCreateCasesFromFile = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtQuestionnaireFile
            // 
            this.txtQuestionnaireFile.Location = new System.Drawing.Point(160, 400);
            this.txtQuestionnaireFile.Name = "txtQuestionnaireFile";
            this.txtQuestionnaireFile.Size = new System.Drawing.Size(144, 20);
            this.txtQuestionnaireFile.TabIndex = 0;
            // 
            // lblQuestionnairePackage
            // 
            this.lblQuestionnairePackage.AutoSize = true;
            this.lblQuestionnairePackage.Location = new System.Drawing.Point(32, 408);
            this.lblQuestionnairePackage.Name = "lblQuestionnairePackage";
            this.lblQuestionnairePackage.Size = new System.Drawing.Size(117, 13);
            this.lblQuestionnairePackage.TabIndex = 1;
            this.lblQuestionnairePackage.Text = "Questionnaire package";
            // 
            // btnBrowseQuestionnaireFile
            // 
            this.btnBrowseQuestionnaireFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseQuestionnaireFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowseQuestionnaireFile.Location = new System.Drawing.Point(320, 400);
            this.btnBrowseQuestionnaireFile.Name = "btnBrowseQuestionnaireFile";
            this.btnBrowseQuestionnaireFile.Size = new System.Drawing.Size(43, 22);
            this.btnBrowseQuestionnaireFile.TabIndex = 2;
            this.btnBrowseQuestionnaireFile.Text = "...";
            this.btnBrowseQuestionnaireFile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowseQuestionnaireFile.UseVisualStyleBackColor = true;
            this.btnBrowseQuestionnaireFile.Click += new System.EventHandler(this.Browse_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // lblNumberOfCases
            // 
            this.lblNumberOfCases.AutoSize = true;
            this.lblNumberOfCases.Location = new System.Drawing.Point(32, 592);
            this.lblNumberOfCases.Name = "lblNumberOfCases";
            this.lblNumberOfCases.Size = new System.Drawing.Size(87, 13);
            this.lblNumberOfCases.TabIndex = 3;
            this.lblNumberOfCases.Text = "Number of cases";
            // 
            // txtNumberOfCases
            // 
            this.txtNumberOfCases.Location = new System.Drawing.Point(144, 584);
            this.txtNumberOfCases.Name = "txtNumberOfCases";
            this.txtNumberOfCases.Size = new System.Drawing.Size(88, 20);
            this.txtNumberOfCases.TabIndex = 4;
            // 
            // lblPrimaryKeyFrom
            // 
            this.lblPrimaryKeyFrom.AutoSize = true;
            this.lblPrimaryKeyFrom.Location = new System.Drawing.Point(32, 560);
            this.lblPrimaryKeyFrom.Name = "lblPrimaryKeyFrom";
            this.lblPrimaryKeyFrom.Size = new System.Drawing.Size(84, 13);
            this.lblPrimaryKeyFrom.TabIndex = 5;
            this.lblPrimaryKeyFrom.Text = "Primary key from";
            // 
            // txtPrimaryKeyFrom
            // 
            this.txtPrimaryKeyFrom.Location = new System.Drawing.Point(144, 552);
            this.txtPrimaryKeyFrom.Name = "txtPrimaryKeyFrom";
            this.txtPrimaryKeyFrom.Size = new System.Drawing.Size(88, 20);
            this.txtPrimaryKeyFrom.TabIndex = 6;
            // 
            // btnCreateCases
            // 
            this.btnCreateCases.Location = new System.Drawing.Point(32, 616);
            this.btnCreateCases.Name = "btnCreateCases";
            this.btnCreateCases.Size = new System.Drawing.Size(100, 29);
            this.btnCreateCases.TabIndex = 11;
            this.btnCreateCases.Text = "Create";
            this.btnCreateCases.UseVisualStyleBackColor = true;
            this.btnCreateCases.Click += new System.EventHandler(this.CreateInDatabaseButton_Click);
            // 
            // lblQuestionnaireName
            // 
            this.lblQuestionnaireName.AutoSize = true;
            this.lblQuestionnaireName.Location = new System.Drawing.Point(32, 528);
            this.lblQuestionnaireName.Name = "lblQuestionnaireName";
            this.lblQuestionnaireName.Size = new System.Drawing.Size(101, 13);
            this.lblQuestionnaireName.TabIndex = 15;
            this.lblQuestionnaireName.Text = "Questionnaire name";
            // 
            // lblServerPark
            // 
            this.lblServerPark.AutoSize = true;
            this.lblServerPark.Location = new System.Drawing.Point(32, 328);
            this.lblServerPark.Name = "lblServerPark";
            this.lblServerPark.Size = new System.Drawing.Size(62, 13);
            this.lblServerPark.TabIndex = 17;
            this.lblServerPark.Text = "Server park";
            // 
            // lblServerHostname
            // 
            this.lblServerHostname.AutoSize = true;
            this.lblServerHostname.Location = new System.Drawing.Point(32, 72);
            this.lblServerHostname.Name = "lblServerHostname";
            this.lblServerHostname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblServerHostname.Size = new System.Drawing.Size(87, 13);
            this.lblServerHostname.TabIndex = 19;
            this.lblServerHostname.Text = "Server hostname";
            this.lblServerHostname.Click += new System.EventHandler(this.serverNameLabel_Click);
            // 
            // txtServerHostname
            // 
            this.txtServerHostname.Location = new System.Drawing.Point(125, 72);
            this.txtServerHostname.Name = "txtServerHostname";
            this.txtServerHostname.Size = new System.Drawing.Size(256, 20);
            this.txtServerHostname.TabIndex = 20;
            this.txtServerHostname.TextChanged += new System.EventHandler(this.ServerNameTextBox_TextChanged);
            // 
            // lblBinding
            // 
            this.lblBinding.AutoSize = true;
            this.lblBinding.Location = new System.Drawing.Point(32, 40);
            this.lblBinding.Name = "lblBinding";
            this.lblBinding.Size = new System.Drawing.Size(42, 13);
            this.lblBinding.TabIndex = 21;
            this.lblBinding.Text = "Binding";
            this.lblBinding.Click += new System.EventHandler(this.bindingLabel_Click);
            // 
            // drpBinding
            // 
            this.drpBinding.FormattingEnabled = true;
            this.drpBinding.Location = new System.Drawing.Point(125, 40);
            this.drpBinding.Name = "drpBinding";
            this.drpBinding.Size = new System.Drawing.Size(72, 21);
            this.drpBinding.TabIndex = 22;
            this.drpBinding.TextChanged += new System.EventHandler(this.BindingDropDown_TextChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(32, 104);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 23;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(125, 104);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(120, 20);
            this.txtUsername.TabIndex = 24;
            this.txtUsername.TextChanged += new System.EventHandler(this.UserNameTextBox_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(32, 136);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 25;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(125, 136);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(120, 20);
            this.txtPassword.TabIndex = 26;
            this.txtPassword.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // lblCreateCases
            // 
            this.lblCreateCases.AutoSize = true;
            this.lblCreateCases.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateCases.Location = new System.Drawing.Point(16, 496);
            this.lblCreateCases.Name = "lblCreateCases";
            this.lblCreateCases.Size = new System.Drawing.Size(81, 13);
            this.lblCreateCases.TabIndex = 29;
            this.lblCreateCases.Text = "Create cases";
            // 
            // lblBlaiseConnectionSettings
            // 
            this.lblBlaiseConnectionSettings.AutoSize = true;
            this.lblBlaiseConnectionSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlaiseConnectionSettings.Location = new System.Drawing.Point(12, 9);
            this.lblBlaiseConnectionSettings.Name = "lblBlaiseConnectionSettings";
            this.lblBlaiseConnectionSettings.Size = new System.Drawing.Size(156, 13);
            this.lblBlaiseConnectionSettings.TabIndex = 33;
            this.lblBlaiseConnectionSettings.Text = "Blaise connection settings";
            // 
            // line1
            // 
            this.line1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line1.Location = new System.Drawing.Point(16, 280);
            this.line1.MaximumSize = new System.Drawing.Size(375, 2);
            this.line1.MinimumSize = new System.Drawing.Size(375, 2);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(375, 2);
            this.line1.TabIndex = 35;
            this.line1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnInstallQuestionnaire
            // 
            this.btnInstallQuestionnaire.Location = new System.Drawing.Point(32, 432);
            this.btnInstallQuestionnaire.Name = "btnInstallQuestionnaire";
            this.btnInstallQuestionnaire.Size = new System.Drawing.Size(100, 29);
            this.btnInstallQuestionnaire.TabIndex = 36;
            this.btnInstallQuestionnaire.Text = "Install";
            this.btnInstallQuestionnaire.UseVisualStyleBackColor = true;
            this.btnInstallQuestionnaire.Click += new System.EventHandler(this.InstallQuestionnaireButton_Click);
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(149, 232);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(100, 29);
            this.btnTestConnection.TabIndex = 37;
            this.btnTestConnection.Text = "Test connection";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.TestConnectionButton_Click);
            // 
            // btnBrowseCaseFile
            // 
            this.btnBrowseCaseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseCaseFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowseCaseFile.Location = new System.Drawing.Point(312, 712);
            this.btnBrowseCaseFile.Name = "btnBrowseCaseFile";
            this.btnBrowseCaseFile.Size = new System.Drawing.Size(43, 22);
            this.btnBrowseCaseFile.TabIndex = 38;
            this.btnBrowseCaseFile.Text = "...";
            this.btnBrowseCaseFile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowseCaseFile.UseVisualStyleBackColor = true;
            this.btnBrowseCaseFile.Click += new System.EventHandler(this.BrowseCaseFileButton_Click);
            // 
            // lblCaseSample
            // 
            this.lblCaseSample.AutoSize = true;
            this.lblCaseSample.Location = new System.Drawing.Point(32, 712);
            this.lblCaseSample.Name = "lblCaseSample";
            this.lblCaseSample.Size = new System.Drawing.Size(67, 13);
            this.lblCaseSample.TabIndex = 39;
            this.lblCaseSample.Text = "Case sample";
            // 
            // txtCaseFile
            // 
            this.txtCaseFile.Location = new System.Drawing.Point(112, 712);
            this.txtCaseFile.Name = "txtCaseFile";
            this.txtCaseFile.Size = new System.Drawing.Size(184, 20);
            this.txtCaseFile.TabIndex = 40;
            // 
            // line3
            // 
            this.line3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line3.Location = new System.Drawing.Point(16, 480);
            this.line3.MaximumSize = new System.Drawing.Size(375, 2);
            this.line3.MinimumSize = new System.Drawing.Size(375, 2);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(375, 2);
            this.line3.TabIndex = 41;
            // 
            // lblInstallQuestionnaire
            // 
            this.lblInstallQuestionnaire.AutoSize = true;
            this.lblInstallQuestionnaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstallQuestionnaire.Location = new System.Drawing.Point(16, 376);
            this.lblInstallQuestionnaire.Name = "lblInstallQuestionnaire";
            this.lblInstallQuestionnaire.Size = new System.Drawing.Size(121, 13);
            this.lblInstallQuestionnaire.TabIndex = 42;
            this.lblInstallQuestionnaire.Text = "Install questionnaire";
            // 
            // drpServerPark
            // 
            this.drpServerPark.DropDownWidth = 100;
            this.drpServerPark.FormattingEnabled = true;
            this.drpServerPark.Location = new System.Drawing.Point(104, 320);
            this.drpServerPark.Name = "drpServerPark";
            this.drpServerPark.Size = new System.Drawing.Size(120, 21);
            this.drpServerPark.TabIndex = 43;
            this.drpServerPark.SelectedIndexChanged += new System.EventHandler(this.ServerParkDropDown_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(263, 232);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 29);
            this.btnRefresh.TabIndex = 44;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.RefreshQuestionnairesButton_Click);
            // 
            // drpQuestionnaireName
            // 
            this.drpQuestionnaireName.DropDownWidth = 200;
            this.drpQuestionnaireName.FormattingEnabled = true;
            this.drpQuestionnaireName.Location = new System.Drawing.Point(144, 520);
            this.drpQuestionnaireName.Name = "drpQuestionnaireName";
            this.drpQuestionnaireName.Size = new System.Drawing.Size(216, 21);
            this.drpQuestionnaireName.TabIndex = 45;
            this.drpQuestionnaireName.SelectedIndexChanged += new System.EventHandler(this.QuestionnaireDropDown_SelectedIndexChanged);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(32, 168);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(26, 13);
            this.lblPort.TabIndex = 46;
            this.lblPort.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(125, 168);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(72, 20);
            this.txtPort.TabIndex = 47;
            this.txtPort.TextChanged += new System.EventHandler(this.PortTextBox_TextChanged);
            // 
            // lblRemotePort
            // 
            this.lblRemotePort.AutoSize = true;
            this.lblRemotePort.Location = new System.Drawing.Point(32, 200);
            this.lblRemotePort.Name = "lblRemotePort";
            this.lblRemotePort.Size = new System.Drawing.Size(65, 13);
            this.lblRemotePort.TabIndex = 48;
            this.lblRemotePort.Text = "Remote port";
            // 
            // txtRemotePort
            // 
            this.txtRemotePort.Location = new System.Drawing.Point(125, 200);
            this.txtRemotePort.Name = "txtRemotePort";
            this.txtRemotePort.Size = new System.Drawing.Size(72, 20);
            this.txtRemotePort.TabIndex = 49;
            this.txtRemotePort.TextChanged += new System.EventHandler(this.RemotePortTextBox_TextChanged);
            // 
            // line2
            // 
            this.line2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line2.Location = new System.Drawing.Point(16, 360);
            this.line2.MaximumSize = new System.Drawing.Size(375, 2);
            this.line2.MinimumSize = new System.Drawing.Size(375, 2);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(375, 2);
            this.line2.TabIndex = 50;
            // 
            // lblSelectServerPark
            // 
            this.lblSelectServerPark.AutoSize = true;
            this.lblSelectServerPark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectServerPark.Location = new System.Drawing.Point(16, 296);
            this.lblSelectServerPark.Name = "lblSelectServerPark";
            this.lblSelectServerPark.Size = new System.Drawing.Size(111, 13);
            this.lblSelectServerPark.TabIndex = 51;
            this.lblSelectServerPark.Text = "Select server park";
            // 
            // lblCreateCasesFromSampleFile
            // 
            this.lblCreateCasesFromSampleFile.AutoSize = true;
            this.lblCreateCasesFromSampleFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateCasesFromSampleFile.Location = new System.Drawing.Point(16, 680);
            this.lblCreateCasesFromSampleFile.Name = "lblCreateCasesFromSampleFile";
            this.lblCreateCasesFromSampleFile.Size = new System.Drawing.Size(173, 13);
            this.lblCreateCasesFromSampleFile.TabIndex = 52;
            this.lblCreateCasesFromSampleFile.Text = "Create cases from sample file";
            // 
            // line4
            // 
            this.line4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line4.Location = new System.Drawing.Point(16, 664);
            this.line4.MaximumSize = new System.Drawing.Size(375, 2);
            this.line4.MinimumSize = new System.Drawing.Size(375, 2);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(375, 2);
            this.line4.TabIndex = 53;
            // 
            // btnCreateCasesFromFile
            // 
            this.btnCreateCasesFromFile.Location = new System.Drawing.Point(32, 744);
            this.btnCreateCasesFromFile.Name = "btnCreateCasesFromFile";
            this.btnCreateCasesFromFile.Size = new System.Drawing.Size(100, 29);
            this.btnCreateCasesFromFile.TabIndex = 54;
            this.btnCreateCasesFromFile.Text = "Create";
            this.btnCreateCasesFromFile.UseVisualStyleBackColor = true;
            this.btnCreateCasesFromFile.Click += new System.EventHandler(this.CreateFromSampleButton_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(35, 232);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 29);
            this.btnConnect.TabIndex = 55;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // BlaiseDataTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(410, 785);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnCreateCasesFromFile);
            this.Controls.Add(this.line4);
            this.Controls.Add(this.lblCreateCasesFromSampleFile);
            this.Controls.Add(this.lblSelectServerPark);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.txtRemotePort);
            this.Controls.Add(this.lblRemotePort);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.drpQuestionnaireName);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.drpServerPark);
            this.Controls.Add(this.lblInstallQuestionnaire);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.txtCaseFile);
            this.Controls.Add(this.lblCaseSample);
            this.Controls.Add(this.btnBrowseCaseFile);
            this.Controls.Add(this.btnTestConnection);
            this.Controls.Add(this.btnInstallQuestionnaire);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.lblBlaiseConnectionSettings);
            this.Controls.Add(this.lblCreateCases);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.drpBinding);
            this.Controls.Add(this.lblBinding);
            this.Controls.Add(this.txtServerHostname);
            this.Controls.Add(this.lblServerHostname);
            this.Controls.Add(this.lblServerPark);
            this.Controls.Add(this.lblQuestionnaireName);
            this.Controls.Add(this.btnCreateCases);
            this.Controls.Add(this.txtPrimaryKeyFrom);
            this.Controls.Add(this.lblPrimaryKeyFrom);
            this.Controls.Add(this.txtNumberOfCases);
            this.Controls.Add(this.lblNumberOfCases);
            this.Controls.Add(this.btnBrowseQuestionnaireFile);
            this.Controls.Add(this.lblQuestionnairePackage);
            this.Controls.Add(this.txtQuestionnaireFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BlaiseDataTool";
            this.Text = "Blaise Questionnaire Data Tool";
            this.Load += new System.EventHandler(this.BlaiseDataTool_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuestionnaireFile;
        private System.Windows.Forms.Label lblQuestionnairePackage;
        private System.Windows.Forms.Button btnBrowseQuestionnaireFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lblNumberOfCases;
        private System.Windows.Forms.TextBox txtNumberOfCases;
        private System.Windows.Forms.Label lblPrimaryKeyFrom;
        private System.Windows.Forms.TextBox txtPrimaryKeyFrom;
        private System.Windows.Forms.Button btnCreateCases;
        private System.Windows.Forms.Label lblQuestionnaireName;
        private System.Windows.Forms.Label lblServerPark;
        private System.Windows.Forms.Label lblServerHostname;
        private System.Windows.Forms.TextBox txtServerHostname;
        private System.Windows.Forms.Label lblBinding;
        private System.Windows.Forms.ComboBox drpBinding;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblCreateCases;
        private System.Windows.Forms.Label lblBlaiseConnectionSettings;
        private System.Windows.Forms.Label line1;
        private System.Windows.Forms.Button btnInstallQuestionnaire;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Button btnBrowseCaseFile;
        private System.Windows.Forms.Label lblCaseSample;
        private System.Windows.Forms.TextBox txtCaseFile;
        private System.Windows.Forms.Label line3;
        private System.Windows.Forms.Label lblInstallQuestionnaire;
        private System.Windows.Forms.ComboBox drpServerPark;
        private System.Windows.Forms.ComboBox drpQuestionnaireName;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblRemotePort;
        private System.Windows.Forms.TextBox txtRemotePort;
        private System.Windows.Forms.Label line2;
        private System.Windows.Forms.Label lblSelectServerPark;
        private System.Windows.Forms.Label lblCreateCasesFromSampleFile;
        private System.Windows.Forms.Label line4;
        private System.Windows.Forms.Button btnCreateCasesFromFile;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnConnect;
    }
}

