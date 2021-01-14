using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Alpha_1._0.Logic
{
    public class ScheduleDay : ScheduleItem
    {
        //attributes
        public int hoursDone { get; set; }
        public int hoursMorning { get; set; }
        public int hoursEvening { get; set; }
        public int hoursNoon { get; set; }
        //constructors
        public ScheduleDay(int dateID, int hoursMorning, int hoursNoon, int hoursEvening, int hoursDone)
        {
            this.hoursDone = hoursDone;
            this.dateID = dateID;
            this.hoursMorning = hoursMorning;
            this.hoursNoon = hoursNoon;
            this.hoursEvening = hoursEvening;
        }

    }
}
