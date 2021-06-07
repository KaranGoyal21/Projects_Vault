using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Project
{
    /// <summary>
    /// Delegate concept
    /// It adds reference of method in a delegate for further sequential task.
    /// Multiple methods in single delegate is known as Multiple Cast Delegate.
    /// </summary>
    /*
    delegate int Mydel(int x, int y); // For single reference delegate
    */
    delegate void Mydel(int x, int y); // For MultiCast Delegate
    class Program
    {
        // For single reference delegate
        /*
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        */

        // For MultiCast Delegate
        public static void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public static void Multiply(int x, int y)
        {
            Console.WriteLine(x * y);
        }

        static void Main(string[] args)
        {
            // For single reference delegate
            /*
            Mydel del = new Mydel(Add);
            int result = del(10, 30);
            Console.WriteLine(result);
            del = Multiply;
            result = del(10, 30);
            Console.WriteLine(result);
            */

            // For MultiCast Delegate
            Mydel del = Add;
            del += Multiply;
            del(10, 30);

        }
    }
}