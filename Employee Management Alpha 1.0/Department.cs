using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Alpha_1._0
{
    class Department
    {

        //attributes

        public string name { get; set; }
        public string department_head { get; set; }
        public string address { get; set; }
        public int phone { get; set; }
        public string email { get; set; }
        public string language { get; set; }
        public int id { get; set; }

        public string status { get; set; }

        //properties

        public string Name
        {
            get { return this.name; }
        }
        public int Id
        {
            get { return this.id; }
        }

        //constructors

        public Department(string name, string department_head, string address, int phone, string email, string language, string status)
        {
            this.name = name;
            this.department_head = department_head;
            this.address = address;
            this.phone = phone;
            this.email = email;
            this.language = language;
            this.status = status;
            
        }



        public Department(int id, string name, string status)
        {
           
            this.id = id;
            this.name = name;
            this.status = status;
        }

        public string GetDepInfo()
        {
            return $"{this.id} {this.name} {this.status}";
        }
    }
}
