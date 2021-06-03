using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Project
{
    /// <summary>
    /// Structure concept
    /// Class is of reference type and structure are of value types
    /// </summary>
    struct structure1
    {
        public int Val { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            structure1 MyStructure1 = new structure1();
            MyStructure1.Val = 10;

            structure1 MyStructure2 = MyStructure1;
            Console.WriteLine(MyStructure2.Val);

            MyStructure1.Val = 15;
            Console.WriteLine(MyStructure2.Val);
        }
    }
}