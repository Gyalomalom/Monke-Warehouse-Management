using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ClockinApp
{
    public class DBconnect
    {

        public List<Clockin> clockins = new List<Clockin>();

        MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;database=dbi360075;uid=dbi360075;password=monke;");

        public List<Clockin> LoadClockins()
        {
            string sql = "SELECT * FROM clockin;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                clockins.Add(new Clockin(Convert.ToInt32(dr[0]), Convert.ToString(dr[1]), Convert.ToString(dr[2]), Convert.ToString(dr[3]), Convert.ToInt32(dr[4]), Convert.ToString(dr[5])));
            }
            if (clockins.Count() >= 1)

            {
                conn.Close();

                return clockins;
            }
            else
            {
                conn.Close();

                return null;
            }

        }

        public void Clockin(string time, int id, string line)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO clockin (Clockin, Clockout, Status, EmpID, Tag) VALUES (@Clockin, @Clockout, @Status, @EmpID, @Tag)", conn);
            cmd.Parameters.AddWithValue("@Clockin", time);
            cmd.Parameters.AddWithValue("@Clockout", "na");
            cmd.Parameters.AddWithValue("@Status", "Active");
            cmd.Parameters.AddWithValue("@EmpID", id);
            cmd.Parameters.AddWithValue("@Tag", line);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Clockout(int id, string time)
        {

            string sql = $"UPDATE `clockin` SET `Status` = 'Inactive', `Clockout` = '{time}' WHERE ID = {id}";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public int GetID(string tag)
        {
            int nul = 0;

            conn.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM employee WHERE Tag = '{tag}';", conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                int id = Convert.ToInt32(dr[0]);
                dr.Close();
                conn.Close();
                return id;
            }
            else
            {
                dr.Close();
                conn.Close();
                return nul;
            }

        }
    }
}
