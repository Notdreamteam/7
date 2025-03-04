using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._23
{
    class SpeedComparator
    {
        public string CompareSpeeds(double speedKmPerHour, double speedMetersPerSecond)
        {
            double speedKmPerHourInMetersPerSecond = speedKmPerHour * 1000 / 3600;

            if (speedKmPerHourInMetersPerSecond > speedMetersPerSecond)
            {
                return $"Скорость {speedKmPerHour} км/ч больше, чем {speedMetersPerSecond} м/с.";
            }
            else if (speedKmPerHourInMetersPerSecond < speedMetersPerSecond)
            {
                return $"Скорость {speedMetersPerSecond} м/с больше, чем {speedKmPerHour} км/ч.";
            }
            else
            {
                return $"Скорость {speedKmPerHour} км/ч равна {speedMetersPerSecond} м/с.";
            }
        }
    }
}
