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
        
        ClockinManager clockin;
        

        public Form1()
        {
            InitializeComponent();
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            clockin = new ClockinManager();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            clockin.ClockIn();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
