using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._18
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите длину стороны a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину стороны b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину стороны c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            TriangleChecker checker = new TriangleChecker();

            bool isIsosceles = checker.IsIsosceles(a, b, c);

            if (isIsosceles)
            {
                Console.WriteLine("Треугольник является равнобедренным.");
            }
            else
            {
                Console.WriteLine("Треугольник не является равнобедренным.");
            }
        }
    }
}
