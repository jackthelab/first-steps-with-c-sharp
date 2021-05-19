using System;

namespace first_steps_with_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ways to output to console are .Write() and .WriteLine() methods
            // Notice the differences in line spacing

            // Console.WriteLine("Hello World!");

            // Console.Write("Congratulations!");
            // Console.Write(" ");
            // Console.Write("You wrote your first line of code!");

            // FirstChallenge -- write two lines of code using each method above
            // Console.WriteLine("This is the first line.");
            // Console.Write("This is a second line.");

            // Data Types

            // string literals -- need double quotes
            // use: words, phrases, alphanumeric not for calculation

            // Console.WriteLine("string");

            // char literals -- using single quotes
            // use: single alphanumeric character not for calculation

            // Console.WriteLine('b');

            // int literals -- integer literals
            // use: whole numbers

            // Console.WriteLine(123);

            // decimal literals -- use an m at the end to signal integer literal
            // use: decimals

            // Console.WriteLine(12.3m);

            // bool literal
            // use: true/false (all binary?)

            // Console.WriteLine(true);

            // Declaring Variables

            // declare data type and give name -- can only hold data type declared
            string firstName;
            // char userInputLetter;
            // decimal particlesPerMillion;
            // bool processedCustomer;

            // Setting variables and getting their values
            firstName = "Bob";
            Console.WriteLine(firstName);

            // Can reassign a variable in C#
            // firstName = "Beth";
            // Console.WriteLine(firstName);
        }
    }
}
