using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_Alpha_1._0
{
    public partial class ScheduleListForm : Form
    {
        public ScheduleListForm()
        {
            InitializeComponent();
            
        }

        

        private void ScheduleListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Scheduler.Instance.SetDefaultColor();
        }
    }
}
