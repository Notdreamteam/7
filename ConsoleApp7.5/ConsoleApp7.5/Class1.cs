using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._5
{
    class class1
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public class1(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }

        private double P(double number)
        {
            return number >= 0 ? number * number : number;
        }

        public void N()
        {
            a = P(a);
            b = P(b);
            c = P(c);
        }

        public void R()
        {
            Console.WriteLine($"Обработанные числа:");
            Console.WriteLine($"Число 1: {a}");
            Console.WriteLine($"Число 2: {b}");
            Console.WriteLine($"Число 3: {c}");
        }
    }

}
