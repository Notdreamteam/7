using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._20
{
    class FlowRateComparator
    {
        public string CompareFlowRates(double flowRate1, double flowRate2)
        {
            if (flowRate1 > flowRate2)
            {
                return "Первая объемная скорость больше второй.";
            }
            else if (flowRate1 < flowRate2)
            {
                return "Вторая объемная скорость больше первой.";
            }
            else
            {
                return "Объемные скорости равны.";
            }
        }
    }

}
