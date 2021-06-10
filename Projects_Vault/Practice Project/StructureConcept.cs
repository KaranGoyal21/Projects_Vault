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
            structure1 var1 = new structure1();
            var1.Val = 10;

            structure1 var2 = var1;
            Console.WriteLine(var2.Val);

            var1.Val = 15;
            Console.WriteLine(var1.Val);
            Console.WriteLine(var2.Val);
        }
    }
}