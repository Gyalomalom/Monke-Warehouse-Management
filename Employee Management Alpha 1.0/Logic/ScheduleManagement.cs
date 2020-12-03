using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Employee_Management_Alpha_1._0.Scheduling
{
    public class ScheduleManagement
    {
        MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;database=dbi360075;uid=dbi360075;password=monke;");//sql connector

        int calWeek;
        int year;
        ScheduleItem sItem;
        
        //Constructor(s)
        public ScheduleManagement(int year, int CalendarWeek)
        {
            this.year = year;
            this.calWeek = CalendarWeek;
        }

        //methods
        public List<int> ReturnDatesbyDay()
        {
            List<int> daysbyDate = new List<int>();
            string sql = $"SELECT * FROM `time_dimension` WHERE `y` = {year} AND `w` = { calWeek };";
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            int i = 0;


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

        public List<int> ReturnEmployeesByShift(int timeofday, int dateID)
        {
            List<int> employees = new List<int>();
            string sql;
            if (timeofday == 1)
            {
                //morning code
                sql = $"SELECT `EmpID` FROM `schedule` WHERE `DateID` = '{dateID}' AND `morning`= '1'";
            }
            else if (timeofday == 2)
            {
                //afternoon code
                sql = $"SELECT `EmpID` FROM `schedule` WHERE `DateID` = '{dateID}' AND `afternoon`= '1'";
            }
            else
            {
                //evening code
                sql = $"SELECT `EmpID` FROM `schedule` WHERE `DateID` = '{dateID}' AND `evening`= '1'";
            }

            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            int i = 0;


            while (dr.Read())
            {
                employees.Add(Convert.ToInt32(dr["EmpID"]));
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
        /*method to return the shifts an employee has when given a specified date and employee ID, still unfinished*/

        public List<ScheduleItem> ReturnEmployeeShiftsByDate(int DateID, int EmpID)
        {
            List<ScheduleItem> employeeWithShifts = new List<ScheduleItem>();
            string sql = $"SELECT * FROM `schedule` WHERE `DateID` = '{DateID}' AND `EmpID`= '{EmpID}';";

            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                employeeWithShifts.Add(new ScheduleItem(Convert.ToInt32(dr["DateID"]), Convert.ToInt32(dr["EmpID"]), Convert.ToBoolean(dr["morning"]), Convert.ToBoolean(dr["afternoon"]), Convert.ToBoolean(dr["evening"])));
            }


            if (employeeWithShifts.Count() >= 1)

            {
                conn.Close();

                return employeeWithShifts;
            }
            else
            {
                conn.Close();

                return null;
            }

        }

        

        public List<int> ReturnAvailableEmployeesPerDate(int DateID, List<int> empIDs, string ToD)
        {
            List<int> availableEmployeeIds = new List<int>();
            
            foreach (int id in empIDs)
            {
                ScheduleItem schPlaceholder;
                   
                if (this.ReturnEmployeeShiftsByDate(DateID, id) != null)
                {
                    schPlaceholder = this.ReturnEmployeeShiftsByDate(DateID, id)[0];
                    if (!((ToD == "morning") && schPlaceholder.morning)||((ToD == "afternoon") && schPlaceholder.afternoon)||((ToD == "evening") && schPlaceholder.evening))
                    {
                        if ((!(schPlaceholder.morning)&& !(schPlaceholder.afternoon))||(!(schPlaceholder.afternoon) && !(schPlaceholder.evening)) ||(!(schPlaceholder.morning) && !(schPlaceholder.evening)))
                        {
                            availableEmployeeIds.Add(id);
                        }
                    }
                  
                }
                else
                {
                    availableEmployeeIds.Add(id);
                }

            }

            if (availableEmployeeIds.Count() >= 1)
            {
                return availableEmployeeIds;
            }
            else
            {
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

        public Dictionary<int, int> ReturnHoursScheduled(string department)
        {
            Dictionary<int, int> EmpWorkHours = new Dictionary<int, int>();
            string sql = $@"SELECT td.w, s.EmpID, e.Department, (COALESCE(SUM(s.morning), 0) + COALESCE(SUM(s.afternoon), 0) + COALESCE(SUM(s.evening), 0)) * 4 AS shiftsTotal
                            FROM `schedule` as s
                            INNER JOIN `time_dimension` as td

                                ON(s.DateID = td.id)

                                INNER JOIN `employee` as e

                                ON(s.EmpID = e.ID)
                            GROUP BY s.EmpID
                            HAVING td.w = '{calWeek}' AND e.Department = '{department}';";

            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                EmpWorkHours.Add(Convert.ToInt32(dr["EmpID"]), Convert.ToInt32(dr["shiftsTotal"]));
            }
            if (EmpWorkHours.Count() >= 1)

            {
                conn.Close();

                return EmpWorkHours;
            }
            else
            {
                conn.Close();

                return null;
            }
        }


    }
}
