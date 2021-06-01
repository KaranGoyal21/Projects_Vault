using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Project
{
    public class Testing
    {
        static void Main(string[] args)
        {
            /*
            Testing.MaxMarks = 50;// does not require instantiation of class and can be initialise directly

            Testing t1 = new Testing();
            t1.marks = 45;
            t1.CalculatePercent();
            */
            Testing t1 = new Testing(); //Instantiating class in t1 and calculating percentage using default constructor
            t1.CalculatePercent();
            Testing t2 = new Testing(35); //Instantiating class in t2 and calculating percentage using parameterised constructor
            t2.CalculatePercent();
            Testing t3 = new Testing(t2); //Instantiating class in t3 and calculating percentage using copy constructor
            t3.CalculatePercent();
            Testing t4 = new Testing { marks = 10 };  //Object initializer
            t4.CalculatePercent();

        }


        /*
        /// <summary>
        /// defining class and instantiating the class and passing data to invoke the method.
        /// </summary>
        int marks;// non static or instance member
        static int MaxMarks = 50;// static or class member. they are noway related to instance
        void CalculatePercent()
        {
            int percent = this.marks * 100 / Testing.MaxMarks;
            Console.WriteLine(percent);
        }
        */

        /// <summary>
        /// testing constructor types
        /// </summary>
        int marks;// non static or instance member
        static int MaxMarks;// static or class member. they are noway related to instance
        Testing()    //Default constructor
        {
            this.marks = 30;
        }
        Testing(int marks)    //Parameterised constructor
        {
            this.marks = marks;
        }
        Testing(Testing t)    //Copy constructor
        {
            this.marks = t.marks;
        }

        static Testing()    //Static constructor
        {
            Testing.MaxMarks = 50;
        }
        void CalculatePercent()
        {
            int percent = this.marks * 100 / Testing.MaxMarks;
            Console.WriteLine(percent);
        }
    }
}
