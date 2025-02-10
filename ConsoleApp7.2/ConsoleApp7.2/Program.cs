using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите зарплату: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите стаж (в годах): ");
            int experience = Convert.ToInt32(Console.ReadLine());

            class1 calculator = new class1(salary, experience);

            double bonus = calculator.C();
            double totalSalary = calculator.D();

            Console.WriteLine($"Надбавка за стаж: {bonus:C}");
            Console.WriteLine($"Итоговая сумма к выплате: {totalSalary:C}");
        }
    }
}
