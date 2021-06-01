using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Project
{
    /// <summary>
    /// Creating base class and derived class. Inheritance is used to showcase relation between two of them.
    /// </summary>
    class MyClass1 // Base class
    {
        public MyClass1()
        {
            Console.WriteLine("MyClass1 Default Constructor");
        }
        public MyClass1(int a)
        {
            Console.WriteLine("MyClass1 Parameterized Constructor");
        }
        static MyClass1()
        {
            Console.WriteLine("MyClass1 Static Constructor");
        }
        public void Method1()
        {
            Console.WriteLine("Method1 from Myclass1");
        }
    }
    class MyClass2 : MyClass1 // Derived class
    {
        public MyClass2()
        {
            Console.WriteLine("MyClass2 Default Constructor");
        }
        public MyClass2(int b) : base(b) // Parameterised constructor inrelation with base class which will take the same value as derived class object.
        {
            Console.WriteLine("MyClass2 Parameterized Constructor");
        }
        static MyClass2()
        {
            Console.WriteLine("MyClass2 Static Constructor");
        }
        public new void Method1() // Data hiding concept is used to hide the method 1 used in class1 or base class.
        {
            Console.WriteLine("Method1 from Myclass1");
        }
        public void Method2()
        {
            Console.WriteLine("Method2 from Myclass2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //MyClass1 obj1 = new MyClass1();
            MyClass2 obj2 = new MyClass2(10);
            //obj2.Method1();
            //obj2.Method2();
        }
    }
}

