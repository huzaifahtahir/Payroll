using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

//******************************************************
// File: Department.cs
//
// Purpose: Contains the class definition for Department.
//          Department will hold all the fields, properties, 
//          and methods for the Department class.
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
    public class Department
    {
        // Declare Fields
        #region Fields
        private string m_Name;
        private List<Worker> m_Workers;
        private List<Shift> m_Shifts;
        private Worker w;
        private Shift s;

        #endregion

        #region Field Properties
        [DataMember(Name = "name")]
        public string Name { get => m_Name; set => m_Name = value; }
        [DataMember(Name = "workers")]
        public List<Worker> Workers { get => m_Workers; set => m_Workers = value; }
        [DataMember(Name = "shifts")]
        public List<Shift> Shifts { get => m_Shifts; set => m_Shifts = value; }
             
        #endregion

        #region Methods

        public Department()
        {
            Name = "HR Department";

            Workers = new List<Worker>();
            for (int i = 0; i < 5; i++)
            {
                w = new Worker();
                w.Id = i + 100;
                Workers.Add(w);
            }

            Shifts = new List<Shift>();
            for(int i = 0; i < 5; i++)
            {
                s = new Shift();
                s.WorkerId = Convert.ToString(i + 100);
                Shifts.Add(s);
            }
        }


        public Worker FindWorker(int workerId)
        {
            if (Workers.Exists(w => w.Id == workerId))
            {
                //Console.WriteLine(Workers.Find(w => w.Id == workerId));
                return Workers.Find(w => w.Id == workerId);
            }

            else
            {
                Console.WriteLine("Worker with that ID does not exist");
                return null;
            }
           
        }

        public double CalculatePay(int workerId)
        {
            double pay = 0;
            if (Workers.Exists(w => w.Id == workerId) && Shifts.Exists(s => s.WorkerId == Convert.ToString(workerId)))
            {
                pay = w.Payrate * s.HoursWorked;             
            }

            return pay;       
        }

        public override string ToString()
        {
            Console.WriteLine("\n" + Name);       
            Workers.ForEach(Console.WriteLine);
            Shifts.ForEach(Console.WriteLine);
            return null;
        }

        
        #endregion



    }
}
