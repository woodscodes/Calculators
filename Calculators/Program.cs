using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculators
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new CompoundCalculator();
            Console.WriteLine(calc.CompoundedInterest().ToString("C", CultureInfo.CurrentCulture));
            var calc2 = new InterestRateCalculator();
            Console.WriteLine(calc2.GetInterestRate().ToString("C", CultureInfo.CurrentCulture));
            var calc3 = new APRCalculator();
            Console.WriteLine(calc3.GetMonthlyPayment().ToString("C", CultureInfo.CurrentCulture));

        }
    }
}
