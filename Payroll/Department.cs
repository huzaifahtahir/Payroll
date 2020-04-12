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

        //****************************************************
        // Method: Department()
        //
        // Purpose: Constructor.
        //          To set default values to Dept fields. 
        //****************************************************
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
            for (int i = 0; i < 5; i++)
            {
                s = new Shift();
                s.WorkerId = Convert.ToString(i + 100);
                Shifts.Add(s);
            }
        }

        //****************************************************
        // Method: FindWorker(int workerId)
        //
        // Purpose: returns worker instance if found in the 
        //          list, otherwise returns nothing.
        //****************************************************
        public Worker FindWorker(int workerId)
        {
            if (Workers.Exists(w => w.Id == workerId))
            {
                //Console.WriteLine("\n" + Workers.Find(w => w.Id == workerId) + "\n");
                return Workers.Find(w => w.Id == workerId);
            }

            else
            {
                Console.WriteLine("\nWorker with that ID does not exist\n");
                return null;
            }

        }

        //****************************************************
        // Method: CalculatePay(int workerId)
        //
        // Purpose: returns pay of worker if the worker exists
        //          otherwise, returns a 0;
        //****************************************************
        public double CalculatePay(int workerId)
        {
            double hours = 0;

            foreach (Shift x in Shifts)
            {
                if (x.WorkerId == Convert.ToString(workerId))
                {
                    hours += x.HoursWorked;
                }
            }

            Worker _worker = FindWorker(workerId);
            double pay = hours * _worker.Payrate;

            return pay;
        }

        //****************************************************
        // Method: CalculateHours(int workerId)
        //
        // Purpose: returns hours of worker if the worker exists
        //          otherwise, returns a 0;
        //****************************************************
        public double CalculateHours(int workerId)
        {
            double hours = 0;

            foreach (Shift x in Shifts)
            {
                if (x.WorkerId == Convert.ToString(workerId))
                {
                    hours += x.HoursWorked;
                }
            }

            return hours;
        }

        //****************************************************
        // Method: CalculateTotalHours
        //
        // Purpose: returns total hours worked by employees;
        // Note:    I realized this was redundant way into
        //          working the rest of the GUI so I left it.
        //****************************************************
        public double CalculateTotalHours()
        {
            double hours = 0;

            foreach (Shift x in Shifts)
            {

                hours += x.HoursWorked;

            }

            return hours;
        }

        //****************************************************
        // Method: ToString()
        //
        // Purpose: To show all the fields of dept for output.
        //****************************************************
        public override string ToString()
        {
            string data = "";

            data += Name + "\n";

            foreach (Worker w in Workers)
            {
                data += w.ToString() + "\n";
            }

            foreach (Shift s in Shifts)
            {
                data += s.ToString() + "\n";
            }
            return data;


            //public override string ToString() => $"{this.Name}, {this.m_Workers}, {this.m_Shifts}";
            //Console.WriteLine("\n" + Name);
            //Workers.ForEach(Console.WriteLine);
            //Shifts.ForEach(Console.WriteLine);
            //=> $"this.name"
        }


        #endregion



    }
}
