using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._19
{
    class PythagoreanTripletChecker
    {
        public bool IsPythagoreanTriplet(int a, int b, int c)
        {
            return (a * a + b * b == c * c) ||
                   (a * a + c * c == b * b) ||
                   (b * b + c * c == a * a);
        }
    }
}
