using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Введите три числа:");
                Console.Write("Число 1: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Число 2: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Число 3: ");
                double c = Convert.ToDouble(Console.ReadLine());

                class1 processor = new class1(a, b, c);

                processor.N();

                processor.R();
        }
    }
}
