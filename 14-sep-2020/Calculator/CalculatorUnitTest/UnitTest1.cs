using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //Arrange
            /* Console.WriteLine("enter first number");
             int a = Int32.Parse(Console.ReadLine());
             Console.WriteLine("enter second number");
             int b = Int32.Parse(Console.ReadLine());
             int expectedsum =0;
             int expectedmultiplication = 0;*/
            int expectedsum = 39;
            int num1 = 29;
            int num2 = 10;
            int expectedmul = 290;

                //Act
               int resultsum= CalculatorFunction.CalculatorFunctionProgram.add(num1,num2);
            int resultMultiplication = CalculatorFunction.CalculatorFunctionProgram.multiplication(num1, num2);

                //Assert
                Assert.AreEqual(expectedsum, resultsum);
                Assert.AreEqual(expectedmul, resultMultiplication);


            
        }
    }
}
