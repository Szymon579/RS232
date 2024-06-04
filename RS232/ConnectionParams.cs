
using System.IO.Ports;
using System.Runtime.CompilerServices;

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

    public static Handshake ToControl(this string control)
    {
        switch (control)
        {
            case "None":
                return Handshake.None;
            case "XON/XOFF":
                return Handshake.XOnXOff;
            case "DTR/DSR":
                return Handshake.RequestToSend; //TODO
            case "RTS/CTS":
                return Handshake.RequestToSend;
            default:
                return Handshake.None;
        }
    }

    public static string ToTerminator(this string terminator)
    {
        switch (terminator)
        {
            case "None":
                return "";
            case "CR":
                return "\r";
            case "LF":
                return "\n";
            case "CR-LF":
                return "\r\n";
            case "Custom":
                return "Custom";
            default:
                return "";
        }
    }

}




