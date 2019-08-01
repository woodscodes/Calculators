using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculators
{
    public class CompoundCalculator
    {
        public decimal CompoundedInterest()
        {
            int principal = 5000;
            double interestRate = 0.05;
            int intervalsOfCompounding = 12;
            int totalPeriod = 10;

            double amount = principal * Math.Pow((1 + interestRate / intervalsOfCompounding), intervalsOfCompounding * totalPeriod);
            return Math.Round((decimal)amount, 2);
        }
    }
}
