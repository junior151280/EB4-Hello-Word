using NUnit.Framework;
using DotNetCore_Hello_World_App;


namespace DotNetCore_Hello_World_App_Test
{
    public class Tests
    {
        Calculate calc = new Calculate();

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void PassingTest()
        {
            
            Assert.AreEqual(4, calc.Add(2, 2));
        }

        [Test]
        public void FailingTest()
        {
            Assert.AreNotEqual(5, calc.Add(2, 2));
        }
    }
}