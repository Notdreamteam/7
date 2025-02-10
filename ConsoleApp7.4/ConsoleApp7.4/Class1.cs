using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._4
{
    class class1
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public class1(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public bool R()
        {
            double[] sides = { A, B, C };
            Array.Sort(sides);

            double a = sides[0];
            double b = sides[1];
            double c = sides[2];

            return Math.Abs((a * a + b * b) - (c * c)) < 0.0001; 
        }
    }
}
