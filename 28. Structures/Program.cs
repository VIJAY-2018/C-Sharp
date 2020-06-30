using System;

namespace Structures
{
    class Program
    {
        public struct Customer
        {
            private string _name;
            private int _id;

            //Constructor
            public Customer(int id, string name)
            {
                this._id = id;
                this._name = name;
            }

            public int ID
            {
                get { return this._id; }
                set { this._id = value; }
            }
            public string NAME
            {
                get { return this._name; }
                set { this._name = value; }
            }

            public void PrintName()
            {
                Console.WriteLine($"Id = {this._id} and Name = {this._name}");
            }
        }
        static void Main()
        {
            Customer c1 = new Customer(1, "Vijay");
            c1.PrintName();

            Customer c2 = new Customer();
            c2.ID = 2;
            c2.NAME = "Dhruvi";
            c2.PrintName();

            Customer c3 = new Customer
            {
                ID = 3,
                NAME = "Shailesh"
            };
            c3.PrintName();
        }
    }
}
/*------------ SOME IMPORTANT POINTS -----------------
  Just like classed structs can have
1. Private Fields
2. Public Properties
3. Constructors
4. Methods
5. Open initializer syntax, introduced in C# 3.0 can be used to initialize
   either a struct or a class.
 */