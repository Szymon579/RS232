using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS232
{
    public class ConnectionSettings
    {
        public static string portName     { get; set; }
        public static int boudRate        { get; set; }
        public static int dataBits        { get; set; }
        public static int stopBits        { get; set; }
        public static int parity          { get; set; }
        public static string handshake    { get; set; }
        public static string terminator   { get; set; }

        public ConnectionSettings(string portName, int boudRate, int dataBits, int stopBits, int parity, string handshake, string terminator)
        {
            ConnectionSettings.portName = portName;
            ConnectionSettings.boudRate = boudRate;
            ConnectionSettings.dataBits = dataBits;
            ConnectionSettings.stopBits = stopBits;
            ConnectionSettings.parity = parity;
            ConnectionSettings.handshake = handshake;
            ConnectionSettings.terminator = terminator;
        }
    }
}
