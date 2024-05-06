using System.IO.Ports;

namespace RS232
{
    public partial class MainForm : Form
    {
        SerialController serialController;

        public MainForm()
        {
            InitializeComponent();
            ComponentSetup();
            SetStatus("Form loaded.");

            serialController = new SerialController();
            serialController.MessageReceived += MessageReceived;
        }

        private void ComponentSetup()
        {
            portCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            boudRateCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            dataBitsCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            stopBitsCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            parityCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            controlCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            terminatorCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            modeCombo.DropDownStyle = ComboBoxStyle.DropDownList;

            portCombo.Items.Clear();
            boudRateCombo.Items.Clear();
            dataBitsCombo.Items.Clear();
            stopBitsCombo.Items.Clear();
            parityCombo.Items.Clear();
            controlCombo.Items.Clear();
            terminatorCombo.Items.Clear();
            modeCombo.Items.Clear();

            portCombo.Items.AddRange(ConnectionParams.GetPortNames());
            boudRateCombo.Items.AddRange(ConnectionParams.GetBoudRates());
            dataBitsCombo.Items.AddRange(ConnectionParams.GetDataBits());
            stopBitsCombo.Items.AddRange(ConnectionParams.GetStopBits());
            parityCombo.Items.AddRange(ConnectionParams.GetParity());
            controlCombo.Items.AddRange(ConnectionParams.GetControls());
            terminatorCombo.Items.AddRange(ConnectionParams.GetTerminators());
            modeCombo.Items.AddRange(ConnectionParams.GetModes());

            portCombo.SelectedIndex = 0;
            boudRateCombo.SelectedIndex = 0;
            dataBitsCombo.SelectedIndex = 0;
            stopBitsCombo.SelectedIndex = 0;
            parityCombo.SelectedIndex = 0;
            controlCombo.SelectedIndex = 0;
            terminatorCombo.SelectedIndex = 0;
            modeCombo.SelectedIndex = 0;




        }
        private void SetStatus(string message)
        {
            statusLabel.Text = message;
            Console.WriteLine(message);
        }

        private void transmitButton_Click(object sender, EventArgs e)
        {
            string portName = portCombo.SelectedItem.ToString();
            int boudRate = Int32.Parse(boudRateCombo.SelectedItem.ToString());
            int dataBits = Int32.Parse(dataBitsCombo.SelectedItem.ToString());
            StopBits stopBits = (StopBits)stopBitsCombo.SelectedIndex + 1;
            Parity parity = (Parity)parityCombo.SelectedIndex;
            Handshake handshake = (Handshake)controlCombo.SelectedIndex;

            serialController.PortSetup(portName, boudRate, dataBits, stopBits, parity, handshake);
            serialController.OpenPort();

            SetStatus("Transmitting");
        }

        private void receiveButton_Click(object sender, EventArgs e)
        {
            string portName = portCombo.SelectedItem.ToString();
            int boudRate = Int32.Parse(boudRateCombo.SelectedItem.ToString());
            int dataBits = Int32.Parse(dataBitsCombo.SelectedItem.ToString());
            StopBits stopBits = (StopBits)stopBitsCombo.SelectedIndex + 1;
            Parity parity = (Parity)parityCombo.SelectedIndex;
            Handshake handshake = (Handshake)controlCombo.SelectedIndex;

            serialController.PortSetup(portName, boudRate, dataBits, stopBits, parity, handshake);
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
            serialController.StopReading();
            
        }

        private void MessageReceived(object sender, string message)
        {
            Invoke(new Action(() =>
            {
                textBox.AppendText(message + Environment.NewLine);
            }));
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            serialController.Write(inputTextBox.Text);
            inputTextBox.Clear();
        }
    }
}
