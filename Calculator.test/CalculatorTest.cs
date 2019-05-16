using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Test_AdditionOfTwoNumbers()
        {
            double expected = 10;
            double actual = Calculator.Bussiness.Calculator.Add(-10, 20);
            Assert.AreEqual(expected, actual, "Actual value didn't match with the expected value");
        }

        [TestMethod]
        public void Test_MultiplicationOfTwoNumbers()
        {
            double expected = 200;
            double actual = Calculator.Bussiness.Calculator.Product(10, 20);
            Assert.AreEqual(expected, actual, "Actual value didn't match with the expected value");
        }
        [TestMethod]

        public void Test_DivisionOfTwoNumbers()
        {
            double expected = 5;
            double actual = Calculator.Bussiness.Calculator.Divide(10, 2);
            Assert.AreEqual(expected, actual);
        }

       
        [TestMethod]

        public void Test_ModulusOfTwoNumbers()
        {
            double expected = 2;
            double actual = Calculator.Bussiness.Calculator.Mod(5, 3);
            Assert.AreEqual(expected, actual);
        }





    }
}

