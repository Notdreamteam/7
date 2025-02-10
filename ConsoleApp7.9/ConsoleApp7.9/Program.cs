using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сторону квадрата (a): ");
            double side = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите радиус круга (R): ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Square square = new Square(side);
            Circle circle = new Circle(radius);

            double squareArea = square.CalculateArea();
            double circleArea = circle.CalculateArea();

            if (squareArea > circleArea)
            {
                Console.WriteLine("Площадь квадрата больше площади круга.");
            }
            else if (squareArea < circleArea)
            {
                Console.WriteLine("Площадь круга больше площади квадрата.");
            }
            else
            {
                Console.WriteLine("Площади квадрата и круга равны.");
            }

            Console.WriteLine($"Площадь квадрата: {squareArea:F2}");
            Console.WriteLine($"Площадь круга: {circleArea:F2}");
        }
    }
}
