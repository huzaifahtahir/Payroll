using System;
using Payroll;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PayrollUnitTest
{
    [TestClass]
    public class ShiftTests
    {
        [TestMethod]
        public void TestWorkerId()
        {
            string expected = "R1";
            Shift s = new Shift();

            string actual = s.WorkerId;
            Assert.AreEqual(expected, actual, "The IDs did not match");

        }

        [TestMethod]
        public void TestHoursWorked()
        {
            double expected = 5;
            Shift s = new Shift();

            double actual = s.HoursWorked;
            Assert.AreEqual(expected, actual, 0.001, "The hours worked did not match.");
        }

        [TestMethod]
        public void TestDate()
        {
            DateTime expected = new DateTime(1994, 06, 12);
            Shift s = new Shift();

            DateTime actual = s.Date;
            Assert.AreEqual(expected, actual, "The date did not match");
        }

    }
}
