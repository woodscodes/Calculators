using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ABetterCalculator.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        public void CanCreateACalcAndRunIt()
        {

            //var calc = new BetterCalc();

            //Assert.AreEqual(6, calc.Run());
        }

        //[TestMethod]
        /*public void CanUseWhileLoopToDoSimpleMaths()
        {
            var input1 = 0;
            var input2 = 0;
            var answer = 0;

            while (true)
            {
                Console.WriteLine("What number do you want to add up?");
                input1 = 6;
                Console.WriteLine("To?");
                input2 = 3;

                answer = AddTheThings(input1, input2);

                if (answer == 9)
                    break;
            }

            Assert.AreEqual(answer, 9);

        }*/

        /*private int AddTheThings(int input1, int input2)
        {
            return input1 + input2;
        }*/
        

        //[TestMethod]
        public void CanUseAWhileLoopToMakeMathsSelections()
        {            

            while (true)
            {
                Console.WriteLine("What do you want to do?");
                var userInput = Console.ReadLine();
                // check input for the magic 'd'

                switch (userInput)
                {
                    case "+":
                        Console.WriteLine("Please enter the numbers you want to add, when you're finished press d for done");
                        //AddTestyv2();
                        break;
                    case "-":
                        Console.WriteLine("Please enter the numbers you want to subtract, when you're finished press d for done");
                        SubtractTesty();
                        break;
                    default:
                        break;
                }
            }
        }

        private int SubtractTesty()
        {
            //var totalerino = 0; // <-- totalerino should be passed into, perhaps the calc selection also?
            while (true)
            {
                    
            }
        }

        //[TestMethod]
        /*public void CanDoAddWhileLoopTest()
        {
            var n = AddTestyv2();
            Assert.AreEqual(0, n);
        }*/        

        /*
        private int addtestyv2()
        {
            var totalerino = 0;

            while (true) 
            {
                var numero = 0; <--- Could extract this logic here to separate stuff? More readable and reusable... ? 
                var input = console.readline();
                if (!int.tryparse(input, out numero))
                    if (input.toupper() == "d")
                        break;
                    else
                        throw new exception("input not valid");
                else
                    totalerino += numero; //doTheThing() < -- To reduce repetition, can make mini method here to do the calculation?
            }

            return totalerino;
        }*/


    }
}
