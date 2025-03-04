using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._27
{
    class TimeOfDayChecker
    {
        public string DetermineTimeOfDay(int hour)
        {
            if (hour >= 0 && hour < 12)
            {
                return "AM";
            }
            else if (hour >= 12 && hour < 24)
            {
                return "PM";
            }
            else
            {
                return "Некорректное время";
            }
        }
    }
}
