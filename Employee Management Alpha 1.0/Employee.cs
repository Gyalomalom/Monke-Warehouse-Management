using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Alpha_1._0
{
    public class Employee
    {
        //attributes
        private int id;
        private string first_name;
        private string last_name;
        private DateTime date_of_birth;
        private string bsn; //social security number in the Netherlands
        private string company_function;//their role in the company. To be potentially replaced by Enum later
        private int working_hours_per_week;
        private string phone_number;
        private string address;
        private string email;
        private string emergency_contact; //full name of emergency contact
        private string emergency_relation;//How this contact relates to the employee? (Spouse, sibling, parent etc)
        private string emergency_number; //emergency contact phone number for contact
        private List<string> certifications; //primarily relevant for depo workers
        private List<string> languages_spoken;//primarily relevant for sales reps, cashiers and customer support
        private string contract_type;
        private string contract_duration;
        private static int idSeed = 100;

        //properties
        public int Id
        {
            get { return this.id; }
        }

        public string Firstname
        {
            get { return this.first_name; }
        }

        public string Lastname
        {
            get { return this.last_name; }
        }

        //constructors
        public Employee(string first_name, string last_name, DateTime date_of_birth, string bsn, string phone_number, string contract_type)
        {
            idSeed++;
            this.id = idSeed;
            this.first_name = first_name;
            this.last_name = last_name;
            this.date_of_birth = date_of_birth;
            this.bsn = bsn;
            this.phone_number = phone_number;
            this.contract_type = contract_type;
        }

        //methods
        public string Return_Employee_Info()
        {
            return $"Employee full name: {this.first_name} {this.last_name}, Date of birth: {Convert.ToString(this.date_of_birth)}";
        }

    }
}
