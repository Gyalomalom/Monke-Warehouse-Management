using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Employee_Management_Alpha_1._0
{
    public class ShiftManagement
    {
        MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;database=dbi360075;uid=dbi360075;password=monke;");//sql connector
        //attributes
        private List<Shift> shifts;
        private Shift shift; //temporary storage for adding to the list

        //constructor
        public ShiftManagement()
        {
            this.shifts = new List<Shift>();
        }

        //methods

        public Shift GetShiftbyID (int itemId)
        {
            
            
            if (GetAllShifts().Count > 0)//For cycle runs into an error if list is empty, so we check it here and skip the cycle if it's empty
            {
                for (int i = 0; i < GetAllShifts().Count; i++)
                {
                    if (GetAllShifts()[i].Id == itemId)
                    {
                        return GetAllShifts()[i];
                    }
                }
            }
            return null;
        }

        public List<Shift> GetAllShifts ()
        {
            shifts.Clear();
            string sql = "SELECT * FROM shift ORDER BY `shift`.`date`, tod ASC";
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            

            while (dr.Read())
            {
                Tod.TryParse(dr[3].ToString(), out Tod tod);
                var date = Convert.ToDateTime(dr[2]).Date;
                shifts.Add(new Shift(Convert.ToInt32(dr[0]), Convert.ToInt32(dr[1]), date, tod));
            }
            if (shifts.Count() >= 1)

            {
                conn.Close();

                return shifts;
            }
            else
            {
                conn.Close();

                return null;
            }

        }

        /*public void RemoveShiftbyId (string id)
        {
            string sql = $"DELETE FROM `employee` WHERE `employee`.`ID` = {id};";
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            try
            {
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }*/
        /*
        public void ChangeEmployeeStatus(string id, EmployeeStatus status)
        {
            //this.employee = new Employee(); //instantiate a new object of type employee
            //this.employees.Add(employee); //add it to list of type employee
            MySqlConnection connection;
            string connectionString;
            connectionString = "server=studmysql01.fhict.local;database=dbi360075;uid=dbi360075;password=monke;";
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    //MessageBox.Show("Data entered succesfully.");
                    MySqlCommand cmd = new MySqlCommand($"UPDATE `employee` SET `Status` = '{status}' WHERE ID = {id}", connection);
                    cmd.ExecuteNonQuery();


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
        */

        public void AddShift(int empID, DateTime dateOfShift, Tod tod)
        {
            this.shift = new Shift(empID, dateOfShift, tod); //instantiate a new object of type shift
            this.shifts.Add(shift); //add it to list of type employee
            MySqlConnection connection;
            string connectionString;
            connectionString = "server=studmysql01.fhict.local;database=dbi360075;uid=dbi360075;password=monke;";
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    //MessageBox.Show("Data entered succesfully.");
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO shift (employeeID, date, tod) VALUES (@employeeID, @date, @tod)", connection);
                    

                    cmd.Parameters.AddWithValue("@employeeID", empID);
                    cmd.Parameters.AddWithValue("@date", dateOfShift);
                    cmd.Parameters.AddWithValue("@tod", tod);
                    cmd.ExecuteNonQuery();


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }


    }
    }



