using System;

namespace While_Loop
{
    class Program
    {
        static void Main()
        {
            int check = 0;

            while(check <= 29)
            {
                Console.Write($"{check}, ");
                check++;
            }
            Console.Write($"{check}");
            // open task manager and check the performace of CPU for infinite loop condition
        }
    }
}