using System;

namespace _5._Common_Operators
{
    class Program
    {
        static void Main()
        {
            // Assignment operator

            int x = 10, y = 12;

            Console.WriteLine($"The number is x = {x}");

            // Arithmetic operators

            int sum = x + y;
            int sub = x - y;
            int prod = x * y;
            int divide = x / y;

            Console.WriteLine($"Addition of {x} and  {y} = {sum}");
            Console.WriteLine($"Subtraction of {x} and {y} = {sub}");
            Console.WriteLine($"Multiplication of {x} and {y} = {prod}");
            Console.WriteLine($"Division of {x} and {y} = {divide}");

            // Comparison operator
            if(x == y)
            {
                Console.WriteLine($"{x} = {y}");
            }
            else if(x < y)
            {
                Console.WriteLine($"{x} < {y}");
            }
            else if(x > y)
            {
                Console.WriteLine($"{x} > {y}");
            }

            bool check = false;

            if(check)
            {
                Console.WriteLine($"Check is {check}");
            }
            else
            {
                Console.WriteLine($"Check is {!check}");
            }

            // Conditional operator
            bool val1 = false, val2 = true;

            if(val1 == true && val2 == true)
            {
                Console.WriteLine("Both are true");
            }
            else if(val1 == true || val2 == false)
            {
                Console.WriteLine("val1 is true");
            }
            else if (val1 == false || val2 == true)
            {
                Console.WriteLine("val2 is true");
            }
            else
            {
                Console.WriteLine("Both are false");
            }

            // Ternary operator

            bool result = (x > y) ? true : false;

            if (result)
            {
                Console.WriteLine($"{x} is greater than {y}");
            }
            else
            {
                Console.WriteLine($"{x} is not greater than {y}");
            }
        }
    }
}
