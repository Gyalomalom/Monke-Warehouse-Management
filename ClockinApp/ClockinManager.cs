using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO.Ports;


namespace ClockinApp
{
    class ClockinManager
    {
        Portread readcard;
        MySqlConnection connect;

        public ClockinManager()
        {
            readcard = new Portread();
            connect = new MySqlConnection("server=studmysql01.fhict.local;database=dbi360075;uid=dbi360075;password=monke;");
        }

        public int GetID(string tag)
        {
            int nul = 0;
            
                
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM employee WHERE Tag = '{tag}';", connect);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                int id = Convert.ToInt32(dr[0]);
                dr.Close();
                return id;
            }
            else
            {

                return nul;
            }
            
        } 

        public void ClockIn()
        {

            string line = readcard.ReadCard();

            if (line == "Waiting for card...")
            {

            }
            else
            {

                try
                {
                    connect.Open();
                    if (connect.State == ConnectionState.Open)
                    {
                        int id = GetID(line);
                        string time = DateTime.Now.ToString("HH:mm dd/MM/yyy");
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO clockin (Clockin, Clockout, Status, EmpID) VALUES (@Clockin, @Clockout, @Status, @EmpID)", connect);
                        cmd.Parameters.AddWithValue("@Clockin", time);
                        cmd.Parameters.AddWithValue("@Clockout", "na");
                        cmd.Parameters.AddWithValue("@Status", "Active");
                        cmd.Parameters.AddWithValue("@EmpID", id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Clocked in at" + DateTime.Now.ToString("HH:mm"));
                    }
                }
                catch (Exception expection)
                {
                    MessageBox.Show(expection.Message);
                }
                connect.Close();

            }
            
        }
    }
}
