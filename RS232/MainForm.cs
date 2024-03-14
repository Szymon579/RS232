namespace RS232
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetStatus("Form loaded.");
        }

        private void transmitButton_Click(object sender, EventArgs e)
        {

        }

        private void receiveButton_Click(object sender, EventArgs e)
        {

        }

        private void pingButton_Click(object sender, EventArgs e)
        {

        }

        private void SetStatus(string message)
        {
            statusLabel.Text = message;
            Console.WriteLine(message);
        }
    }
}
