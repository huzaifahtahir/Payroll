using System;
using Payroll;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//******************************************************
// File: WorkerTests.cs
//
// Purpose: Contains the class definition for WorkerTests.
//          WorkerTests will hold all the unit test methods
//          for the Worker class.
//          This class was built to be used in Unit
//          Testing for the Worker class.
//
// Written By: Huzaifah Tahir 
//
// Compiler: Visual Studio 2019
//
//******************************************************

namespace PayrollUnitTest
{
    [TestClass]
    public class WorkerTests
    {
        #region Test Methods
        //****************************************************
        // Method: TestName
        //
        // Purpose: To test the name for unit testing.
        //****************************************************

        [TestMethod]
        public void TestName()
        {
            string expected = "John Doe";
            Worker w = new Worker();

            string actual = w.Name;
            Assert.AreEqual(expected, actual, "The name is not the same.");
        }

        //****************************************************
        // Method: TestId
        //
        // Purpose: To test the ID for unit testing.
        //****************************************************
        [TestMethod]
        public void TestId()
        {
            int expected = 1;
            Worker w = new Worker();

            int actual = w.Id;
            Assert.AreEqual(expected, actual, 0.001, "The ID is not the same.");
        }

        //****************************************************
        // Method: TestPayRate
        //
        // Purpose: To test the payrate for unit testing.
        //****************************************************
        [TestMethod]
        public void TestPayRate()
        {
            double expected = 1.11;
            Worker w = new Worker();
            double actual = w.Payrate;
            Assert.AreEqual(expected, actual, 0.001, "The payrate is not the same");
        }
        #endregion
    }
}
