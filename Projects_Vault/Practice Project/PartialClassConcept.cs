using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Project
{
    /// <summary>
    /// Partial class concept
    /// We divide logic members as per task or operation that are presented in same class to numerous partial classes.
    /// While executing it will treat all of them as a single class.
    /// </summary>
    partial class MyClass1
    {
        public void M1()
        {
            Console.WriteLine("M1 from Myclass1");
        }
    }
    partial class MyClass1
    {
        public void M2()
        {
            Console.WriteLine("M2 from Myclass1");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass1 obj = new MyClass1();
            obj.M1();
            obj.M2();
        }
    }
}