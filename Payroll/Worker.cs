using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    public class Worker
    {
        #region Field Variables
        private string m_Name;
        private int m_Id;
        private double m_Payrate;
        #endregion

        #region Field Properties
        public int Id { get => m_Id; set => m_Id = value; }
        public double Payrate { get => m_Payrate; set => m_Payrate = value; }
        public string Name { get => m_Name; set => m_Name = value; }
        #endregion

        #region Methods
        public Worker()
        {
            m_Name = "John Doe";
            m_Id = 1;
            m_Payrate = 1.11;
        }

        public override string ToString()
        {
            return m_Name + ", " + m_Id + ", " + m_Payrate;
        }
        #endregion

    }
}
