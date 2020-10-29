using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Employee_Management_Alpha_1._0
{
    class CardReader
    {
        
        List<string> ClockIn = new List<string>();

        public CardReader() { }

        SerialPort port = new SerialPort("COM3",
        9600, Parity.None, 8, StopBits.One);
        [STAThread]

        public void ReadPort()
        {
            if (port.BytesToRead > 0)
            {
                string login = port.ReadLine();
                ClockIn.Add(login);
            }
        }
    }
}
