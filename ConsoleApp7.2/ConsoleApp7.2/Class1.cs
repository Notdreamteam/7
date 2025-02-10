using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._2
{
    class class1
    {
       
        public double a { get; set; }
        public int b { get; set; }

      
        public class1(double A, int B)
        {
            a = A;
            b = B;
        }

       
        public double C()
        {
            if (b >= 2 && b < 5)
            {
                return a * 0.02; 
            }
            else if (b >= 5 && b < 10)
            {
                return a * 0.05; 
            }
            else
            {
                return 0; 
            }
        }

       
        public double D()
        {
            return a + C();
        }
    }
}
