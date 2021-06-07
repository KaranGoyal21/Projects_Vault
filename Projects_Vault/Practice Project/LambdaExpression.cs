using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Project
{
    /// <summary>
    /// Lamda Expression
    /// Simple task or function can be converted to lambda expression.
    /// </summary>
    /*delegate int Del(int x);// for single value*/
    delegate void Del(int x, int y);// for multiple value
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Del del = x => x * x;// for single value
            int result = del(10);
            Console.WriteLine(result);
            */

            // for multiple value
            Del del = (x, y) =>
            {
                Console.WriteLine(x * y);
            };
            del(10, 10);
        }
    }
}