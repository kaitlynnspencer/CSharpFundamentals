using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Conditionals
{
    [TestClass]
    public class IfElse
    {
        [TestMethod]
        public void IfElseStatements()
        {
            bool userIsHungry = true;

            // if keyword
            if (userIsHungry) // condition in parenthesis
            {
                //Body
                Console.WriteLine("Eat something");
            }

            string name = "Katie";

            if (name == "Katie")
            {
                Console.WriteLine("You must be so cool!");
            }

            if (name != "Katie")
            {
                Console.WriteLine("You must not be very cool");
            }

            // ctrl + d = copys a line 
            // shift + d = deletes a line 
        }

        [TestMethod]
        public void IfElseElseStatements()
        {
            bool choresAreDone = false; 

            if (choresAreDone)
            {
                Console.WriteLine("Have fun at the movies!");
            }

            else
            {
                Console.WriteLine("Stay at home and do your chores.");
                // cw tab tab = console writeline shortcut 
            }

            string input = "7";
            int totalHours = int.Parse(input);

            // Nested Conditionals
            if(totalHours >=8)
            {
                Console.WriteLine("Yo should be well rested");
            }

            // shift enter puts a new line under the one youre on 
            else
            {
                Console.WriteLine("You should be tired today");

                if(totalHours < 4)
                {
                    Console.WriteLine("You should get more sleep");
                }
            }
        }

        [TestMethod]
        public void IfElseIfStatements()
        {
            Random rng = new Random();
            int roll = rng.Next(1, 7);

                if (roll == 6)
            {
                Console.WriteLine("you rolled six! good job!");
            }
                else if (roll == 5)
            {
                Console.WriteLine("you rolled five, not bad.");
            }
                else if (roll == 4)
            {
                Console.WriteLine("you rolled not a six or a five.");
            }
                else if (roll == 3)
            {
                Console.WriteLine("THREEEEE");
            }
                else if (roll > 1)
            {
                Console.WriteLine("TOOOOOO WARS?!");
            }
                else
            {
                Console.WriteLine("Uno");
            }
        }
    }
}
