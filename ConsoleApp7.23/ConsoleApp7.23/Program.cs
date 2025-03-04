using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._23
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите скорость в км/ч: ");
            double speedKmPerHour = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите скорость в м/с: ");
            double speedMetersPerSecond = Convert.ToDouble(Console.ReadLine());

            SpeedComparator comparator = new SpeedComparator();

            string result = comparator.CompareSpeeds(speedKmPerHour, speedMetersPerSecond);
            Console.WriteLine(result);
        }
    }
}
