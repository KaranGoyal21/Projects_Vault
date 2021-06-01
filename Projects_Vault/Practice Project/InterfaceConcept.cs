using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Project
{
    /// <summary>
    /// Implementing interface concept where multiple inheriting can be done
    /// </summary>
    interface IInterface1
    {
        void Method1();
        void Method2();
    }
    interface IInterface2
    {
        void Method2();
    }
    class MyClass1
    {
        public void M1()
        {
            Console.WriteLine("M1 from Myclass2");
        }
    }
    class MyClass2 : MyClass1, IInterface1, IInterface2
    {
        public void Method1()
        {
            Console.WriteLine("Method 1");
        }
        /*public void Method2()//Implicite implementation of interface
        {
            Console.WriteLine("Method 2");
        }*/
        void IInterface1.Method2()
        {
            Console.WriteLine("Method2 for IInterface1");
        }
        void IInterface2.Method2()
        {
            Console.WriteLine("Method2 for IInterface2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass2 m2 = new MyClass2();
            IInterface1 i1 = new MyClass2();
            i1.Method2();
            IInterface2 i2 = new MyClass2();
            i2.Method2();
        }
    }
}