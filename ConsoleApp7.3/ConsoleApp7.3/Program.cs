using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точки A:");
            Console.Write("x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты точки B:");
            Console.Write("x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            class1 A = new class1(x1, y1);
            class1 B = new class1(x2, y2);

            double A1= A.D();
            double B1 = B.D();

            if (A1 > B1)
            {
                Console.WriteLine("Точка A находится дальше от начала координат.");
            }
            else if (A1 < B1)
            {
                Console.WriteLine("Точка B находится дальше от начала координат.");
            }
            else
            {
                Console.WriteLine("Точки A и B находятся на одинаковом расстоянии от начала координат.");
            }
        }    
    }
}
