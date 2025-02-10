using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._14
{
    class NumberComparator
    {
        public double Number1 { get; set; }
        public double Number2 { get; set; }

        public NumberComparator(double num1, double num2)
        {
            Number1 = num1;
            Number2 = num2;
        }

        public double CalculateDifferenceOfSquares()
        {
            return (Number1 * Number1) - (Number2 * Number2);
        }

        public double CalculateAbsoluteSquareOfDifference()
        {
            double difference = Number1 - Number2;
            return Math.Abs(difference * difference);
        }

        public string CompareResults()
        {
            double differenceOfSquares = CalculateDifferenceOfSquares();
            double absoluteSquareOfDifference = CalculateAbsoluteSquareOfDifference();

            if (differenceOfSquares > absoluteSquareOfDifference)
            {
                return "Разность квадратов чисел больше модуля квадрата разности.";
            }
            else if (differenceOfSquares < absoluteSquareOfDifference)
            {
                return "Модуль квадрата разности больше разности квадратов чисел.";
            }
            else
            {
                return "Разность квадратов чисел равна модулю квадрата разности.";
            }
        }
    }

}
