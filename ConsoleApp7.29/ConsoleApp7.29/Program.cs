using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._29
{
    internal class Program
    {
        static void Main()
        {
            double siriusDistanceKm = 8.14e12;

            double arcturusDistanceParsecs = 103;

            StarDistanceComparator comparator = new StarDistanceComparator();

            string result = comparator.CompareDistances(siriusDistanceKm, arcturusDistanceParsecs);
            Console.WriteLine(result);
        }
    }
}
