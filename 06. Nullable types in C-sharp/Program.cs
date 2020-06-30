using System;

namespace Nullable_types_in_C_sharp
{
    class Program
    {
        static void Main()
        {
            /*In C#, types  are divided into 2 broad categories:

              value types - int, float, double, structs, enums etc
              Reference Types – Interface, Class, delegates, arrays etc

              By default value types are non nullable.To make them nullable use ?
              int i = 0(i is non nullable, so "i" cannot be set to null, i = null will generate compiler error)
              int? j = 0(j is nullable int, so j = null is legal)

               Nullable types bridge the differences between C# types and Database types*/

            //  int i = null;   not possible
            int? i = null;

            Console.WriteLine($"The value of i = {i}");

            bool? AreYouOK = null;
            Console.WriteLine("Are you ok ?? say 'true' or 'false'");
            string query = Console.ReadLine();

            if (query.Length == 0)
            {
                Console.WriteLine("Kya aap gunge hai ?? kuch to bolo");
            }
            else
            {
                AreYouOK = bool.Parse(query);

                if (AreYouOK == false)
                {
                    Console.WriteLine("Oh good !");
                }
                else if (AreYouOK == true)
                {
                    Console.WriteLine("So sad !");
                }
            }

            // Without Null Coalescing operator

            int? TicketonSale = 100;

            int AvailableTicket = (int)TicketonSale;

            if(AvailableTicket == 0)
            {
                Console.WriteLine("Available ticket = 0");
            }
            else
            {
                Console.WriteLine($"Available ticket = {AvailableTicket}");
            }
            
            
            // Null Coalescing operator -- reduces the no of lines of code

            int? TicketsOnSale = 100;

            int AvailableTickets = TicketsOnSale ?? 0;

            Console.WriteLine($"Available tickets = {AvailableTickets}");
        }
         
    }
}