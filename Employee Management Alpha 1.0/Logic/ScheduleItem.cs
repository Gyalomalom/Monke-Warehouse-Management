using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Alpha_1._0.Logic
{
    public class ScheduleItem : ManagementItem
    {
        //attributes
        public int dateID { get; set; }
        public string empName { get; set; }
        public int empID { get; set; }
        public bool morning{ get; set; }
        public bool afternoon { get; set; }
        public bool evening { get; set; }
        public int workhours { get; set; }
        public int contracthours { get; set; }

        //constructor(s)
        public ScheduleItem(int DateID, int EmpID, bool Morning, bool Afternoon, bool Evening)
        {
            this.dateID = DateID;
            this.empID = empID;
            this.morning = Morning;
            this.afternoon = Afternoon;
            this.evening = Evening;
        }

        public ScheduleItem(int DateID, int EmpID, string Name, bool Morning, bool Afternoon, bool Evening)
        {
            this.dateID = DateID;
            this.empID = EmpID;
            this.morning = Morning;
            this.afternoon = Afternoon;
            this.evening = Evening;
            this.empName = Name;
        }

        public ScheduleItem(int EmpID, string Name)
        {
            this.empID = EmpID;
            this.empName = Name;

        }

        public ScheduleItem (int EmpID, string Name, int HoursContract, int HoursActual)
        {
            this.empID = EmpID;
            this.empName = Name;
            this.contracthours = HoursContract;
            this.workhours = HoursActual;
        }


    }
}
