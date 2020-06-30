using System;

namespace MethodHiding
{
    public class Employee
    {
        public string Firstname;
        public string LastName;

        public void PrintName()
        {
            Console.WriteLine($"Firstname = {Firstname} and Lastname = {LastName}");
        }
    }
    public class PartTimeEmployee : Employee
    {
        public new void PrintName()
        {
            // base.PrintName();   // If we want to invoke the base class method
            Console.WriteLine("Intern Candidate");
            Console.WriteLine($"Firstname = {Firstname} and Lastname = {LastName}");
        }
    }
    public class FulltimeEmployee : Employee
    {
        public new void PrintName()
        {
            Console.WriteLine("Full time Candidate");
            Console.WriteLine($"Firstname = {Firstname} and Lastname = {LastName}");
        }
    }
    class Program
    {
        static void Main()
        {
            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.Firstname = "Vijay";
            PTE.LastName = "Pokhriyal";
            PTE.PrintName();

            FulltimeEmployee FTE = new FulltimeEmployee();
            FTE.Firstname = "Vivek";
            FTE.LastName = "Viswanathan";
            FTE.PrintName();

            // Suppose if we want to call the base class method then
            ((Employee)PTE).PrintName();
        }
    }
}
// -------------- Some important points -------------------
/*
 1. If we want to hide the base class method , then use the same method in the child class
 2. To avoid warning use the new keyword in the child class in the method name
 3. If we want to use the base class method, then we can do it in 2 ways:
    3.1 We can use base keyword. For eg. base.PrintName() in the child class
    3.2 Case child type to parent type object and invoke the hidden member.
        i.e. We can use ((Base class name)inherited class object).methodname to invoke
    3.3 We can use Base class name before child class object to give a reference 
        For e.g. Employee PTE = new PartTimeEmployee();
                 PTE.PrintName();  // This will invoke the base class method
 4. A parent class reference variable can point to child class reference variable but vice-versa is not true
 */