using System;

namespace If_Statement
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter any number");

            int number = int.Parse(Console.ReadLine());

            if(number == 1)
            {
                Console.WriteLine($"number = {number}");
            }
            else if(number == 2)
            {
                Console.WriteLine($"number = {number}");
            }
            else
            {
                Console.WriteLine("Number is neither 1 nor 2");
            }
        }
    }
}
