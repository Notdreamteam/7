using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите массу и объем первого тела:");
            Console.Write("Масса: ");
            double mass1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Объем: ");
            double volume1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите массу и объем второго тела:");
            Console.Write("Масса: ");
            double mass2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Объем: ");
            double volume2 = Convert.ToDouble(Console.ReadLine());

            Body body1 = new Body(mass1, volume1);
            Body body2 = new Body(mass2, volume2);

            double surfaceArea1 = body1.CalculateSurfaceArea();
            double surfaceArea2 = body2.CalculateSurfaceArea();

            if (surfaceArea1 > surfaceArea2)
            {
                Console.WriteLine("Первое тело имеет большую площадь поверхности.");
            }
            else if (surfaceArea1 < surfaceArea2)
            {
                Console.WriteLine("Второе тело имеет большую площадь поверхности.");
            }
            else
            {
                Console.WriteLine("Оба тела имеют одинаковую площадь поверхности.");
            }
        }
    }
}
