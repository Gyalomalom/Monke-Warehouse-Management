﻿using System;
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
    public partial class Scheduler : Form
    {
        public static Scheduler Instance = null;
        public Scheduler()
        {
            InitializeComponent();
            Scheduler.Instance = this;
        }


        public void SetDefaultColor()
        {
            pnlMornMonday.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void pnlMornMonday_Click(object sender, EventArgs e)
        {
            pnlMornMonday.BackColor = Color.AliceBlue;
            ScheduleListForm SchdlList = new ScheduleListForm();
            SchdlList.Show();
        }
    }
}
