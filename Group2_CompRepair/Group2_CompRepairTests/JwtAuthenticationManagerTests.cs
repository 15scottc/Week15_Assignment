using Microsoft.VisualStudio.TestTools.UnitTesting;
using Group2_CompRepair;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group2_CompRepair.Controllers;
using static Group2_CompRepair.Controllers.ComputerPartsController;

namespace Group2_CompRepair.Tests
{
    [TestClass()]
    public class JwtAuthenticationManagerTests
    {
        [TestMethod()]
        public void AuthenticateTest()
        {
            JwtAuthenticationManager manager = new JwtAuthenticationManager("FakeKeyNotReal1111!");

            User user = new User
            {
                username = "testusername",
                password = "testpassword"
            };

            var ret=manager.Authenticate(user.username, user.password);

            Assert.IsNull(ret);
        }
    }
}