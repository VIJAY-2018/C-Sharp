using System;

namespace Polymorphism
{
    public class Employee
    {
        public string FirstName = "FN";
        public string LastName = "LN";

        public virtual void PrintName()
        {
            Console.WriteLine($"Firstname = {FirstName} and Lastname = {LastName}");
        }
    }
    public class PartTimeEmployee :  Employee
    {
        public override void PrintName()
        {
            Console.WriteLine($"Firstname = {FirstName} and Lastname = {LastName} --> Part time employee");
        }
    }
    public class FullTimeEmployee : Employee
    {
        public override void PrintName()
        {
            Console.WriteLine($"Firstname = {FirstName} and Lastname = {LastName} --> Full time employee");
        }
    }
    public class Internship : Employee
    {
        public override void PrintName()
        {
            Console.WriteLine($"Firstname = {FirstName} and Lastname = {LastName} --> Intern employee");
        }
    }
    public class TemporaryEmployee : Employee
    {
       /* public override void PrintName()
        {
            Console.WriteLine($"Firstname = {FirstName} and Lastname = {LastName} --> Temporary employee");
        }*/
    }
    class Program
    {
        public static void Main()
        {
            Employee[] emp = new Employee[5];
            emp[0] = new Employee();
            emp[1] = new PartTimeEmployee();
            emp[2] = new FullTimeEmployee();
            emp[3] = new Internship();
            emp[4] = new TemporaryEmployee();


            foreach(Employee e in emp)
            {
                e.PrintName();
            }
        }
    }
}
//  ---- Some important points about Polymorphism ----
/*
 1. Polymorphism is one of the primary pillars of OOP.
 2. Polymorphism allows us to invoke derived class methods through a base class reference during runtime.
 3. In the base class the method is declared virtual, and in the derived class we override the same method.
 4. The virtual keyword indicates, the method can be overridden in any derived class.
 5. If we do not use any overridden method in the derived class, then by default the base class method will be invoked.
 */