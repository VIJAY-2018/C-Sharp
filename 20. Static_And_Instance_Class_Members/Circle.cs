using System;

namespace Static_And_Instance_Class_Members
{
    class Circle
    {
        int radius = 0;                  // instance fields
        public static float _PI;// = 3.14F;        // static fields  - only make static if it is gonna be constant i.e. not gonna change

        // Static Constructor  --> used to initialize the static members of the class.
        static Circle()
        {
            Circle._PI = 3.14F;
            Console.WriteLine("Static constructor called");
            //Circle._PI = 3.14F;
        }
        public Circle(int radius)
        {
            Console.WriteLine("Instance constructor called");
            this.radius = radius;
        }
        /*static Circle()
        {
            Console.WriteLine("Static constructor called");
            Circle._PI = 3.14F;
        }*/

        public void AreaOfCircle()
        {
            float area = _PI * this.radius * this.radius;
            Console.WriteLine($"Area of circle = {area}");
        }
        static void Main()
        {
            Console.WriteLine($"_PI = {Circle._PI}");  

           /* Circle C1 = new Circle(5);
            C1.AreaOfCircle();

            Circle C2 = new Circle(11);
            C2.AreaOfCircle();*/
        }
    }
}
/*
 1. When a class member includes a static modifier, then member is called as static member.
 2. Static members are invoked using class name, whereas instance members are invoked using instance(object) of the class.
 3. Static methods cannot have access modifiers
 4. Static constructor is called only once, no matter how many instances you create.
 5. Static constructors are called before instance constructors.
 6. Static constructors are called even before the initialization of static members.
 */
