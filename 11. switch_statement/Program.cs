using System;

namespace switch_statement
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter any number between 1 - 5");

            int number = int.Parse(Console.ReadLine());

            switch(number)
            {
                /*  case 2:
                      Console.WriteLine($"The number is {number}");
                      break;

                  case 3:
                      Console.WriteLine($"The number is {number}");
                      break;

                  case 4:
                      Console.WriteLine($"The number is {number}");
                      break;*/

                // We can also merge case if the message is same, see below

                case 2:
                case 3:
                case 4:
                    Console.WriteLine($"The number is {number}");
                    break;

                default:
                    Console.WriteLine("The number is neither 2,3,4");
                    break;
            }
        }
    }
}