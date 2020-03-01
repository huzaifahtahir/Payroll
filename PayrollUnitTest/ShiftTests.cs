using System;
using Payroll;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//******************************************************
// File: ShiftTests.cs
//
// Purpose: Contains the class definition for ShiftTests.
//          ShiftTests will hold all the unit test methods
//          for the Shift class.
//          This class was built to be used in Unit
//          Testing for the Shift class.
//
// Written By: Huzaifah Tahir
//
// Compiler: Visual Studio 2019
//
//******************************************************

namespace PayrollUnitTest
{
    [TestClass]
    public class ShiftTests
    {
        #region Test Methods
        //****************************************************
        // Method: TestWorkerId
        //
        // Purpose: To test the Worker ID for unit testing.
        //****************************************************

        [TestMethod]
        public void TestWorkerId()
        {
            string expected = "100";
            Shift s = new Shift();

            string actual = s.WorkerId;
            Assert.AreEqual(expected, actual, "The IDs did not match");

        }

        //****************************************************
        // Method: TestHoursWorked
        //
        // Purpose: To test the hours worked for unit testing.
        //****************************************************
        [TestMethod]
        public void TestHoursWorked()
        {
            double expected = 5;
            Shift s = new Shift();

            double actual = s.HoursWorked;
            Assert.AreEqual(expected, actual, 0.001, "The hours worked did not match.");
        }

        //****************************************************
        // Method: TestDate
        //
        // Purpose: To test the date for unit testing.
        //****************************************************
        [TestMethod]
        public void TestDate()
        {
            DateTime expected = new DateTime(1994, 06, 12);
            Shift s = new Shift();

            DateTime actual = s.Date;
            Assert.AreEqual(expected, actual, "The date did not match");
        }
        #endregion
    }
}
