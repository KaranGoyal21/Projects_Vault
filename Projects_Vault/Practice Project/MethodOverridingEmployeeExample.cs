using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Project
{
    /// <summary>
    /// Implementing method overriding concept where objects are bound to method in particular class at runtime.
    /// </summary>
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual void Work()
        {
            Console.WriteLine("It works.....");
        }
    }
    class Student : Person
    {
        public override void Work()
        {
            Console.WriteLine("It studies.....");
        }

    }
    class Employee : Person
    {
        public double Salary { get; set; }
        public string Designation { get; set; }
        public override void Work()//override done explicitly by derived or child class to define its own logic
        {
            Console.WriteLine("It earns.....");
        }
    }
    class Manager :Employee
    {
        public sealed override void Work()//Method logic is sealed to avoid further override of this method in devired classes.
        {
            Console.WriteLine("It manages the team.....");
        }
    }
    class BranchManager : Manager
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Student();
            p1.Work();
            p1 = new Employee();
            p1.Work();
            p1 = new Manager();
            p1.Work();
            p1 = new BranchManager();
            p1.Work();
        }
    }

}
