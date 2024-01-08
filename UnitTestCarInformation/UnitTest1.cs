using CarInformation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestCarInformation
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIfCarIsEco()
        {
            
            int year = 2001;
            int year2 = 2022;
            int year3 = 2019;
            var testerIfCarEco= new Car();

            string result= testerIfCarEco.CheckIfCarEco(year);
            string result2 = testerIfCarEco.CheckIfCarEco(year2);
            string result3 = testerIfCarEco.CheckIfCarEco(year3);

            Assert.AreEqual("Екологична ли съм - ECO", result,"Find eco year not working");
            Assert.AreEqual("Екологична ли съм - ECO", result2, "Find eco year2 not working");
            Assert.AreEqual("Екологична ли съм - ECO", result3, "Find eco year3 not working");


        }
        [TestMethod]
        public void TestIfCarIsNotEco()
        {
            int year = 1999;
            int year2 = 1890; 
            var testerIfCarEco = new Car();

            string result = testerIfCarEco.CheckIfCarEco(year);
            string result2 = testerIfCarEco.CheckIfCarEco(year2);

            Assert.AreEqual("Екологична ли съм - I’m NOT Eco CAR", result, "Find eco year not  working");
            Assert.AreEqual("Екологична ли съм - I’m NOT Eco CAR", result2, "Find eco year2 not  working");

        }
    }
}
