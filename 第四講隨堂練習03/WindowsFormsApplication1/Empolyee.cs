using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Empolyee
    {
        private int baseSalary;
        private int benefit;

        public int BaseSalary
        {
            get { return baseSalary; }
            set {
               baseSalary= (value > 0) ? value : 0;
            }
        }


        public int Benefit
        {
            get { return benefit; }
            set { benefit = value; }
        }
  

        public int Salary
        {
            get { return baseSalary + benefit; }
          
        }
    }
}
