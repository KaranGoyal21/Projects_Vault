using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Project
{
    /// <summary>
    /// Generic class concept
    /// Type of class can be defined at runtime
    /// </summary>
    class MyClass1<T1, T2>
    {
        public T1 MyProperty { get; set; }
        public void M1(T1 p1,T2 p2)
        {
            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass1<int, string> obj = new MyClass1<int, string>();
            obj.MyProperty = 10;
            obj.M1(15, "Hello");
            Console.WriteLine(obj.MyProperty);
        }
    }
}