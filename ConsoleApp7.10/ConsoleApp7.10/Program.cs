using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три числа:");
            Console.Write("A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("B: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("C: ");
            double c = Convert.ToDouble(Console.ReadLine());

            NumberProcessor processor = new NumberProcessor(a, b, c);

            processor.ProcessNumbers();

            processor.PrintResults();
        }
    }
}
