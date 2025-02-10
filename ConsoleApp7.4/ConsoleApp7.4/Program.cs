using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны треугольника:");
            Console.Write("a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            class1 triangle = new class1(a, b, c);

            if (triangle.R
                ())
            {
                Console.WriteLine("Треугольник является прямоугольным.");
            }
            else
            {
                Console.WriteLine("Треугольник не является прямоугольным.");
            }
        }
    }
}
