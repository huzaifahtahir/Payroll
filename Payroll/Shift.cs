using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    class Shift
    {
        #region Field Variables
        private string m_WorkerId;
        private double m_HoursWorked;
        private DateTime m_Date;
        #endregion

        public string WorkerId { get => m_WorkerId; set => m_WorkerId = value; }
        public double HoursWorked { get => m_HoursWorked; set => m_HoursWorked = value; }
        public DateTime Date { get => m_Date; set => m_Date = value; }

        public Shift()
        {
            m_WorkerId = "R1";
            m_HoursWorked = 5;
            m_Date = new DateTime(1994, 06, 12);
        }


    }
}
