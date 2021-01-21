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
using System.Text.RegularExpressions;

namespace Employee_Management_Alpha_1._0
{
    public partial class StatisticsView : Form
    {
        int year;
        int calWeek;
        string department;

        Department_Management departmentManagement;
        Employee_Management employeeManagement;

        const string pattern = @"([^\s]+)";
        const string patternName = @"(?<=^(\S+\s){1})\S+";

        public StatisticsView()
        {
           
            InitializeComponent();
            string[] departments = ReturnDepartmentNames();
            foreach (string name in departments)
                cbDepartment.Items.Add(name);
            
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

        AutoScheduler autoscheduler;

        private void label4_Click(object sender, EventArgs e)
        {

        }



        public void UpdateStats()
        {
            if ((!string.IsNullOrEmpty(cbYear.Text))&& (!string.IsNullOrEmpty(cbCalWeek.Text))&& (!string.IsNullOrEmpty(cbDepartment.Text)))
            { 
                year = Convert.ToInt32(cbYear.Text);
                calWeek = Convert.ToInt32(cbCalWeek.Text);
                department = cbDepartment.Text;

                autoscheduler = new AutoScheduler(year, calWeek, department);
                List<int> weekDates = new List<int>();
                weekDates = autoscheduler.ReturnDatesbyWeekAndYear();
                List<ScheduleDay> scheduleDays = new List<ScheduleDay>();
                scheduleDays = autoscheduler.GetScheduleDaysAndHours();
                if (scheduleDays != null)
                    foreach (ScheduleDay day in scheduleDays)
                    {
                        lbHours.Text += $"{day.hoursDone.ToString()} on {day.dateID} {Environment.NewLine}";
                    }
            }
            else
            {
                MessageBox.Show("Please make sure all fields are filled.");
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateStats();
        }
    }
}
