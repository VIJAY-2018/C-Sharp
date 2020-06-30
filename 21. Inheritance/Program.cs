using System;
namespace Inheritance
{
    class Program
    {
        class Employee
        {
            string FirstName;
            string LastName;
            string Email;

            public void Set_Primary_Details()
            {
                Console.WriteLine("------------- Please enter your primary details ---------------");
                Console.WriteLine("Enter your firstname");
                FirstName = Console.ReadLine();
                Console.WriteLine("Enter your lastname");
                LastName = Console.ReadLine();
                Console.WriteLine("Enter your email id");
                Email = Console.ReadLine();
            }
            public void Get_Primary_Details()
            {
                Console.WriteLine($"Firstname = {FirstName}");
                Console.WriteLine($"Lastname = {LastName}");
                Console.WriteLine($"Email id = {Email}");
            }
        }
        class FullTimeEmployee : Employee
        {
            float PF;
            float Income_Tax;
            float Professional_Tax;

            public void Set_Secondary_Details()
            {
                Set_Primary_Details();
                Console.WriteLine("------------ Please enter your secondary details ---------------");
                Console.WriteLine("Enter your PF amount");
                PF = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter your Income tax amount");
                Income_Tax = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter your Professional tax amount");
                Professional_Tax = float.Parse(Console.ReadLine());
            }
            public void GetDetails()
            {
                Get_Primary_Details();
                Console.WriteLine($"PF = {PF}");
                Console.WriteLine($"Income_tax = {Income_Tax}");
                Console.WriteLine($"Professional_Tax = {Professional_Tax}");
            }
        }
        class Interns : Employee
        {
            float Professional_Tax;

            public void Set_Secondary_Details()
            {
                Set_Primary_Details();
                Console.WriteLine("Enter your Professional tax amount");
                Professional_Tax = float.Parse(Console.ReadLine());
            }
            public void GetDetails()
            {
                Get_Primary_Details();
                Console.WriteLine($"Professional_Tax = {Professional_Tax}");
            }
        }
        public static void Main()
        {
            Console.WriteLine("Full time employee details required:");
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.Set_Secondary_Details();

            Console.WriteLine("------ Full time employee details --------");
            FTE.GetDetails();

            Console.WriteLine("Intern employee details required:");
            Interns INTERN = new Interns();
            INTERN.Set_Secondary_Details();

            Console.WriteLine("------ Intern employee details --------");
            INTERN.GetDetails();
        }
    }
}
/*
 1. C# supports only single class inheritance.
 2. C# doesn't support multiple inheritance.
 3. C# supports multiple interface inheritance.
 4. Child class is a specialization of a base class.
 5. Base classes are automatically instantiated before child class.
 6. Parent class constructor executes before child class constructor.
 */