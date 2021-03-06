﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;


namespace Employee_Management_Alpha_1._0
{
    class Department_Management
    {
        MySqlConnection connect = new MySqlConnection("server=studmysql01.fhict.local;database=dbi360075;uid=dbi360075;password=monke;");
        //attributes
        private List<Department> departments;
        private Department department;

        //contructors


        public Department_Management()
        {
            this.departments = new List<Department>();
        }

        //methods 

        public Department FindDepbyID(int id)
        {
            if(FindAllDep().Count > 0)
            {
                for (int i = 0; i < FindAllDep().Count; i++)
                {
                    if(FindAllDep()[i].id == id)
                    {
                        return FindAllDep()[i];
                    }

                }
            }
            return null;
        }
        public List<Department> FindAllDep()
        {
            departments.Clear();
            string sql = "SELECT * FROM department;";
            MySqlCommand cmd = new MySqlCommand(sql, this.connect);
            connect.Open();
            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                departments.Add(new Department(Convert.ToInt32(rd[6]), Convert.ToString(rd[0]), Convert.ToString(rd[7])));
            }
            if(departments.Count() >= 1)
            {
                connect.Close();
                return departments;
            }
            else
            {
                connect.Close();
                return null;
            }

        }

        public void AddDepartment(string name, string department_head, string address, string phone, string email, string language, string status)
        {
            this.department = new Department(name, department_head, address, phone, email, language, status);
            this.departments.Add(department);

            try
            {
                connect.Open();
                if(connect.State == ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO department (Name, Head, Address, Phone, Email, Language, Status) VALUES (@Name, @Head, @Address, @Phone, @Email, @Language, @Status)", connect);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Head", department_head);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Language", language);
                    cmd.Parameters.AddWithValue("@Status", "Active");
                    
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception expection)
            {
                MessageBox.Show(expection.Message);
            }
            connect.Close();
        }

        public void RemoveDepartment(string id)
        {
            string sql = $"DELETE FROM `department` WHERE `department`.`ID` = {id};";
            MySqlCommand cmd = new MySqlCommand(sql, this.connect);
            try
            {
                connect.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connect.Close();

        }
        public void UpdateStatus(string id, DepartmentStatus status)
        {
            try
            {
                connect.Open();
                if(connect.State == ConnectionState.Open)
                {

                    MySqlCommand cmd = new MySqlCommand($"UPDATE `department` SET `Status` = '{status}' WHERE `ID` = {id}", this.connect);
                    cmd.ExecuteNonQuery();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AssignEmployee(string name, string id)
        {
            try
            {
                connect.Open();
                if (connect.State == ConnectionState.Open)
                {

                    MySqlCommand cmd = new MySqlCommand($@"INSERT INTO `depemp` (`Dep`, `EmpID`, `DepStatus`) VALUES ('{name}', '{id}', '1')
                                                        ON DUPLICATE KEY UPDATE `DepStatus` = '1';", this.connect);

                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void UnassignEmployee(string name, string id)
        {
            try
            {
                connect.Open();
                if (connect.State == ConnectionState.Open)
                {

                    MySqlCommand cmd = new MySqlCommand($@"INSERT INTO `depemp` (`Dep`, `EmpID`, `DepStatus`) VALUES ('{name}', '{id}', '0')
                                                        ON DUPLICATE KEY UPDATE `DepStatus` = '0';", this.connect);

                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public List<Employee> ReturnEmployeesByDepartment (string name)
        {
            List<Employee> employees = new List<Employee>();
            string sql = $@"SELECT * FROM `depemp`
                          INNER JOIN employee as e ON(e.ID = EmpID)
                          WHERE Dep = '{name}' AND DepStatus = '1' AND e.Status = 'Active'";
            MySqlCommand cmd = new MySqlCommand(sql, this.connect);
            connect.Open();
            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                employees.Add(new Employee(Convert.ToInt32(rd["ID"]), Convert.ToString(rd["FirstName"]), Convert.ToString(rd["LastName"])));
            }
            if (departments.Count() >= 1)
            {
                connect.Close();
                return employees;
            }
            else
            {
                connect.Close();
                return null;
            }
        }

     
            
    }
}
