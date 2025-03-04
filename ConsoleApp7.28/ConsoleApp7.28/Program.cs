using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._28
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите географическую долготу (от -180 до 180): ");
            double longitude = Convert.ToDouble(Console.ReadLine());

            HemisphereChecker checker = new HemisphereChecker();

            string hemisphere = checker.DetermineHemisphere(longitude);

            Console.WriteLine($"Место находится в {hemisphere}.");
        }
    }
}
