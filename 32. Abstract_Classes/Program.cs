using System;

namespace Abstract_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
/*------------- Some important points---------------
 
    1. The abstract keyword is used to create abstract classes.
    2. An abstract class is incomplete and hence cannot be instantiated.
    3. An abstract class can only be used as base class.
    4. An abstract class cannot be sealed.
    5. An abstract class may contain abstract members(methods, properties, indexers,
       and events), but not mandatory.
    6. A non-abstract class derived from an abstract class must provide implementation
       for all inherited abstract members.

    If a class inherits an abstract class, there are 2 options available for that class
    Option 1: Provide implementation for all the abstract members inherited from the
              base abstract class.
    Option 2: If the class does not wish to provide implementation for all the abstract 
              members inherited from the abstract class, then the class has to be marked
              as abstract.
 */