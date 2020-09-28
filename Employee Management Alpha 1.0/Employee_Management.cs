using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Alpha_1._0
{
    public class Employee_Management
    {
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

        public List<string> ReturnBasicEmployeeInfo()
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
        }

        public void AddEmployee (string first_name, string last_name, DateTime date_of_birth, string bsn, string phone_number, string contract_type)
        {
            this.employee = new Employee(first_name, last_name, date_of_birth, bsn, phone_number, contract_type); //instantiate a new object of type employee
            this.employees.Add(employee); //add it to list of type employee
        }
    }
}
