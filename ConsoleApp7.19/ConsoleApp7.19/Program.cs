using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._19
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите число a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            PythagoreanTripletChecker checker = new PythagoreanTripletChecker();

            bool isPythagoreanTriplet = checker.IsPythagoreanTriplet(a, b, c);

            if (isPythagoreanTriplet)
            {
                Console.WriteLine("Числа являются тройкой Пифагора.");
            }
            else
            {
                Console.WriteLine("Числа не являются тройкой Пифагора.");
            }
        }
    }
}
