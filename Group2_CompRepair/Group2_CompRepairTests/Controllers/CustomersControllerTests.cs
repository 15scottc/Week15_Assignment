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
    public class CustomersControllerTests
    {
        [TestMethod()]
        public void GetCustomerTest()
        {
            CustomersController controller = new CustomersController();

            Customer customer = new Customer
            {
                CustomerId = 5,
                CustomerFirstname = "Cody",
                CustomerLastname = "Scott",
            };

            Assert.IsInstanceOfType(customer.CustomerId, typeof(int));
        }
    }
}