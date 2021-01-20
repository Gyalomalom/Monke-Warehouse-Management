using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Employee_Management_Alpha_1._0.Logic;
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
            cbYear.Text = Convert.ToString(ReturnCurrentYear());
            string[] departments = ReturnDepartmentNames();
            foreach (string name in departments)
                cbDepartment.Items.Add(name);
            cbDepartment.Text = departments[0];
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
        #region ReturnMethods
        public int ReturnCurrentDates()
        {
            return Date;
        }

        public int ReturnSelectedToD()
        {
            return ToD;
        }

        public int ReturnSelectedYear()
        {
            return Convert.ToInt32(cbYear.Text);
        }

        public int ReturnCurrentYear()
        {
            return Convert.ToInt32(DateTime.Now.Year);
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

        public string ReturnSelectedDepartmentName()
        {
            DepName = cbDepartment.Text;
            return DepName;
        }

        public string[] ReturnDepartmentNames()
        {
            Department_Management department = new Department_Management();
            List<string> depNames = new List<string>();
            List<Department> allDeps = department.FindAllDep();

            foreach (Department dep in allDeps)
            {
                depNames.Add(dep.Name);
            }

            return depNames.ToArray();

        }
        #endregion

        public void LoadSchedule()
        {
            ClearShiftLabels();
                int i = 0;
                scheduleManagement = new ScheduleManagement(Convert.ToInt32(ReturnSelectedYear()), Convert.ToInt32(ReturnSelectedCalWeek()), Scheduler.Instance.ReturnSelectedDepartmentName());
                employeeManagement = new Employee_Management();
            List<ScheduleItem> Items = new List<ScheduleItem>();
            Items = scheduleManagement.ReturnScheduledEmployees();
                RealDates = new List<int>();
                int tr = 7 - scheduleManagement.ReturnDatesbyWeekAndYear().Count();//accounts for start of year when calendar week may be smaller than 7 days
                int j = 0;
                int tod = 3;// number representing time of day, starting from 3 = evening, 2 = noon, 1 = morning
                try
                {

                    foreach (GroupBox gb in pnlDates.Controls.OfType<GroupBox>())
                    {
                        if (tr == 0)
                        {
                            foreach (Label lb in gb.Controls.OfType<Label>())
                            {
                                lb.Text = String.Format("{0:0000/00/00}", scheduleManagement.ReturnDatesbyWeekAndYear()[i]);
                                RealDates.Add(scheduleManagement.ReturnDatesbyWeekAndYear()[i]);
                                if (i < scheduleManagement.ReturnDatesbyWeekAndYear().Count())
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
                    MessageBox.Show($" Error loading dates from server. Please make sure given year is supported.{Environment.NewLine}Full Error: {ex}");
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
                                    bool Noshift = true;
                                    if (Items!=null)
                                    {
                                        if (tod == 1)
                                        {
                                        
                                            foreach (ScheduleItem item in Items)
                                            {
                                                if ((item.morning) && (item.dateID == RealDates[j]) && (item.SchedDep == ReturnSelectedDepartmentName()))
                                                {
                                                    label.Text += $"ID: {item.empID} {item.empName}{Environment.NewLine}";
                                                    Noshift = false;
                                                }
                                            }

                                        }

                                        if (tod == 2)
                                        {
                                            foreach (ScheduleItem item in Items)
                                            {
                                                if ((item.afternoon) && (item.dateID == RealDates[j]) && (item.SchedDep == ReturnSelectedDepartmentName()))
                                                {
                                                    label.Text += $"ID: {item.empID} {item.empName}{Environment.NewLine}";
                                                    Noshift = false;
                                                }
                                            }

                                        }

                                        if (tod == 3)
                                        {
                                            foreach (ScheduleItem item in Items)
                                            {
                                                if ((item.evening) && (item.dateID == RealDates[j]) && (item.SchedDep == ReturnSelectedDepartmentName()))
                                                {
                                                    label.Text += $"ID: {item.empID} {item.empName}{Environment.NewLine}";
                                                    Noshift = false;
                                                }
                                            }

                                        }                                   
                                    }
                                    else
                                    {
                                        label.Text = "No shifts found.";
                                    }
                                    if (Noshift == true)
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
        #region Individual Panel Handling
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
        #endregion

        private void gbMonday_Enter(object sender, EventArgs e)
        {

        }

        private void cbCalWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void btnLoadSchedule_Click(object sender, EventArgs e)
        {
            // Set cursor as hourglass
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();
            LoadSchedule();
            //set cursor to default
            Cursor.Current = Cursors.Default;
            Application.DoEvents();

        }

        private void cbDepartment_TextUpdate(object sender, EventArgs e)
        {
            DepName = cbDepartment.Text;
        }

        private void btnAutoFill_Click(object sender, EventArgs e)
        {
            // Set cursor as hourglass
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();
            //initialize scheduler and call appropriate method
            AutoScheduler autoSched = new AutoScheduler(ReturnSelectedYear(), ReturnSelectedCalWeek(), ReturnSelectedDepartmentName());
            autoSched.AutoPopulate();
            LoadSchedule();
            //set cursor to default
            Cursor.Current = Cursors.Default;
            Application.DoEvents();
        }

        private void Scheduler_Load(object sender, EventArgs e)
        {

        }

        private void Scheduler_Leave(object sender, EventArgs e)
        {
        }

        private void gbGeneralScheduler_Enter(object sender, EventArgs e)
        {

        }

        private void Scheduler_Enter(object sender, EventArgs e)
        {
        }
    }
}
