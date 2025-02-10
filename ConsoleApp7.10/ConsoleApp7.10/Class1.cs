using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._10
{
    class NumberProcessor
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public NumberProcessor(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        private double ProcessNumber(double number)
        {
            return number >= 0 ? Math.Pow(number, 3) : 0;
        }

        public void ProcessNumbers()
        {
            A = ProcessNumber(A);
            B = ProcessNumber(B);
            C = ProcessNumber(C);
        }

        public void PrintResults()
        {
            Console.WriteLine("Обработанные числа:");
            Console.WriteLine($"A: {A}");
            Console.WriteLine($"B: {B}");
            Console.WriteLine($"C: {C}");
        }
    }
}
