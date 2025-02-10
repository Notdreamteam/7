using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._3
{
    class class1
    {
        public double X { get; set; }
        public double Y { get; set; }

        public class1(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double D()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
    }
}
