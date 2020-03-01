using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

//******************************************************
// File: Shift.cs
//
// Purpose: Contains the class definition for Shift.
//          Shift will hold all the fields, properties, 
//          and methods for the Shift class.
//          This class was built to be used in the
//          Payroll App.
//
// Written By: Huzaifah Tahir
//
// Compiler: Visual Studio 2019
//
//******************************************************

namespace Payroll
{
    [DataContract]
    public class Shift
    {
        // Declare Fields
        #region Field Variables
        private string m_WorkerId;
        private double m_HoursWorked;
        private DateTime m_Date;
        #endregion

        // Properties for all the fields
        #region Field Properties
        [DataMember(Name = "workid")]
        public string WorkerId { get => m_WorkerId; set => m_WorkerId = value; }

        [DataMember(Name = "hoursworked")]
        public double HoursWorked { get => m_HoursWorked; set => m_HoursWorked = value; }

        [DataMember(Name = "date")]
        public DateTime Date { get => m_Date; set => m_Date = value; }
        #endregion

        // All the methods and overrides
        #region Methods

        //****************************************************
        // Method: Shift()
        //
        // Purpose: Constructor.
        //          To set default values to shift fields. 
        //****************************************************
        public Shift()
        {
            m_WorkerId = "100";
            m_HoursWorked = 5;
            m_Date = new DateTime(1994, 06, 12);
        }

        //****************************************************
        // Method: ToString()
        //
        // Purpose: To show the all the fields for output.
        //****************************************************
        public override string ToString()
        {
            return m_WorkerId + ", " + m_HoursWorked + ", " + m_Date.Month + "/" + m_Date.Day + "/" + m_Date.Year;
        }
        #endregion

    }
}
