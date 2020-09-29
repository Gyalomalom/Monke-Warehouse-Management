using System;
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
            if(departments.Count != 0)
            {
                for (int i = 0; i < departments.Count; i++)
                {
                    if(this.departments[i].Id == id)
                    {
                        return this.departments[i];
                    }

                }
            }
            return null;
        }

        public void AddDepartment(string name, string department_head, string address, int phone, string email, string language, int id)
        {
            this.department = new Department(name, department_head, address, phone, email, language, id);
            this.departments.Add(department);
            MySqlConnection connection;
            string connectionString;
            connectionString = "server = studmysql01.fhict.local; database = dbi360075; uid = dbi360075; password = monke;";
            connection = new MySqlConnection(connectionString);

            try
            {
                connect.Open();
                if(connection.State == ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO department (Name, Head, Address, Phone, Email, Language, ID) VALUES (@Name, @Head, @Address, @Phone, @Email, @Language, @ID", connection);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Head", department_head);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Language", language);
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception expection)
            {
                MessageBox.Show(expection.Message);
            }
            connection.Close();
        }
            
    }
}
