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
            _connectionModel = new ConnectionModel();
        }

        private void BlaiseDataTool_Load(object sender, EventArgs e)
        {
            txtPrimaryKeyFrom.Text = @"9001";
            txtNumberOfCases.Text = @"10";
            drpBinding.Items.AddRange(new object[] { "HTTP", "HTTPS" });
            drpBinding.SelectedIndex = 0;

            _connectionModel = GetConnectionModelFromConfig();

            txtServerHostname.Text = _connectionModel?.ServerName;
            txtUsername.Text = _connectionModel?.UserName;
            txtPassword.Text = _connectionModel?.Password;
            txtPort.Text = _connectionModel?.Port.ToString();
            txtRemotePort.Text = _connectionModel?.RemotePort.ToString();

            ConfigureBindingDropDown();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show("No sample file was selected", @"Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show($"There was an error creating the cases - {exception.Message}", @"Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ServerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            var value = txtServerHostname.GetNullableStringValue();
            if (value == null) return;
            _connectionModel.ServerName = value;
        }

        private void BindingDropDown_TextChanged(object sender, EventArgs e)
        {
            var value = drpBinding.GetNullableStringValue();
            if (value == null) return;
            _connectionModel.Binding = value;
        }

        private void UserNameTextBox_TextChanged(object sender, EventArgs e)
        {
            var value = txtUsername.GetNullableStringValue();
            if (value == null) return;
            _connectionModel.UserName = value;
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            var value = txtPassword.GetNullableStringValue();
            if (value == null) return;
            _connectionModel.Password = value;
        }

        private void PortTextBox_TextChanged(object sender, EventArgs e)
        {
            var value = txtPort.GetNullableIntegerValue();
            if (value == null) return;
            _connectionModel.Port = (int)value;
        }

        private void RemotePortTextBox_TextChanged(object sender, EventArgs e)
        {
            var value = txtRemotePort.GetNullableIntegerValue();
            if (value == null) return;
            _connectionModel.RemotePort = (int)value;
        }

        private void TestConnectionButton_Click(object sender, EventArgs e)
        {
            if (TestBlaiseConnectionIsCorrect())
            {
                MessageBox.Show(@"Connection successful", @"Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(@"Connection details appear to be incorrect", @"Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InstallQuestionnaireButton_Click(object sender, EventArgs e)
        {
            var questionnaireFile = txtQuestionnaireFile.GetNullableStringValue();
            var questionnaireName = drpQuestionnaireName.SelectedItem?.ToString();
            var serverParkName = drpServerPark.SelectedItem?.ToString();

            if (questionnaireFile == null || questionnaireName == null || serverParkName == null)
            {
                MessageBox.Show(@"There are some null or incorrect values", @"Create cases in database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                QuestionnaireHelper.GetInstance(_connectionModel).InstallQuestionnaire(questionnaireName, serverParkName, questionnaireFile);
                MessageBox.Show(@"Installation successful", @"Install Questionnaire", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            PopulateDropDowns();
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
                    Binding = drpBinding.SelectedItem.ToString(),
                    Port = int.Parse(txtPort.Text),
                    RemotePort = int.Parse(txtRemotePort.Text),
                };
            }
        }

        private void ConfigureBindingDropDown()
        {
            foreach (var item in drpBinding.Items)
            {
                if (!_connectionModel.Binding.Equals(item.ToString(), StringComparison.CurrentCultureIgnoreCase))
                {
                    continue;
                }

                drpBinding.SelectedItem = item;
                break;
            }
        }

        private bool TestBlaiseConnectionIsCorrect()
        {
            if (txtServerHostname.GetNullableStringValue() == null ||
                txtUsername.GetNullableStringValue() == null ||
                txtPassword.GetNullableStringValue() == null ||
                txtPort.GetNullableIntegerValue() == null ||
                txtRemotePort.GetNullableIntegerValue() == null)
            {
                return false;
            }

            return ConnectionHelper.GetInstance(_connectionModel).ConnectionSuccessful;
        }

        private void PopulateDropDowns()
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

        private void bindingLabel_Click(object sender, EventArgs e)
        {
            // Add functionality if needed
        }

        private void serverNameLabel_Click(object sender, EventArgs e)
        {
            // Add functionality if needed
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Add functionality if needed
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

        private void QuestionnaireDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Add functionality if needed
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                Environment.SetEnvironmentVariable("ENV_BLAISE_SERVER_HOST_NAME", txtServerHostname.Text);
                Environment.SetEnvironmentVariable("ENV_BLAISE_ADMIN_USER", txtUsername.Text);
                Environment.SetEnvironmentVariable("ENV_BLAISE_ADMIN_PASSWORD", txtPassword.Text);
                Environment.SetEnvironmentVariable("ENV_BLAISE_SERVER_BINDING", drpBinding.Text);
                Environment.SetEnvironmentVariable("ENV_BLAISE_CONNECTION_PORT", txtPort.Text);
                Environment.SetEnvironmentVariable("ENV_BLAISE_REMOTE_CONNECTION_PORT", txtRemotePort.Text);
                
                _connectionModel = GetConnectionModelFromConfig();
                ConfigureBindingDropDown();
                PopulateDropDowns();
                btnConnect.Enabled = false;

                if (ConnectionHelper.GetInstance(_connectionModel).ConnectionSuccessful)
                {
                    MessageBox.Show(@"Connection successful", @"Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lblQuestionnaireName_Click(object sender, EventArgs e)
        {

        }

        private void lblPrimaryKeyFrom_Click(object sender, EventArgs e)
        {

        }
    }
}