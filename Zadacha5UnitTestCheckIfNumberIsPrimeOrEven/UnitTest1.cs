using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zadacha5CheckIfNumberIsPrimeOrEven;
using System;


namespace Zadacha5UnitTestCheckIfNumberIsPrimeOrEven
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIfNumberIsPrime()
        {
            var test = new IsNumberOddOrPrime();
            int number = 18;
            int number2 = 7;

            bool result = test.IsPrime(number);
            bool result2 = test.IsPrime(number2);


            Assert.AreEqual(false, result, "Eror TestIfNumberIsPrime result");
            Assert.AreEqual(true, result2, "Eror TestIfNumberIsPrime result2");

        }
        [TestMethod]
        public void TestIfNumberIsEven()
        {
            var test = new IsNumberOddOrPrime();
            int number = 5;
            int number2 = 10;

            bool result = test.IsEven(number);
            bool result2 = test.IsEven(number2);


            Assert.AreEqual(false, result, "Eror TestIfNumberIsEven result");
            Assert.AreEqual(true, result2, "Eror TestIfNumberIsEven result2");

        }
    }
}
