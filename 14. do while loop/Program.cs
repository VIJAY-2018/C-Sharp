using System;
using System.Xml.Serialization;

namespace do_while_loop
{
    class Program
    {
        static void Main()
        {
            string choice;
            do
            {
                Console.WriteLine("Please enter any number");
                int input = int.Parse(Console.ReadLine());
                int i = 0,result = 0;

                while (i <= input)
                {
                    result += 2;
                    i++;
                    Console.Write($"{result} ");
                }

                do
                {

                    Console.WriteLine("\nDo you want to continue?, say yes or no");
                    choice = Console.ReadLine().ToUpper();

                    if (choice != "YES" && choice != "NO")
                    {
                        Console.WriteLine($"You have entered {choice}, Please enter a valid input!");
                    }
                } while (choice != "YES" && choice != "NO");
            } while (choice == "YES");
        }
    }
}
