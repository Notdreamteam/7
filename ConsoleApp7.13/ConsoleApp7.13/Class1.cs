using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._13
{
    class DepositCalculator
    {
        public double DepositAmount { get; set; }
        public int ContractDuration { get; set; }

        public DepositCalculator(double depositAmount, int contractDuration)
        {
            DepositAmount = depositAmount;
            ContractDuration = contractDuration;
        }

        public double CalculateMonthlyPayout()
        {
            double annualInterestRate;

            if (ContractDuration == 6)
            {
                annualInterestRate = 0.06; 
            }
            else if (ContractDuration == 12)
            {
                annualInterestRate = 0.08; 
            }
            else
            {
                throw new ArgumentException("Недопустимый срок договора. Допустимые значения: 6 или 12 месяцев.");
            }

            double monthlyInterestRate = annualInterestRate / 12;

            double monthlyPayout = DepositAmount * monthlyInterestRate;

            return monthlyPayout;
        }
    }
}
