using System;
using System.Threading;

namespace goto_and_label
{
    class Program
    {
        static void Main()
        {
            int total_price = 0;

            START:
            Console.WriteLine("Enter cup size of coffee \n 1. Small \n 2. Medium \n 3. Large");

            int size = int.Parse(Console.ReadLine());

            switch(size)
            {
                case 1:
                    total_price += size * 78;
                    break;

                case 2:
                    total_price += size * 78;
                    break;

                case 3:
                    total_price += size * 78;
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            CHOICE:
            Console.WriteLine("Do you want to purchase again ? Yes or No");

            string choice = Console.ReadLine();

            switch(choice.ToUpper())
            {
                case "YES":
                    goto START;

                case "NO":
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    Console.WriteLine("Please enter a valid choice");
                    goto CHOICE;
            }
            Console.WriteLine("Thank you for shopping, please visit again");
            Console.WriteLine($"Your total expenses are : \n {total_price}");
        }
    }
}