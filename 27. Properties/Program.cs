using System;

namespace Properties
{
    public class Student
    {
        private int _Id;
        private string _Name;

        //setting up id
        public void SetId(int id)
        {
            if (id > 0)
            {
                this._Id = id;
            }
            else
            {
                throw new Exception("Please enter valid Student id");
            }
        }
        public int GetId()
        {
            return this._Id;
        }

        //setting up name
        public void SetName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                this._Name = name;
            }
            else
            {
                throw new Exception("Student name cannot be null");
            }
        }
        public string GetName()
        {
            if (!string.IsNullOrEmpty(this._Name))
            {
                return this._Name;
            }
            else
            {
                throw new Exception("Name is empty");
            }
        }
    }
    class Program
    { 
        static void Main()
        {
            Student s = new Student();

            Console.WriteLine("Please enter student id");
            int id = int.Parse(Console.ReadLine());
            s.SetId(id);

            Console.WriteLine("Please enter student name");
            string name = Console.ReadLine();
            s.SetName(name);
            Console.WriteLine($"Student id is = {s.GetId()}");
            Console.WriteLine($"Student name = {s.GetName()}");
        }
    }
}
/*--------------- Some important points ----------------
 1. Marking the class fields public and exposing to the external world is bad,
    as you will not have control over what gets assigned and returned.
 2. Programming languages that does not have properties use getter and setter methods
    to encapsulate and protect fields.
 */