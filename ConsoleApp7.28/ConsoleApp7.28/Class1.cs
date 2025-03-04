using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._28
{
    class HemisphereChecker
    {
        public string DetermineHemisphere(double longitude)
        {
            if (longitude >= 0 && longitude <= 180)
            {
                return "Восточное полушарие";
            }
            else if (longitude < 0 && longitude >= -180)
            {
                return "Западное полушарие";
            }
            else
            {
                return "Некорректная долгота";
            }
        }
    }
}
