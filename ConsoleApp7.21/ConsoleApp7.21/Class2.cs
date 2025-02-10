using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._21
{
    class Square
    {
        public double Area { get; set; }

        public Square(double area)
        {
            Area = area;
        }

        public double CalculateSide()
        {
            return Math.Sqrt(Area);
        }
    }
}
