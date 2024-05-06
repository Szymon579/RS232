using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RS232
{
    class SerialController
    {
        public event EventHandler<string> MessageReceived;


        private SerialPort serialPort;
        private bool continueReading = false;
        
        public SerialController()
        {
            serialPort = new SerialPort();
        }

        public void PortSetup(string portName, int boudRate, int dataBits, 
                    StopBits stopBits, Parity parity, Handshake handshake)
        {
            serialPort.PortName = portName;
            serialPort.BaudRate = boudRate;
            serialPort.DataBits = dataBits;
            serialPort.StopBits = stopBits;
            serialPort.Parity = parity;
            serialPort.Handshake = handshake;

            serialPort.ReadTimeout = 500;
            serialPort.WriteTimeout = 500;
        }

        public void OpenPort()
        {
            if(!serialPort.IsOpen)
                serialPort.Open();
        }

        public void ClosePort()
        {
            if(serialPort.IsOpen) 
                serialPort.Close();
        }

        public void Write(string text)
        {
            serialPort.WriteLine(text);
        }

        private async void Read()
        {
            while (continueReading)
            {
                try
                {
                    string message = serialPort.ReadLine();
                    //Console.WriteLine(message);

                    if (message.StartsWith("Ping: "))
                    {
                        RespondToPing(message);
                        continue;
                    }
                    
                    MessageReceived.Invoke(this, message);
                }
                catch (TimeoutException) { }
            }
            ClosePort();
            Console.WriteLine("Reading stopped");
        }

        public async Task StartReading()
        {
            continueReading = true;

            await Task.Run(() =>
            {
                Read();
            });
        }

        public void StopReading()
        {
            continueReading = false;
            //ClosePort();
        }

        public TimeSpan Ping()
        {
            DateTime startTime = DateTime.UtcNow;
            string pingMessage = "Ping: " + startTime.Ticks.ToString();
            serialPort.WriteLine(pingMessage);
            string response = serialPort.ReadLine();
            DateTime endTime = DateTime.UtcNow;

            if (pingMessage.Substring(6) != response.Substring(10))
                return TimeSpan.Zero;

            TimeSpan roundTripDelay = endTime - startTime;

            return roundTripDelay;
        }

        private void RespondToPing(string message)
        {
            long receivedTimestamp = long.Parse(message.Substring(6));

            serialPort.WriteLine("Response: " + receivedTimestamp);
        }


    }
}
