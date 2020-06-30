using System;

namespace Class_vs_Structure
{
    class Program
    {
       // public struct Customer // For point 5 and 6 and 7 and 8 and 9 , comment line no 8 when you use line no 7 to see the differences in class vs structs
        public class Customer
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public Customer(int id,string name)
            {
                this.ID = id;
                this.Name = name;
            }
            //For point 8
            //Class can have parameter less constructor
            public Customer()
            {

            }
            //For point 7 
            // Structure can't have destructor but class can have 
            ~Customer()
            {

            }

        }

        // For point 9 - Struct can't inherit from another class where as a class can
        public class ChildClass : Customer
        {

        }
        static void Main()
        {
            int x = 10;                     //Point 2 Structs are stored on stack
            Customer c = new Customer(101, "Vijay");    //Point 2 classes are stored on heap

            {
                int y = x;          // Point 2 and 3 and 4, Value types hold their memory where they are declared
                Customer c2 = c;    // Point 2 and 3 and 4, Reference types hold a reference to an object in memory.
            }
            Customer c1 = c;                                // Point 5 and 6 for structure and class demo
            c1.Name = "Dhruvi";
            Console.WriteLine($"Id = {c1.ID} and Name = {c1.Name}");
            Console.WriteLine($"Id = {c.ID} and Name = {c.Name}");
        }
    }
}
/*-----------Some important points on Class and Structure----------

    1. All the differences that are applicable to value types and reference types
       are also applicable to classes and structs.
    2. Structs are stored on stack, where as classes are stored on the heap.
    3. Value types hold their value in memory where they are declared, but reference
       types hold a reference to an object in memory.
    4. Value types are destroyed immediately after the scope is lost, where as for 
       reference types only the reference variable is destroyed after the scope is lost.
       The object is later destroyed by garbage collector.
    5. When you copy a struct into another struct, a new copy of that struct gets created
        and modifications on one struct will not affect the values contained by another struct.
    6. When you copy a class into another class, we only gets a copy of the reference variable.
       Both the reference variables point to the same object on the heap. So, operations on one
       variable will affect the values contained by another reference variable.
    7. Structs can't have destructors, but classes can have destructors.
    8. Structs cannot have explicit parameter less constructor where as a class can.
    9. Struct can't inherit from another class where as a class can, Both structs and classes 
       can inherit from an interface.
 */

