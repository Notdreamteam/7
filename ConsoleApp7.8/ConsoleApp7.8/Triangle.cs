﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._8
{
    class Triangle
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public bool IsValid()
        {
            return A + B > C && A + C > B && B + C > A;
        }

        public double CalculateArea()
        {
            if (!IsValid())
            {
                throw new InvalidOperationException("Треугольник не существует.");
            }

            double p = (A + B + C) / 2;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
