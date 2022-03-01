using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_TypesAndVariables
{
    //Comment ctrl + k + c = comment 
    /* Long Comment ctrl + shift + / */

    // PascalCaseCapitalization
    // camelCaseCapitalization



    [TestClass]
    public class ValueTypes
    {
        [TestMethod]
        public void Booleans()
        {
            // Declaring a variable
            bool declared;

            //assigning a variable 
            declared = true;

            // declare and initialize a variable 
            bool declarationAndInitialized = false;

            // assigning adter declaration
            declarationAndInitialized = true;
        }

        [TestMethod]
        public void Characters()
        {
            char character = 'a';
            char symbol = '?';
            char number = '7';
            char space = ' ';
            char specialCharacter = '\n';
        }

        [TestMethod]
        public void WholeNumbers()
        {
            byte byteMin = 0;
            byte byteMax = 255;
            short shortMin = -32768;
            short shortMax = 32767;
            int intMin = -2147483648;
            int intMax = 2147483647;
            long longMin = -9223372036854775808;
            long longMax = 9223372036854775807;
            int a = 15;
            int b = -10;
        }

        [TestMethod]
        public void Decimals()
        {
            // 7 digits of precision 
            float floatExample = 1.120012f;
            // 15-16 digits of precision
            double doubleExample = 12.121092109209d;
            // 20-29 digits of precision
            decimal decimalExample = -123.2210188m;
        }

        enum PastryType { Cake, Cupcake, Eclaire, Petitfour, Crossant };//enums are in PascalCase

        [TestMethod]
        public void Enums()
        {
            PastryType myPastry = PastryType.Crossant;

        }

        [TestMethod]
        public void Structs()
        {
            DateTime today = DateTime.Today;
            DateTime birthday = new DateTime(1972, 6, 20);
        }
    }
}
