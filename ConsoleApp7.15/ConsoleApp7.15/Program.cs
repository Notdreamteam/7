using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точки A:");
            Console.Write("x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты точки B:");
            Console.Write("x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Point pointA = new Point(x1, y1);
            Point pointB = new Point(x2, y2);

            double distanceA = pointA.DistanceToOrigin();
            double distanceB = pointB.DistanceToOrigin();

            if (distanceA < distanceB)
            {
                Console.WriteLine("Точка A находится ближе к началу координат.");
            }
            else if (distanceA > distanceB)
            {
                Console.WriteLine("Точка B находится ближе к началу координат.");
            }
            else
            {
                Console.WriteLine("Точки A и B находятся на одинаковом расстоянии от начала координат.");
            }
        }
    }
}
