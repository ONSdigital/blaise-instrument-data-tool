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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlaiseDataTool));
            this.grpConnectionDetails = new System.Windows.Forms.GroupBox();
            this.lblServerHostname = new System.Windows.Forms.Label();
            this.txtServerHostname = new System.Windows.Forms.TextBox();
            this.lblBinding = new System.Windows.Forms.Label();
            this.drpBinding = new System.Windows.Forms.ComboBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.drpServerPark = new System.Windows.Forms.ComboBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblRemotePort = new System.Windows.Forms.Label();
            this.txtRemotePort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lblServerPark = new System.Windows.Forms.Label();
            this.txtQuestionnaireFile = new System.Windows.Forms.TextBox();
            this.btnBrowseQuestionnaireFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblNumberOfCases = new System.Windows.Forms.Label();
            this.txtNumberOfCases = new System.Windows.Forms.TextBox();
            this.lblPrimaryKeyFrom = new System.Windows.Forms.Label();
            this.txtPrimaryKeyFrom = new System.Windows.Forms.TextBox();
            this.btnCreateCases = new System.Windows.Forms.Button();
            this.lblQuestionnaireName = new System.Windows.Forms.Label();
            this.lblBlaiseConnectionSettings = new System.Windows.Forms.Label();
            this.btnInstallQuestionnaire = new System.Windows.Forms.Button();
            this.btnBrowseCaseFile = new System.Windows.Forms.Button();
            this.txtCaseFile = new System.Windows.Forms.TextBox();
            this.drpQuestionnaireName = new System.Windows.Forms.ComboBox();
            this.btnCreateCasesFromFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.createcases = new System.Windows.Forms.TabControl();
            this.Default = new System.Windows.Forms.TabPage();
            this.File = new System.Windows.Forms.TabPage();
            this.grpConnectionDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.createcases.SuspendLayout();
            this.Default.SuspendLayout();
            this.File.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConnectionDetails
            // 
            this.grpConnectionDetails.BackColor = System.Drawing.Color.Transparent;
            this.grpConnectionDetails.Controls.Add(this.lblServerHostname);
            this.grpConnectionDetails.Controls.Add(this.txtServerHostname);
            this.grpConnectionDetails.Controls.Add(this.lblBinding);
            this.grpConnectionDetails.Controls.Add(this.drpBinding);
            this.grpConnectionDetails.Controls.Add(this.lblUsername);
            this.grpConnectionDetails.Controls.Add(this.txtUsername);
            this.grpConnectionDetails.Controls.Add(this.lblPassword);
            this.grpConnectionDetails.Controls.Add(this.txtPassword);
            this.grpConnectionDetails.Controls.Add(this.drpServerPark);
            this.grpConnectionDetails.Controls.Add(this.lblPort);
            this.grpConnectionDetails.Controls.Add(this.txtPort);
            this.grpConnectionDetails.Controls.Add(this.lblRemotePort);
            this.grpConnectionDetails.Controls.Add(this.txtRemotePort);
            this.grpConnectionDetails.Controls.Add(this.btnConnect);
            this.grpConnectionDetails.Controls.Add(this.btnDisconnect);
            this.grpConnectionDetails.Controls.Add(this.lblServerPark);
            this.grpConnectionDetails.Location = new System.Drawing.Point(21, 15);
            this.grpConnectionDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grpConnectionDetails.Name = "grpConnectionDetails";
            this.grpConnectionDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grpConnectionDetails.Size = new System.Drawing.Size(418, 320);
            this.grpConnectionDetails.TabIndex = 0;
            this.grpConnectionDetails.TabStop = false;
            this.grpConnectionDetails.Text = "Connection Details";
            // 
            // lblServerHostname
            // 
            this.lblServerHostname.AutoSize = true;
            this.lblServerHostname.Location = new System.Drawing.Point(18, 65);
            this.lblServerHostname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServerHostname.Name = "lblServerHostname";
            this.lblServerHostname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblServerHostname.Size = new System.Drawing.Size(69, 16);
            this.lblServerHostname.TabIndex = 19;
            this.lblServerHostname.Text = "Hostname";
            this.lblServerHostname.Click += new System.EventHandler(this.serverNameLabel_Click);
            // 
            // txtServerHostname
            // 
            this.txtServerHostname.Location = new System.Drawing.Point(118, 62);
            this.txtServerHostname.Margin = new System.Windows.Forms.Padding(4);
            this.txtServerHostname.Name = "txtServerHostname";
            this.txtServerHostname.Size = new System.Drawing.Size(280, 22);
            this.txtServerHostname.TabIndex = 20;
            this.txtServerHostname.TextChanged += new System.EventHandler(this.ServerNameTextBox_TextChanged);
            // 
            // lblBinding
            // 
            this.lblBinding.AutoSize = true;
            this.lblBinding.Location = new System.Drawing.Point(18, 35);
            this.lblBinding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBinding.Name = "lblBinding";
            this.lblBinding.Size = new System.Drawing.Size(52, 16);
            this.lblBinding.TabIndex = 21;
            this.lblBinding.Text = "Binding";
            this.lblBinding.Click += new System.EventHandler(this.bindingLabel_Click);
            // 
            // drpBinding
            // 
            this.drpBinding.FormattingEnabled = true;
            this.drpBinding.Location = new System.Drawing.Point(118, 30);
            this.drpBinding.Margin = new System.Windows.Forms.Padding(4);
            this.drpBinding.Name = "drpBinding";
            this.drpBinding.Size = new System.Drawing.Size(74, 24);
            this.drpBinding.TabIndex = 22;
            this.drpBinding.TextChanged += new System.EventHandler(this.BindingDropDown_TextChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(18, 95);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(70, 16);
            this.lblUsername.TabIndex = 23;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(118, 92);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(116, 22);
            this.txtUsername.TabIndex = 24;
            this.txtUsername.TextChanged += new System.EventHandler(this.UserNameTextBox_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(18, 125);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 25;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(118, 122);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(116, 22);
            this.txtPassword.TabIndex = 26;
            this.txtPassword.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // drpServerPark
            // 
            this.drpServerPark.DropDownWidth = 100;
            this.drpServerPark.FormattingEnabled = true;
            this.drpServerPark.Location = new System.Drawing.Point(118, 277);
            this.drpServerPark.Margin = new System.Windows.Forms.Padding(4);
            this.drpServerPark.Name = "drpServerPark";
            this.drpServerPark.Size = new System.Drawing.Size(116, 24);
            this.drpServerPark.TabIndex = 43;
            this.drpServerPark.SelectedIndexChanged += new System.EventHandler(this.ServerParkDropDown_SelectedIndexChanged);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(18, 155);
            this.lblPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(31, 16);
            this.lblPort.TabIndex = 46;
            this.lblPort.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(118, 152);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(74, 22);
            this.txtPort.TabIndex = 47;
            this.txtPort.TextChanged += new System.EventHandler(this.PortTextBox_TextChanged);
            // 
            // lblRemotePort
            // 
            this.lblRemotePort.AutoSize = true;
            this.lblRemotePort.Location = new System.Drawing.Point(18, 185);
            this.lblRemotePort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemotePort.Name = "lblRemotePort";
            this.lblRemotePort.Size = new System.Drawing.Size(81, 16);
            this.lblRemotePort.TabIndex = 48;
            this.lblRemotePort.Text = "Remote port";
            // 
            // txtRemotePort
            // 
            this.txtRemotePort.Location = new System.Drawing.Point(118, 182);
            this.txtRemotePort.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemotePort.Name = "txtRemotePort";
            this.txtRemotePort.Size = new System.Drawing.Size(74, 22);
            this.txtRemotePort.TabIndex = 49;
            this.txtRemotePort.TextChanged += new System.EventHandler(this.RemotePortTextBox_TextChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(18, 222);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(111, 36);
            this.btnConnect.TabIndex = 55;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(140, 222);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(109, 36);
            this.btnDisconnect.TabIndex = 56;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lblServerPark
            // 
            this.lblServerPark.AutoSize = true;
            this.lblServerPark.Location = new System.Drawing.Point(18, 282);
            this.lblServerPark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServerPark.Name = "lblServerPark";
            this.lblServerPark.Size = new System.Drawing.Size(77, 16);
            this.lblServerPark.TabIndex = 17;
            this.lblServerPark.Text = "Server park";
            // 
            // txtQuestionnaireFile
            // 
            this.txtQuestionnaireFile.Location = new System.Drawing.Point(21, 33);
            this.txtQuestionnaireFile.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuestionnaireFile.Name = "txtQuestionnaireFile";
            this.txtQuestionnaireFile.Size = new System.Drawing.Size(312, 22);
            this.txtQuestionnaireFile.TabIndex = 0;
            // 
            // btnBrowseQuestionnaireFile
            // 
            this.btnBrowseQuestionnaireFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowseQuestionnaireFile.Location = new System.Drawing.Point(341, 30);
            this.btnBrowseQuestionnaireFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseQuestionnaireFile.Name = "btnBrowseQuestionnaireFile";
            this.btnBrowseQuestionnaireFile.Size = new System.Drawing.Size(57, 27);
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
            this.lblNumberOfCases.Location = new System.Drawing.Point(18, 50);
            this.lblNumberOfCases.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfCases.Name = "lblNumberOfCases";
            this.lblNumberOfCases.Size = new System.Drawing.Size(109, 16);
            this.lblNumberOfCases.TabIndex = 3;
            this.lblNumberOfCases.Text = "Number of cases";
            // 
            // txtNumberOfCases
            // 
            this.txtNumberOfCases.Location = new System.Drawing.Point(137, 46);
            this.txtNumberOfCases.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumberOfCases.Name = "txtNumberOfCases";
            this.txtNumberOfCases.Size = new System.Drawing.Size(116, 22);
            this.txtNumberOfCases.TabIndex = 4;
            // 
            // lblPrimaryKeyFrom
            // 
            this.lblPrimaryKeyFrom.AutoSize = true;
            this.lblPrimaryKeyFrom.Location = new System.Drawing.Point(18, 20);
            this.lblPrimaryKeyFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrimaryKeyFrom.Name = "lblPrimaryKeyFrom";
            this.lblPrimaryKeyFrom.Size = new System.Drawing.Size(107, 16);
            this.lblPrimaryKeyFrom.TabIndex = 5;
            this.lblPrimaryKeyFrom.Text = "Primary key from";
            this.lblPrimaryKeyFrom.Click += new System.EventHandler(this.lblPrimaryKeyFrom_Click);
            // 
            // txtPrimaryKeyFrom
            // 
            this.txtPrimaryKeyFrom.Location = new System.Drawing.Point(137, 16);
            this.txtPrimaryKeyFrom.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrimaryKeyFrom.Name = "txtPrimaryKeyFrom";
            this.txtPrimaryKeyFrom.Size = new System.Drawing.Size(116, 22);
            this.txtPrimaryKeyFrom.TabIndex = 6;
            // 
            // btnCreateCases
            // 
            this.btnCreateCases.Location = new System.Drawing.Point(18, 80);
            this.btnCreateCases.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateCases.Name = "btnCreateCases";
            this.btnCreateCases.Size = new System.Drawing.Size(133, 36);
            this.btnCreateCases.TabIndex = 11;
            this.btnCreateCases.Text = "Create";
            this.btnCreateCases.UseVisualStyleBackColor = true;
            this.btnCreateCases.Click += new System.EventHandler(this.CreateInDatabaseButton_Click);
            // 
            // lblQuestionnaireName
            // 
            this.lblQuestionnaireName.AutoSize = true;
            this.lblQuestionnaireName.Location = new System.Drawing.Point(18, 36);
            this.lblQuestionnaireName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestionnaireName.Name = "lblQuestionnaireName";
            this.lblQuestionnaireName.Size = new System.Drawing.Size(90, 16);
            this.lblQuestionnaireName.TabIndex = 15;
            this.lblQuestionnaireName.Text = "Questionnaire";
            this.lblQuestionnaireName.Click += new System.EventHandler(this.lblQuestionnaireName_Click);
            // 
            // lblBlaiseConnectionSettings
            // 
            this.lblBlaiseConnectionSettings.AutoSize = true;
            this.lblBlaiseConnectionSettings.Location = new System.Drawing.Point(12, 9);
            this.lblBlaiseConnectionSettings.Name = "lblBlaiseConnectionSettings";
            this.lblBlaiseConnectionSettings.Size = new System.Drawing.Size(156, 13);
            this.lblBlaiseConnectionSettings.TabIndex = 33;
            this.lblBlaiseConnectionSettings.Text = "Blaise connection settings";
            // 
            // btnInstallQuestionnaire
            // 
            this.btnInstallQuestionnaire.Location = new System.Drawing.Point(21, 66);
            this.btnInstallQuestionnaire.Margin = new System.Windows.Forms.Padding(4);
            this.btnInstallQuestionnaire.Name = "btnInstallQuestionnaire";
            this.btnInstallQuestionnaire.Size = new System.Drawing.Size(108, 36);
            this.btnInstallQuestionnaire.TabIndex = 36;
            this.btnInstallQuestionnaire.Text = "Install";
            this.btnInstallQuestionnaire.UseVisualStyleBackColor = true;
            this.btnInstallQuestionnaire.Click += new System.EventHandler(this.InstallQuestionnaireButton_Click);
            // 
            // btnBrowseCaseFile
            // 
            this.btnBrowseCaseFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowseCaseFile.Location = new System.Drawing.Point(301, 13);
            this.btnBrowseCaseFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseCaseFile.Name = "btnBrowseCaseFile";
            this.btnBrowseCaseFile.Size = new System.Drawing.Size(57, 27);
            this.btnBrowseCaseFile.TabIndex = 38;
            this.btnBrowseCaseFile.Text = "...";
            this.btnBrowseCaseFile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowseCaseFile.UseVisualStyleBackColor = true;
            this.btnBrowseCaseFile.Click += new System.EventHandler(this.BrowseCaseFileButton_Click);
            // 
            // txtCaseFile
            // 
            this.txtCaseFile.Location = new System.Drawing.Point(18, 16);
            this.txtCaseFile.Margin = new System.Windows.Forms.Padding(4);
            this.txtCaseFile.Name = "txtCaseFile";
            this.txtCaseFile.Size = new System.Drawing.Size(273, 22);
            this.txtCaseFile.TabIndex = 40;
            // 
            // drpQuestionnaireName
            // 
            this.drpQuestionnaireName.DropDownWidth = 200;
            this.drpQuestionnaireName.FormattingEnabled = true;
            this.drpQuestionnaireName.Location = new System.Drawing.Point(118, 31);
            this.drpQuestionnaireName.Margin = new System.Windows.Forms.Padding(4);
            this.drpQuestionnaireName.Name = "drpQuestionnaireName";
            this.drpQuestionnaireName.Size = new System.Drawing.Size(280, 24);
            this.drpQuestionnaireName.TabIndex = 45;
            this.drpQuestionnaireName.SelectedIndexChanged += new System.EventHandler(this.QuestionnaireDropDown_SelectedIndexChanged);
            // 
            // btnCreateCasesFromFile
            // 
            this.btnCreateCasesFromFile.Location = new System.Drawing.Point(18, 80);
            this.btnCreateCasesFromFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateCasesFromFile.Name = "btnCreateCasesFromFile";
            this.btnCreateCasesFromFile.Size = new System.Drawing.Size(133, 36);
            this.btnCreateCasesFromFile.TabIndex = 54;
            this.btnCreateCasesFromFile.Text = "Create";
            this.btnCreateCasesFromFile.UseVisualStyleBackColor = true;
            this.btnCreateCasesFromFile.Click += new System.EventHandler(this.CreateFromSampleButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtQuestionnaireFile);
            this.groupBox1.Controls.Add(this.btnBrowseQuestionnaireFile);
            this.groupBox1.Controls.Add(this.btnInstallQuestionnaire);
            this.groupBox1.Location = new System.Drawing.Point(21, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 118);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Install Questionnaire";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.createcases);
            this.groupBox2.Controls.Add(this.lblQuestionnaireName);
            this.groupBox2.Controls.Add(this.drpQuestionnaireName);
            this.groupBox2.Location = new System.Drawing.Point(21, 475);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 249);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create Cases";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // createcases
            // 
            this.createcases.Controls.Add(this.Default);
            this.createcases.Controls.Add(this.File);
            this.createcases.Location = new System.Drawing.Point(18, 80);
            this.createcases.Name = "createcases";
            this.createcases.SelectedIndex = 0;
            this.createcases.Size = new System.Drawing.Size(380, 157);
            this.createcases.TabIndex = 57;
            // 
            // Default
            // 
            this.Default.Controls.Add(this.lblPrimaryKeyFrom);
            this.Default.Controls.Add(this.txtPrimaryKeyFrom);
            this.Default.Controls.Add(this.lblNumberOfCases);
            this.Default.Controls.Add(this.txtNumberOfCases);
            this.Default.Controls.Add(this.btnCreateCases);
            this.Default.Location = new System.Drawing.Point(4, 25);
            this.Default.Name = "Default";
            this.Default.Padding = new System.Windows.Forms.Padding(3);
            this.Default.Size = new System.Drawing.Size(372, 128);
            this.Default.TabIndex = 0;
            this.Default.Text = "Default";
            this.Default.UseVisualStyleBackColor = true;
            // 
            // File
            // 
            this.File.Controls.Add(this.txtCaseFile);
            this.File.Controls.Add(this.btnBrowseCaseFile);
            this.File.Controls.Add(this.btnCreateCasesFromFile);
            this.File.Location = new System.Drawing.Point(4, 25);
            this.File.Name = "File";
            this.File.Padding = new System.Windows.Forms.Padding(3);
            this.File.Size = new System.Drawing.Size(372, 128);
            this.File.TabIndex = 1;
            this.File.Text = "JSON File";
            this.File.UseVisualStyleBackColor = true;
            // 
            // BlaiseDataTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(460, 743);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpConnectionDetails);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BlaiseDataTool";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = " ";
            this.Load += new System.EventHandler(this.BlaiseDataTool_Load);
            this.grpConnectionDetails.ResumeLayout(false);
            this.grpConnectionDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.createcases.ResumeLayout(false);
            this.Default.ResumeLayout(false);
            this.Default.PerformLayout();
            this.File.ResumeLayout(false);
            this.File.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConnectionDetails;
        private System.Windows.Forms.TextBox txtQuestionnaireFile;
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
        private System.Windows.Forms.Label lblBlaiseConnectionSettings;
        private System.Windows.Forms.Button btnInstallQuestionnaire;
        private System.Windows.Forms.Button btnBrowseCaseFile;
        private System.Windows.Forms.TextBox txtCaseFile;
        private System.Windows.Forms.ComboBox drpServerPark;
        private System.Windows.Forms.ComboBox drpQuestionnaireName;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblRemotePort;
        private System.Windows.Forms.TextBox txtRemotePort;
        private System.Windows.Forms.Button btnCreateCasesFromFile;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl createcases;
        private System.Windows.Forms.TabPage Default;
        private System.Windows.Forms.TabPage File;
    }
}

