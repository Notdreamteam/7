using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._17
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите координату x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            PointChecker checker = new PointChecker();

            bool isInFourthQuadrant = checker.IsInFourthQuadrant(x, y);

            if (isInFourthQuadrant)
            {
                Console.WriteLine("Точка лежит в четвертой четверти.");
            }
            else
            {
                Console.WriteLine("Точка не лежит в четвертой четверти.");
            }
        }
    }
}
