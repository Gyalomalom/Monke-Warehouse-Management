using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Employee_Management_Alpha_1._0.Database;
using Employee_Management_Alpha_1._0.Logic;

namespace AutoSchedulerTests
{
    [TestClass]
    public class SchedulerTests
    {
        [TestMethod]
        public void AvailableEmployeesTest()
        {
            AutoScheduler autoSched = new AutoScheduler(2021, 3, "Cleaning");
            autoSched.ReturnAvailableEmployees("afternoon", 20210124);
        }
    }
}
