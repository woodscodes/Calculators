using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ABetterCalculator.UnitTests
{
    [TestClass]
    public class ArithmeticOpsUnitTests
    {
        [TestMethod]
        public void CanReassignPassedInNumberToMultiply()
        {
            var total = 2;
            var numberToMultiply = 5;

            if (total == 0)
                total = numberToMultiply;
            else
                total *= numberToMultiply;
                    // don't do calculation, assign total back

            Assert.AreEqual(10, total);           

        }

        [TestMethod]
        public void CanReassignToAvoidDivideByZeroException()
        {
            var total = 2;
            var numberToDivide = 1;

            var result = PerformDivisionChecks(numberToDivide, total);

            Assert.AreEqual(2, result);
        }

        private static decimal PerformDivisionChecks(decimal number, decimal total)
        {

            if (number == 0)
                throw new DivideByZeroException("Please use a value above or below 0");
            else if (total == 0)
                return total = number;

            return total / number;
        }
    }
}
