using System;

namespace MethodOverridingVSMethodHiding
{
    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("I am in Base class");
        }
    }
    public class ChildClass : BaseClass
    {
        // This is Method overriding - we use override keyword
       /* public override void Print()
        {
            Console.WriteLine("I am in child class");
        }*/

        // This is Method Hiding - we use new keyword
        public new void Print()
        {
            Console.WriteLine("I am in child class");
        }
    }
    class Program
    {
        static void Main()
        {
            BaseClass B = new ChildClass();
            B.Print();

            ChildClass C = new ChildClass();
            C.Print();
        }
    }
}
//--------- Some Important points ------------
/*
  1. In method overriding, a base class reference variable pointing to a child class object,
     will invoke the overridden method in the child class.
  
  2. In method hiding a base class reference variable pointing to a child class object,
     will invoke the hidden method in the Base class.
 */