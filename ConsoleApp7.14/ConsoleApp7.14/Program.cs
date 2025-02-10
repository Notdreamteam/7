using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа:");
            Console.Write("Число 1: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Число 2: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            NumberComparator comparator = new NumberComparator(num1, num2);

            string result = comparator.CompareResults();
            Console.WriteLine(result);
        }
    }
}
