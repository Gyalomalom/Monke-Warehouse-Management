﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;
using Employee_Management_Alpha_1._0.Database;
using System.Windows.Forms;

namespace Employee_Management_Alpha_1._0.Logic
{
    public class AutoScheduler : ScheduleManagement
    {
        public AutoScheduler (int year, int calWeek, string department):base(year, calWeek, department)
        {
           
        }

        public int GetAvailableHours()
        {
            int result = 0;
            string sql = $@"SELECT e.Dep, FLOOR((SUM(e.WorkingHours))) AS HoursNeeded
                            FROM (SELECT *
                            FROM employee
                                 	INNER JOIN (SELECT * FROM `depemp` WHERE DepStatus = '1' AND Dep = '{department}') as d
                                  	ON employee.ID = d.EmpID
                            WHERE status = 'Active') AS e
                            GROUP BY e.Dep;";
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                result = (Convert.ToInt32(dr["HoursNeeded"]));
            }
            conn.Close();

            return result;
        }

        public int GetHoursPerDay()
        {
            return (this.GetAvailableHours() / 7)-((this.GetAvailableHours() / 7)%12);
        }
        
        public int GetHoursPerShift()
        {
            return ((this.GetHoursPerDay() / 3)-((this.GetHoursPerDay() / 3)%4));
        }

        public List<ScheduleItem> GetAllEmployees()
        {

                List<ScheduleItem> items = new List<ScheduleItem>();

                string sql = $@"SELECT d.Dep, e.Status, e.ID, CONCAT(e.FirstName, ' ' , e.LastName) AS Name, e.WorkingHours, de.NrDep
                            FROM employee as e
                            INNER JOIN (SELECT * FROM `depemp` WHERE DepStatus = '1' AND Dep = '{department}') as d
                            ON e.ID = d.EmpID
                            INNER JOIN (SELECT *
									FROM employee as e
									INNER JOIN (SELECT EmpID, COUNT(Dep) AS NrDep
									FROM depemp
									WHERE DepStatus = '1'
									GROUP BY EmpID) as ed
									ON ed.EmpID = e.ID) as de
                                    	ON (de.EmpID = e.ID)
                            HAVING Status = 'Active'
                            ORDER BY de.NrDep ASC, e.WorkingHours DESC;";

                MySqlCommand cmd = new MySqlCommand(sql, this.conn);
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    items.Add(new ScheduleItem(Convert.ToInt32(dr["ID"]), Convert.ToString(dr["Name"]), Convert.ToInt32(dr["WorkingHours"])));
                }
                if (items.Count() >= 1)

