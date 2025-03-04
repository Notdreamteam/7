using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._30
{
    class NumberChecker
    {
        public string CheckNumber(int number)
        {
            if (number % 2 == 0)
            {
                return "Число является четным.";
            }
            else if (number % 10 == 7)
            {
                return "Число оканчивается на 7.";
            }
            else
            {
                return "Число не является четным и не оканчивается на 7.";
            }
        }
    }
}
