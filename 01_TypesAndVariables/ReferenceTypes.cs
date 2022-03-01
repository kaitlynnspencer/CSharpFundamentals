using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ReferenceTypes
    {
        [TestMethod]
        public void Strings()
        {
            // String is a collections of chars

            // Declare 
            string thisIsDeclared;

            // Initialize by assigning
            string declared;
            declared = "This is initialized";

            // Declared and initalized
            string declaredAndInitialized = "This is both declaring and initializing";

            string number = "7787";

            string nullString;
            string emptyString = "";

            string firstName = "Katie";
            string lastName = "Spencer";

            // Concatenation 
            string concatenetedFullName = firstName + " " + lastName;
            Console.WriteLine(concatenetedFullName);

            // Compositing
            string compositeFullName = string.Format("{0} {1}", firstName, lastName);
            Console.WriteLine(compositeFullName);

            // Interpolation
            string interpolatedFullName = $"{firstName} {lastName}";
            Console.WriteLine(interpolatedFullName);
        }

        [TestMethod]
        public void Collections()
        {
            string stringExample = "This is a collection of chars";

            string[] stringArray = { "Hello", "World", "Why" };

            Console.WriteLine(stringArray[2]);

            // updating a value by it's index
            stringArray[0] = "Who";

            // Like an array but more dynamic
            List<string> listOfStrings = new List<string>();
            List<int> listOfIntergers = new List<int>();

            listOfStrings.Add("A string");
            listOfIntergers.Add(12900);

            //First in first out, like getting in line 
            Queue<string> firstInFirstOut = new Queue<string>();

            firstInFirstOut.Enqueue("I'm First");
            firstInFirstOut.Enqueue("I'm next");

            // a collection of key value pairs
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();

            // have to give it a key, 7, and a value, "agent"
            keyAndValue.Add(7, "agent");

            Dictionary<string, string> realDictionary = new Dictionary<string, string>();

            realDictionary.Add("Know", "Be aware of through observation, inquiry, or information");

            Console.WriteLine(realDictionary["Know"]);


            //Extra Collection types, not as usefu but good to know they exist

            // Dictionary that is sorted so the value can be accessed by the key and the index
            SortedList<int, string> sortedKeyAndValue = new SortedList<int, string>();
            
            //Probably won't ever use
            HashSet<int> uniqueList = new HashSet<int>();


            //Like Stacking objects, last object added is first of the "stack"
            Stack<string> lastInFirstOut = new Stack<string>();

        }

        [TestMethod]
        public void Classes()
        {
            // Use new to make a 'new'instance of a class 
            Random rng = new Random();

            int randomNumber = rng.Next();
            Console.WriteLine(randomNumber);
        }
    }
}
