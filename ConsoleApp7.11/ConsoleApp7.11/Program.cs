using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            NumberChecker checker = new NumberChecker(number);

            checker.PrintResult();
        }
    }
}
