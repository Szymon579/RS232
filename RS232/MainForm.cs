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
            serialController.MessageReceivedEvent += MessageReceived;
            serialController.StatusUpdateEvent += StatusUpdated;

            InitializeComponent();
            ComboBoxSetup();
            SetStatus("Form loaded");
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

        private void transmitButton_Click(object sender, EventArgs e)
        {
            GetSettings();
            serialController.OpenPort();

            SetStatus("Transmitting");
        }

        private void receiveButton_Click(object sender, EventArgs e)
        {
            GetSettings();
            serialController.OpenPort();
            serialController.StartReading();

            SetStatus("Receiving");
        }

        private void pingButton_Click(object sender, EventArgs e)
        {
            serialController.OpenPort();
            TimeSpan pingTime = serialController.Ping();
            MessageBox.Show("Ping: " + pingTime.TotalMilliseconds + "ms");
            serialController.ClosePort();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            //Invoke(new Action(() => { serialController.StopReading(); }));
            serialController.StopReading();
            serialController.ClosePort();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            serialController.Write(inputTextBox.Text);
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
