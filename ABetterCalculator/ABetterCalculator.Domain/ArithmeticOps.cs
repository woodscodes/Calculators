using ABetterCalculator.ABetterCalculator.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABetterCalculator.ABetterCalculator.Domain
{
    public class ArithmeticOps
    {
        private static decimal _total;

        internal static decimal Calculate(string userInput)
        {
            Console.WriteLine($"Enter each number you want to {DisplayArithmeticOperator(userInput)}, pressing enter after each. Press 'd' if you're done.");
            return GetTotal(userInput);
        }

        private static string DisplayArithmeticOperator(string userInput)
        {
            switch (userInput)
            {
                case "+":
                    return "add";
                case "-":
                    return "subtract";
                case "*":
                    return "multiply";
                case "/":
                    return "divide";
                default:
                    return "";
            }
        }

        private static decimal GetTotal(string userInput)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (!decimal.TryParse(input, out decimal number))
                    if (input.ToUpper() == "D")
                        break;
                    else
                        throw new Exception("Input not valid");
                else
                {
                    Validation.PerformValidationOnDecimalInput(number);
                    _total = PerformCalculation(userInput, number);           
                }
            }
            Console.WriteLine($"Current total is {_total}");

            return _total;
        }

        private static decimal PerformCalculation(string userInput, decimal number)
        {
            if (userInput == "+")
                return _total + number;
            else if (userInput == "-")
                return _total - number;
            else if (userInput == "/")
                return PerformDivisionChecks(number);
            else
                return PerformMultiplicationChecks(number);                
        }

        private static decimal PerformMultiplicationChecks(decimal number)
        {            
            if (_total == 0)
                return _total = number;

            return _total * number;
        }

        private static decimal PerformDivisionChecks(decimal number)
        {
            if (number == 0)
                throw new DivideByZeroException("Please use a value above or below 0");
            else if (_total == 0)
                return _total = number;   
            
            return _total / number;
        }
    }
}
