using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABetterCalculator.ABetterCalculator.Domain
{
    public class CalcBrain
    {
        private decimal _total;
        private string _selectedOperation;

        public void Run()
        {
            // here's the brain of the operation, it will power the ui and take in user input        
            //PerformValidationOnSelection(); ??? Part of the GetUserInput stuff
            while (true)
            {
                GetUserInput();
                // Switch on selections from userInput
                switch (_selectedOperation)
                {
                    case "+":
                        _total += ArithmeticOps.Calculate(_selectedOperation);
                        _selectedOperation = "";
                        break;
                    case "-":
                        _total -= ArithmeticOps.Calculate(_selectedOperation);
                        _selectedOperation = "";
                        break;
                    case "*":
                        _total *= ArithmeticOps.Calculate(_selectedOperation);
                        _selectedOperation = "";
                        break;
                    case "/":
                        _total /= ArithmeticOps.Calculate(_selectedOperation);
                        _selectedOperation = "";
                        break;
                    default:
                        break;
                }
            }
        }

        private void GetUserInput()
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("(enter '+' for add, '-' for subtract, '*' for multiply and '/' for divide, or press 'd' for done.");
            _selectedOperation = Console.ReadLine();
            PerformValidationOnSelection(_selectedOperation);
        }

        private void PerformValidationOnSelection(string selectedOperation)
        {
            // implement me
        }
    }
}
