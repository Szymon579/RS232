using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private byte[] pingMessage = { 0x11 };
        
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

                serialPort.ReadTimeout = 100;
                serialPort.WriteTimeout = 100;
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
                serialPort.WriteLine(text + terminator); //TODO: change to write(), possibly funking with custom terminator
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

                        if (buff[0] == pingMessage[0])
                        {
                            serialPort.DiscardOutBuffer();
                            serialPort.Write(new byte[] { 0x11 }, 0, 1);
                            continue;
                        }

                        MessageReceivedEvent.Invoke(this, message);
                    }
                    catch (TimeoutException) { }
                }
                else
                {
                    Thread.Sleep(50);
                }
                    
            }

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

        public void Ping()
        {
            serialPort.ReadTimeout = 5000;

            byte[] pingMessage = new byte[] { 0x11 };
            byte[] responseBuff = new byte[1];

            Stopwatch stopwatch = new Stopwatch();

            serialPort.DiscardInBuffer();
            stopwatch.Start();
            serialPort.Write(pingMessage, 0, 1);

            try
            {
                serialPort.Read(responseBuff, 0, 1);
                stopwatch.Stop();    
            }
            catch (TimeoutException ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (responseBuff[0] == pingMessage[0])
            {
                MessageBox.Show("Round Trip Delay: " + (float)stopwatch.Elapsed.Microseconds / 1000 + "ms", "Ping", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }      
            else
            {
                MessageBox.Show("Unexpected ping response", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

    }
}
