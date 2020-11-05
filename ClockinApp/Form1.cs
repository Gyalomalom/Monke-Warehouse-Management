using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ClockinApp
{
    public partial class Form1 : Form
    {
        Portread readcard;

        public Form1()
        {
            InitializeComponent();
            readcard = new Portread();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
            string line = readcard.ReadCard();
            listBox1.Items.Add(line);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
