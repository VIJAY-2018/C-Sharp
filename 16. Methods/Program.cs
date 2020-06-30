using System;

namespace Methods
{
    class Program
    {
        static void Main()
        {
            /*
             *  [Attributes-type]
             *  Access specifier return-type method-name(Parameters)
             *  {
             *       Method Body
             *  }
             */

             Program p = new Program();

            Console.WriteLine("Please enter two numbers");
            int fn = int.Parse(Console.ReadLine());
            int sn = int.Parse(Console.ReadLine());
            Console.WriteLine($"Addition of {fn} and {sn} = {p.Add(fn,sn)}");
            // if we make evenNumbers() method as static, then we will invoke that method by class name, Program.evenNumbers()
            Program.EvenNumbers();
        }
        public static void EvenNumbers()
        {
           for(int i=0;i<=20;i+=2)
            {
                Console.Write($"{i} ");
            }
        }

        public int Add(int first_number, int second_number)
        {
            return first_number + second_number;
        }
    }
}
