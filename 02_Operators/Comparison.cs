using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Operators
{
    [TestClass]
    public class Comparison
    {
        [TestMethod]
        public void Comparisons()
        {
            int age = 25;
            string username = "Katie";

            bool equals = age == 45;
            bool userIsKatie = username == "Eric";
            Console.WriteLine("User is 45: " + equals);
            Console.WriteLine($"User is Katie: {userIsKatie}");
            // one = is used to assign a value, == is used to compare if two values are equal to one another

            bool notEqual= age != 112;
            bool userIsNotJustin = username != "Justin";
            Console.WriteLine($"User is not 112: {notEqual}");
            Console.WriteLine("User is not Justin: " + userIsNotJustin);

            // Comparisons on reference types wirk different
            // equals checks the address which is different for two objects

            List<string> firstList = new List<string>();
            firstList.Add(username);

            List<string> secondList = new List<string>();
            secondList.Add(username);

            bool areSame = firstList == secondList;

            // More Comparison Operations
            bool greaterThan = age > 12;
            bool lessThan = age < 75;

            bool greaThanOrEqual = age >= 66;
            bool lessThanOrEqual = age <= 23;

            bool trueValue = true;
            bool falseValue = false;

            //Or
            bool tOrT = trueValue || trueValue;
            bool tOrF = trueValue || falseValue;
            bool fOrT = falseValue || trueValue;
            bool fOrF = falseValue || falseValue;

            // And
            bool tAndT = trueValue && trueValue;
            bool tAndF = trueValue && falseValue;
            bool fAndT = falseValue && trueValue;
            bool fAndF = falseValue && falseValue;
        }
    }
}
