using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._18
{
    class TriangleChecker
    {
        public bool IsIsosceles(double a, double b, double c)
        {
            return a == b || a == c || b == c;
        }
    }

}
