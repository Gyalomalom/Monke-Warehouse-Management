using Employee_Management_Alpha_1._0.Scheduling;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_Alpha_1._0
{
    public partial class Scheduler : Form
    {
        ScheduleManagement scheduleManagement;

        public static Scheduler Instance = null;
        public static int Date = 0;
        public static int ToD = 0;// 1 for morning, 2 for afternoon, 3 for evening
        public Scheduler()
        {
            InitializeComponent();
            Scheduler.Instance = this;
            cbCalWeek.Text = "1";
            cbYear.Text = "2020";
        }


        public void SetDefaultColor()
        {
            foreach (GroupBox gb in pnlDates.Controls.OfType<GroupBox>())
            {
                foreach (Panel panel in gb.Controls.OfType<Panel>())
                {
                    panel.BackColor = SystemColors.GradientInactiveCaption;
                }
            }

        }

        private void pnlMornMonday_Click(object sender, EventArgs e)
        {
            Date = Convert.ToInt32(lblDateMon.Text);
            ToD = 1;
            pnlMornMonday.BackColor = Color.AliceBlue;
            ScheduleListForm SchdlList = new ScheduleListForm();
            SchdlList.Show();

        }
        private void pnlNoonMonday_Click(object sender, EventArgs e)
        {
            Date = Convert.ToInt32(lblDateMon.Text);
            ToD = 2;
            pnlNoonMonday.BackColor = Color.AliceBlue;
            ScheduleListForm SchdlList = new ScheduleListForm();
            SchdlList.Show();
        }
        private void pnlEvenMonday_Click(object sender, EventArgs e)
        {
            Date = Convert.ToInt32(lblDateMon.Text);
            ToD = 3;
            pnlEvenMonday.BackColor = Color.AliceBlue;
            ScheduleListForm SchdlList = new ScheduleListForm();
            SchdlList.Show();
        }

        private void pnlMornTuesday_Click(object sender, EventArgs e)
        {
            Date = Convert.ToInt32(lblDateTue.Text);
            ToD = 1;
            pnlEvenTuesday.BackColor = Color.AliceBlue;
            ScheduleListForm SchdlList = new ScheduleListForm();
            SchdlList.Show();
        }
        private void pnlNoonTuesday_Click(object sender, EventArgs e)
        {
            Date = Convert.ToInt32(lblDateTue.Text);
            ToD = 2;
            pnlNoonTuesday.BackColor = Color.AliceBlue;
            ScheduleListForm SchdlList = new ScheduleListForm();
            SchdlList.Show();
        }
        private void pnlEvenTuesday_Click(object sender, EventArgs e)
        {
            Date = Convert.ToInt32(lblDateTue.Text);
            ToD = 3;
            pnlEvenTuesday.BackColor = Color.AliceBlue;
            ScheduleListForm SchdlList = new ScheduleListForm();
            SchdlList.Show();
        }

        private void pnlMornWednesday_Click(object sender, EventArgs e)
        {
            Date = Convert.ToInt32(lblDateWed.Text);
            ToD = 1;
            pnlMornWednesday.BackColor = Color.AliceBlue;
            ScheduleListForm SchdlList = new ScheduleListForm();
            SchdlList.Show();
        }
        private void pnlNoonWednesday_Click(object sender, EventArgs e)
        {
            Date = Convert.ToInt32(lblDateWed.Text);
            ToD = 2;
            pnlNoonWednesday.BackColor = Color.AliceBlue;
            ScheduleListForm SchdlList = new ScheduleListForm();
            SchdlList.Show();
        }
        private void pnlEvenWednesday_Click(object sender, EventArgs e)
        {
            Date = Convert.ToInt32(lblDateWed.Text);
            ToD = 3;
            pnlEvenWednesday.BackColor = Color.AliceBlue;
            ScheduleListForm SchdlList = new ScheduleListForm();
            SchdlList.Show();
        }

        private void pnlMornThursday_Click(object sender, EventArgs e)
        {
            Date = Convert.ToInt32(lblDateThu.Text);
            ToD = 1;
            pnlMornThursday.BackColor = Color.AliceBlue;
            ScheduleListForm SchdlList = new ScheduleListForm();
            SchdlList.Show();
        }
        private void pnlNoonThursday_Click(object sender, EventArgs e)
        {
            Date = Convert.ToInt32(lblDateThu.Text);
            ToD = 2;
            pnlNoonThursday.BackColor = Color.AliceBlue;
            ScheduleListForm SchdlList = new ScheduleListForm();
            SchdlList.Show();
        }
        private void pnlEvenThursday_Click(object sender, EventArgs e)
        {
            Date = Convert.ToInt32(lblDateThu.Text);
            ToD = 3;
            pnlEvenThursday.BackColor = Color.AliceBlue;
            ScheduleListForm SchdlList = new ScheduleListForm();
            SchdlList.Show();
        }

        private void pnlMornFriday_Click(object sender, EventArgs e)
        {
            Date = Convert.ToInt32(lblDateFri.Text);
            ToD = 1;
            pnlMornFriday.BackColor = Color.AliceBlue;
            ScheduleListForm SchdlList = new ScheduleListForm();
            SchdlList.Show();
        }
        private void pnlNoonFriday_Click(object sender, EventArgs e)
        {
            Date = Convert.ToInt32(lblDateFri.Text);
            ToD = 2;
            pnlNoonFriday.BackColor = Color.AliceBlue;
            ScheduleListForm SchdlList = new ScheduleListForm();
            SchdlList.Show();
        }
        private void pnlEvenFriday_Click(object sender, EventArgs e)
        {
            Date = Convert.ToInt32(lblDateFri.Text);
            ToD = 3;
            pnlEvenFriday.BackColor = Color.AliceBlue;
            ScheduleListForm SchdlList = new ScheduleListForm();
            SchdlList.Show();
        }

        private void pnlMornSaturday_Click(object sender, EventArgs e)
        {
            Date = Convert.ToInt32(lblDateSat.Text);
            ToD = 1;
            pnlMornSaturday.BackColor = Color.AliceBlue;
            ScheduleListForm SchdlList = new ScheduleListForm();
            SchdlList.Show();
        }
        private void pnlNoonSaturday_Click(object sender, EventArgs e)
        {
            Date = Convert.ToInt32(lblDateSat.Text);
            ToD = 2;
            pnlNoonSaturday.BackColor = Color.AliceBlue;
            ScheduleListForm SchdlList = new ScheduleListForm();
            SchdlList.Show();
        }
        private void pnlEvenSaturday_Click(object sender, EventArgs e)
        {
            Date = Convert.ToInt32(lblDateSat.Text);
            ToD = 3;
            pnlEvenSaturday.BackColor = Color.AliceBlue;
            ScheduleListForm SchdlList = new ScheduleListForm();
            SchdlList.Show();
        }

        private void pnlMornSunday_Click(object sender, EventArgs e)
        {
            Date = Convert.ToInt32(lblDateSun.Text);
            ToD = 1;
            pnlMornSunday.BackColor = Color.AliceBlue;
            ScheduleListForm SchdlList = new ScheduleListForm();
            SchdlList.Show();
        }
        private void pnlNoonSunday_Click(object sender, EventArgs e)
        {
            Date = Convert.ToInt32(lblDateSun.Text);
            ToD = 2;
            pnlNoonSunday.BackColor = Color.AliceBlue;
            ScheduleListForm SchdlList = new ScheduleListForm();
            SchdlList.Show();
        }
        private void pnlEvenSunday_Click(object sender, EventArgs e)
        {
            Date = Convert.ToInt32(lblDateSun.Text);
            ToD = 3;
            pnlEvenSunday.BackColor = Color.AliceBlue;
            ScheduleListForm SchdlList = new ScheduleListForm();
            SchdlList.Show();
        }

        private void gbMonday_Enter(object sender, EventArgs e)
        {

        }

        private void cbCalWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void btnLoadSchedule_Click(object sender, EventArgs e)
        {
            int i = 0;
           try
            {
                scheduleManagement = new ScheduleManagement(Convert.ToInt32(cbYear.SelectedItem), Convert.ToInt32(cbCalWeek.SelectedItem));
                foreach (GroupBox gb in pnlDates.Controls.OfType<GroupBox>())
                {
                    foreach (Label lb in gb.Controls.OfType<Label>())
                    {
                        lb.Text = Convert.ToString(scheduleManagement.ReturnDatesbyDay()[i]);
                       if (i< scheduleManagement.ReturnDatesbyDay().Count())
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ ex}");
            }
            
        }
    }
}
