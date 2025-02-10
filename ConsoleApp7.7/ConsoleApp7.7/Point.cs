using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._7
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public bool IsInsideCircle(double radius)
        {
            double distanceToOrigin = Math.Sqrt(X * X + Y * Y);

            return distanceToOrigin <= radius;
        }
    }

}
