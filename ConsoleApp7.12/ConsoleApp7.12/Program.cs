using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._12
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

            Point point = new Point(x, y);

            if (point.IsInFirstQuadrant())
            {
                Console.WriteLine("Точка лежит в первой четверти.");
            }
            else
            {
                Console.WriteLine("Точка не лежит в первой четверти.");
            }
        }
    }
}
