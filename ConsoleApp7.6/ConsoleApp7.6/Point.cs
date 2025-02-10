using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._6
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public string DetermineQuadrant()
        {
            if (X > 0 && Y > 0)
            {
                return "Точка находится в первой четверти.";
            }
            else if (X < 0 && Y > 0)
            {
                return "Точка находится во второй четверти.";
            }
            else if (X < 0 && Y < 0)
            {
                return "Точка находится в третьей четверти.";
            }
            else if (X > 0 && Y < 0)
            {
                return "Точка находится в четвертой четверти.";
            }
            else if (X == 0 && Y != 0)
            {
                return "Точка лежит на оси Y.";
            }
            else if (Y == 0 && X != 0)
            {
                return "Точка лежит на оси X.";
            }
            else
            {
                return "Точка находится в начале координат.";
            }
        }
    }
}
