using Microsoft.VisualStudio.TestTools.UnitTesting;
using Group2_CompRepair.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2_CompRepair.Controllers.Tests
{
    [TestClass()]
    public class ComputerPartsControllerTests
    {
        [TestMethod()]
        public void GetComputerPartTest()
        {
            var parts = new ComputerPartsController();
            var computerParts = parts.GetComputerParts();
            Assert.IsNotNull(computerParts);
        }
    }
}