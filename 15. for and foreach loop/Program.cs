using System;

namespace for_and_foreach_loop
{
    class Program
    {
        static void Main()
        {
            // for loop demo with break and continue
            for(int i=0; i<=20; i++)
            {
                if(i%2 == 1)
                {
                    continue;
                }
                Console.Write($"{i} ");

                if(i == 19)
                {
                    break;
                }
            }

            Console.WriteLine("\n Array elements are");

            // foreach loop
            int[] arr = new int[5];

            arr[0] = 11;
            arr[1] = 12;
            arr[2] = 13;
            arr[3] = 14;
            arr[4] = 15;

            foreach(int ele in arr)
            {
                Console.Write(ele + " ");
            }
        }
    }
}
