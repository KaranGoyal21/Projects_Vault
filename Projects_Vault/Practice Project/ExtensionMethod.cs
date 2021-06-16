using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Project
{
    /// <summary>
    /// Extension method is created to add method to existing types.
    /// They are special kind of static method in static class.
    /// They can be accessed with instance member and not class name like other static methods.
    /// </summary>
    static class Class1
    {
        public static int GetDigits(this int num)
        {
            int count = 0;
            while(num != 0)
            {
                count++;
                num = num / 10;
            }
            return count;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 2121345135;
            int result = num1.GetDigits();
            Console.WriteLine("Digits: "+result);
        }
    }
}