using System;
using Payroll;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PayrollUnitTest
{
    [TestClass]
    public class WorkerTests
    {
        [TestMethod]
        public void TestName()
        {
            string expected = "John Doe";
            Worker w = new Worker();

            string actual = w.Name;
            Assert.AreEqual(expected, actual, "The name is not the same.");
        }

        [TestMethod]
        public void TestId()
        {
            int expected = 1;
            Worker w = new Worker();

            int actual = w.Id;
            Assert.AreEqual(expected, actual, 0.001, "The ID is not the same.");
        }

        [TestMethod]
        public void TestPayRate()
        {
            double expected = 1.11;
            Worker w = new Worker();
            double actual = w.Payrate;
            Assert.AreEqual(expected, actual, 0.001, "The payrate is not the same");

        }

    }
}