                {
                    conn.Close();

                    return items;
                }
                else
                {
                    conn.Close();

                    return null;
                }
            
        }

        public List<ScheduleDay> GetScheduleDaysAndHours()
        {
            string sql = $@"SELECT q.date, q.w, q.Dep, q.totalMorning, q.totalAfternoon, q.TotalEvening, q.TotalHours, (
                                SELECT FLOOR(SUM(e.WorkingHours)/7) AS ShiftsNeeded
                                FROM (SELECT *
                                FROM employee as c
                                      INNER JOIN (SELECT * FROM `depemp` WHERE DepStatus = '1' AND Dep = '{department}') AS l 
                                    ON (c.ID = l.EmpID)
                                WHERE c.status = 'Active') AS e
                                GROUP BY e.Dep) AS HoursNeeded
                            FROM (SELECT td.id AS date, td.w, d.Dep, s.Dep AS SchedDep, (COALESCE(SUM(s.morning), 0)*4) AS totalMorning, (COALESCE(SUM(s.afternoon), 0) * 4) AS totalAfternoon, (COALESCE(SUM(s.evening), 0) * 4) AS totalEvening, (COALESCE(SUM(s.morning), 0) + COALESCE(SUM(s.afternoon), 0) + COALESCE(SUM(s.evening), 0)) * 4 AS TotalHours
                                FROM `schedule` as s
                                RIGHT JOIN (SELECT y, w, id FROM `time_dimension` WHERE w = '{calWeek}' AND y = '{year}' ) as td

                                    ON(s.DateID = td.id)

                                    INNER JOIN `employee` as e

                                    ON(s.EmpID = e.ID)
                                  	INNER JOIN (SELECT * FROM `depemp` WHERE DepStatus = '1' AND Dep = '{department}') AS d 
                                    ON (e.ID = d.EmpID)
                                GROUP BY date
                             HAVING d.Dep = '{department}' AND SchedDep = '{department}') as q";

            List<ScheduleDay> days = new List<ScheduleDay>();
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                days.Add(new ScheduleDay(Convert.ToInt32(dr["date"]), Convert.ToInt32(dr["totalMorning"]), Convert.ToInt32(dr["totalAfternoon"]), Convert.ToInt32(dr["totalEvening"]), Convert.ToInt32(dr["TotalHours"])));
            }
            if (days.Count() >= 1)

            {
                conn.Close();

                return days;
            }
            else
            {
                conn.Close();

                return null;
            }
        }

        /*following method returns all employees in a given day who haven't been scheduled on a particular shift already*/
        public List<ScheduleItem> ReturnScheduledEmployeesByDayExlShift(int date, string timeofday)
        {
            List<ScheduleItem> items = new List<ScheduleItem>();
            string sql = $@"SELECT td.y, td.w,  d.Dep, e.Status, td.id, s.EmpID, CONCAT(e.FirstName, ' ' , e.LastName) AS Name, s.morning, s.afternoon, s.evening, s.Dep as SchedDep
                            FROM schedule as s 
                            INNER JOIN employee as e ON s.EmpID = e.ID
                            INNER JOIN time_dimension as td on s.DateID = td.id
                            INNER JOIN (SELECT * FROM `depemp` WHERE DepStatus = '1' AND Dep = '{department}') AS d 
                                    ON (e.ID = d.EmpID)
                            HAVING e.Status = 'Active' AND td.id = '{date}' AND d.Dep = '{department}' AND s.{timeofday} = 0  AND ((s.morning)+(s.afternoon)+(s.evening)='1');";

            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                items.Add(new ScheduleItem(Convert.ToInt32(dr["id"]), Convert.ToInt32(dr["EmpID"]), Convert.ToString(dr["Name"]), Convert.ToBoolean(dr["morning"]), Convert.ToBoolean(dr["afternoon"]), Convert.ToBoolean(dr["evening"]), Convert.ToString(dr["SchedDep"])));
            }
            if (items.Count() >= 1)

            {
                conn.Close();

                return items;
            }
            else
            {
                conn.Close();

                return null;
            }
        }

        

        public void AutoPopulate()
        {
            List<int> allDates = this.ReturnDatesbyWeekAndYear();
            List<ScheduleDay> datesWithHours = this.GetScheduleDaysAndHours();
            List < ScheduleItem > employees = this.GetAllEmployees();
            int hoursPerDay = this.GetHoursPerDay();
            int hoursPerShift = this.GetHoursPerShift();

            
            foreach (int date in allDates)
            {
                Debug.WriteLine($"parsing {date}");
                int counter = hoursPerDay; //set default value to counter
                ScheduleDay dayPlaceholder = null;
                if(datesWithHours!=null)
                foreach(ScheduleDay day in datesWithHours)//check if there are already any scheduled hours in a given day before proceeding
                {
                    if (day.dateID == date) //if a match is found
                    {
                        counter = hoursPerDay - day.hoursDone; //adjust the counter to only count the remaining hours needed for that day
                        dayPlaceholder = day;
                    }
                }
                //Debug.WriteLine($"Counter {counter} + morning {dayPlaceholder.hoursMorning} + noon {dayPlaceholder.hoursNoon} + eve {dayPlaceholder.hoursEvening} + total {dayPlaceholder.hoursDone}");
                while (counter > 0) //as long as that specific day still has unfilled hours
                {

                    /*begin working on a per-shift basis*/
                    
                    if (dayPlaceholder != null)//if this date already had any shifts assigned/any hours scheduled
                    {
                        
                        if(dayPlaceholder.hoursMorning < hoursPerShift)
                        {
                            //if employee is available, add them here
                            List<ScheduleItem> availableEmps = this.ReturnAvailableEmployees("morning", date);
                            List<ScheduleItem> schedTodayExShift = this.ReturnScheduledEmployeesByDayExlShift(date, "morning");
                            
                            
                            if (availableEmps.Any())
                            {
                                Debug.WriteLine("Looking for employees for date: " + date.ToString() + "morn");
                                Debug.WriteLine(availableEmps[0].empName + date.ToString() + "morning");
                                ScheduleItem preferredEmployee = availableEmps.FirstOrDefault();
                                //CHECK IF EMPLOYEE IS ALREADY SCHEDULED TODAY
                                if (schedTodayExShift != null)
                                for (int i = 0; i<availableEmps.Count(); i++)
                                {
                                        bool matched = false;
                                        for (int j = 0; j<schedTodayExShift.Count(); j++)
                                        {
                                            if (availableEmps[i].empID == schedTodayExShift[j].empID)//IF EMPLOYEE ISN'T Already scheduled today, they become preferred
                                            {
                                                matched = true;
                                            
                                            }
                                        }
                                        if (matched == false)
                                        {
                                            preferredEmployee = availableEmps[i];
                                            break;
                                        }
                                }
                                

                                
                                //IF REACH END CYCLE AND NO EMPLOYEE AVAILABLE THAT IS NOT SCHEDULED TODAY, ADD FIRST EMPLOYEE IN LIST
                                this.AddEmployeeToShift("morning", date, preferredEmployee.empID);
                                dayPlaceholder.hoursMorning += 4;
                                counter -= 4;
                            }
                            else //if there are no available employees, saturate the shift hours and move on to the next shift;
                            {
                                dayPlaceholder.hoursMorning = hoursPerShift;
                                Debug.WriteLine("No available employees found.");
                            }
                            
                        }
                        if(dayPlaceholder.hoursNoon < hoursPerShift)
                        {
                            Debug.WriteLine("Looking for employees for date: " + date.ToString() + "noon");
                            //if employee is available, add them here
                            List<ScheduleItem> availableEmps = this.ReturnAvailableEmployees("afternoon", date);
                            List<ScheduleItem> schedTodayExShift = this.ReturnScheduledEmployeesByDayExlShift(date, "afternoon");
                            
                            if (availableEmps.Any())
                            {
                                Debug.WriteLine(availableEmps[0].empName + date.ToString() + "noon");
                                ScheduleItem preferredEmployee = availableEmps.FirstOrDefault();
                                //CHECK IF EMPLOYEE IS ALREADY SCHEDULED TODAY
                                if (schedTodayExShift != null)
                                for (int i = 0; i < availableEmps.Count(); i++)
                                {
                                        bool matched = false;
                                        for (int j = 0; j < schedTodayExShift.Count(); j++)
                                        {
                                            if (availableEmps[i].empID == schedTodayExShift[j].empID)//IF EMPLOYEE ISN'T Already scheduled today, they become preferred
                                            {
                                                matched = true;

                                            }
                                        }
                                        if (matched == false)
                                        {
                                            preferredEmployee = availableEmps[i];
                                            break;
                                        }

                                    }

                                //IF REACH END CYCLE AND NO EMPLOYEE AVAILABLE THAT IS NOT SCHEDULED TODAY, ADD FIRST EMPLOYEE IN LIST
                                this.AddEmployeeToShift("afternoon", date, preferredEmployee.empID);
                                dayPlaceholder.hoursNoon += 4;
                                counter -= 4;
                            }
                            else //if there are no available employees, saturate the shift hours and move on to next shift
                            {
                                dayPlaceholder.hoursNoon = hoursPerShift;
                                Debug.WriteLine("No available employees found.");
                            }
                        }
                        if(dayPlaceholder.hoursEvening < hoursPerShift)
                        {
                            Debug.WriteLine("Looking for employees for date: " + date.ToString() + "eve");
                            //if employee is available, add them here
                            List<ScheduleItem> availableEmps = this.ReturnAvailableEmployees("evening", date);
                            List<ScheduleItem> schedTodayExShift = this.ReturnScheduledEmployeesByDayExlShift(date, "evening");
                            
                            if (availableEmps.Any())
                            {
                                Debug.WriteLine(availableEmps[0].empName + date.ToString() + "eve");
                                ScheduleItem preferredEmployee = availableEmps.FirstOrDefault();
                                //CHECK IF EMPLOYEE IS ALREADY SCHEDULED TODAY
                                if (schedTodayExShift != null)
                                for (int i = 0; i < availableEmps.Count(); i++)
                                {
                                        bool matched = false;
                                        for (int j = 0; j < schedTodayExShift.Count(); j++)
                                        {
                                            if (availableEmps[i].empID == schedTodayExShift[j].empID)//IF EMPLOYEE ISN'T Already scheduled today, they become preferred
                                            {
                                                matched = true;

                                            }
                                        }
                                        if (matched == false)
                                        {
                                            preferredEmployee = availableEmps[i];
                                            break;
                                        }

                                    }

                                //IF REACH END CYCLE AND NO EMPLOYEE AVAILABLE THAT IS NOT SCHEDULED TODAY, ADD FIRST EMPLOYEE IN LIST
                                this.AddEmployeeToShift("evening", date, preferredEmployee.empID);
                                dayPlaceholder.hoursEvening += 4;
                                counter -= 4;
                            }
                            else //since it's the last shift for the day, if there are no available employees, end the process by setting counter to 0
                            {
                                counter = 0;
                                Debug.WriteLine("No available employees found. Exit clause.");
                            }
                        }
                    }
                    else
                    {
                        dayPlaceholder = new ScheduleDay(date, 0, 0, 0, 0);
                        if (dayPlaceholder.hoursMorning < hoursPerShift)
                        {
                            Debug.WriteLine("Looking for employees for date: " + date.ToString() + "morn");
                            //if employee is available, add them here
                            List<ScheduleItem> availableEmps = this.ReturnAvailableEmployees("morning", date);
                            List<ScheduleItem> schedTodayExShift = this.ReturnScheduledEmployeesByDayExlShift(date, "morning");
                            
                            if (availableEmps.Any())
                            {
                                Debug.WriteLine(availableEmps[0].empName + date.ToString() + "morn");
                                ScheduleItem preferredEmployee = availableEmps.FirstOrDefault();
                                //CHECK IF EMPLOYEE IS ALREADY SCHEDULED TODAY
                                if (schedTodayExShift != null)
                                for (int i = 0; i < availableEmps.Count(); i++)
                                {
                                        bool matched = false;
                                        for (int j = 0; j < schedTodayExShift.Count(); j++)
                                        {
                                            if (availableEmps[i].empID == schedTodayExShift[j].empID)//IF EMPLOYEE ISN'T Already scheduled today, they become preferred
                                            {
                                                matched = true;

                                            }
                                        }
                                        if (matched == false)
                                        {
                                            preferredEmployee = availableEmps[i];
                                            break;
                                        }

                                    }

                                //IF REACH END CYCLE AND NO EMPLOYEE AVAILABLE THAT IS NOT SCHEDULED TODAY, ADD FIRST EMPLOYEE IN LIST
                                this.AddEmployeeToShift("morning", date, preferredEmployee.empID);
                                dayPlaceholder.hoursMorning += 4;
                                counter -= 4;
                            }
                            else //if there are no available employees, saturate the shift hours and move on to next shift
                            {
                                dayPlaceholder.hoursMorning = hoursPerShift;
                                Debug.WriteLine("No available employees found.");
                            }
                        }
                        if (dayPlaceholder.hoursNoon < hoursPerShift)
                        {
                            Debug.WriteLine("Looking for employees for date: " + date.ToString() + "noon");

                            //if employee is available, add them here
                            List<ScheduleItem> availableEmps = this.ReturnAvailableEmployees("afternoon", date);
                            List<ScheduleItem> schedTodayExShift = this.ReturnScheduledEmployeesByDayExlShift(date, "afternoon");
                            
                            if (availableEmps.Any())
                            {
                                Debug.WriteLine(availableEmps[0].empName + date.ToString() + "noon");
                                ScheduleItem preferredEmployee = availableEmps.FirstOrDefault();
                                //CHECK IF EMPLOYEE IS ALREADY SCHEDULED TODAY
                                if (schedTodayExShift != null)
                                for (int i = 0; i < availableEmps.Count(); i++)
                                {
                                        bool matched = false;
                                        for (int j = 0; j < schedTodayExShift.Count(); j++)
                                        {
                                            if (availableEmps[i].empID == schedTodayExShift[j].empID)//IF EMPLOYEE ISN'T Already scheduled today, they become preferred
                                            {
                                                matched = true;

                                            }
                                        }
                                        if (matched == false)
                                        {
                                            preferredEmployee = availableEmps[i];
                                            break;
                                        }

                                    }

                                //IF REACH END CYCLE AND NO EMPLOYEE AVAILABLE THAT IS NOT SCHEDULED TODAY, ADD FIRST EMPLOYEE IN LIST
                                this.AddEmployeeToShift("afternoon", date, preferredEmployee.empID);
                                dayPlaceholder.hoursNoon += 4;
                                counter -= 4;
                            }
                            else //if there are no available employees, saturate the shift hours and move on to next shift
                            {
                                dayPlaceholder.hoursNoon = hoursPerShift;
                                Debug.WriteLine("No available employees found.");
                            }
                        }
                        if (dayPlaceholder.hoursEvening < hoursPerShift)
                        {
                            Debug.WriteLine("Looking for employees for date: " + date.ToString() + "eve");
                            //if employee is available, add them here
                            List<ScheduleItem> availableEmps = this.ReturnAvailableEmployees("evening", date);
                            List<ScheduleItem> schedTodayExShift = this.ReturnScheduledEmployeesByDayExlShift(date, "evening");
                            
                            if (availableEmps.Any())
                            {
                                Debug.WriteLine(availableEmps[0].empName + date.ToString() + "eve");
                                ScheduleItem preferredEmployee = availableEmps.FirstOrDefault();
                                //CHECK IF EMPLOYEE IS ALREADY SCHEDULED TODAY
                                if (schedTodayExShift != null)
                                for (int i = 0; i < availableEmps.Count(); i++)
                                {
                                        bool matched = false;
                                        for (int j = 0; j < schedTodayExShift.Count(); j++)
                                        {
                                            if (availableEmps[i].empID == schedTodayExShift[j].empID)//IF EMPLOYEE ISN'T Already scheduled today, they become preferred
                                            {
                                                matched = true;

                                            }
                                        }
                                        if (matched == false)
                                        {
                                            preferredEmployee = availableEmps[i];
                                            break;
                                        }

                                    }

                                //IF REACH END CYCLE AND NO EMPLOYEE AVAILABLE THAT IS NOT SCHEDULED TODAY, ADD FIRST EMPLOYEE IN LIST
                                this.AddEmployeeToShift("evening", date, preferredEmployee.empID);
                                dayPlaceholder.hoursEvening += 4;
                                counter -= 4;
                            }
                            else //since it's the last shift of the day, if there are no available employees, end the process by setting counter to 0
                            {
                                counter = 0;
                                Debug.WriteLine("No available employees found. Exit clause.");
                            }
                        }
                    }

                    //
                }
            }


        }
    }
}
