using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._25
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите напряжение на первом участке (В): ");
            double voltage1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите сопротивление первого участка (Ом): ");
            double resistance1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите напряжение на втором участке (В): ");
            double voltage2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите сопротивление второго участка (Ом): ");
            double resistance2 = Convert.ToDouble(Console.ReadLine());

            CircuitAnalyzer analyzer = new CircuitAnalyzer();

            string result = analyzer.CompareCurrents(voltage1, resistance1, voltage2, resistance2);
            Console.WriteLine(result);
        }
    }
}
