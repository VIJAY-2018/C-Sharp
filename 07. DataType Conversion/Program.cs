using System;

namespace DataType_Conversion
{
    class Program
    {
        static void Main()
        {
            int x = 10;

            // Implicit conversion, generally lower order datatype can be typecasted to higher order datatype but vice-versa is not true

            float f = x;

            Console.WriteLine($"Value of f is {f}");

            float k = 1089898954545.2555F;

            //  int k1 = k;  //  not possible lower order datatype can't handle higher order datatype values

            // Explicit conversion using (datatype) and  Convert.sthsth
            // Typecase operator doesn't throws exception, whereas Convert.  throws exception

            int k2 = (int)k;
          //  int k1 = Convert.ToInt32(k);              // Convert throws exception

            Console.WriteLine("k2 is {0}", k2);
        //    Console.WriteLine("k1 is {0}", k1);

            // using Parse and TryParse, to convert string to other datatypes

            string str = "111121";  // The string format should be in correct format, incorrect format = "112212sfsfs"

            int num = int.Parse(str);


            Console.WriteLine($"Number is {num}");


            string str1 = "111121sfslfdjl";
            int result = 0;
            bool isConversionSuccessful = int.TryParse(str1,out result);

            if(isConversionSuccessful)
            {
                Console.WriteLine("Type conversion successful");
            }
            else
            {
                Console.WriteLine("Input format is not legible, please enter the correct string format");
            }

            /*Difference between Parse and TryParse
                1. If the number is in a string format you have 2 options - Parse() and TryParse() 
                2. Parse() method throws an exception if it cannot parse the value, whereas TryParse() returns a bool indicating whether it succeeded or failed.
                3. Use Parse() if you are sure the value will be valid, otherwise use TryParse()*/
        }
    }
}