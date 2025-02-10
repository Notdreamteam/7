using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите площадь круга: ");
            double circleArea = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите площадь квадрата: ");
            double squareArea = Convert.ToDouble(Console.ReadLine());

            Circle circle = new Circle(circleArea);
            Square square = new Square(squareArea);

            double circleRadius = circle.CalculateRadius();
            double squareSide = square.CalculateSide();

            if (2 * circleRadius <= squareSide)
            {
                Console.WriteLine("Круг уместится в квадрате.");
            }
            else
            {
                Console.WriteLine("Круг не уместится в квадрате.");
            }

            if (squareSide <= 2 * circleRadius)
            {
                Console.WriteLine("Квадрат уместится в круге.");
            }
            else
            {
                Console.WriteLine("Квадрат не уместится в круге.");
            }
        }
    }
    }
}
