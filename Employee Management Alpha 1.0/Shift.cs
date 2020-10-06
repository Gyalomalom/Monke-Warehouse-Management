using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace Employee_Management_Alpha_1._0
{
    public class Shift
    {
        //attributes
        public int id { get; set; }
        public int emp_id { get; set; }
        public DateTime dateOfShift { get; set; }
        public Tod tod { get; set; }

        //string first_name, string last_name, DateTime date_of_birth, string bsn, string postion, int workinghours, string phoneNr, string address, string email, string emergencyC, string emergencyR, string emergencyNr, string certifications, string languages, string contract, string duratio
        //properties
        public int Id
        {
            get { return this.id; }
        }

        //constructors
        public Shift(int emp_id, DateTime dateOfShift, Tod tod)
        {

            this.emp_id = emp_id;
            this.dateOfShift = dateOfShift;
            this.tod = tod;
            
        }

        public Shift(int id, int emp_id, DateTime dateOfShift, Tod tod)
        {

            this.id = id;
            this.emp_id = emp_id;
            this.dateOfShift = dateOfShift;
            this.tod = tod;

        }


        //methods
        public string GetShiftInfo()
        {
            return $"{this.id} {this.emp_id} {this.dateOfShift.ToShortDateString()} {this.tod}";
        }

    }
}
