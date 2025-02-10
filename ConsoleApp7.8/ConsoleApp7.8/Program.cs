using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны первого треугольника (a1, b1, c1):");
            Console.Write("a1: ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("b1: ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("c1: ");
            double c1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите стороны второго треугольника (a2, b2, c2):");
            Console.Write("a2: ");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("b2: ");
            double b2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("c2: ");
            double c2 = Convert.ToDouble(Console.ReadLine());

            Triangle triangle1 = new Triangle(a1, b1, c1);
            Triangle triangle2 = new Triangle(a2, b2, c2);

            if (!triangle1.IsValid())
            {
                Console.WriteLine("Первый треугольник не существует.");
                return;
            }

            if (!triangle2.IsValid())
            {
                Console.WriteLine("Второй треугольник не существует.");
                return;
            }

            
            double area1 = triangle1.CalculateArea();
            double area2 = triangle2.CalculateArea();

            if (area1 > area2)
            {
                Console.WriteLine("Площадь первого треугольника больше.");
            }
            else if (area1 < area2)
            {
                Console.WriteLine("Площадь второго треугольника больше.");
            }
            else
            {
                Console.WriteLine("Площади треугольников равны.");
            }
        }
    }
}
