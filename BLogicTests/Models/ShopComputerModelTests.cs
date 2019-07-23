using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BLogic.Models.Tests {
    [TestClass()]
    public class ShopComputerModelTests {
        [TestMethod()]
        public void StartTest() {
            var model = new ShopComputerModel();
            model.Start();
            Thread.Sleep(10000);
        }
    }
}