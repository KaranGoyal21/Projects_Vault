using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Reflection;

namespace Practice_Project
{
    /// <summary>
    /// Multithreading Concept
    /// </summary>
    class program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(Method1));
            Thread thread2 = new Thread(new ThreadStart(Method2));

            //thread1.Priority = ThreadPriority.Highest;
            //thread1.IsBackground = true;  //By default its false.
            thread1.Start();
            thread2.Start();
        }

        static void Method1()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i == 50)
                {
                    //Thread.CurrentThread.Abort();
                    Thread.Sleep(3000);
                }

                Console.WriteLine("Method1 : " + i);
            }
        }

        static void Method2()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Method2 : " + i);
            }
        }
    }
}
