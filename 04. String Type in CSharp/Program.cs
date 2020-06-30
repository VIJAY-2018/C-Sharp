using System;

namespace String_Type_in_CSharp
{
    class Program
    {
        static void Main()
        {
            // If we want to write sth in double quotes then we should use escape sequence characters, \" \" but that doesn't seems good

            Console.WriteLine("My name is \"Vijay\"");

            Console.WriteLine("My project path is \n C:\\Users\\vpokhriyal\\source\\repos\\C#");

            // To overcome the above problem we use "Verbatim Literal", we just put '@' symbol before the string

            Console.WriteLine(@"My project path is C:\Users\vpokhriyal\source\repos\C#");

            /*  In C#, a verbatim string is created using a special symbol @. It provides better readability
                @ is known as a verbatim identifier. If a string contains @ as a prefix followed by double quotes,
                  then compiler identifies that string as a verbatim string and compile that string. 
                  The main advantage of @ symbol is to tell the string constructor to ignore escape characters and 
                  line breaks. */
        }
    }
}
