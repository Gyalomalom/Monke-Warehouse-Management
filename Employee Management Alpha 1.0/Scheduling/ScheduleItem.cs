using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Alpha_1._0.Scheduling
{
    public class ScheduleItem
    {
        //attributes
        public int dateID { get; set; }
        public int empID { get; set; }
        public bool morning{ get; set; }
        public bool afternoon { get; set; }
        public bool evening { get; set; }
        public int workhours { get; set; }

        //constructor(s)
        public ScheduleItem(int DateID, int EmpID, bool Morning, bool Afternoon, bool Evening)
        {
            this.dateID = DateID;
            this.empID = empID;
            this.morning = Morning;
            this.afternoon = Afternoon;
            this.evening = Evening;
        }


    }
}
