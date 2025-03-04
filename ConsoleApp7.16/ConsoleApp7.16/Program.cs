using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._16
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите координату x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите внутренний радиус r: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите внешний радиус R: ");
            double R = Convert.ToDouble(Console.ReadLine());

            TorusChecker checker = new TorusChecker();

            bool isInside = checker.IsPointInsideTorus(x, y, r, R);

            if (isInside)
            {
                Console.WriteLine("Точка лежит внутри тора.");
            }
            else
            {
                Console.WriteLine("Точка не лежит внутри тора.");
            }
        }
    }
}
