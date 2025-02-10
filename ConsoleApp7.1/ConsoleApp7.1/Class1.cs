using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._1
{
    class class1
    {
        public double a { get; set; }
        public double b { get; set; }

        public class1(double a1, double b1)
        {
            a = a1;
            b = b1;
        }

        public double C()
        {
            double sum = a + b;
            return sum * sum;
        }

        public double S()
        {
            return (a * a) + (b * b);
        }

        public string R()
        {
            double s = C();
            double q = S();

            if (s > q)
            {
                return "Квадрат суммы больше суммы квадратов.";
            }
            else if (s < q)
            {
                return "Сумма квадратов больше квадрата суммы.";
            }
            else
            {
                return "Квадрат суммы равен сумме квадратов.";
            }
        }
    }

}
