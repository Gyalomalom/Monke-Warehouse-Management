using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Data;
using Employee_Management_Alpha_1._0.Database;
using System.Windows.Forms;


namespace Employee_Management_Alpha_1._0.Logic
{
    public class StatisticsManagement
    {
        protected MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;database=dbi360075;uid=dbi360075;password=monke;");

        protected int calWeek;
        protected int year;
        protected string department;
        

        public StatisticsManagement(int year, int CalendarWeek, string department)
        {
            this.year = year;
            this.calWeek = CalendarWeek;
            this.department = department;
        }

        public int ReturnEmployeesByShift(string timeofday, int dateID)
        {
            List<ScheduleItem> employees = new List<ScheduleItem>();
            List<ScheduleItem> scheduledEmployees = this.ReturnScheduledEmployees();
            if (scheduledEmployees != null)
            {
                if (timeofday == "morning")
                {
                    //morning code
                    foreach (ScheduleItem e in scheduledEmployees)
                    {
                        if (e.dateID == dateID)
                            if (e.morning)
                            {
                                employees.Add(e);
                            }
                    }
                }
                else if (timeofday == "afternoon")
                {
                    //afternoon code
                    foreach (ScheduleItem e in scheduledEmployees)
                    {
                        if (e.dateID == dateID)
                            if (e.afternoon)
                            {
                                employees.Add(e);
                            }
                    }
                }
                else
                {
                    //evening code
                    foreach (ScheduleItem e in scheduledEmployees)
                    {
                        if (e.dateID == dateID)
                            if (e.evening)
                            {
                                employees.Add(e);
                            }
                    }
                }

                return employees;
            }
            else
            {
                return null;
            }



        }

    }
}
