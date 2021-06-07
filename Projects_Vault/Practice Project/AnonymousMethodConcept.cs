using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Project
{
    /// <summary>
    /// Anonymous Method Concept
    /// Method without name.
    /// Reference is created between anonymous method and delegate to avoid manual invoking of method
    /// </summary>
    delegate int Del(int x);
    class Program
    {
        static void Main(string[] args)
        {
            Del del = delegate (int x)
            {
                Console.WriteLine("This is anonymous method");
                return 0;
            };
            del(10);
        }
    }
}