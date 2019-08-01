using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculators
{
    public class InterestRateCalculator
    {
        public decimal GetInterestRate()
        {
            int principal = 10000;
            decimal rateOfInterst = 3.875m / 100;
            int timePeriod = 5;

            decimal interestPlusPrincipal = principal * ( 1 + (rateOfInterst * timePeriod));
            return Math.Round(interestPlusPrincipal, 2);            
        }
    }
}
