using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._26
{
    internal class Program
    {


        static void Main()
        {
            double massVenus = 4.86e27;
            double radiusVenus = 6175;
            double massSaturn = 5.68e29;
            double radiusSaturn = 57750;

            PlanetGravityAnalyzer analyzer = new PlanetGravityAnalyzer();

            string result = analyzer.CompareGravity(massVenus, radiusVenus, massSaturn, radiusSaturn);
            Console.WriteLine(result);

        }
    }
}

