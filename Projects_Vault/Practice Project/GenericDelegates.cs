using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Project
{
    /// <summary>
    /// Generic Delegate concept
    /// Defining data type at runtime.
    /// Using some pre defined generic delegate i.e func,action,predicate
    /// </summary>

    class Program
    {
        public static void SampleMethod(string name)
        {
            Console.WriteLine("Welcome " + name);
        }
        public static int Add(int x,int y)
        {
            return x + y;
        }
        public static bool Login(string uid)
        {
            if(uid == "karan")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            Action<string> action1 = SampleMethod;
            Func<int, int, int> func1 = Add;
            Predicate<string> pred1 = Login;

            action1("Karan");
            int result = func1(10, 20);
            bool result2 = pred1("karan");

            Console.WriteLine(result);
            Console.WriteLine(result2);
        }
    }
}