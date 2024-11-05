using System;
using System.Linq;
using System.Windows.Forms;
using Blaise.Nuget.Api.Contracts.Models;
using Blaise.Nuget.Api.Providers;
using Blaise.Questionnaire.Data.Tool.Gui.Extensions;
using Blaise.Questionnaire.Data.Tool.Helpers;
using System.IO;

namespace Blaise.Questionnaire.Data.Tool.Gui
{
    public partial class BlaiseQuestionnaireDataTool : Form
    {
        private ConnectionModel _connectionModel;

        public BlaiseQuestionnaireDataTool()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            UpdateUIOnConnectionStatus(false);
        }

        private void BlaiseQuestionnaireDataTool_Load(object sender, EventArgs e)
        {
            txtPrimaryKeyFrom.Text = "9001";
            txtNumberOfCases.Text = "10";
            cboBinding.Items.AddRange(new object[] { "HTTP", "HTTPS" });
            cboBinding.SelectedIndex = 0;
            _connectionModel = GetConnectionModelFromConfig();
            txtHostname.Text = _connectionModel?.ServerName;
            txtUsername.Text = _connectionModel?.UserName;
            txtPassword.Text = _connectionModel?.Password;
            txtPort.Text = _connectionModel?.Port.ToString();
            txtRemotePort.Text = _connectionModel?.RemotePort.ToString();
            ConfigureBinding();
        }

        private ConnectionModel GetConnectionModelFromConfig()
        {
            var blaiseConfigurationProvider = new BlaiseConfigurationProvider();
            try
            {
                return blaiseConfigurationProvider.GetConnectionModel();
            }
            catch
            {
                return new ConnectionModel
                {
                    Binding = cboBinding.SelectedItem.ToString(),
                    Port = int.Parse(txtPort.Text),
                    RemotePort = int.Parse(txtRemotePort.Text),
                };
            }
        }

