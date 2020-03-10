using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payroll;

//******************************************************
// File: DepartmentTests.cs
//
// Purpose: Contains the class definition for Department 
//          Tests. Department Tests will hold all the unit 
//          test methods for the Worker class.
//          This class was built to be used in Unit
//          Testing for the Department class.
//
// Written By: Huzaifah Tahir 
//
// Compiler: Visual Studio 2019
//
//******************************************************

namespace PayrollUnitTest
{
    [TestClass]
    public class DepartmentTests
    {
        #region TestMethods

        //****************************************************
        // Method: TestFindWithGoodID
        //
        // Purpose: To test the FindWorker method with a valid
        //          id.
        //****************************************************
        [TestMethod]
        public void TestFindWithGoodID()
        {
            Department d = new Department();
            int validID = 101;
            Worker expected = d.FindWorker(validID);

            Assert.AreEqual(expected.Id, validID, "The IDs did not match");

        }

        //****************************************************
        // Method: TestFindWithBadID
        //
        // Purpose: To test the FindWorker method with an 
        //          invalid ID.
        //****************************************************
        [TestMethod]
        public void TestFindWithBadID()
        {
            Department d = new Department();
            int invalidID = 201;
            Worker expected = d.FindWorker(invalidID);

            Assert.AreEqual(expected, null, "The IDs matched. It should be invalid");

        }

        //****************************************************
        // Method: TestCalculatePay
        //
        // Purpose: To test the CalculatePay method and see
        //          if it returns a valid pay.
        //****************************************************
        [TestMethod]
        public void TestCalculatePay()
        {
            Department d = new Department();
            int validID = 101;
            double expectedPay = 5.55;
            double actualPay = d.CalculatePay(validID);

            Assert.AreEqual(expectedPay, actualPay, 0.001, "The Pay did not match");

        }
        #endregion
    }
}
