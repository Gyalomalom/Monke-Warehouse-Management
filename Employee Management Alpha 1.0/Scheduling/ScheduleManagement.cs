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
                daysbyDate.Add( Convert.ToInt32(dr["id"]));
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
    }
}
