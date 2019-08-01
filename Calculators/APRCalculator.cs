using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculators
{
    public class APRCalculator
    {
        public double GetMonthlyPayment()
        {
            int principal = 15200;
            decimal annualInterestRate = 5 / 100;
            decimal monthlyInterestRate = annualInterestRate / 12;
            int termInMonths = 60;

            return Math.Pow(principal * (1 + (double)monthlyInterestRate), termInMonths) / Math.Pow(1 + (double)monthlyInterestRate, termInMonths) - 1;

        }


    }
}
