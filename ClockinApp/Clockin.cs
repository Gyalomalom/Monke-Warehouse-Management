using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockinApp
{
    class Clockin
    {
        public int ID { get; set; }
        public string clockin { get; set; }
        public string clockout { get; set; }
        public string status { get; set; }
        public int empid { get; set; }
        public string tag { get; set; }

        public Clockin(int id, string clockin, string clockout, string status, int empid, string tag)
        {
            this.ID = id;
            this.clockin = clockin;
            this.clockout = clockout;
            this.status = status;
            this.empid = empid;
            this.tag = tag;
        }
    }
}
