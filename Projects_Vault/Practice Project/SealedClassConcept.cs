using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Project
{
    /// <summary>
    /// Sealed class concept
    /// Sealing the class prohibits it to inherit child/derived classes i.e. it cannot behave like base class but can behave like child class.
    /// </summary>
    sealed class MyClass1
    {
        public void M1()
        {
            Console.WriteLine("M1 from Myclass2");
        }
    }
    class MyClass2 : MyClass1
    {

    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}