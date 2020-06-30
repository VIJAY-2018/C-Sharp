using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main()
        {
            Add(1, 2, 3);
            Add(1, 2, out int Sum);
            Add(1, 3.5f);
        }
        public static void Add(int first, int second, int third)
        {
            int Sum = first + second + third;
            Console.WriteLine($"Sum = {Sum}");
        }

        public static void Add(int first, int second, out int Sum)
        {
            Sum = first + second;
            Console.WriteLine($"Sum = {first+second}");
        }
        public static void Add(int first, float second)
        {
            float Sum = first + second;
            Console.WriteLine($"Sum = {first + second}");
        }
    }
}
/*------  Method Overloading ------
 
 1. Function overloading and Method overloading are used interchangeably.
 2. Method overloading allows a class to have multiple methods with the same name,
    but, with a different signature. So, in C# functions can be overloaded based on
    the number, type(int,float, etc) and kind(value, Ref or out) of parameters.
 3. The signature of a method consists of the name of the method and the type,
    kind(value, ref, or out) and the number of its formal parameters. The signature
    of a method does not include the return type and the params modifirer. So,
    it is not possible to overload a function, just based on the return type or 
    params modifier.
 
 */