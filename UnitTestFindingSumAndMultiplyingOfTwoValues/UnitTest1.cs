using FindingPandSofBandA;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestFindingSumAndMultiplyingOfTwoValues
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIfSumIsCorrect()
        {
            List<int> numbers = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> numbers2 = new List<int> { 7, 8, 9, 10, 11, 12, 13 };
            var tester = new SimpleAritmeticOperations();

            int result = tester.Summing(numbers);
            int result2 = tester.Summing(numbers2);

            Assert.AreEqual(44, result, "Error TestIfSumIsCorrect result 1");
            Assert.AreEqual(70, result2, "Error TestIfSumIsCorrect result 2");
        }
        [TestMethod]
        public void TestIfMultiplyWork()
        {
            List<int> numbers = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> numbers2 = new List<int> { 7, 8, 9, 10, 11, 12, 13 };
            var tester = new SimpleAritmeticOperations();

            int result = tester.Multiply(numbers);
            int result2 = tester.Multiply(numbers2);

            Assert.AreEqual(362880, result, "Error TestIfMultiplyWork result 1");
            Assert.AreEqual(8648640, result2, "Error TestIfMultiplyWork result 2");
        }
        [TestMethod]
        public void TestIfPrimeNumbersMethodWork()
        {
            var tester = new SimpleAritmeticOperations();
            int testNumber1 = 15;
            int testNumber2 = 19;

            bool result = tester.IsPrime(testNumber1);
            bool result2 = tester.IsPrime(testNumber2);

            Assert.AreEqual(false, result, "Eror TestIfPrimeNumbersMethodWork result 1");
            Assert.AreEqual(true, result2, "Eror TestIfPrimeNumbersMethodWork result 2");
        }
    }
}
