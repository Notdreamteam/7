using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._26
{
    class PlanetGravityAnalyzer
    {
        private const double G = 6.7e-8;

        public double CalculateGravity(double mass, double radius)
        {
            double massInGrams = mass;
            double radiusInCentimeters = radius * 1e5; // 1 км = 1e5 см

            return G * massInGrams / (radiusInCentimeters * radiusInCentimeters);
        }

        public string CompareGravity(double massVenus, double radiusVenus, double massSaturn, double radiusSaturn)
        {
            double gravityVenus = CalculateGravity(massVenus, radiusVenus);
            double gravitySaturn = CalculateGravity(massSaturn, radiusSaturn);

            if (gravityVenus > gravitySaturn)
            {
                return $"Ускорение силы тяжести на Венере ({gravityVenus} см/сек²) больше, чем на Сатурне ({gravitySaturn} см/сек²).";
            }
            else if (gravityVenus < gravitySaturn)
            {
                return $"Ускорение силы тяжести на Сатурне ({gravitySaturn} см/сек²) больше, чем на Венере ({gravityVenus} см/сек²).";
            }
            else
            {
                return $"Ускорения силы тяжести на Венере и Сатурне равны ({gravityVenus} см/сек²).";
            }
        }
    }

}
