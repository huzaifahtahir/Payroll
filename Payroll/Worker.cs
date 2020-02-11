using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

//******************************************************
// File: Worker.cs
//
// Purpose: Contains the class definition for Worker.
//          Worker will hold all the fields, properties, 
//          and methods for the Worker class for info 
//          such as their Name, ID, and Payrate.
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
    public class Worker
    {
        // Declare Fields
        #region Field Variables
        private string m_Name;
        private int m_Id;
        private double m_Payrate;
        #endregion

        // Define properties for fields
        #region Field Properties
        [DataMember(Name = "id")]
        public int Id { get => m_Id; set => m_Id = value; }

        [DataMember(Name = "payrate")]
        public double Payrate { get => m_Payrate; set => m_Payrate = value; }

        [DataMember(Name = "name")]
        public string Name { get => m_Name; set => m_Name = value; }
        #endregion

        // All the methods and overrides
        #region Methods

        //****************************************************
        // Method: Worker()
        //
        // Purpose: Constructor.
        //          To set default values to worker fields. 
        //****************************************************
        public Worker()
        {
            m_Name = "John Doe";
            m_Id = 1;
            m_Payrate = 1.11;
        }

        //****************************************************
        // Method: ToString()
        //
        // Purpose: To show the all the fields for output.
        //****************************************************
        public override string ToString()
        {
            return m_Name + ", " + m_Id + ", " + m_Payrate;
        }
        #endregion

    }
}
