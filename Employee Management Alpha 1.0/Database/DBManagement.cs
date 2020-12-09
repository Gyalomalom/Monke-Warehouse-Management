using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using Employee_Management_Alpha_1._0.Logic;
using System.Threading.Tasks;

namespace Employee_Management_Alpha_1._0.Database
{
    public class DBManagement
    {
        private string sql;
        public DBManagement(string sql)
        {
            this.sql = sql;
        }

        public List<ManagementItem> ExecuteSQL()
        {
            List < ManagementItem > items = new List<ManagementItem>();
            using (MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;database=dbi360075;uid=dbi360075;password=monke;"))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    conn.Open();
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                               items.Add(new ScheduleItem(Convert.ToInt32(dr["DateID"]), Convert.ToInt32(dr["EmpID"]), Convert.ToBoolean(dr["morning"]), Convert.ToBoolean(dr["afternoon"]), Convert.ToBoolean(dr["evening"])));
                            }
                        }

                    }

                }

            }
            return items;
        }

    }
}
