using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace ClockinApp
{
    class Portread
    {
        SerialPort port;

        public Portread()
        {
            if (port == null)
            {
                port = new SerialPort("COM3", 9600);
                port.Open();

            }
        }

        public string ReadCard()
        {
            string message = "Waiting for card...";

            if (port.BytesToRead > 0)
            {
                string line = port.ReadLine();
                line = line.Trim();
                

                return line;
                


            }
            return message;
            
        }
    }
}
