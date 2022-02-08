using System;
using System.Linq;
using System.Windows.Forms;
using Blaise.Instrument.Data.Gui.Extensions;
using Blaise.Instrument.Data.Helpers;
using Blaise.Nuget.Api.Contracts.Models;
using Blaise.Nuget.Api.Providers;

namespace Blaise.Instrument.Data.Gui
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
                InstrumentFileTextBox.Text = openFileDialog.FileName;
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
            var instrumentName = InstrumentDropDown.SelectedItem?.ToString();
            var serverParkName = ServerParkDropDown.SelectedItem?.ToString();

            if (numberOfCases == null || primaryKeyValue == null ||
                instrumentName == null || serverParkName == null)
            {
                MessageBox.Show(@"There are some null or incorrect values", @"Create cases in database",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                CaseHelper
                    .GetInstance(_connectionModel)
                    .CreateCasesInBlaise((int)numberOfCases, instrumentName, serverParkName, (int)primaryKeyValue,
                        CaseSampleFileTextBox.GetNullableStringValue());

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

        private void InstallInstrumentButton_Click(object sender, EventArgs e)
        {
            var instrumentFile = InstrumentFileTextBox.GetNullableStringValue();
            var instrumentName = InstrumentDropDown.SelectedItem?.ToString();
            var serverParkName = ServerParkDropDown.SelectedItem?.ToString();

            if (instrumentFile == null ||
                instrumentName == null ||
                serverParkName == null)
            {
                MessageBox.Show(@"There are some null or incorrect values", @"Create cases in database",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                InstrumentHelper.GetInstance(_connectionModel).InstallInstrument(instrumentName, serverParkName,
                    instrumentFile);

                MessageBox.Show(@"Installation successful", @"Install Instrument", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show($"There was an error installing the instrument - {exception.Message}",
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

        private void RefreshInstrumentsButton_Click(object sender, EventArgs e)
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

            var instruments = InstrumentHelper.GetInstance(_connectionModel).GetInstruments().ToList();

            if (!instruments.Any())
            {
                return;
            }

            InstrumentDropDown.Items.Clear();
            InstrumentDropDown.Items.AddRange(instruments.Cast<object>().ToArray());
            InstrumentDropDown.SelectedIndex = 0;
        }
    }
}
