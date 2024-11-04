using System;
using System.Linq;
using System.Windows.Forms;
using Blaise.Nuget.Api.Contracts.Models;
using Blaise.Nuget.Api.Providers;
using Blaise.Questionnaire.Data.Gui.Extensions;
using Blaise.Questionnaire.Data.Helpers;

namespace Blaise.Questionnaire.Data.Gui
{
    public partial class BlaiseDataTool : Form
    {
        private ConnectionModel _connectionModel;

        public BlaiseDataTool()
        {
            InitializeComponent();
            UpdateUIOnConnectionStatus(false);
        }

        private void BlaiseDataTool_Load(object sender, EventArgs e)
        {
            txtPrimaryKeyFrom.Text = @"9001";
            txtNumberOfCases.Text = @"10";
            cboBinding.Items.AddRange(new object[] { "HTTP", "HTTPS" });
            cboBinding.SelectedIndex = 0;
            _connectionModel = GetConnectionModelFromConfig();
            txtHostname.Text = _connectionModel?.ServerName;
            txtUsername.Text = _connectionModel?.UserName;
            txtPassword.Text = _connectionModel?.Password;
            txtPort.Text = _connectionModel?.Port.ToString();
            txtRemotePort.Text = _connectionModel?.RemotePort.ToString();
            ConfigureBindingDropDown();
        }

        private void btnBrowseQuestionnaireFile_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.Filter = "BPKG files (*.bpkg)|*.bpkg|ZIP files (*.zip)|*.zip";
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtQuestionnaireFile.Text = openFileDialog.FileName;
            }
            else
            {
                MessageBox.Show(@"There was an error in selecting a file", @"File selector", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateInDatabaseButton_Click(object sender, EventArgs e)
        {
            var numberOfCases = txtNumberOfCases.GetNullableIntegerValue();
            var primaryKeyValue = txtPrimaryKeyFrom.GetNullableIntegerValue();
            var questionnaireName = drpQuestionnaireName.SelectedItem?.ToString();
            var serverParkName = drpServerPark.SelectedItem?.ToString();

            if (numberOfCases == null || primaryKeyValue == null || questionnaireName == null || serverParkName == null)
            {
                MessageBox.Show(@"There are some null or incorrect values", @"Create cases in database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                CaseHelper.GetInstance(_connectionModel).CreateCasesInBlaise((int)numberOfCases, questionnaireName, serverParkName, (int)primaryKeyValue);
                MessageBox.Show(@"Cases created successfully", @"Create cases", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show($"There was an error creating the cases - {exception.Message}", @"Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateFromSampleButton_Click(object sender, EventArgs e)
        {
            var questionnaireName = drpQuestionnaireName.SelectedItem?.ToString();
            var serverParkName = drpServerPark.SelectedItem?.ToString();
            var caseSampleFile = txtCaseFile.GetNullableStringValue();

            if (caseSampleFile is null)
            {
                MessageBox.Show("No sample file was selected", @"Create cases", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                CaseHelper.GetInstance(_connectionModel).CreateCasesInBlaise(questionnaireName, serverParkName, caseSampleFile);
                MessageBox.Show(@"Cases created successfully", @"Create cases", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show($"There was an error creating the cases - {exception.Message}", @"Create cases", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InstallQuestionnaireButton_Click(object sender, EventArgs e)
        {
            var questionnaireFile = txtQuestionnaireFile.GetNullableStringValue();
            var questionnaireName = drpQuestionnaireName.SelectedItem?.ToString();
            var serverParkName = drpServerPark.SelectedItem?.ToString();

            if (questionnaireFile == null || questionnaireName == null || serverParkName == null)
            {
                MessageBox.Show(@"There are some null or incorrect values", @"Install questionnaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                QuestionnaireHelper.GetInstance(_connectionModel).InstallQuestionnaire(questionnaireName, serverParkName, questionnaireFile);
                MessageBox.Show(@"Installation successful", @"Install Questionnaire", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulateServerParkAndQuestionnaire();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show($"There was an error installing the questionnaire - {exception.Message}", @"Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BrowseCaseFileButton_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtCaseFile.Text = openFileDialog.FileName;
            }
            else
            {
                MessageBox.Show(@"There was an error in selecting a file", @"File selector", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshQuestionnairesButton_Click(object sender, EventArgs e)
        {
            if (!TestBlaiseConnectionIsCorrect())
            {
                MessageBox.Show("There is an issue with the configuration", @"Refresh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PopulateServerParkAndQuestionnaire();
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

        private void ConfigureBindingDropDown()
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

        private bool TestBlaiseConnectionIsCorrect()
        {
            if (txtHostname.GetNullableStringValue() == null ||
                txtUsername.GetNullableStringValue() == null ||
                txtPassword.GetNullableStringValue() == null ||
                txtPort.GetNullableIntegerValue() == null ||
                txtRemotePort.GetNullableIntegerValue() == null)
            {
                return false;
            }

            return ConnectionHelper.GetInstance(_connectionModel).ConnectionSuccessful;
        }

        private void PopulateServerParkAndQuestionnaire()
        {
            if (!ConnectionHelper.GetInstance(_connectionModel).ConnectionModelValid)
            {
                return;
            }

            var serverParks = ServerParkHelper.GetInstance(_connectionModel).GetServerParks();
            drpServerPark.Items.Clear();
            drpServerPark.Items.AddRange(serverParks.Cast<object>().ToArray());
            drpServerPark.SelectedIndex = 0;

            var serverParkName = drpServerPark.SelectedItem?.ToString();
            var questionnaires = QuestionnaireHelper.GetInstance(_connectionModel).GetQuestionnaires(serverParkName).ToList();
            if (!questionnaires.Any())
            {
                return;
            }

            drpQuestionnaireName.Items.Clear();
            drpQuestionnaireName.Items.AddRange(questionnaires.Cast<object>().ToArray());
            drpQuestionnaireName.SelectedIndex = 0;
        }


        private void ServerParkDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            var serverParkName = drpServerPark.SelectedItem?.ToString();
            var questionnaires = QuestionnaireHelper.GetInstance(_connectionModel).GetQuestionnaires(serverParkName).ToList();
            if (!questionnaires.Any())
            {
                return;
            }

            drpQuestionnaireName.Items.Clear();
            drpQuestionnaireName.Items.AddRange(questionnaires.Cast<object>().ToArray());
            drpQuestionnaireName.SelectedIndex = 0;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                _connectionModel = new ConnectionModel(); // Ensure this is the correct initialization

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
                    MessageBox.Show(@"Connection successful", @"Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("Connection failed: Invalid connection details.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            _connectionModel = null;            
            drpServerPark.Items.Clear();
            drpQuestionnaireName.Items.Clear();
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
            drpServerPark.Enabled = isConnected;
            drpQuestionnaireName.Enabled = isConnected;
            grpInstallQuestionnaire.Enabled = isConnected;
            grpCreateCases.Enabled = isConnected;
            btnDisconnect.Enabled = isConnected;

        }


    }
}