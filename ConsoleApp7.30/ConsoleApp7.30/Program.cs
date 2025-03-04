using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._30
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите натуральное число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            NumberChecker checker = new NumberChecker();

            string result = checker.CheckNumber(number);

            Console.WriteLine(result);
        }
    }
}
