using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_Alpha_1._0
{
    public partial class ScheduleListForm : Form
    {
        int superGlobalID = -1;
        int superGlobalIDAssigned = -1;
        Employee_Management employeeManagement = new Employee_Management();
        ShiftManagement shiftManagement;
        Department_Management departmentManagement;
        Scheduling.ScheduleManagement scheduleManagement = new Scheduling.ScheduleManagement(Scheduler.Instance.ReturnYear(), Scheduler.Instance.ReturnSelectedCalWeek());
        string timeofday;
        const string pattern = @"([^\s]+)"; //pattern to get the first string before a space
        Regex rg = new Regex(pattern);

        public ScheduleListForm()
        {
            InitializeComponent();
            //UpdateListEmployees();
            string date = String.Format("{0:0000/00/00}", Scheduler.Instance.ReturnCurrentDates());
            timeofday = "nothing";
            if (Scheduler.Instance.ReturnToD() == 1)
                timeofday = "morning";
            else if (Scheduler.Instance.ReturnToD() == 2)
                timeofday = "afternoon";
            else
                timeofday = "evening";


            lblIndicatorDate.Text = $"Date: {date} {Environment.NewLine}Shift: {timeofday}";
            UpdateAssignedEmployees();
            UpdateListEmployees();

        }

        private void UpdateListEmployees()
        {
            lbAvailableEmployees.Items.Clear();
            List<int> employees = new List<int>();
            foreach(Employee employee in employeeManagement.GetAllEmployees())
            {
                
                if (employee.departmentName == Scheduler.Instance.ReturnDepartmentName()&&(employee.status=="Active"))
                {
                    employees.Add(employee.Id);

                }
            }
            Dictionary<int, int> Dict = new Dictionary<int, int>();
                Dict = scheduleManagement.ReturnHoursScheduled(Scheduler.Instance.ReturnDepartmentName());
            List<int> availableEmployees = new List<int>();
            availableEmployees = scheduleManagement.ReturnAvailableEmployeesPerDate(Scheduler.Instance.ReturnCurrentDates(), employees, timeofday);
            if (availableEmployees != null)
            {
                foreach (int id in availableEmployees)
                {
                    if(Dict!=null) {
                        if (Dict.ContainsKey(id))
                        {
                            int totalhours = 40;
                            //employeeManagement.GetEmployeebyID(id).workinghours; - temporarily set to 20;
                            //MessageBox.Show($" {Dict[id]}/{totalhours}");
                            if (Dict[id] < totalhours)
                            {
                                lbAvailableEmployees.Items.Add(employeeManagement.GetEmployeebyID(id).GetEmployeeInfo() + $" {Dict[id]}/{totalhours}");
                            }
                        }
                    }
                    else
                    {
                        lbAvailableEmployees.Items.Add(employeeManagement.GetEmployeebyID(id).GetEmployeeInfo());
                    }
                }
            }
            else
            {
                MessageBox.Show("No available employees found.");
            }
            


        }

        private void UpdateAssignedEmployees()
        {
            lbAssignedEmp.Items.Clear();
            if (scheduleManagement.ReturnEmployeesByShift(Scheduler.Instance.ReturnToD(), Scheduler.Instance.ReturnCurrentDates()) != null)
            {


                for (int k = 0; k < scheduleManagement.ReturnEmployeesByShift(Scheduler.Instance.ReturnToD(), Scheduler.Instance.ReturnCurrentDates()).Count(); k++)
                {
                    //MessageBox.Show($"For date {RealDates[j]} shift {tod} returning employee with ID {scheduleManagement.ReturnEmployeesByShift(tod, RealDates[j])[k]}");
                    lbAssignedEmp.Items.Add(Convert.ToString(employeeManagement.GetEmployeebyID(scheduleManagement.ReturnEmployeesByShift(Scheduler.Instance.ReturnToD(), Scheduler.Instance.ReturnCurrentDates())[k]).GetEmployeeFullName()));
                }
            }
            else
            {
                lbAssignedEmp.Items.Add("No shifts found.");
            }
        }

        private void UpdateHoursScheduled()
        {
            //Dictionary<int, int> Dict = scheduleManagement.ReturnHoursScheduled(Scheduler.Instance.ReturnDepartmentName());
            //foreach (int key in Dict.Keys)
            //{
            //    if()
            //}
            //lvHoursScheduled.Items.Add();
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
                if (!(lbAvailableEmployees.SelectedItem.Equals(null)))
                {
                    string ID = lbAvailableEmployees.SelectedItem.ToString();
                    Match match = Regex.Match(ID, pattern);
                    if (match.Success)
                    {
                        superGlobalID = Convert.ToInt32(match.Value);
                        //MessageBox.Show($"{superGlobalID}");
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void lbAssignedEmp_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(lbAssignedEmp.SelectedItem.Equals(null)))
                {
                    string ID = lbAssignedEmp.SelectedItem.ToString();
                    Match match = Regex.Match(ID, pattern);
                    if (match.Success)
                    {
                        superGlobalIDAssigned = Convert.ToInt32(match.Value);
                        //MessageBox.Show($"{superGlobalIDAssigned}");
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnUnassign_Click(object sender, EventArgs e)
        {
            if (!(superGlobalIDAssigned == -1))
            {
                scheduleManagement.RemoveEmployeeFromShift(timeofday, Scheduler.Instance.ReturnCurrentDates(), superGlobalIDAssigned);
                MessageBox.Show("Employee unassigned from shift successfully.");
                UpdateAssignedEmployees();
                UpdateListEmployees();
            }
            else
                MessageBox.Show("Please select an employee from the lists." + Environment.NewLine + "If you can't see any employees, none are legibile to be assigned");
        }
    
    }
}
