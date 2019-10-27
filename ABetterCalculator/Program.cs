using ABetterCalculator.ABetterCalculator.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABetterCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //A Better Calculator asks which function is required and then does the thing
            //That can be in any order of operations
            //Thinking a switch statement to choose the input
            //A while loop to manage the logic?
            var calc = new CalcBrain();
            calc.Run();
        }

    }
}
