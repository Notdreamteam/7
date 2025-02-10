using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._6
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

            string result = point.DetermineQuadrant();
            Console.WriteLine(result);
        }
    }
}
