using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сумму вклада: ");
            double depositAmount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите срок договора (6 или 12 месяцев): ");
            int contractDuration = Convert.ToInt32(Console.ReadLine());

            DepositCalculator calculator = new DepositCalculator(depositAmount, contractDuration);

            try
            {
                double monthlyPayout = calculator.CalculateMonthlyPayout();

                Console.WriteLine($"Ежемесячная выплата по депозиту: {monthlyPayout:F2} руб.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
