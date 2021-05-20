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
            // string firstName;
            // could also initialize/assign when declaring -- string firstName = "Bob";
            // char userInputLetter;
            // decimal particlesPerMillion;
            // bool processedCustomer;

            // Setting variables and getting their values
            // Have to assign the variable a value before using it or will return an error
            // firstName = "Bob";
            // Console.WriteLine(firstName);

            // Can reassign a variable in C#
            // firstName = "Beth";
            // Console.WriteLine(firstName);

            // can use implicitly typed variable with var keyword
            // var lastName = "Smith";

            // Console.WriteLine(lastName);

            // Catch here: type must stay the same as the original data-type -- string in the above example
            // trying to write lastName = 12.0m would result in an error

            // Can still change the value just not the data type of the value
            // the below would still work even if lastName = 12.0m will not
            // lastName = "Biggs";

            // Console.WriteLine(lastName);

            // var is useful if the datatype is ambiguous when writing the code.
            // try to use the data type -- especially when learning

            // *************************CHALLENGE************************ //
            // string challengeName = "Bob";
            // int messages = 3;
            // decimal temperature = 34.4m;

            // Console.Write("Hello, ");
            // Console.Write(challengeName);
            // Console.Write("! You have ");
            // Console.Write(messages);
            // Console.Write(" in your inbox. The temperature is ");
            // Console.Write(temperature);
            // Console.WriteLine(" celsius.");

            // to skip ahead for string interpolation -- difference from JS, '$' before double quotes and not needed individual times
            // Console.WriteLine($"Hello, {challengeName}! You have {messages} in your inbox. The temperature is {temperature} celsius.");

            // use the \ for escape characters
            Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...\n");
            Console.WriteLine("Invoice: 1021\tComplete!");
            Console.WriteLine("Invoice: 1022\tComplete!\n");
            Console.WriteLine("Output Directory:");

            // Can write 'verbatim' string literals with @ sign
            // keep all whitespace and characters without the need to escape the backslash

            Console.WriteLine(@"    c:\sources\repos\(this is where ");
        }
    }
}
