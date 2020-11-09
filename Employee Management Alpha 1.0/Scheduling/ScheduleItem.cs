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
        private int dateID { get; set; }
        private int empID { get; set; }
        private bool morning{ get; set; }
        private bool afternoon { get; set; }
        private bool evening { get; set; }

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