        private void ConfigureBinding()
        {
            foreach (var item in cboBinding.Items)
            {
                if (!_connectionModel.Binding.Equals(item.ToString(), StringComparison.CurrentCultureIgnoreCase))
                {
                    continue;
                }
                cboBinding.SelectedItem = item;
                break;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                _connectionModel = new ConnectionModel();
                _connectionModel.ServerName = txtHostname.Text;
                _connectionModel.UserName = txtUsername.Text;
                _connectionModel.Password = txtPassword.Text;
                _connectionModel.Binding = cboBinding.Text;
                _connectionModel.Port = int.Parse(txtPort.Text);
                _connectionModel.RemotePort = int.Parse(txtRemotePort.Text);
                PopulateServerParkAndQuestionnaire();                
                if (ConnectionHelper.GetInstance(_connectionModel).ConnectionSuccessful)
                {
                    UpdateUIOnConnectionStatus(true);
                    MessageBox.Show("Connection successful", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Connection failed \n\n" + exception.Message, "Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            _connectionModel = null;            
            cboServerPark.Items.Clear();
            cboQuestionnaire.Items.Clear();
            UpdateUIOnConnectionStatus(false);
        }

        private void UpdateUIOnConnectionStatus(bool isConnected)
        {
            btnConnect.Enabled = !isConnected;            
            txtHostname.Enabled = !isConnected;
            txtUsername.Enabled = !isConnected;
            txtPassword.Enabled = !isConnected;
            txtPort.Enabled = !isConnected;
            txtRemotePort.Enabled = !isConnected;
            cboBinding.Enabled = !isConnected;
            cboServerPark.Enabled = isConnected;
            cboQuestionnaire.Enabled = isConnected;
            grpInstallQuestionnaire.Enabled = isConnected;
            grpCreateCases.Enabled = isConnected;
            btnDisconnect.Enabled = isConnected;
        }

        private void PopulateServerParkAndQuestionnaire()
        {
            if (!ConnectionHelper.GetInstance(_connectionModel).ConnectionModelValid)
            {
                return;
            }
            var serverParks = ServerParkHelper.GetInstance(_connectionModel).GetServerParks();
            cboServerPark.Items.Clear();
            cboServerPark.Items.AddRange(serverParks.Cast<object>().ToArray());
            cboServerPark.SelectedIndex = 0;
            var serverParkName = cboServerPark.SelectedItem?.ToString();
            var questionnaires = QuestionnaireHelper.GetInstance(_connectionModel).GetQuestionnaires(serverParkName).ToList();
            if (!questionnaires.Any())
            {
                return;
            }
            cboQuestionnaire.Items.Clear();
            cboQuestionnaire.Items.AddRange(questionnaires.Cast<object>().ToArray());
            cboQuestionnaire.SelectedIndex = 0;
        }

        private void cboServerPark_SelectedIndexChanged(object sender, EventArgs e)
        {
            var serverParkName = cboServerPark.SelectedItem?.ToString();
            var questionnaires = QuestionnaireHelper.GetInstance(_connectionModel).GetQuestionnaires(serverParkName).ToList();
            if (!questionnaires.Any())
            {
                return;
            }
            cboQuestionnaire.Items.Clear();
            cboQuestionnaire.Items.AddRange(questionnaires.Cast<object>().ToArray());
            cboQuestionnaire.SelectedIndex = 0;
        }

        private void btnBrowseQuestionnaireFile_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.Filter = "BPKG files (*.bpkg)|*.bpkg|ZIP files (*.zip)|*.zip";
            var fileDialogResult = openFileDialog.ShowDialog();
            if (fileDialogResult == DialogResult.OK)
            {
                txtQuestionnaireFile.Text = openFileDialog.FileName;
            }
            else if (fileDialogResult == DialogResult.Cancel)
            {
                txtQuestionnaireFile.Text = "";
            }
            else
            {
                MessageBox.Show(@"Error selecting file", @"File selector", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInstallQuestionnaire_Click(object sender, EventArgs e)
        {
            var questionnaireFile = txtQuestionnaireFile.GetNullableStringValue();
            var questionnaireName = System.IO.Path.GetFileNameWithoutExtension(txtQuestionnaireFile.Text);
            var serverPark = cboServerPark.SelectedItem?.ToString();
            if (questionnaireFile == null)
            {
                MessageBox.Show("Please select a questionnaire package file", "Install questionnaire", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Cursor = Cursors.WaitCursor;
            try
            {
                QuestionnaireHelper.GetInstance(_connectionModel).InstallQuestionnaire(questionnaireName, serverPark, questionnaireFile);
                PopulateServerParkAndQuestionnaire();
                txtQuestionnaireFile.Text = "";
                System.Media.SystemSounds.Beep.Play();
                this.Activate();
                MessageBox.Show("Install successful", "Install questionnaire", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show("Install questionnaire failed \n\n" + exception.Message, "Install questionnaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnCreateCases_Click(object sender, EventArgs e)
        {
            var numberOfCases = txtNumberOfCases.GetNullableIntegerValue();
            var primaryKeyFrom = txtPrimaryKeyFrom.GetNullableIntegerValue();
            var questionnaireName = cboQuestionnaire.SelectedItem?.ToString();
            var serverPark = cboServerPark.SelectedItem?.ToString();
            if (numberOfCases == null || primaryKeyFrom == null)
            {
                MessageBox.Show("Please provide primary key from and number of cases", "Create cases", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Cursor = Cursors.WaitCursor;
            try
            {
                CaseHelper.GetInstance(_connectionModel).CreateCasesInBlaise((int)numberOfCases, questionnaireName, serverPark, (int)primaryKeyFrom);
                System.Media.SystemSounds.Beep.Play();
                this.Activate();
                MessageBox.Show("Created cases successfully", "Create cases", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Create cases failed \n\n" + exception.Message, "Create cases", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnBrowseCaseFile_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.Filter = "JSON files (*.json)|*.json";
            var caseFilesDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Blaise.Questionnaire.Data.Tool.Helpers\CaseFiles");
            // to do - fix ^
            if (Directory.Exists(caseFilesDirectory))
            {
                openFileDialog.InitialDirectory = caseFilesDirectory;
            }
            var fileDialogResult = openFileDialog.ShowDialog();
            if (fileDialogResult == DialogResult.OK)
            {
                txtCaseFile.Text = openFileDialog.FileName;
            }
            else if (fileDialogResult == DialogResult.Cancel)
            {
                txtCaseFile.Text = "";
            }
            else
            {
                MessageBox.Show(@"Error selecting file", @"File selector", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateCasesFromFile_Click(object sender, EventArgs e)
        {
            var questionnaireName = cboQuestionnaire.SelectedItem?.ToString();
            var serverPark = cboServerPark.SelectedItem?.ToString();
            var caseFile = txtCaseFile.GetNullableStringValue();
            if (caseFile is null)
            {
                MessageBox.Show("Please select a case JSON file", "Create cases", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Cursor = Cursors.WaitCursor;
            try
            {
                CaseHelper.GetInstance(_connectionModel).CreateCasesInBlaise(questionnaireName, serverPark, caseFile);
                System.Media.SystemSounds.Beep.Play();
                this.Activate();
                MessageBox.Show("Created cases successfully", "Create cases", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show("Create cases failed \n\n" + exception.Message, "Create cases", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}