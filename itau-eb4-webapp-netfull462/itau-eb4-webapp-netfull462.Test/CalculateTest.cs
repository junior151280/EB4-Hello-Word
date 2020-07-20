using System;
using itau_eb4_webapp_netfull462.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace itau_eb4_webapp_netfull462.Test
{
    [TestClass]
    public class CalculateTest
    {
        private readonly Calculate calculate = new Calculate();
        [TestMethod]
        public void PassingTest()
        {
            Assert.AreEqual(4, calculate.Add(2, 2));
        }

        [TestMethod]
        public void FailingTest()
        {
            Assert.AreNotEqual(5, calculate.Add(2, 2));
        }
    }
}
