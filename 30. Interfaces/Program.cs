using System;

namespace Interfaces
{
    class Program
    {
        interface ICustomer1
        {
            void show();   //Point 3 -  By default it is public , we can explicitly use the access modifiers
            void Print();       // Point 1

          //  int id;             // Point 4

        /*
         public void print()     // Point 2 - compile time error
        {
        }
         */
        }
        interface ICustomer2 
        {
            void Print2();
        }
        interface ICustomer3 : ICustomer2
        {
            void Print3();
        }

        public class Customer : ICustomer1, ICustomer3
        {
            public void Print()                             // Point 5
            {
               
            }

            public void show()
            {
               
            }
            public void Print2()
            {

            }

            public void Print3()
            {
               
            }
        }
        static void Main()
        {
            ICustomer1 IC1 = new Customer();        // Point 8
            IC1.Print();
        }
    }
}
/*------------Some Important Points-------------
 
    1. We create interfaces using interface keyword. Just like classes interfaces also
       contains properties, methods, delegates or events, but only declarations and no 
       implementations.

    2. It is a compile time error to provide implementations for any interface member.

    3. Interface members are public by default, and they don't allow explicit access 
       modifiers.

    4. Interfaces cannot contain fields.

    5. If a class or a struct inherits from an interface, it must provide implementation 
       for all interface members. Otherwise, we get a compiler error.

    6. A class or a struct can inherit from more than one interface at the same time, but where
       as, a class cannot inherit from more than once class at the same time.

    7. Interfaces can inherit from other interfaces. A class that inherits this interface must 
       provide implementation for all interface members in the entire interface inheritance chain.

    8. We cannot create an instance of an inheritance, but an interface reference variable can 
       point to a derived class object.
 */
