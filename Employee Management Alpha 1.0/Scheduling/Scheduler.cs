using Employee_Management_Alpha_1._0.Scheduling;
using System;
using System.Globalization;
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
        Employee_Management employeeManagement;


        public static Scheduler Instance = null;
        public static int Date = 0;
        public static int ToD = 0;// 1 for morning, 2 for afternoon, 3 for evening
        public static List<int> RealDates;
        public static string DepName = "not specified";
        public Scheduler()
        {
            InitializeComponent();
            Scheduler.Instance = this;
            cbCalWeek.Text = Convert.ToString(ReturnCurrentCalWeek());
            cbYear.Text = "2020";
            cbDepartment.Text = "Cleaning";
            DepName = cbDepartment.Text;
            LoadSchedule();
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

        public void ClearShiftLabels()
        {
            foreach (GroupBox gb in pnlDates.Controls.OfType<GroupBox>())
            {
                foreach (Panel pnl in gb.Controls.OfType<Panel>())
                {
                    foreach (Label label in pnl.Controls.OfType<Label>())
                    {
                        label.Text = "";
                    }
                }
            }
        }

        public int ReturnCurrentDates()
        {
            return Date;
        }

        public int ReturnToD()
        {
            return ToD;
        }

        public int ReturnYear()
        {
            return Convert.ToInt32(cbYear.Text);
        }
        public int ReturnCurrentCalWeek()
        {
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            Calendar cal = dfi.Calendar;

            return cal.GetWeekOfYear(DateTime.Now, dfi.CalendarWeekRule, dfi.FirstDayOfWeek);
        }

        public int ReturnSelectedCalWeek()
        {
            return Convert.ToInt32(cbCalWeek.Text);
        }

        public string ReturnDepartmentName()
        {
            return DepName;
        }

        public void LoadSchedule()
        {
            ClearShiftLabels();
                int i = 0;
                scheduleManagement = new ScheduleManagement(Convert.ToInt32(cbYear.SelectedItem), Convert.ToInt32(cbCalWeek.SelectedItem));
                employeeManagement = new Employee_Management();
                RealDates = new List<int>();
                int tr = 7 - scheduleManagement.ReturnDatesbyDay().Count();
                int j = 0;
                int tod = 3;
                try
                {

                    foreach (GroupBox gb in pnlDates.Controls.OfType<GroupBox>())
                    {
                        if (tr == 0)
                        {
                            foreach (Label lb in gb.Controls.OfType<Label>())
                            {
                                lb.Text = String.Format("{0:0000/00/00}", scheduleManagement.ReturnDatesbyDay()[i]);
                                RealDates.Add(scheduleManagement.ReturnDatesbyDay()[i]);
                                if (i < scheduleManagement.ReturnDatesbyDay().Count())
                                {
                                    i++;
                                }
                            }
                        }
                        else
                        {
                            tr--;
                            RealDates.Add(0);
                            foreach (Label lb in gb.Controls.OfType<Label>())
                            {
                               lb.Text = "No such date in CW";
                            }
                        }

                        
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ ex}");
                }

                try
                {
                foreach (GroupBox gb in pnlDates.Controls.OfType<GroupBox>())
                {
                    foreach (Panel pnl in gb.Controls.OfType<Panel>())
                    {
                        //MessageBox.Show($"Working on panel {pnl.Name}");
                        foreach (Label label in pnl.Controls.OfType<Label>())
                        {
                            if ((RealDates[j] != 0))
                            {
                                /*insert code to read data for speciifc time of date here*/
                                //MessageBox.Show($"Parsing date(s): {RealDates[j]} with shift {tod}.");
                                if (scheduleManagement.ReturnEmployeesByShift(tod, RealDates[j])!=null)
                                {


                                    for (int k = 0; k < scheduleManagement.ReturnEmployeesByShift(tod, RealDates[j]).Count(); k++)
                                    {
                                        //MessageBox.Show($"For date {RealDates[j]} shift {tod} returning employee with ID {scheduleManagement.ReturnEmployeesByShift(tod, RealDates[j])[k]}");
                                        label.Text += "ID: "+Convert.ToString(employeeManagement.GetEmployeebyID(scheduleManagement.ReturnEmployeesByShift(tod, RealDates[j])[k]).GetEmployeeFullName()) +Environment.NewLine;
                                    }
                                }
                                else
                                {
                                    label.Text = "No shifts found.";
                                }
                                if (tod == 1)
                                {

                                    tod = 3;
                                    j++;
                                }
                                else
                                {
                                    tod--;
                                    
                                }
                                    
               
                            }
                            else if (RealDates[j] == 0)
                            {
                                //MessageBox.Show($"The real date is{RealDates[j]}");
                                if (tod == 1)
                                {

                                    tod = 3;
                                    j++;
                                }
                                else
                                {
                                    tod--;

                                }
                                label.Text = "N/A";
                            }
                            
                        }
                    }
                }

            }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}");
                }
            
        }

        private void pnlMornMonday_Click(object sender, EventArgs e)
        {
            Date = RealDates[0];
            ToD = 1;
            pnlMornMonday.BackColor = Color.AliceBlue;
            if (Date != 0)
            {
                ScheduleListForm SchdlList = new ScheduleListForm();
                SchdlList.Show();
            }
            else {
                MessageBox.Show("The date you've selected is not applicable. Please re-load the dates for the calendar week and try again.");
                SetDefaultColor();
            }

        }
        private void pnlNoonMonday_Click(object sender, EventArgs e)
        {
            Date = RealDates[0];
            ToD = 2;
            pnlNoonMonday.BackColor = Color.AliceBlue;
            if (Date != 0)
            {
                ScheduleListForm SchdlList = new ScheduleListForm();
                SchdlList.Show();
            }
            else
            {
                MessageBox.Show("The date you've selected is not applicable. Please re-load the dates for the calendar week and try again.");
                SetDefaultColor();
            }
        }
        private void pnlEvenMonday_Click(object sender, EventArgs e)
        {
            Date = RealDates[0];
            ToD = 3;
            pnlEvenMonday.BackColor = Color.AliceBlue;
            if (Date != 0)
            {
                ScheduleListForm SchdlList = new ScheduleListForm();
                SchdlList.Show();
            }
            else
            {
                MessageBox.Show("The date you've selected is not applicable. Please re-load the dates for the calendar week and try again.");
                SetDefaultColor();
            }
        }

        private void pnlMornTuesday_Click(object sender, EventArgs e)
        {
            Date = RealDates[1];
            ToD = 1;
            pnlMornTuesday.BackColor = Color.AliceBlue;
            if (Date != 0)
            {
                ScheduleListForm SchdlList = new ScheduleListForm();
                SchdlList.Show();
            }
            else
            {
                MessageBox.Show("The date you've selected is not applicable. Please re-load the dates for the calendar week and try again.");
                SetDefaultColor();
            }
        }
        private void pnlNoonTuesday_Click(object sender, EventArgs e)
        {
            Date = RealDates[1];
            ToD = 2;
            pnlNoonTuesday.BackColor = Color.AliceBlue;
            if (Date != 0)
            {
                ScheduleListForm SchdlList = new ScheduleListForm();
                SchdlList.Show();
            }
            else
            {
                MessageBox.Show("The date you've selected is not applicable. Please re-load the dates for the calendar week and try again.");
                SetDefaultColor();
            }
        }
        private void pnlEvenTuesday_Click(object sender, EventArgs e)
        {
            Date = RealDates[1];
            ToD = 3;
            pnlEvenTuesday.BackColor = Color.AliceBlue;
            if (Date != 0)
            {
                ScheduleListForm SchdlList = new ScheduleListForm();
                SchdlList.Show();
            }
            else
            {
                MessageBox.Show("The date you've selected is not applicable. Please re-load the dates for the calendar week and try again.");
                SetDefaultColor();
            }
        }

        private void pnlMornWednesday_Click(object sender, EventArgs e)
        {
            Date = RealDates[2];
            ToD = 1;
            pnlMornWednesday.BackColor = Color.AliceBlue;
            if (Date != 0)
            {
                ScheduleListForm SchdlList = new ScheduleListForm();
                SchdlList.Show();
            }
            else
            {
                MessageBox.Show("The date you've selected is not applicable. Please re-load the dates for the calendar week and try again.");
                SetDefaultColor();
            }
        }
        private void pnlNoonWednesday_Click(object sender, EventArgs e)
        {
            Date = RealDates[2];
            ToD = 2;
            pnlNoonWednesday.BackColor = Color.AliceBlue;
            if (Date != 0)
            {
                ScheduleListForm SchdlList = new ScheduleListForm();
                SchdlList.Show();
            }
            else
            {
                MessageBox.Show("The date you've selected is not applicable. Please re-load the dates for the calendar week and try again.");
                SetDefaultColor();
            }
        }
        private void pnlEvenWednesday_Click(object sender, EventArgs e)
        {
            Date = RealDates[2];
            ToD = 3;
            pnlEvenWednesday.BackColor = Color.AliceBlue;
            if (Date != 0)
            {
                ScheduleListForm SchdlList = new ScheduleListForm();
                SchdlList.Show();
            }
            else
            {
                MessageBox.Show("The date you've selected is not applicable. Please re-load the dates for the calendar week and try again.");
                SetDefaultColor();
            }
        }

        private void pnlMornThursday_Click(object sender, EventArgs e)
        {
            Date = RealDates[3];
            ToD = 1;
            pnlMornThursday.BackColor = Color.AliceBlue;
            if (Date != 0)
            {
                ScheduleListForm SchdlList = new ScheduleListForm();
                SchdlList.Show();
            }
            else
            {
                MessageBox.Show("The date you've selected is not applicable. Please re-load the dates for the calendar week and try again.");
                SetDefaultColor();
            }
        }
        private void pnlNoonThursday_Click(object sender, EventArgs e)
        {
            Date = RealDates[3];
            ToD = 2;
            pnlNoonThursday.BackColor = Color.AliceBlue;
            if (Date != 0)
            {
                ScheduleListForm SchdlList = new ScheduleListForm();
                SchdlList.Show();
            }
            else
            {
                MessageBox.Show("The date you've selected is not applicable. Please re-load the dates for the calendar week and try again.");
                SetDefaultColor();
            }
        }
        private void pnlEvenThursday_Click(object sender, EventArgs e)
        {
            Date = RealDates[3];
            ToD = 3;
            pnlEvenThursday.BackColor = Color.AliceBlue;
            if (Date != 0)
            {
                ScheduleListForm SchdlList = new ScheduleListForm();
                SchdlList.Show();
            }
            else
            {
                MessageBox.Show("The date you've selected is not applicable. Please re-load the dates for the calendar week and try again.");
                SetDefaultColor();
            }
        }

        private void pnlMornFriday_Click(object sender, EventArgs e)
        {
            Date = RealDates[4];
            ToD = 1;
            pnlMornFriday.BackColor = Color.AliceBlue;
            if (Date != 0)
            {
                ScheduleListForm SchdlList = new ScheduleListForm();
                SchdlList.Show();
            }
            else
            {
                MessageBox.Show("The date you've selected is not applicable. Please re-load the dates for the calendar week and try again.");
                SetDefaultColor();
            }
        }
        private void pnlNoonFriday_Click(object sender, EventArgs e)
        {
            Date = RealDates[4];
            ToD = 2;
            pnlNoonFriday.BackColor = Color.AliceBlue;
            if (Date != 0)
            {
                ScheduleListForm SchdlList = new ScheduleListForm();
                SchdlList.Show();
            }
            else
            {
                MessageBox.Show("The date you've selected is not applicable. Please re-load the dates for the calendar week and try again.");
                SetDefaultColor();
            }
        }
        private void pnlEvenFriday_Click(object sender, EventArgs e)
        {
            Date = RealDates[4];
            ToD = 3;
            pnlEvenFriday.BackColor = Color.AliceBlue;
            if (Date != 0)
            {
                ScheduleListForm SchdlList = new ScheduleListForm();
                SchdlList.Show();
            }
            else
            {
                MessageBox.Show("The date you've selected is not applicable. Please re-load the dates for the calendar week and try again.");
                SetDefaultColor();
            }
        }

        private void pnlMornSaturday_Click(object sender, EventArgs e)
        {
            Date = RealDates[5];
            ToD = 1;
            pnlMornSaturday.BackColor = Color.AliceBlue;
            if (Date != 0)
            {
                ScheduleListForm SchdlList = new ScheduleListForm();
                SchdlList.Show();
            }
            else
            {
                MessageBox.Show("The date you've selected is not applicable. Please re-load the dates for the calendar week and try again.");
                SetDefaultColor();
            }
        }
        private void pnlNoonSaturday_Click(object sender, EventArgs e)
        {
            Date = RealDates[5];
            ToD = 2;
            pnlNoonSaturday.BackColor = Color.AliceBlue;
            if (Date != 0)
            {
                ScheduleListForm SchdlList = new ScheduleListForm();
                SchdlList.Show();
            }
            else
            {
                MessageBox.Show("The date you've selected is not applicable. Please re-load the dates for the calendar week and try again.");
                SetDefaultColor();
            }
        }
        private void pnlEvenSaturday_Click(object sender, EventArgs e)
        {
            Date = RealDates[5];
            ToD = 3;
            pnlEvenSaturday.BackColor = Color.AliceBlue;
            if (Date != 0)
            {
                ScheduleListForm SchdlList = new ScheduleListForm();
                SchdlList.Show();
            }
            else
            {
                MessageBox.Show("The date you've selected is not applicable. Please re-load the dates for the calendar week and try again.");
                SetDefaultColor();
            }
        }

        private void pnlMornSunday_Click(object sender, EventArgs e)
        {
            Date = RealDates[6];
            ToD = 1;
            pnlMornSunday.BackColor = Color.AliceBlue;
            if (Date != 0)
            {
                ScheduleListForm SchdlList = new ScheduleListForm();
                SchdlList.Show();
            }
            else
            {
                MessageBox.Show("The date you've selected is not applicable. Please re-load the dates for the calendar week and try again.");
                SetDefaultColor();
            }
        }
        private void pnlNoonSunday_Click(object sender, EventArgs e)
        {
            Date = RealDates[6];
            ToD = 2;
            pnlNoonSunday.BackColor = Color.AliceBlue;
            if (Date != 0)
            {
                ScheduleListForm SchdlList = new ScheduleListForm();
                SchdlList.Show();
            }
            else
            {
                MessageBox.Show("The date you've selected is not applicable. Please re-load the dates for the calendar week and try again.");
                SetDefaultColor();
            }
        }
        private void pnlEvenSunday_Click(object sender, EventArgs e)
        {
            Date = RealDates[6];
            ToD = 3;
            pnlEvenSunday.BackColor = Color.AliceBlue;
            if (Date != 0)
            {
                ScheduleListForm SchdlList = new ScheduleListForm();
                SchdlList.Show();
            }
            else
            {
                MessageBox.Show("The date you've selected is not applicable. Please re-load the dates for the calendar week and try again.");
                SetDefaultColor();
            }
        }

        private void gbMonday_Enter(object sender, EventArgs e)
        {

        }

        private void cbCalWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void btnLoadSchedule_Click(object sender, EventArgs e)
        {
            LoadSchedule();
            
        }

        private void cbDepartment_TextUpdate(object sender, EventArgs e)
        {
            DepName = cbDepartment.Text;
        }
    }
}
