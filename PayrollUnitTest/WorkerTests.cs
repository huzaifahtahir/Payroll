using System;
using Payroll;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//******************************************************
// File: WorkerTests.cs
//
// Purpose: Contains the class definition for GameInfo.
//          GameInfo will hold all game information 
//          such as the high/low range of allowable
//          guesses, the number of guesses allowed,
//          the number of guesses the player actually
//          took, and whether or not the player won.
//          This class was built to be used in the
//          NumberGuessing game.
//
// Written By: Arthur Hoskey 
//
// Compiler: Visual Studio 2015
//
//******************************************************

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
