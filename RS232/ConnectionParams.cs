
using System.IO.Ports;

public static class ConnectionParams
{

    public static string[] GetPortNames()
    {
        return SerialPort.GetPortNames();
    }

    public static string[] GetBoudRates()
    {
        return [
            "110", 
            "300", 
            "600", 
            "1200", 
            "2400", 
            "4800", 
            "9600", 
            "14400", 
            "19200", 
            "38400", 
            "57600", 
            "115200"
            ];
    }

    public static string[] GetDataBits()
    {
        return [
            "7", 
            "8"
            ];
    }

    public static string[] GetStopBits()
    {
        return [
            "1",
            "2",
            ];
    }

    public static string[] GetParity()
    {
        return [
            "None",
            "Even",
            "Odd"
            ];
    }

    public static string[] GetControls()
    {
        return [
            "None",
            "XON/XOFF",
            "DTR/DSR",
            "RTS/CTS"
            ];
    }

    public static string[] GetTerminators()
    {
        return [
            "None",
            "CR",
            "LF",
            "CR-LF",
            "Custom"
            ];
    }

    public static string[] GetModes()
    {
        return [
            "Text",
            "Binary",
            ];
    }

}




