using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Project
{
    /// <summary>
    /// Implementing data hiding concept where in derived class a method with same signature is explicitly run by hiding method or data for same in base class
    /// </summary>
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void Work()
        {
            Console.WriteLine("It works.....");
        }
    }
    class Employee : Person
    {
        public double Salary { get; set; }
        public string Designation { get; set; }
        public new void Work()//Hiding done explicitly using "new" keyword
        {
            Console.WriteLine("It earns.....");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.Work();
        }
    }

}
