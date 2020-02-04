using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    public class Shift
    {

        #region Field Variables
        private string m_WorkerId;
        private double m_HoursWorked;
        private DateTime m_Date;
        #endregion

        #region Field Properties
        public string WorkerId { get => m_WorkerId; set => m_WorkerId = value; }
        public double HoursWorked { get => m_HoursWorked; set => m_HoursWorked = value; }
        public DateTime Date { get => m_Date; set => m_Date = value; }
        #endregion

        #region Methods
        public Shift()
        {
            m_WorkerId = "100";
            m_HoursWorked = 5;
            m_Date = new DateTime(1994, 06, 12);
        }


        public override string ToString()
        {
            return m_WorkerId + ", " + m_HoursWorked + ", " + m_Date;
        }
        #endregion

    }
}
