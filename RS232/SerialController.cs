using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace RS232
{
    class SerialController
    {
        public event EventHandler<string> MessageReceivedEvent;
        public event EventHandler<string> StatusUpdateEvent;

        private SerialPort serialPort;
        private Thread readThread;
        private volatile bool continueReading;
        private string terminator;
        
        public SerialController()
        {
            serialPort = new SerialPort();
            readThread = null;
            continueReading = false;
        }

        public bool PortSetup() 
        {
            //avoid setup on opened port
            if (serialPort.IsOpen)
                serialPort.Close();

            try
            {
                serialPort.PortName = ConnectionSettings.portName;
                serialPort.BaudRate = ConnectionSettings.boudRate;
                serialPort.DataBits = ConnectionSettings.dataBits;
                serialPort.StopBits = (StopBits)ConnectionSettings.stopBits;
                serialPort.Parity = (Parity)ConnectionSettings.parity;
                serialPort.Handshake = ConnectionSettings.handshake.ToControl();
                this.terminator = ConnectionSettings.terminator.ToTerminator();

                serialPort.ReadTimeout = 50;
                serialPort.WriteTimeout = 50;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public void OpenPort()
        {
            if (serialPort.IsOpen)
                return;

            if (!PortSetup())
                return;

            serialPort.Open();
            StatusUpdateEvent.Invoke(this, "Port open");            
        }

        public void ClosePort()
        {
            if(serialPort.IsOpen)
            {
                serialPort.Close();
                StatusUpdateEvent.Invoke(this, "Port closed");
            }   
        }

        public void Write(string text)
        {
            if (serialPort.IsOpen)
            {
                serialPort.WriteLine(text + terminator);
                StatusUpdateEvent.Invoke(this, "Data sent");
            }
            else
            {
                StatusUpdateEvent.Invoke(this, "Port closed, could not write!");
            }
        }

        public void StartReading()
        {
            if (!continueReading)
            {
                continueReading = true;
                readThread = new Thread(Read);
                readThread.Start();
            }
        }

        private void Read()
        {
            while (continueReading)
            {
                if(serialPort.IsOpen)
                {
                    byte[] buff = new byte[serialPort.ReadBufferSize+1];
                    try
                    {
                        
                        int bytesRead = serialPort.Read(buff, 0, serialPort.ReadBufferSize);
                        string message = System.Text.Encoding.ASCII.GetString(buff, 0, bytesRead);

                        MessageReceivedEvent.Invoke(this, message);

                        //string message = serialPort.ReadExisting();

                        //if (message.StartsWith("Ping: "))
                        //{
                        //    RespondToPing(message);
                        //    continue;
                        //}

                        //MessageReceivedEvent.Invoke(this, message);
                    }
                    catch (TimeoutException) { }
                }
                else
                {
                    Thread.Sleep(100);
                }
                    
            }

            //ClosePort();
            Console.WriteLine("Reading stopped");
        } 

        public void StopReading()
        {
            if(continueReading)
            {
                continueReading = false;
                readThread.Join();
                readThread = null;
            }
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
