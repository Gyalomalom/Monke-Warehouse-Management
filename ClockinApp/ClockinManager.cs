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
    class ClockinManager
    {

        MySqlConnection connect = new MySqlConnection("server=studmysql01.fhict.local;database=dbi360075;uid=dbi360075;password=monke;");

        public void ClockIn()
        {
            try
            {
                connect.Open();
                if (connect.State == ConnectionState.Open)
                {
                    string time = DateTime.Now.ToString("HH:mm dd/MM/yyy");
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO clockin (Clockin, Clockout, Status, EmpID) VALUES (@Clockin, @Clockout, @Status, @EmpID)", connect);
                    cmd.Parameters.AddWithValue("@Clockin", time);
                    cmd.Parameters.AddWithValue("@Clockout", "na");
                    cmd.Parameters.AddWithValue("@Status", "Active");
                    cmd.Parameters.AddWithValue("@EmpID", "na");
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
