using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp2.Test
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
