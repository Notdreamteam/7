using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._20
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите первую объемную скорость (л/с): ");
            double flowRate1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите вторую объемную скорость (м^3/мин): ");
            double flowRate2 = Convert.ToDouble(Console.ReadLine());

            double flowRate2InLitersPerSecond = flowRate2 * 1000 / 60;

            FlowRateComparator comparator = new FlowRateComparator();

            string result = comparator.CompareFlowRates(flowRate1, flowRate2InLitersPerSecond);

            Console.WriteLine(result);
        }
    }
}
