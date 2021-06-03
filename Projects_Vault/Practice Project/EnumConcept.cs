using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Project
{
    /// <summary>
    /// Enum concept
    /// Forces user to choose values from the list of constants called enum.
    /// They are integer types for 0 base index to access them
    /// We will get named constant for individual values
    /// </summary>
    enum Gender
    {
        Male = 1,
        Female = 2,
        Unknown = 3
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person { Name = "Karan", Age = 10, Gender = Gender.Female };
            int gen = (int)p1.Gender;
            Console.WriteLine(gen);
        }
    }
}