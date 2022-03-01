using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Conditionals
{
    [TestClass]
    public class Ternary
    {
        [TestMethod]
        public void TernaryMethod()
        {
            int age = 31;

            // variable = (condition) ? trueResult : false result 
            bool isAdult = (age >= 18) ? true : false;
            string adultStatus = (age >= 18) ? "Adult" : "Child";

            Console.WriteLine($"Is Adult: {isAdult} they are {adultStatus}");

            int numOne = 10;

            int numTwo = (numOne == 10) ? 30 : 20;

            bool isEvolved = true;

            string pokemon = (isEvolved) ? "Charizard" :
                "Charmander";
        }
    }
}
