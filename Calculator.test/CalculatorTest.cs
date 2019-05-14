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
            int expected = 10;
            int actual = Calculator.Add(-10, 20);
            Assert.AreEqual(expected, actual, "Actual value didn't match with the expected value");
        }

        [TestMethod]
        public void Test_MultiplicationOfTwoNumbers()
        {
            int expected = 200;
            int actual = Calculator.Product(10, 20);
            Assert.AreEqual(expected, actual, "Actual value didn't match with the expected value");
        }
        [TestMethod]

        public void Test_DivisionOfTwoNumbers()
        {
            int expected = 0;
            int actual = Calculator.Divide(10, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_DivideBy0ThrowsDivideByZeroException()
        {
            Calculator.Divide(10, 0);
        }
        [TestMethod]

        public void Test_ModulusOfTwoNumbers()
        {
            int expected = 2;
            int actual = Calculator.Mod(5, 3);
            Assert.AreEqual(expected, actual, "Expected and Actual results are not matching");
        }





    }
}

