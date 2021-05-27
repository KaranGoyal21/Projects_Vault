using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Project
{
    public class Testing
    {
        /// <summary>
        /// defining class and instantiating the class and passing data to invoke the method.
        /// </summary>
        int marks;// non static or instance member
        static int MaxMarks = 50;// static or class member. there are noway related to instance
        void CalculatePercent()
        {
            int percent = this.marks * 100 / MaxMarks;
            Console.WriteLine(percent);
        }

        static void Main(string[] args)
        {
            Testing.MaxMarks = 50;// does not require instantiation of class and can be initialise directly

            Testing t1 = new Testing();
            t1.marks = 45;
            t1.CalculatePercent();
        }
    }
}
