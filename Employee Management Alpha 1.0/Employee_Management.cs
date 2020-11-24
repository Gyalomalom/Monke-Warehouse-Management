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
    public class Employee_Management
    {
        MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;database=dbi360075;uid=dbi360075;password=monke;");//sql connector
        //attributes
        private List<Employee> employees;
        private Employee employee; //temporary storage for adding to the list

        //constructor
        public Employee_Management()
        {
            this.employees = new List<Employee>();
        }

        //methods

        public Employee GetEmployeebyID (int itemId)
        {
            
            
            if (GetAllEmployees().Count > 0)//For cycle runs into an error if list is empty, so we check it here and skip the cycle if it's empty
            {
                for (int i = 0; i < GetAllEmployees().Count; i++)
                {
                    if (GetAllEmployees()[i].Id == itemId)
                    {
                        return GetAllEmployees()[i];
                    }
                }
            }
            return null;
        }

        

        public List<Employee> GetAllEmployees ()
        {
            employees.Clear();
            string sql = "SELECT * FROM employee;";
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            
            while(dr.Read())
            {
                employees.Add(new Employee(Convert.ToInt32(dr[0]), Convert.ToString(dr[1]), Convert.ToString(dr[2]), Convert.ToString(dr[18]), Convert.ToString(dr[19])));
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

        /*public string GetEmployeeAccount(string email, string password)
        {
            if (GetAllEmployees().Count > 0)//For cycle runs into an error if list is empty, so we check it here and skip the cycle if it's empty
            {
                for (int i = 0; i < GetAllEmployees().Count; i++)
                {
                    if (GetAllEmployees()[i].email == email && GetAllEmployees()[i].password == password)
                    {
                        return GetAllEmployees()[i].postion;
                    }
                }
            }
            return null;
        }*/

        public void RemoveEmployeebyId (string id)
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
        }

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
        /*public List<string> ReturnBasicEmployeeInfo()
        {
            List<string> info = new List<string>();
            if (employees.Count > 0)//For cycle runs into an error if list is empty, so we check it here and skip the cycle if it's empty
            {
                for (int i = 0; i < employees.Count; i++)
                {
                        info.Add(this.employees[i].Return_Employee_Info());
                }
            }
            else
            {
                return null;
            }
            return info;
        }*/

        /*public void AddEmployee (string first_name, string last_name, DateTime date_of_birth, string bsn, string postion, int workinghours, string phoneNr, string address, string email, string emergencyC, string emergencyR, string emergencyNr, string certifications, string languages, string contract, string duration)
        {
            this.employee = new Employee(first_name, last_name, date_of_birth, bsn, postion, workinghours, phoneNr, address, email, emergencyC, emergencyR, emergencyNr, certifications, languages, contract, duration); //instantiate a new object of type employee
            this.employees.Add(employee); //add it to list of type employee
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
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO employee (FirstName, LastName, DOB, BSN, Position, WorkingHours, PhoneNr, Address, Email, EmergencyC, EmergencyR, EmergencyNr, Certifications, Languages, ContractType, ContractDuration) VALUES (@FirstName, @LastName, @DOB, @BSN, @Position, @WorkingHours, @PhoneNr, @Address, @Email, @EmergencyC, @EmergencyR, @EmergencyNr, @Certifications, @Languages, @ContractType, @ContractDuration)", connection);
                    //cmd.Parameters.AddWithValue("@employeeID", Convert.ToInt32(tbEmployeeID.Text));

                    cmd.Parameters.AddWithValue("@FirstName", first_name);
                    cmd.Parameters.AddWithValue("@LastName", last_name);
                    cmd.Parameters.AddWithValue("@DOB", date_of_birth);
                    cmd.Parameters.AddWithValue("@BSN", Convert.ToString(tbTel.Text));
                    cmd.Parameters.AddWithValue("@Position", Convert.ToString(richTextBox1.Text));
                    cmd.Parameters.AddWithValue("@WorkingHours", Convert.ToString(tbContactName.Text));
                    cmd.Parameters.AddWithValue("@PhoneNr", Convert.ToString(tbContactPhone.Text));
                    cmd.Parameters.AddWithValue("@Address", Convert.ToDecimal(tbSalary.Text));
                    cmd.Parameters.AddWithValue("@Email", Convert.ToString(comboBox1.SelectedItem));
                    cmd.Parameters.AddWithValue("@EmergencyC", Convert.ToString(comboBox2.SelectedItem));
                    cmd.Parameters.AddWithValue("@EmergencyR", Convert.ToString(tbEmpPassword.Text));
                    cmd.Parameters.AddWithValue("@EmergencyNr", Convert.ToString(tbEmpUsername.Text));
                    cmd.Parameters.AddWithValue("@Certifications", Convert.ToString(tbEmpUsername.Text));
                    cmd.Parameters.AddWithValue("@Languages", Convert.ToString(tbEmpUsername.Text));
                    cmd.Parameters.AddWithValue("@ContractType", Convert.ToString(tbEmpUsername.Text));
                    cmd.Parameters.AddWithValue("@ContractDuration", Convert.ToString(tbEmpUsername.Text));
                    cmd.ExecuteNonQuery();


                } }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }*/
        public void AddEmployeeTest(string first_name, string last_name)
        {
            this.employee = new Employee(first_name, last_name); //instantiate a new object of type employee
            this.employees.Add(employee); //add it to list of type employee
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
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO employee (FirstName, LastName, DOB, BSN, Position, WorkingHours, PhoneNr, Address, Email, EmergencyC, EmergencyR, EmergencyNr, Certifications, Languages, ContractType, ContractDuration, Status) VALUES (@FirstName, @LastName, @DOB, @BSN, @Position, @WorkingHours, @PhoneNr, @Address, @Email, @EmergencyC, @EmergencyR, @EmergencyNr, @Certifications, @Languages, @ContractType, @ContractDuration, @Status)", connection);
                    //cmd.Parameters.AddWithValue("@employeeID", Convert.ToInt32(tbEmployeeID.Text));

                    cmd.Parameters.AddWithValue("@FirstName", first_name);
                    cmd.Parameters.AddWithValue("@LastName", last_name);
                    cmd.Parameters.AddWithValue("@DOB", "2020-09-27");
                    cmd.Parameters.AddWithValue("@BSN", "");
                    cmd.Parameters.AddWithValue("@Position", "");
                    cmd.Parameters.AddWithValue("@WorkingHours", 20);
                    cmd.Parameters.AddWithValue("@PhoneNr", "");
                    cmd.Parameters.AddWithValue("@Address", "");
                    cmd.Parameters.AddWithValue("@Email", "");
                    cmd.Parameters.AddWithValue("@EmergencyC", "");
                    cmd.Parameters.AddWithValue("@EmergencyR", "");
                    cmd.Parameters.AddWithValue("@EmergencyNr", "");
                    cmd.Parameters.AddWithValue("@Certifications", "");
                    cmd.Parameters.AddWithValue("@Languages", "");
                    cmd.Parameters.AddWithValue("@ContractType", "");
                    cmd.Parameters.AddWithValue("@ContractDuration", "");
                    cmd.Parameters.AddWithValue("@Status", "Active");
                    cmd.ExecuteNonQuery();


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
        public void ChangeEmployeeTest(string id, string first_name, string last_name)
        {
            this.employee = new Employee(first_name, last_name); //instantiate a new object of type employee
            this.employees.Add(employee); //add it to list of type employee
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
                    MySqlCommand cmd = new MySqlCommand($"UPDATE `employee` SET `FirstName` = '{first_name}', `LastName` = '{last_name}' WHERE ID = {id}", connection);
                    //, `DOB`, `BSN`, `Position`, `WorkingHours`, `PhoneNr`, `Address`, `Email`, `EmergencyC`, `EmergencyR`, `EmergencyNr`, `Certifications`, `Languages`, `ContractType`, `ContractDuration`
                    //cmd.Parameters.AddWithValue("@employeeID", Convert.ToInt32(tbEmployeeID.Text));

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



