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
    public class ScheduleManagement
    {
        protected MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;database=dbi360075;uid=dbi360075;password=monke;");//sql connector

        protected int calWeek;
        protected int year;
        protected string department;
        ScheduleItem sItem;
        
       
        public ScheduleManagement(int year, int CalendarWeek, string department)
        {
            this.year = year;
            this.calWeek = CalendarWeek;
            this.department = department;
        }

        //methods
        public List<int> ReturnDatesbyWeekAndYear()
        {
            List<int> daysbyDate = new List<int>();
            string sql = $@"SELECT y, w, id 
                            FROM time_dimension
                            WHERE y = '{year}' AND w = '{calWeek}'";
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                daysbyDate.Add(Convert.ToInt32(dr["id"]));
            }


            if (daysbyDate.Count() >= 1)

            {
                conn.Close();

                return daysbyDate;
            }
            else
            {
                conn.Close();

                return null;
            }




        }

        public List<ScheduleItem> ReturnEmployeesByShift(string timeofday, int dateID)
        {
            List<ScheduleItem> employees = new List<ScheduleItem>();
            List <ScheduleItem> scheduledEmployees = this.ReturnScheduledEmployees();
            if(scheduledEmployees != null)
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
        

        

        public List<ScheduleItem> ReturnAvailableEmployees(string timeofday, int date)
        {
            List<ScheduleItem> Scheduled = this.ReturnScheduledEmployees();
            List<ScheduleItem> All = this.ReturnEmployeesByDepartment();
            List<ScheduleItem> HrsScheduled = this.ReturnHoursScheduled();
            List<ScheduleItem> Available = new List<ScheduleItem>();
            
            foreach(ScheduleItem person in All ?? new List<ScheduleItem>())
            {
                bool wasScheduled = false;
                foreach (ScheduleItem schedulee in Scheduled ?? new List<ScheduleItem>())
                {
                    if (person.empID == schedulee.empID)
                    {
                        if (schedulee.dateID == date)
                        {
                            if (!((schedulee.morning ? 1 : 0) + (schedulee.afternoon ? 1 : 0) + (schedulee.evening ? 1 : 0) == 0))
                            {
                                if ((schedulee.morning ? 1 : 0) + (schedulee.afternoon ? 1 : 0) + (schedulee.evening ? 1 : 0) == 1)
                                {
                                    foreach(ScheduleItem hours in HrsScheduled)
                                        if (hours.empID == schedulee.empID)
                                            if (hours.contracthours - hours.workhours > 0)
                                            {
                                                
                                                if ((timeofday == "morning") && (schedulee.morning == false))
                                                {
                                                    Available.Add(hours);

                                                    
                                                }
                                                if ((timeofday == "afternoon") && (schedulee.afternoon == false))
                                                {
                                                    Available.Add(hours);

                                                    
                                                }
                                                if ((timeofday == "evening") && (schedulee.evening == false))
                                                {
                                                    Available.Add(hours);

                                                    
                                                }
                                            }

                                }
                                wasScheduled = true;
                            }

                        }
                        
                    }

                }
                if (wasScheduled == false)
                {
                    
                    
                        foreach (ScheduleItem hours in HrsScheduled)
                            if (hours.empID == person.empID)
                                if (hours.contracthours - hours.workhours > 0)                                    
                                        Available.Add(hours);

                }
            }

            return Available;
        }

        public List<ScheduleItem> ReturnEmployeesByDepartment()
        {
            List<ScheduleItem> items = new List<ScheduleItem>();

            string sql = $@"SELECT d.Dep, e.Status, e.ID, CONCAT(e.FirstName, ' ' , e.LastName) AS Name
                            FROM employee as e
                                INNER JOIN (SELECT Dep, EmpID, DepStatus FROM depemp WHERE Dep = '{department}' AND DepStatus = '1') as d
                                    ON d.EmpID = e.ID
                            WHERE Status = 'Active'";

            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                items.Add(new ScheduleItem(Convert.ToInt32(dr["ID"]), Convert.ToString(dr["Name"])));
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

        public void AddEmployeeToShift(string timeofday, int date, int empID)
        {
            string sql;
            //morning code
            if (timeofday == "morning")
            {
                sql = $@"INSERT INTO `schedule` (DateID, EmpID, morning, afternoon, evening)
                            VALUES ({date}, {empID}, 1, 0, 0)
                            ON DUPLICATE KEY UPDATE {timeofday} = 1;";
            }
            else if (timeofday == "afternoon")
            {
                sql = $@"INSERT INTO `schedule` (DateID, EmpID, morning, afternoon, evening)
                            VALUES ({date}, {empID}, 0, 1, 0)
                            ON DUPLICATE KEY UPDATE {timeofday} = 1;";
            }
            else
            {
                sql = $@"INSERT INTO `schedule` (DateID, EmpID, morning, afternoon, evening)
                            VALUES ({date}, {empID}, 0, 0, 1)
                            ON DUPLICATE KEY UPDATE {timeofday} = 1;";
            }

            
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    //MessageBox.Show("Data entered succesfully.");
                    MySqlCommand cmd = new MySqlCommand(sql, this.conn);
                    cmd.ExecuteNonQuery();


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            conn.Close();

        }

        public void RemoveEmployeeFromShift(string timeofday, int date, int empID)
        {
            string sql;
            //morning code
            sql = $@"UPDATE `schedule` SET {timeofday} = '0' WHERE `DateID` = '{date}' AND `EmpID` = '{empID}';";


            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    //MessageBox.Show("Data entered succesfully.");
                    MySqlCommand cmd = new MySqlCommand(sql, this.conn);
                    cmd.ExecuteNonQuery();


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        public List<ScheduleItem> ReturnHoursScheduled()
        {
            List<ScheduleItem> employees = new List<ScheduleItem>();
            ScheduleItem placeholder;
            string sql = $@"SELECT d.Dep, e.Status, e.ID, CONCAT(e.FirstName, ' ' , e.LastName) AS Name, e.WorkingHours AS ShiftsContract, COALESCE(q.ShiftsTotal, 0) AS ShiftsTotal
                            FROM employee as e
                            LEFT JOIN (SELECT td.w, s.EmpID, d.Dep, e.WorkingHours AS shiftsContract, (COALESCE(SUM(s.morning), 0) + COALESCE(SUM(s.afternoon), 0) + COALESCE(SUM(s.evening), 0)) * 4 AS shiftsTotal
                            FROM `schedule` as s
                            INNER JOIN (SELECT y, w, id FROM `time_dimension` WHERE w = '{calWeek}' AND y = '{year}' ) as td

                                ON(s.DateID = td.id)

                                INNER JOIN `employee` as e

                                ON(s.EmpID = e.ID)
                                       
                                	INNER JOIN (SELECT * FROM `depemp` WHERE DepStatus = '1' AND Dep = '{department}') AS d 
                                    ON (d.EmpID = e.ID)
                            GROUP BY s.EmpID) as q
                                ON(e.ID = q.EmpID)
                        INNER JOIN (SELECT * FROM `depemp` WHERE DepStatus = '1' AND Dep = '{department}') AS d 
                                    ON (e.ID = d.EmpID) 
                        HAVING d.Dep = '{department}' AND e.Status = 'Active'
                        ORDER BY e.ID ASC;";

            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                placeholder = new ScheduleItem(Convert.ToInt32(dr["ID"]), Convert.ToString(dr["Name"]), Convert.ToInt32(dr["ShiftsContract"]), Convert.ToInt32(dr["ShiftsTotal"]));
                employees.Add(placeholder);
            }
            if (employees.Count() >= 1)

            {
                conn.Close();

                return employees;
            }
            else
            {
                conn.Close();

                return null;
            }
        }

        public List<ScheduleItem> ReturnScheduledEmployees()
        {
            List<ScheduleItem> items = new List<ScheduleItem>();

            string sql = $@"SELECT td.y, td.w, d.Dep, e.Status, s.DateID, s.EmpID, CONCAT(e.FirstName, ' ' , e.LastName) AS Name, s.morning, s.afternoon, s.evening
                            FROM schedule as s 
                            INNER JOIN employee as e ON s.EmpID = e.ID
                            INNER JOIN (SELECT * FROM depemp WHERE Dep = '{department}' AND DepStatus = '1') as d ON d.EmpID = e.ID
                            INNER JOIN time_dimension as td on s.DateID = td.id
                            HAVING e.Status = 'Active' AND td.y = '{year}' AND td.w = '{calWeek}'";

            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                items.Add(new ScheduleItem(Convert.ToInt32(dr["DateID"]), Convert.ToInt32(dr["EmpID"]), Convert.ToString(dr["Name"]), Convert.ToBoolean(dr["morning"]), Convert.ToBoolean(dr["afternoon"]), Convert.ToBoolean(dr["evening"])));
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



    }
}
