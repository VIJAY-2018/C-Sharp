using System;

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            int[] evenNumbers = new int[4];
            evenNumbers[0] = 2;
            evenNumbers[1] = 4;
            evenNumbers[2] = 6;
            evenNumbers[3] = 8;

            Console.WriteLine($"evenNumbers[0] = {evenNumbers[0]}");
            Console.WriteLine($"evenNumbers[1] = {evenNumbers[1]}");
            Console.WriteLine($"evenNumbers[2] = {evenNumbers[2]}");
            Console.WriteLine($"evenNumbers[3] = {evenNumbers[3]}");
        }
    }
}
