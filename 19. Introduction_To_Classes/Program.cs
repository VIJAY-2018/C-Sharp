using System;

namespace Introduction_To_Classes
{
    public class Customer
    {
        string _FirstName;
        string _LastName;
        public Customer()
        {
        }
        public Customer(string FirstName, string LastName)   // Parameterized Constructor
        {
            this._FirstName = FirstName;
            this._LastName = LastName;
        }
        public void PrintName()
        {
            Console.WriteLine($"Firstname = {this._FirstName}, Lastname = {this._LastName}");
        }

        ~Customer()
        {

        }
    }
    class Program
    {
        static void Main()
        {
            Customer c1 = new Customer("Vijay", "Pokhriyal");
            c1.PrintName();

            Customer c2 = new Customer();
            c2.PrintName();
        }
    }
}
/* A class consists of data and behaviour.
 1. Class data is represented by its fields.
 2. Behaviour is represented by its methods. 

 ---------------- Constructor  -------------------------

1. To initialize class fields. A class constructor is automatically called when an instance 
    of a class is created.
2. Constructors do not have return values and always have the same name as the class.
3. It is not necessary to define a constructor, it is automatically called if not created explicitly.
4. Constructors can be overloaded.
xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx

---------------- Destructor ------------------------

1. Destructor have the same name as the class with ~ symbol infront of them.
2. They don't take any parameters and don't return any value.
3. They are called by the Garbage Collector
 */

