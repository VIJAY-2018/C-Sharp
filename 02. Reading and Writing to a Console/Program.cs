using System;

namespace Reading_and_Writing_to_a_Console
{
    class Program
    {
        static void Main()
        {
            // 1. Reading from a console

            Console.WriteLine("Please enter your name\n");

            string Username = Console.ReadLine();

            // 2. Writing to a console have 3 ways

            // 2.1  Using concatenation
            Console.WriteLine("Hello " + Username);

            // 2.2 Using placeholder
            Console.WriteLine("Hello {0}", Username);

            // 2.3 Using placeholder
            Console.WriteLine($"Hello {Username}");
        }
    }
}
