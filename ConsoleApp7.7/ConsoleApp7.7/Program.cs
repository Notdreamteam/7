using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точки A:");
            Console.Write("x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите радиус окружности R: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Point point = new Point(x, y);

            if (point.IsInsideCircle(radius))
            {
                Console.WriteLine("Точка лежит внутри окружности.");
            }
            else
            {
                Console.WriteLine("Точка лежит вне окружности.");
            }
        }
    }
}
