using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    class Worker
    {
        private string m_Name;
        private int m_Id;
        private double m_Payrate;


        public int Id { get => m_Id; set => m_Id = value; }
        public double Payrate { get => m_Payrate; set => m_Payrate = value; }
        public string Name { get => m_Name; set => m_Name = value; }

        public Worker()
        {
            m_Name = "John Doe";
            m_Id = 1;
            m_Payrate = 1.11;
        }

        public override string ToString()
        {
            return Name + Id + Payrate;
        }

    }
}
