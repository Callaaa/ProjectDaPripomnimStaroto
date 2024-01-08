using AritmeticProgression;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestAritmeticProgression
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIfCanFindAllElementsInProgression()
        {
            CalculateTasksInAritmeticProgression tester = new CalculateTasksInAritmeticProgression();
            int a1 = 1;
            int b = 2;
            int aN = 12;

            List<int> result = tester.FindingAllElementOfAritmeticProgression(a1, b, aN);

            List<int> rigthAnswer = new List<int> { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23 };
            Assert.AreEqual(string.Join(" ", rigthAnswer), string.Join(" ", result), "CANT FIND ELEMENTS IN PROGRESSION");

        }
        [TestMethod]
        public void TestIfCanFindSnInProgression()
        {
            CalculateTasksInAritmeticProgression tester = new CalculateTasksInAritmeticProgression();
            int a1 = 1;
            int b = 2;
            int aN = 12;

            int result = tester.FindingSnOfThisProgression(a1, b, aN);
            Assert.AreEqual(144, result, "CANT FIND ELEMENTS IN PROGRESSION");
        }
    }
}
