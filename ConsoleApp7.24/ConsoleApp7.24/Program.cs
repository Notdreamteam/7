using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._24
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите длину стороны треугольника (a): ");
            double a = Convert.ToDouble(Console.ReadLine());

            ShapeChecker checker = new ShapeChecker();

            bool circleFitsInTriangle = checker.CanCircleFitInTriangle(a);
            Console.WriteLine(circleFitsInTriangle ? "Круг уместится в треугольнике." : "Круг не уместится в треугольнике.");

            bool triangleFitsInCircle = checker.CanTriangleFitInCircle(a);
            Console.WriteLine(triangleFitsInCircle ? "Треугольник уместится в круге." : "Треугольник не уместится в круге.");
        }
    }
}
