using System;
using System.Runtime.CompilerServices;

namespace Properties_in_CS
{
    public class Student
    {
        private int _Id;
        private string _Name;
        private string _Email;

        public string Email   // making read only access
        {
            get
            {
                return this._Email;
            }
        }

        public int Id          // both read and write access
        {
            get
            {
                return this._Id;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Id cannot be negative");
                }
                this._Id = value;
            }
        }
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be null");
                }
                this._Name = value;
            }
        }
        class Program
        {
            static void Main()
            {
                Student s = new Student();
                Console.WriteLine("Enter id of the student");
                int id = int.Parse(Console.ReadLine());
                s.Id = id;

                Console.WriteLine("Enter name of the student");
                string name = Console.ReadLine();
                s.Name = name;

                Console.WriteLine($"Student id = {s.Id}");
                Console.WriteLine($"Student Name = {s.Name}");
            }
        }
    }
}