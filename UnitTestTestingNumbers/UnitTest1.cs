using ArrayOf20NumbersFindingEmptySpaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestArrayOf20NumbersFindingEmptySpaces
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNumbersToFindSmallestNumber()
        {
            //arrange
            int[] numbers1 = { -1, 9, 0, 3, 6 };
            int[] numbers2 = { 0, -2, -7, 9, 3, 2 };
            var tester = new MethodsForNumbers();
            //Act
            double result = tester.FindSmallestNumber(numbers1);
            double result2 = tester.FindSmallestNumber(numbers2);
            //assert
            Assert.AreEqual(3, result, "Wrong Smallest Number result");
            Assert.AreEqual(2, result2, "Wrong Smallest Number result2");

        }
        [TestMethod]

        public void TestNumbersToFindBiggestNumber()
        {
            int[] numbers = { 99, 101, -2, 0, 14 };
            int[] numbers2 = { 8, -10001, 2, 0, 14 };

            var tester = new MethodsForNumbers();
            double result = tester.FindBiggestNumber(numbers);
            double result2 = tester.FindBiggestNumber(numbers2);

            Assert.AreEqual(101, result, "Wrong Biggest Number result");
            Assert.AreEqual(14, result2, "Wrong Smallest Number result2");

        }
    }
}
