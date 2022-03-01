using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Conditionals
{
    [TestClass]
    public class Switch
    {
        [TestMethod]
        public void SwitchCase()
        {
            int input = 1;
            switch(input)
            {
                case 1:
                    Console.WriteLine("hello");
                    break;
                case 2:
                    Console.WriteLine("what's up");
                    break;
                default:
                    Console.WriteLine("this is not the default, it will execute if not case matches the value");
                    break;
            }   
        }
    }
}
