using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._11
{
    class NumberChecker
    {
        public int Number { get; set; }

        public NumberChecker(int number)
        {
            Number = number;
        }

        public bool IsEven()
        {
            return Number % 2 == 0;
        }

        public bool EndsWithThree()
        {
            return Number % 10 == 3;
        }

        public void PrintResult()
        {
            if (IsEven())
            {
                Console.WriteLine($"Число {Number} является четным.");
            }
            else if (EndsWithThree())
            {
                Console.WriteLine($"Число {Number} оканчивается на 3.");
            }
            else
            {
                Console.WriteLine($"Число {Number} не является четным и не оканчивается на 3.");
            }
        }
    }

}
