using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Operators
{
    [TestClass]
    public class Arithmetic
    {
        [TestMethod]
        public void SimpleOperators()
        {
            int a = 22;
            int b = 15;

            // addition
            int sum = a + b;

            //subtraction
            int difference = a - b;

            //multiplication
            int product = a * b;

            //division
            int quotient = a / b; // with whole numbers it drops the remainder/decimal

            //remainder 
            int remainder = a % b; // returns the remainder

            DateTime today = DateTime.UtcNow;
            DateTime someday = new DateTime(1900, 02, 28);
            TimeSpan timeSpan = today - someday;

        }
    }
}
