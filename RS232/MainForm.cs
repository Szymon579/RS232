using System.Dynamic;
using System.IO.Ports;

namespace RS232
{
    public partial class MainForm : Form
    {
        SerialController serialController;
        List<ComboBox> portSettings;

        public MainForm()
        {
            serialController = new SerialController();
            portSettings = new List<ComboBox>();

            InitializeComponent();
            ComboBoxSetup();

            transmitRadioButton.Checked = true;
            //textBox.ReadOnly = true;
            pingButton.BackColor = SystemColors.Control;

            StopButtonUI();

            serialController.MessageReceivedEvent += MessageReceived;
            serialController.StatusUpdateEvent += StatusUpdated;
        }

        private void ComboBoxSetup()
        {
            portSettings.Add(portCombo);
            portSettings.Add(boudRateCombo);
            portSettings.Add(dataBitsCombo);
            portSettings.Add(stopBitsCombo);
            portSettings.Add(parityCombo);
            portSettings.Add(controlCombo);
            portSettings.Add(terminatorCombo);
            portSettings.Add(modeCombo);

            foreach (ComboBox combo in portSettings)
            {
                combo.DropDownStyle = ComboBoxStyle.DropDownList;
                combo.Items.Clear();
            }

            portCombo.Items.AddRange(ConnectionParams.GetPortNames());
            boudRateCombo.Items.AddRange(ConnectionParams.GetBoudRates());
            dataBitsCombo.Items.AddRange(ConnectionParams.GetDataBits());
            stopBitsCombo.Items.AddRange(ConnectionParams.GetStopBits());
            parityCombo.Items.AddRange(ConnectionParams.GetParity());
            controlCombo.Items.AddRange(ConnectionParams.GetControls());
            terminatorCombo.Items.AddRange(ConnectionParams.GetTerminators());
            modeCombo.Items.AddRange(ConnectionParams.GetModes());

            foreach (ComboBox combo in portSettings)
            {
                combo.SelectedIndex = 0;
            }
            stopBitsCombo.SelectedIndex = 1;
        }

        private void GetSettings()
        {
            ConnectionSettings.portName = portCombo.SelectedItem.ToString();
            ConnectionSettings.boudRate = Int32.Parse(boudRateCombo.SelectedItem.ToString());
            ConnectionSettings.dataBits = Int32.Parse(dataBitsCombo.SelectedItem.ToString());
            ConnectionSettings.stopBits = stopBitsCombo.SelectedIndex;
            ConnectionSettings.parity = parityCombo.SelectedIndex;
            ConnectionSettings.handshake = controlCombo.SelectedItem.ToString();
            ConnectionSettings.terminator = terminatorCombo.SelectedItem.ToString().ToTerminator();
        }

        private void pingButton_Click(object sender, EventArgs e)
        {
            GetSettings();

            serialController.OpenPort();
            serialController.Ping();
            serialController.ClosePort();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            GetSettings();

            if (transmitRadioButton.Checked)
            {
                serialController.OpenPort();
                
                sendButton.Enabled = true;
                inputTextBox.Enabled = true;
                echoCheckBox.Enabled = true;
                
                SetStatus("Transmitting");
            }

            if (receiveRadioButton.Checked)
            {
                serialController.OpenPort();
                serialController.StartReading();

                sendButton.Enabled = false;
                inputTextBox.Enabled = false;
                echoCheckBox.Enabled = false;

                SetStatus("Receiving");
            }

            if (transceiveRadioButton.Checked)
            {
                serialController.OpenPort();
                serialController.StartReading();

                sendButton.Enabled = true;
                inputTextBox.Enabled = true;
                echoCheckBox.Enabled = true;

                SetStatus("Transceiving");
            }

            StartButtonUI();
        }

        private void StartButtonUI()
        {
            paramsPanel.Enabled = false;
            radioGroupBox.Enabled = false;

            pingButton.Enabled = false;

            startButton.Enabled = false;
            startButton.BackColor = Color.Green;

            stopButton.Enabled = true;
            stopButton.BackColor = SystemColors.Control;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            serialController.StopReading();
            serialController.ClosePort();

            StopButtonUI();
        }

        private void StopButtonUI()
        {
            paramsPanel.Enabled = true;
            radioGroupBox.Enabled = true;

            sendButton.Enabled = false;
            inputTextBox.Enabled = false;
            echoCheckBox.Enabled = false;

            pingButton.Enabled = true;
            

            stopButton.Enabled = false;
            stopButton.BackColor = Color.Red;

            startButton.Enabled = true;
            startButton.BackColor = SystemColors.Control;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            serialController.Write(inputTextBox.Text);

            if (echoCheckBox.Checked)
                textBox.AppendText("> " + inputTextBox.Text + "\n");

            inputTextBox.Clear();
        }

        private void MessageReceived(object sender, string message)
        {
            Invoke(new Action(() =>
            {
                textBox.AppendText(message);
            }));
        }

        private void StatusUpdated(object sender, string message)
        {
            Invoke(new Action(() =>
            {
                statusLabel.Text = message;
            }));
        }

        private void SetStatus(string message)
        {
            statusLabel.Text = message;
            Console.WriteLine(message);
        }

        
    }
}
