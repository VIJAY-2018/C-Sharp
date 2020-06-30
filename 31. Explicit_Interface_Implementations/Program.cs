using System;

namespace Explicit_Interface_Implementations
{
    class Program
    {
        interface I1
        {
            void Print();
        }
        interface I2
        {
            void Print();
        }
        public class Customer : I1, I2
        {
            /*void I1.Print()
            {
                Console.WriteLine("This is interface I1");
            }*/
            public void Print()
            {
                Console.WriteLine("This is interface I1");
            }
            void I2.Print()             // explicitly implemented interface
            {
                Console.WriteLine("This is interface I2");
            }
        }
        static void Main()
        {
            // One way to do it
            /*
                        Customer c = new Customer();
                        ((I1)c).Print();                // First need to typecast
                        ((I2)c).Print();
            */

            // Another way to do it
            /* I1 i1 = new Customer();
             I2 i2 = new Customer();

             i1.Print();
             i2.Print();*/

            // Third Way to do it , where we want to make one method as default then change the method in Customer class
            Customer c = new Customer();
            c.Print();   // will invoke I1 method
            ((I2)c).Print();   // will invoke I2 method
        }
    }
}
/*-------------Some important points-------------
 
Questim : A class inherits from 2 interfaces and both the interfaces have the same method name.
          How should the class implement the method for both the interfaces ?

Answer : We are using Explicit Interface Implementation technique to solve this problem.

    1. When a class explicitly implements an interface member, the interface member
       can no longere be accessed thru class reference variable, but only thru the 
       interface reference variable.

    2. Access modifiers are not allowed on explicitly implemented interface members.

    3. If you want to make one of the interface method, the default, then implement that
       method normally and the other interface method explicitly. This makes the default method
       to be accessible thru class instance.
 */