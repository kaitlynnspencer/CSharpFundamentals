using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_loops
{
    [TestClass]
    public class LoopExamples
    {
        [TestMethod]
        public void WhileLoops()
        {
            int total = 1;

            //while(condition) Body

            while (total != 10)
            {
                Console.WriteLine(total);
                total = total + 1;
            }

            total = 0;
            // "infinite" loop, condtion will never be false 
            while (true)
            {
                Console.WriteLine("Goal reached!");
                // break will break the loop 
                break;
            }
            total++;


            int someCount;
            bool keepLooping = true;
            Random randy = new Random();

            while (keepLooping)
            {
                someCount = randy.Next(0, 20);

                //Skip Interations
                if(someCount == 0 || someCount == 10)
                {
                    continue;
                }
                Console.WriteLine(someCount);

                if (someCount == 15)
                {
                    keepLooping = false;
                }
            }
        }

        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 12;

            // 1 starting point, local variable
            // 2 condition, loop while true
            // 3 what we do after each  loop 
            // 4 code to execute each loop 
            for (int i =0; i < studentCount; i++)
            {
                Console.WriteLine(i);
            }

            string[] students = { "Clay", "Stephen", "Ethan", "Victor", "Chris", "Cyrus", "Hayden" };

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Welcome to class {students[i]}");
            }
        }

        [TestMethod]
        public void ForeachLoops()
        {
            string[] students = { "Clay", "Stephen", "Ethan", "Victor", "Chris", "Cyrus", "Hayden" };

            //1 type in collection
            //2 local variable
            //3 in keyword to signify going into collection 
            //4 the collection
            foreach(string student in students)
            {
                Console.WriteLine(student+" is a student in class.");
            }

            string myName = "Henry Allen Venture";
            foreach (char letter in myName)
            {
                if(letter != ' ')
                {
                    Console.WriteLine(letter);
                }
            }
        }

        [TestMethod]
        public void DoWhileLoops()
        {
            int iterator = 0;

            // do runs at least once before the condition is checked
            do
            {
                Console.WriteLine("Hello!");
                iterator++; // iterator = iterator + 1;
            }
            while (iterator < 5);

            do
            {
                Console.WriteLine("My condition is false");
            }
            while (false);

            while(false)
            {
                Console.WriteLine("My condition is false");
            }
        }

    }

}
