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
            this.txtHostname = new System.Windows.Forms.TextBox();
            this.lblBinding = new System.Windows.Forms.Label();
            this.cboBinding = new System.Windows.Forms.ComboBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cboServerPark = new System.Windows.Forms.ComboBox();
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
            this.lblQuestionnaireName = new System.Windows.Forms.Label();
            this.lblBlaiseConnectionSettings = new System.Windows.Forms.Label();
            this.btnInstallQuestionnaire = new System.Windows.Forms.Button();
            this.btnBrowseCaseFile = new System.Windows.Forms.Button();
            this.txtCaseFile = new System.Windows.Forms.TextBox();
            this.cboQuestionnaire = new System.Windows.Forms.ComboBox();
            this.btnCreateCasesFromFile = new System.Windows.Forms.Button();
            this.grpInstallQuestionnaire = new System.Windows.Forms.GroupBox();
            this.grpCreateCases = new System.Windows.Forms.GroupBox();
            this.tabCreateCases = new System.Windows.Forms.TabControl();
            this.tpDefault = new System.Windows.Forms.TabPage();
            this.lblPrimaryKeyFrom = new System.Windows.Forms.Label();
            this.txtPrimaryKeyFrom = new System.Windows.Forms.TextBox();
            this.lblNumberOfCases = new System.Windows.Forms.Label();
            this.txtNumberOfCases = new System.Windows.Forms.TextBox();
            this.btnCreateCases = new System.Windows.Forms.Button();
            this.tpFile = new System.Windows.Forms.TabPage();
            this.grpConnectionDetails.SuspendLayout();
            this.grpInstallQuestionnaire.SuspendLayout();
            this.grpCreateCases.SuspendLayout();
            this.tabCreateCases.SuspendLayout();
            this.tpDefault.SuspendLayout();
            this.tpFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConnectionDetails
            // 
            this.grpConnectionDetails.BackColor = System.Drawing.Color.Transparent;
            this.grpConnectionDetails.Controls.Add(this.lblServerHostname);
            this.grpConnectionDetails.Controls.Add(this.txtHostname);
            this.grpConnectionDetails.Controls.Add(this.lblBinding);
            this.grpConnectionDetails.Controls.Add(this.cboBinding);
            this.grpConnectionDetails.Controls.Add(this.lblUsername);
            this.grpConnectionDetails.Controls.Add(this.txtUsername);
            this.grpConnectionDetails.Controls.Add(this.lblPassword);
            this.grpConnectionDetails.Controls.Add(this.txtPassword);
            this.grpConnectionDetails.Controls.Add(this.cboServerPark);
            this.grpConnectionDetails.Controls.Add(this.lblPort);
            this.grpConnectionDetails.Controls.Add(this.txtPort);
            this.grpConnectionDetails.Controls.Add(this.lblRemotePort);
            this.grpConnectionDetails.Controls.Add(this.txtRemotePort);
            this.grpConnectionDetails.Controls.Add(this.btnConnect);
            this.grpConnectionDetails.Controls.Add(this.btnDisconnect);
            this.grpConnectionDetails.Controls.Add(this.lblServerPark);
            this.grpConnectionDetails.ForeColor = System.Drawing.Color.White;
            this.grpConnectionDetails.Location = new System.Drawing.Point(18, 13);
            this.grpConnectionDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grpConnectionDetails.Name = "grpConnectionDetails";
            this.grpConnectionDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grpConnectionDetails.Size = new System.Drawing.Size(366, 280);
            this.grpConnectionDetails.TabStop = false;
            this.grpConnectionDetails.Text = "Connection Details";
            // 
            // lblServerHostname
            // 
            this.lblServerHostname.AutoSize = true;
            this.lblServerHostname.Location = new System.Drawing.Point(16, 57);
            this.lblServerHostname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServerHostname.Name = "lblServerHostname";
            this.lblServerHostname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblServerHostname.Size = new System.Drawing.Size(62, 14);
            this.lblServerHostname.TabStop = false;
            this.lblServerHostname.Text = "Hostname";
            // 
            // txtHostname
            // 
            this.txtHostname.Location = new System.Drawing.Point(103, 54);
            this.txtHostname.Margin = new System.Windows.Forms.Padding(4);
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.Size = new System.Drawing.Size(246, 22);
            this.txtHostname.TabStop = false;
            // 
            // lblBinding
            // 
            this.lblBinding.AutoSize = true;
            this.lblBinding.Location = new System.Drawing.Point(16, 31);
            this.lblBinding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBinding.Name = "lblBinding";
            this.lblBinding.Size = new System.Drawing.Size(46, 14);
            this.lblBinding.TabStop = false;
            this.lblBinding.Text = "Binding";
            // 
            // cboBinding
            // 
            this.cboBinding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBinding.FormattingEnabled = true;
            this.cboBinding.Location = new System.Drawing.Point(103, 26);
            this.cboBinding.Margin = new System.Windows.Forms.Padding(4);
            this.cboBinding.Name = "cboBinding";
            this.cboBinding.Size = new System.Drawing.Size(65, 22);
            this.cboBinding.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(16, 83);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(61, 14);
            this.lblUsername.TabStop = false;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(103, 80);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(102, 22);
            this.txtUsername.TabStop = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(16, 109);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(58, 14);
            this.lblPassword.TabStop = false;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(103, 107);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(102, 22);
            this.txtPassword.TabStop = false;
            // 
            // cboServerPark
            // 
            this.cboServerPark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServerPark.DropDownWidth = 100;
            this.cboServerPark.FormattingEnabled = true;
            this.cboServerPark.Location = new System.Drawing.Point(103, 242);
            this.cboServerPark.Margin = new System.Windows.Forms.Padding(4);
            this.cboServerPark.Name = "cboServerPark";
            this.cboServerPark.Size = new System.Drawing.Size(102, 22);
            this.cboServerPark.TabStop = false;
            this.cboServerPark.SelectedIndexChanged += new System.EventHandler(this.cboServerPark_SelectedIndexChanged);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(16, 136);
            this.lblPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(30, 14);
            this.lblPort.TabStop = false;
            this.lblPort.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(103, 133);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(65, 22);
            this.txtPort.TabStop = false;
            // 
            // lblRemotePort
            // 
            this.lblRemotePort.AutoSize = true;
            this.lblRemotePort.Location = new System.Drawing.Point(16, 162);
            this.lblRemotePort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemotePort.Name = "lblRemotePort";
            this.lblRemotePort.Size = new System.Drawing.Size(77, 14);
            this.lblRemotePort.TabStop = false;
            this.lblRemotePort.Text = "Remote port";
            // 
            // txtRemotePort
            // 
            this.txtRemotePort.Location = new System.Drawing.Point(103, 159);
            this.txtRemotePort.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemotePort.Name = "txtRemotePort";
            this.txtRemotePort.Size = new System.Drawing.Size(65, 22);
            this.txtRemotePort.TabStop = false;
            // 
            // btnConnect
            // 
            this.btnConnect.ForeColor = System.Drawing.Color.Black;
            this.btnConnect.Location = new System.Drawing.Point(16, 194);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(97, 32);
            this.btnConnect.TabStop = false;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.ForeColor = System.Drawing.Color.Black;
            this.btnDisconnect.Location = new System.Drawing.Point(122, 194);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(95, 32);
            this.btnDisconnect.TabStop = false;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lblServerPark
            // 
            this.lblServerPark.AutoSize = true;
            this.lblServerPark.Location = new System.Drawing.Point(16, 247);
            this.lblServerPark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServerPark.Name = "lblServerPark";
            this.lblServerPark.Size = new System.Drawing.Size(69, 14);
            this.lblServerPark.TabStop = false;
            this.lblServerPark.Text = "Server park";
            // 
            // txtQuestionnaireFile
            // 
            this.txtQuestionnaireFile.Location = new System.Drawing.Point(18, 29);
            this.txtQuestionnaireFile.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuestionnaireFile.Name = "txtQuestionnaireFile";
            this.txtQuestionnaireFile.Size = new System.Drawing.Size(274, 22);
            this.txtQuestionnaireFile.TabStop = false;
            // 
            // btnBrowseQuestionnaireFile
            // 
            this.btnBrowseQuestionnaireFile.ForeColor = System.Drawing.Color.Black;
            this.btnBrowseQuestionnaireFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowseQuestionnaireFile.Location = new System.Drawing.Point(298, 28);
            this.btnBrowseQuestionnaireFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseQuestionnaireFile.Name = "btnBrowseQuestionnaireFile";
            this.btnBrowseQuestionnaireFile.Size = new System.Drawing.Size(50, 24);
            this.btnBrowseQuestionnaireFile.TabStop = false;
            this.btnBrowseQuestionnaireFile.Text = "...";
            this.btnBrowseQuestionnaireFile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowseQuestionnaireFile.UseVisualStyleBackColor = true;
            this.btnBrowseQuestionnaireFile.Click += new System.EventHandler(this.btnBrowseQuestionnaireFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // lblQuestionnaireName
            // 
            this.lblQuestionnaireName.AutoSize = true;
            this.lblQuestionnaireName.Location = new System.Drawing.Point(16, 32);
            this.lblQuestionnaireName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestionnaireName.Name = "lblQuestionnaireName";
            this.lblQuestionnaireName.Size = new System.Drawing.Size(82, 14);
            this.lblQuestionnaireName.TabStop = false;
            this.lblQuestionnaireName.Text = "Questionnaire";
            // 
            // lblBlaiseConnectionSettings
            // 
            this.lblBlaiseConnectionSettings.AutoSize = true;
            this.lblBlaiseConnectionSettings.Location = new System.Drawing.Point(12, 9);
            this.lblBlaiseConnectionSettings.Name = "lblBlaiseConnectionSettings";
            this.lblBlaiseConnectionSettings.Size = new System.Drawing.Size(156, 13);
            this.lblBlaiseConnectionSettings.TabStop = false;
            this.lblBlaiseConnectionSettings.Text = "Blaise connection settings";
            // 
            // btnInstallQuestionnaire
            // 
            this.btnInstallQuestionnaire.ForeColor = System.Drawing.Color.Black;
            this.btnInstallQuestionnaire.Location = new System.Drawing.Point(18, 58);
            this.btnInstallQuestionnaire.Margin = new System.Windows.Forms.Padding(4);
            this.btnInstallQuestionnaire.Name = "btnInstallQuestionnaire";
            this.btnInstallQuestionnaire.Size = new System.Drawing.Size(94, 32);
            this.btnInstallQuestionnaire.TabStop = false;
            this.btnInstallQuestionnaire.Text = "Install";
            this.btnInstallQuestionnaire.UseVisualStyleBackColor = true;
            this.btnInstallQuestionnaire.Click += new System.EventHandler(this.btnInstallQuestionnaire_Click);
            // 
            // btnBrowseCaseFile
            // 
            this.btnBrowseCaseFile.ForeColor = System.Drawing.Color.Black;
            this.btnBrowseCaseFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowseCaseFile.Location = new System.Drawing.Point(263, 14);
            this.btnBrowseCaseFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseCaseFile.Name = "btnBrowseCaseFile";
            this.btnBrowseCaseFile.Size = new System.Drawing.Size(50, 24);
            this.btnBrowseCaseFile.TabStop = false;
            this.btnBrowseCaseFile.Text = "...";
            this.btnBrowseCaseFile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowseCaseFile.UseVisualStyleBackColor = true;
            this.btnBrowseCaseFile.Click += new System.EventHandler(this.btnBrowseCaseFile_Click);
            // 
            // txtCaseFile
            // 
            this.txtCaseFile.ForeColor = System.Drawing.Color.Black;
            this.txtCaseFile.Location = new System.Drawing.Point(16, 14);
            this.txtCaseFile.Margin = new System.Windows.Forms.Padding(4);
            this.txtCaseFile.Name = "txtCaseFile";
            this.txtCaseFile.Size = new System.Drawing.Size(239, 22);
            this.txtCaseFile.TabStop = false;
            // 
            // cboQuestionnaire
            // 
            this.cboQuestionnaire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuestionnaire.DropDownWidth = 200;
            this.cboQuestionnaire.FormattingEnabled = true;
            this.cboQuestionnaire.Location = new System.Drawing.Point(103, 27);
            this.cboQuestionnaire.Margin = new System.Windows.Forms.Padding(4);
            this.cboQuestionnaire.Name = "cboQuestionnaire";
            this.cboQuestionnaire.Size = new System.Drawing.Size(246, 22);
            this.cboQuestionnaire.TabStop = false;
            // 
            // btnCreateCasesFromFile
            // 
            this.btnCreateCasesFromFile.ForeColor = System.Drawing.Color.Black;
            this.btnCreateCasesFromFile.Location = new System.Drawing.Point(16, 70);
            this.btnCreateCasesFromFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateCasesFromFile.Name = "btnCreateCasesFromFile";
            this.btnCreateCasesFromFile.Size = new System.Drawing.Size(116, 32);
            this.btnCreateCasesFromFile.TabStop = false;
            this.btnCreateCasesFromFile.Text = "Create";
            this.btnCreateCasesFromFile.UseVisualStyleBackColor = true;
            this.btnCreateCasesFromFile.Click += new System.EventHandler(this.btnCreateCasesFromFile_Click);
            // 
            // grpInstallQuestionnaire
            // 
            this.grpInstallQuestionnaire.BackColor = System.Drawing.Color.Transparent;
            this.grpInstallQuestionnaire.Controls.Add(this.txtQuestionnaireFile);
            this.grpInstallQuestionnaire.Controls.Add(this.btnBrowseQuestionnaireFile);
            this.grpInstallQuestionnaire.Controls.Add(this.btnInstallQuestionnaire);
            this.grpInstallQuestionnaire.ForeColor = System.Drawing.Color.White;
            this.grpInstallQuestionnaire.Location = new System.Drawing.Point(18, 303);
            this.grpInstallQuestionnaire.Name = "grpInstallQuestionnaire";
            this.grpInstallQuestionnaire.Size = new System.Drawing.Size(366, 103);
            this.grpInstallQuestionnaire.TabStop = false;
            this.grpInstallQuestionnaire.Text = "Install Questionnaire";
            // 
            // grpCreateCases
            // 
            this.grpCreateCases.BackColor = System.Drawing.Color.Transparent;
            this.grpCreateCases.Controls.Add(this.tabCreateCases);
            this.grpCreateCases.Controls.Add(this.lblQuestionnaireName);
            this.grpCreateCases.Controls.Add(this.cboQuestionnaire);
            this.grpCreateCases.ForeColor = System.Drawing.Color.White;
            this.grpCreateCases.Location = new System.Drawing.Point(18, 416);
            this.grpCreateCases.Name = "grpCreateCases";
            this.grpCreateCases.Size = new System.Drawing.Size(366, 222);
            this.grpCreateCases.TabStop = false;
            this.grpCreateCases.Text = "Create Cases";
            // 
            // tabCreateCases
            // 
            this.tabCreateCases.Controls.Add(this.tpDefault);
            this.tabCreateCases.Controls.Add(this.tpFile);
            this.tabCreateCases.Location = new System.Drawing.Point(16, 70);
            this.tabCreateCases.Name = "tabCreateCases";
            this.tabCreateCases.SelectedIndex = 0;
            this.tabCreateCases.Size = new System.Drawing.Size(332, 137);
            this.tabCreateCases.TabStop = false;
            // 
            // tpDefault
            // 
            this.tpDefault.Controls.Add(this.lblPrimaryKeyFrom);
            this.tpDefault.Controls.Add(this.txtPrimaryKeyFrom);
            this.tpDefault.Controls.Add(this.lblNumberOfCases);
            this.tpDefault.Controls.Add(this.txtNumberOfCases);
            this.tpDefault.Controls.Add(this.btnCreateCases);
            this.tpDefault.Cursor = System.Windows.Forms.Cursors.Default;
            this.tpDefault.Location = new System.Drawing.Point(4, 23);
            this.tpDefault.Name = "tpDefault";
            this.tpDefault.Padding = new System.Windows.Forms.Padding(3);
            this.tpDefault.Size = new System.Drawing.Size(324, 110);
            this.tpDefault.TabStop = false;
            this.tpDefault.Text = "Default";
            this.tpDefault.UseVisualStyleBackColor = true;
            // 
            // lblPrimaryKeyFrom
            // 
            this.lblPrimaryKeyFrom.AutoSize = true;
            this.lblPrimaryKeyFrom.ForeColor = System.Drawing.Color.Black;
            this.lblPrimaryKeyFrom.Location = new System.Drawing.Point(16, 18);
            this.lblPrimaryKeyFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrimaryKeyFrom.Name = "lblPrimaryKeyFrom";
            this.lblPrimaryKeyFrom.Size = new System.Drawing.Size(98, 14);
            this.lblPrimaryKeyFrom.TabStop = false;
            this.lblPrimaryKeyFrom.Text = "Primary key from";
            // 
            // txtPrimaryKeyFrom
            // 
            this.txtPrimaryKeyFrom.ForeColor = System.Drawing.Color.Black;
            this.txtPrimaryKeyFrom.Location = new System.Drawing.Point(120, 14);
            this.txtPrimaryKeyFrom.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrimaryKeyFrom.Name = "txtPrimaryKeyFrom";
            this.txtPrimaryKeyFrom.Size = new System.Drawing.Size(102, 22);
            this.txtPrimaryKeyFrom.TabStop = false;
            // 
            // lblNumberOfCases
            // 
            this.lblNumberOfCases.AutoSize = true;
            this.lblNumberOfCases.ForeColor = System.Drawing.Color.Black;
            this.lblNumberOfCases.Location = new System.Drawing.Point(16, 44);
            this.lblNumberOfCases.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfCases.Name = "lblNumberOfCases";
            this.lblNumberOfCases.Size = new System.Drawing.Size(98, 14);
            this.lblNumberOfCases.TabStop = false;
            this.lblNumberOfCases.Text = "Number of cases";
            // 
            // txtNumberOfCases
            // 
            this.txtNumberOfCases.ForeColor = System.Drawing.Color.Black;
            this.txtNumberOfCases.Location = new System.Drawing.Point(120, 40);
            this.txtNumberOfCases.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumberOfCases.Name = "txtNumberOfCases";
            this.txtNumberOfCases.Size = new System.Drawing.Size(102, 22);
            this.txtNumberOfCases.TabStop = false;
            // 
            // btnCreateCases
            // 
            this.btnCreateCases.ForeColor = System.Drawing.Color.Black;
            this.btnCreateCases.Location = new System.Drawing.Point(16, 70);
            this.btnCreateCases.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateCases.Name = "btnCreateCases";
            this.btnCreateCases.Size = new System.Drawing.Size(116, 32);
            this.btnCreateCases.TabStop = false;
            this.btnCreateCases.Text = "Create";
            this.btnCreateCases.UseVisualStyleBackColor = true;
            this.btnCreateCases.Click += new System.EventHandler(this.btnCreateCases_Click);
            // 
            // tpFile
            // 
            this.tpFile.Controls.Add(this.txtCaseFile);
            this.tpFile.Controls.Add(this.btnBrowseCaseFile);
            this.tpFile.Controls.Add(this.btnCreateCasesFromFile);
            this.tpFile.Location = new System.Drawing.Point(4, 23);
            this.tpFile.Name = "tpFile";
            this.tpFile.Padding = new System.Windows.Forms.Padding(3);
            this.tpFile.Size = new System.Drawing.Size(324, 110);
            this.tpFile.TabStop = false;
            this.tpFile.Text = "JSON File";
            this.tpFile.UseVisualStyleBackColor = true;
            // 
            // BlaiseDataTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(402, 653);
            this.Controls.Add(this.grpCreateCases);
            this.Controls.Add(this.grpInstallQuestionnaire);
            this.Controls.Add(this.grpConnectionDetails);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BlaiseDataTool";
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Blaise Questionnaire Data Tool";
            this.Load += new System.EventHandler(this.BlaiseDataTool_Load);
            this.grpConnectionDetails.ResumeLayout(false);
            this.grpConnectionDetails.PerformLayout();
            this.grpInstallQuestionnaire.ResumeLayout(false);
            this.grpInstallQuestionnaire.PerformLayout();
            this.grpCreateCases.ResumeLayout(false);
            this.grpCreateCases.PerformLayout();
            this.tabCreateCases.ResumeLayout(false);
            this.tpDefault.ResumeLayout(false);
            this.tpDefault.PerformLayout();
            this.tpFile.ResumeLayout(false);
            this.tpFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConnectionDetails;
        private System.Windows.Forms.TextBox txtQuestionnaireFile;
        private System.Windows.Forms.Button btnBrowseQuestionnaireFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lblQuestionnaireName;
        private System.Windows.Forms.Label lblServerPark;
        private System.Windows.Forms.Label lblServerHostname;
        private System.Windows.Forms.TextBox txtHostname;
        private System.Windows.Forms.Label lblBinding;
        private System.Windows.Forms.ComboBox cboBinding;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblBlaiseConnectionSettings;
        private System.Windows.Forms.Button btnInstallQuestionnaire;
        private System.Windows.Forms.Button btnBrowseCaseFile;
        private System.Windows.Forms.TextBox txtCaseFile;
        private System.Windows.Forms.ComboBox cboServerPark;
        private System.Windows.Forms.ComboBox cboQuestionnaire;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblRemotePort;
        private System.Windows.Forms.TextBox txtRemotePort;
        private System.Windows.Forms.Button btnCreateCasesFromFile;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.GroupBox grpInstallQuestionnaire;
        private System.Windows.Forms.GroupBox grpCreateCases;
        private System.Windows.Forms.TabControl tabCreateCases;
        private System.Windows.Forms.TabPage tpFile;
        private System.Windows.Forms.TabPage tpDefault;
        private System.Windows.Forms.Label lblPrimaryKeyFrom;
        private System.Windows.Forms.TextBox txtPrimaryKeyFrom;
        private System.Windows.Forms.Label lblNumberOfCases;
        private System.Windows.Forms.TextBox txtNumberOfCases;
        private System.Windows.Forms.Button btnCreateCases;
    }
}

