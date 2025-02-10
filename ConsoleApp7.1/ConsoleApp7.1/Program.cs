using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Введите первое число: ");
            double a1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double b1 = Convert.ToDouble(Console.ReadLine());

          
           class1 comparator = new class1(a1, b1);

            
            string result = comparator.R();
            Console.WriteLine(result);
        }
    }
}
