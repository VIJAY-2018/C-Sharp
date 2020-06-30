using System;

namespace Namespaces
{
    class Program
    {
        static void Main()
        {
            ProjectA.TeamA.ClassA.Print();
            ProjectA.TeamB.ClassB.Print();
        }
    }
   
}
/*namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void print()
            {
                Console.WriteLine("This is TemaA namespace");
            }
        }
    }
}
namespace ProjectA
{
    namespace TeamB
    {
        class ClassB
        {
            public static void print()
            {
                Console.WriteLine("This is TemaB namespace");
            }
        }
    }
}
*/