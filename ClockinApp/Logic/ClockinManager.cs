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
    public class ClockinManager
    {
        protected Portread readcard;
        protected DBconnect database;

        public ClockinManager()
        {
            database = new DBconnect();
            readcard = new Portread();
            LoadData();
            
            
        }

        private void LoadData()
        {
            database.clockins = database.LoadClockins();
        }
        
        public int CheckActive(string tag)
        {

                for (int i = 0; i < database.clockins.Count(); i++)
                {
                    if (database.clockins[i].tag == tag && database.clockins[i].status == "Active")
                    {
                        return database.clockins[i].ID;
                    }
                }
                return 0;        
        }

        public void ClockIn()
        {

            string line = readcard.ReadCard();

            if (line == "Waiting for card...")
            {

            }
            else
            {

                
                string time = DateTime.Now.ToString("h:mm yyyy-MM-dd");

                if (CheckActive(line) == 0)
                {
                    int empid = database.GetID(line);
                    database.Clockin(time, empid, line);
                    LoadData();
                    MessageBox.Show($"Clocked in at {time}");
                }
                else
                {
                    int id = CheckActive(line);
                    database.Clockout(id, time);
                    LoadData();
                    MessageBox.Show($"Clocked out at {time}");
                }
            }
            
           
            
        }

        
    }
}
