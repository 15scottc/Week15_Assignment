using Microsoft.VisualStudio.TestTools.UnitTesting;
using Group2_CompRepair.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group2_CompRepair.Models;

namespace Group2_CompRepair.Controllers.Tests
{
    [TestClass()]
    public class EmployeesControllerTests
    {
        [TestMethod()]
        public void PutEmployeeTest()
        {
            EmployeesController controller = new EmployeesController();
            Employee employee = new Employee
            {
                EmployeeId = 1,
                EmployeeFirstname = "Joh",
                EmployeeLastname = "Green"
            };
            Assert.IsTrue(employee.EmployeeId == 1, "Boss");
        }
    }
}