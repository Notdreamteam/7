using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._22
{
    class Body
    {
        public double Mass { get; set; }
        public double Volume { get; set; }

        public Body(double mass, double volume)
        {
            Mass = mass;
            Volume = volume;
        }

        public double CalculateDensity()
        {
            return Mass / Volume;
        }

        public double CalculateSurfaceArea()
        {
            double sideLength = Math.Pow(Volume, 1.0 / 3.0);

            return 6 * sideLength * sideLength;
        }
    }
}
