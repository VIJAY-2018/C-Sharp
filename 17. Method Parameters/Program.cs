using System;
using System.Security.Cryptography.X509Certificates;

namespace Method_Parameters
{
    class Program
    {
        static void Main()
        {
            // call by value  - there will not be any change in the value
            //Creates a copy of the parameter passed, so modification does not affect each other

            Console.WriteLine("------------- Call By value -------------");
            int a = 10, b = 11;

            Program p = new Program();

            Console.WriteLine($"Before swapping \n a = {a} and b = {b}");
            p.SwapByValue(a, b);
            Console.WriteLine($"After swapping \n a = {a} and b = {b}");

            // call by reference - address will be passed
            // in ref method, any changes made to the parameter passed will be reflected back after calling
             
            Console.WriteLine("------------- Call By address -------------");

            Console.WriteLine($"Before swapping \n a = {a} and b = {b}");
            p.SwapByReference(ref a, ref b);
            Console.WriteLine($"After swapping \n a = {a} and b = {b}");

            // to get the sum and product of two numbers using out
            // out - use when you want a method to return more than one value

             int add = 0, prod = 1;

            p.Operation(a,b,out add,out prod);
            Console.WriteLine($"Addition of {a} and {b} = {add}");
            Console.WriteLine($"Multiplication of {a} and {b} = {prod}");

            Console.WriteLine("------------ Params implementation -------------------");
            // implementation of params method
            int[] arr = new int[3];

            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;

            /*When you need an indefinite number of arguments, you can declare a parameter array, 
             * which allows a procedure to accept an array of values for a parameter. 
             * You do not have to know the number of elements in the parameter array when you define the procedure*/
            
            
            // ParamsMethod();    // without passing any array, it will treat as 0 sized array 
            // ParamsMethod(arr);     // with passing array, it will give us the exact size
            ParamsMethod(1, 2, 4);    // if we pass the elements simply , then also it will take it as an array elements and gives us the size
        }
        public void SwapByValue(int x, int y)
        {
            x = (x ^ y);
            y = (x ^ y);
            x = (x ^ y);
        }
        public void SwapByReference(ref int  x, ref int y)
        {
            x = x ^ y;
            y = x ^ y;
            x = x ^ y;
        }
        public void Operation(int inp1, int inp2,out int add,out int prod)
        {
            add = inp1 + inp2;
            prod = inp1 * inp2;
        }
        public static void ParamsMethod(params int[] arr)
        {
            Console.WriteLine($"Array size is {arr.Length}");
        }
    }
}