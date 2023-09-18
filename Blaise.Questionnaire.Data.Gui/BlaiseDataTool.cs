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
            //primary key
            PrimaryKeyFromTextbox.Text = @"900000";

            //number of cases
            NumberOfCasesTextBox.Text = @"10";

            //binding options
            BindingDropDown.Items.AddRange(new object[] { "HTTP", "HTTPS" });
            BindingDropDown.SelectedIndex = 0;

            //connection model
            _connectionModel = GetConnectionModelFromConfig();

            ServerNameTextBox.Text = _connectionModel?.ServerName;
            UserNameTextBox.Text = _connectionModel?.UserName;
            PasswordTextBox.Text = _connectionModel?.Password;
            PortTextBox.Text = _connectionModel?.Port.ToString();
            RemotePortTextBox.Text = _connectionModel?.RemotePort.ToString();

            ConfigureBindingDropDown();

            RefreshLists();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                QuestionnaireFileTextBox.Text = openFileDialog.FileName;
            }
            else
            {
                MessageBox.Show(@"There was an error in selecting a file", @"File selector",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateInDatabaseButton_Click(object sender, EventArgs e)
        {
            var numberOfCases = NumberOfCasesTextBox.GetNullableIntegerValue();
            var primaryKeyValue = PrimaryKeyFromTextbox.GetNullableIntegerValue();
            var questionnaireName = QuestionnaireDropDown.SelectedItem?.ToString();
            var serverParkName = ServerParkDropDown.SelectedItem?.ToString();

            if (numberOfCases == null || primaryKeyValue == null ||
                questionnaireName == null || serverParkName == null)
            {
                MessageBox.Show(@"There are some null or incorrect values", @"Create cases in database",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                CaseHelper
                    .GetInstance(_connectionModel)
                    .CreateCasesInBlaise((int)numberOfCases, questionnaireName, serverParkName, (int)primaryKeyValue);

                MessageBox.Show(@"Cases created successfully", @"Create cases", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show($"There was an error creating the cases - {exception.Message}",
                    @"Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateFromSampleButton_Click(object sender, EventArgs e)
        {
            var questionnaireName = QuestionnaireDropDown.SelectedItem?.ToString();
            var serverParkName = ServerParkDropDown.SelectedItem?.ToString();
            var caseSampleFile = CaseSampleFileTextBox.GetNullableStringValue();
            if (caseSampleFile is null)
            {
                MessageBox.Show("No sample file was selected",
                    @"Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                CaseHelper
                    .GetInstance(_connectionModel)
                    .CreateCasesInBlaise(questionnaireName, serverParkName, caseSampleFile);

                MessageBox.Show(@"Cases created successfully", @"Create cases", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show($"There was an error creating the cases - {exception.Message}",
                    @"Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ServerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            var value = ServerNameTextBox.GetNullableStringValue();

            if (value == null) return;

            _connectionModel.ServerName = value;
        }

        private void BindingDropDown_TextChanged(object sender, EventArgs e)
        {
            var value = BindingDropDown.GetNullableStringValue();

            if (value == null) return;

            _connectionModel.Binding = value;
        }

        private void UserNameTextBox_TextChanged(object sender, EventArgs e)
        {
            var value = UserNameTextBox.GetNullableStringValue();

            if (value == null) return;

            _connectionModel.UserName = value;
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            var value = PasswordTextBox.GetNullableStringValue();

            if (value == null) return;

            _connectionModel.Password = value;
        }

        private void PortTextBox_TextChanged(object sender, EventArgs e)
        {
            var value = PortTextBox.GetNullableIntegerValue();

            if (value == null) return;

            _connectionModel.Port = (int)value;
        }

        private void RemotePortTextBox_TextChanged(object sender, EventArgs e)
        {
            var value = RemotePortTextBox.GetNullableIntegerValue();

            if (value == null) return;

            _connectionModel.RemotePort = (int)value;
        }

        private void TestConnectionButton_Click(object sender, EventArgs e)
        {
            if (TestBlaiseConnectionIsCorrect())
            {
                MessageBox.Show(@"Connection successful", @"Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show(@"Connection details appear to be incorrect", @"Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void InstallQuestionnaireButton_Click(object sender, EventArgs e)
        {
            var questionnaireFile = QuestionnaireFileTextBox.GetNullableStringValue();
            var questionnaireName = QuestionnaireDropDown.SelectedItem?.ToString();
            var serverParkName = ServerParkDropDown.SelectedItem?.ToString();

            if (questionnaireFile == null ||
                questionnaireName == null ||
                serverParkName == null)
            {
                MessageBox.Show(@"There are some null or incorrect values", @"Create cases in database",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                QuestionnaireHelper.GetInstance(_connectionModel).InstallQuestionnaire(questionnaireName, serverParkName,
                    questionnaireFile);

                MessageBox.Show(@"Installation successful", @"Install Questionnaire", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show($"There was an error installing the questionnaire - {exception.Message}",
                    @"Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BrowseCaseFileButton_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                CaseSampleFileTextBox.Text = openFileDialog.FileName;
            }
            else
            {
                MessageBox.Show(@"There was an error in selecting a file", @"File selector",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshQuestionnairesButton_Click(object sender, EventArgs e)
        {
            if (!TestBlaiseConnectionIsCorrect())
            {
                MessageBox.Show("There is an issue with the configuration",
                    @"Refresh", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            RefreshLists();
        }

        private ConnectionModel GetConnectionModelFromConfig()
        {
            var blaiseConfigurationProvider = new BlaiseConfigurationProvider();
            try
            {
                return blaiseConfigurationProvider.GetConnectionModel();
            }
            catch //yuck
            {
                return new ConnectionModel
                {
                    Binding = BindingDropDown.SelectedItem.ToString(),
                    Port = 8031,
                    RemotePort = 8033,
                };
            }
        }
        private void ConfigureBindingDropDown()
        {
            foreach (var item in BindingDropDown.Items)
            {
                if (!_connectionModel.Binding.Equals(item.ToString(), StringComparison.CurrentCultureIgnoreCase))
                {
                    continue;
                }

                BindingDropDown.SelectedItem = item;
                break;
            }
        }

        private bool TestBlaiseConnectionIsCorrect()
        {
            if (ServerNameTextBox.GetNullableStringValue() == null ||
                UserNameTextBox.GetNullableStringValue() == null ||
                PasswordTextBox.GetNullableStringValue() == null ||
                PortTextBox.GetNullableIntegerValue() == null ||
                RemotePortTextBox.GetNullableIntegerValue() == null)
            {
                return false;
            }

            return ConnectionHelper.GetInstance(_connectionModel).ConnectionSuccessful;
        }

        private void RefreshLists()
        {
            if (!ConnectionHelper.GetInstance(_connectionModel).ConnectionModelValid)
            {
                return;
            }

            var serverParks = ServerParkHelper.GetInstance(_connectionModel).GetServerParks();

            ServerParkDropDown.Items.Clear();
            ServerParkDropDown.Items.AddRange(serverParks.Cast<object>().ToArray());
            ServerParkDropDown.SelectedIndex = 0;

            var questionnaires = QuestionnaireHelper.GetInstance(_connectionModel).GetQuestionnaires().ToList();

            if (!questionnaires.Any())
            {
                return;
            }

            QuestionnaireDropDown.Items.Clear();
            QuestionnaireDropDown.Items.AddRange(questionnaires.Cast<object>().ToArray());
            QuestionnaireDropDown.SelectedIndex = 0;
        }

        private void bindingLabel_Click(object sender, EventArgs e)
        {

        }

        private void serverNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
