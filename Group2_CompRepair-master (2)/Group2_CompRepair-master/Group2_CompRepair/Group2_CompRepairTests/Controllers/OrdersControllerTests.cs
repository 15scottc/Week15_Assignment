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
    public class OrdersControllerTests
    {
        [TestMethod()]
        public void GetOrderTest()
        {
            OrdersController controller = new OrdersController();
            Order orders = new Order
            {
                OrderId = 1
            };
            Assert.AreEqual(1,orders.OrderId);
        }
    }
}