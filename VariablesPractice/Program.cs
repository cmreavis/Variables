using System;

namespace VariablesPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Colin";
            string bootCamp = "TrueCoders";
            int level = 25;
            char myChar = 'A';
            bool myBoolean = true;
            double grade = 99.9;
            decimal myDecimal = 70.05m;

            Console.WriteLine($"My name is {firstName}. This year, I turned {level} years old.");
            Console.WriteLine($"This summer, I started to learn how to code via {bootCamp}.\n" +
                $"When I turn in assignments, I hope to achieve a score of {grade}, otherwise known as an {myChar}.");
            Console.WriteLine($"While I learn coding, I like to keep the thermostat at a crisp {myDecimal} degrees.");
            Console.WriteLine($"Once I have completed all the exercises and quizzes TrueCoders can throw at me, the status of my ability to code will be set to {myBoolean}.");

        }
    }
}
