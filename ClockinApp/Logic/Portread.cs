﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace ClockinApp
{
    public class Portread
    {
        SerialPort port;

        public Portread()
        {
            if (port == null)
            {
                try
                {
                    port = new SerialPort("COM3", 9600);
                    port.Open();

                }
                catch (Exception e)
                {
                    MessageBox.Show("No device found.");
                }
                

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
