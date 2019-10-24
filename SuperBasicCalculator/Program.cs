using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            // Basic calculator does some super basic arithmetic
            var n1 = 5;
            var n2 = 5;

            Add(n1, n2);
            Subtract(n1, n2);
            Multiply(n1, n2);
            Divide(n1, n2);

        }

        private static void Divide(int n1, int n2)
        {
            Console.WriteLine(n1 / n2);
        }

        private static void Multiply(int n1, int n2)
        {
            Console.WriteLine(n1 * n2);
        }

        private static void Subtract(int n1, int n2)
        {
            Console.WriteLine(n1 - n2);
        }

        private static void Add(int n1, int n2)
        {
            Console.WriteLine(n1 + n2);
        }
    }
}
