using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._25
{
    class CircuitAnalyzer
    {
        public double CalculateCurrent(double voltage, double resistance)
        {
            return voltage / resistance;
        }

        public string CompareCurrents(double voltage1, double resistance1, double voltage2, double resistance2)
        {
            double current1 = CalculateCurrent(voltage1, resistance1);
            double current2 = CalculateCurrent(voltage2, resistance2);

            if (current1 < current2)
            {
                return $"Ток на первом участке ({current1} А) меньше, чем на втором ({current2} А).";
            }
            else if (current1 > current2)
            {
                return $"Ток на втором участке ({current2} А) меньше, чем на первом ({current1} А).";
            }
            else
            {
                return $"Токи на обоих участках равны ({current1} А).";
            }
        }
    }
}
