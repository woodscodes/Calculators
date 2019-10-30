using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABetterCalculator.ABetterCalculator.Helpers
{
    public class Validation
    {
        internal static void PerformValidationOnSelection(string selectedOperation)
        {
            // check string is not null
            if (selectedOperation == null)
                throw new ArgumentException("Please provide a valid option");
            else if (String.IsNullOrWhiteSpace(selectedOperation))
                throw new ArgumentException("Please provide a valid option");
        }

        internal static void PerformValidationOnDecimalInput(decimal number)
        {
            if (number < Decimal.MinValue && number > Decimal.MaxValue)
                throw new ArgumentOutOfRangeException("Number provided exceeds the range of acceptable decimal numbers");
        }
    }
}
