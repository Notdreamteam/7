using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._29
{
    class StarDistanceComparator
    {
        private const double LightYearInKm = 9.461e12;
        private const double ParsecInLightYears = 3.259;

        public double ConvertParsecsToKilometers(double parsecs)
        {
            return parsecs * ParsecInLightYears * LightYearInKm;
        }

        public string CompareDistances(double siriusDistanceKm, double arcturusDistanceParsecs)
        {
            double arcturusDistanceKm = ConvertParsecsToKilometers(arcturusDistanceParsecs);

            if (siriusDistanceKm > arcturusDistanceKm)
            {
                return $"Сириус ({siriusDistanceKm} км) находится дальше, чем Арктур ({arcturusDistanceKm} км).";
            }
            else if (siriusDistanceKm < arcturusDistanceKm)
            {
                return $"Арктур ({arcturusDistanceKm} км) находится дальше, чем Сириус ({siriusDistanceKm} км).";
            }
            else
            {
                return $"Сириус и Арктур находятся на одинаковом расстоянии ({siriusDistanceKm} км).";
            }
        }
    }
}
