using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using Employee_Management_Alpha_1._0.Logic;
using System.Windows.Forms;

namespace Employee_Management_Alpha_1._0
{
    public partial class ScheduleListForm : Form
    {
        int superGlobalID = -1;
        int superGlobalIDAssigned = -1;
        static int year = Scheduler.Instance.ReturnSelectedYear();
        static int calWeek = Scheduler.Instance.ReturnSelectedCalWeek();
        static string department = Scheduler.Instance.ReturnSelectedDepartmentName();
        ScheduleManagement scheduleManagement = new ScheduleManagement(year, calWeek, department);
        string timeofday;
        int date = Scheduler.Instance.ReturnCurrentDates();
        const string pattern = @"([^\s]+)"; //pattern to get the first string before a space
        Regex rg = new Regex(pattern);

        public ScheduleListForm()
        {
            InitializeComponent();
            string dateFormat = String.Format("{0:0000/00/00}", date);
            timeofday = "nothing";
            if (Scheduler.Instance.ReturnSelectedToD() == 1)
                timeofday = "morning";
            else if (Scheduler.Instance.ReturnSelectedToD() == 2)
                timeofday = "afternoon";
            else
                timeofday = "evening";


            lblIndicatorDate.Text = $"Date: {dateFormat} {Environment.NewLine}Shift: {timeofday}{Environment.NewLine}Department: {department}";
            UpdateAssignedEmployees();
            UpdateListEmployees();

        }

        private void UpdateListEmployees()
        {   
            lbAvailableEmployees.Items.Clear();
            List<ScheduleItem> employees = scheduleManagement.ReturnAvailableEmployees(timeofday, date);
            foreach(ScheduleItem item in employees)
            {
                lbAvailableEmployees.Items.Add($"{item.empID} {item.empName} {item.workhours}/{item.contracthours}");
            }
        }

        private void UpdateAssignedEmployees()
        {
            lbAssignedEmp.Items.Clear();
            List<ScheduleItem> items = scheduleManagement.ReturnEmployeesByShift(timeofday, date);
            try
            { if(items!=null)
                foreach (ScheduleItem item in items)
                {

                      lbAssignedEmp.Items.Add($"{item.empID} {item.empName}");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No shifts available for this week.");
            }
        }



        private void ScheduleListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Scheduler.Instance.SetDefaultColor();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (!(superGlobalID == -1))
            {
                scheduleManagement.AddEmployeeToShift(timeofday, Scheduler.Instance.ReturnCurrentDates(), superGlobalID);
                MessageBox.Show("Employee assigned successfully.");
                UpdateAssignedEmployees();
                UpdateListEmployees();
            }
            else
                MessageBox.Show("Please select an employee from the lists." + Environment.NewLine + "If you can't see any employees, none are legibile to be assigned");
        }

        private void lbEmployees_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(lbAvailableEmployees.SelectedItem == null))
                {
                    string ID = lbAvailableEmployees.SelectedItem.ToString();
                    Match match = Regex.Match(ID, pattern);
                    if (match.Success)
                    {
                        superGlobalID = Convert.ToInt32(match.Value);
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select an employee.");
            }
        }

        private void lbAssignedEmp_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(lbAssignedEmp.SelectedItem == null))
                {
                    string ID = lbAssignedEmp.SelectedItem.ToString();
                    Match match = Regex.Match(ID, pattern);
                    if (match.Success)
                    {
                        superGlobalIDAssigned = Convert.ToInt32(match.Value);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select an employee.");
            }
        }

        private void btnUnassign_Click(object sender, EventArgs e)
        {
            if (!(superGlobalIDAssigned == -1))
            {
                scheduleManagement.RemoveEmployeeFromShift(timeofday, date, superGlobalIDAssigned);
                MessageBox.Show("Employee unassigned from shift successfully.");
                UpdateAssignedEmployees();
                UpdateListEmployees();
            }
            else
                MessageBox.Show("Please select an employee from the lists." + Environment.NewLine + "If you can't see any employees, none are legibile to be assigned");
        }
    
    }
}
