using System;

namespace Constructor_Overloading
{
    class Program
    {
        class Parent
        {
            public Parent()     // By default, Default constructor is called 
            {
                Console.WriteLine("Parent class constructor called");
            }
            public Parent(string Name)
            {
                Console.WriteLine("Parent class with parameters");
            }
        }

        class Child : Parent
        {
            public Child() //: base("Derived class controlling parent class")
            {
                Console.WriteLine("Child class constructor called");
            }
        }
            
        static void Main(string[] args)
        {
            Child c = new Child();
        }
    }
}
/*
 1. By default, Default constructor is called.
 2. if we want to invoke the parameterized constructor by default, then we have to use : base(Pass the parameters as per datatype) 
*/
