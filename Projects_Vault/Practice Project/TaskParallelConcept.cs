using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Reflection;

namespace Practice_Project
{
    /// <summary>
    /// Task Parallel Concept
    /// Task parallel library is used to achieve same concurrency and parallelism in execution in much easier way.
    /// TPL is based on the concept of a task, which represents asynchronous operation.
    /// Multithreading uses single core processor but TPL uses multi core processor.
    /// TPL runs task parallely in different core of processor so that task is even more faster than multithreading.
    /// </summary>
    class program
    {
        /*
        static void Main(string[] args)
        {

        // Type 1

            //Task t1 = new Task(() => DoWork(1, 1000));
            //t1.Start();
            //Task t2 = new Task(() => DoWork(2, 3000));
            //t2.Start();
            //Task t3 = new Task(() => DoWork(3, 1500));
            //t3.Start();

        // Type 2

            Task t1 = Task.Factory.StartNew(() => DoWork(1, 2000)).ContinueWith((prev) => DoOtherWork(1, 2000));
            Task t2 = Task.Factory.StartNew(() => DoWork(2, 2500));
            Task t3 = Task.Factory.StartNew(() => DoWork(3, 1500));

            Console.ReadKey();
        }

        static void DoWork(int id, int sleep)
        {
            Console.WriteLine("Task {0} is beginning...", id);
            Thread.Sleep(sleep);
            Console.WriteLine("Task {0} is completed...", id);
        }

        static void DoOtherWork(int id, int sleep)
        {
            Console.WriteLine("Other Task {0} is beginning...", id);
            Thread.Sleep(sleep);
            Console.WriteLine("Other Task {0} is completed...", id);
        }*/

        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("i = " + i);
                Thread.Sleep(1000);
            }  //Traditional for loop

            Parallel.For(0, 10, j =>

                  {
                      Console.WriteLine("j = " + j);
                      Thread.Sleep(1000);
                  });
        }
    }
}
