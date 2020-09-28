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

        public Employee GetEmployeebyID (int id)
        {
            if (employees.Count > 0)//For cycle runs into an error if list is empty, so we check it here and skip the cycle if it's empty
            {
                for (int i = 0; i < employees.Count; i++)
                {
                    if (this.employees[i].Id == id)
                    {
                        return this.employees[i];
                    }
                }
            }
            return null;
        }

        public bool RemoveEmployeebyId (int id)
        {

            if (GetEmployeebyID(id) == null)
            {
                return false;
            }
            else
            {
                employees.Remove(GetEmployeebyID(id));
                return true;
            }
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
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO employee (FirstName, LastName, DOB, BSN, Position, WorkingHours, PhoneNr, Address, Email, EmergencyC, EmergencyR, EmergencyNr, Certifications, Languages, ContractType, ContractDuration) VALUES (@FirstName, @LastName, @DOB, @BSN, @Position, @WorkingHours, @PhoneNr, @Address, @Email, @EmergencyC, @EmergencyR, @EmergencyNr, @Certifications, @Languages, @ContractType, @ContractDuration)", connection);
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



