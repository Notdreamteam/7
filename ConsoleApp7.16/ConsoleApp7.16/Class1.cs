using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._16
{
    class TorusChecker
    {
        public bool IsPointInsideTorus(double x, double y, double r, double R)
        {
            double distanceSquared = x * x + y * y;

            return distanceSquared >= r * r && distanceSquared <= R * R;
        }
    }
}
