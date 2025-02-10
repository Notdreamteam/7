using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._21
{
    class Circle
    {
        public double Area { get; set; }

        public Circle(double area)
        {
            Area = area;
        }

        public double CalculateRadius()
        {
            return Math.Sqrt(Area / Math.PI);
        }
    }
}
