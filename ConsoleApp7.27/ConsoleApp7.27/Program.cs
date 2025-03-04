using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._27
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите текущее время (часы, от 0 до 23): ");
            int hour = Convert.ToInt32(Console.ReadLine());

            TimeOfDayChecker checker = new TimeOfDayChecker();

            string timeOfDay = checker.DetermineTimeOfDay(hour);

            Console.WriteLine($"Время суток: {timeOfDay}");
        }
    }
}
