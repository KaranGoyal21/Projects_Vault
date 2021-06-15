using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Project
{
    /// <summary>
    /// Implementing generic collection concept. Type is mentioned at runtime.
    /// Memory allocation is of dynamic type i.e memory consumption will be according to the data stored in the collection.
    /// Data stored will be of object type.
    /// Number of elements are stored in single collection.
    /// In basic array its of static type.
    /// </summary>

    class Collection
    {
        List<int> list;
        Stack<int> stack;
        Queue<int> queue;
        Dictionary<int, string> Dic;
        SortedDictionary<int, string> sortDic;

        /// <summary>
        /// List can be used to add, remove, sort in ascending and descending order of the list using index/typed item value.
        /// Its zero based index list. They are type specific.
        /// </summary>
        public void ListConcept()
        {
            list = new List<int>(10);
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);

            //list.Remove(30);
            //list.RemoveAt(3);
            //list.RemoveRange(2, 2);

            //list.Sort();
            //list.Reverse();

            int count = list.Count;
            Console.WriteLine("Count: " +count);

            int capacity = list.Capacity;
            Console.WriteLine("Capacity: " +capacity);

            list.TrimExcess();
            capacity = list.Capacity;
            Console.WriteLine("Capacity: " + capacity);

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Stack uses push and pop concept i.e last in first out. They are type specific.
        /// </summary>
        public void StackConcept()
        {
            stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);

            //stack.Pop();
            //int top = stack.Peek();
            //Console.WriteLine(top);

            foreach(int item in stack)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Queue uses queuing and dequeuing concept i.e first in first out. They are type specific.
        /// </summary>
        public void QueueConcept()
        {
            queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);

            //queue.Dequeue();
            //int top = queue.Peek();
            //Console.WriteLine(top);

            foreach(int item in queue)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Dictionary contains key value pair. They are type specific.
        /// Key must be unique as major tasks like search, remove are done using keys only.
        /// </summary>
        public void DictionaryConcept()
        {
            Dic = new Dictionary<int, string>();
            Dic.Add(101, "Value1");
            Dic.Add(105, "1234");
            Dic.Add(205, "1234");
            Dic.Add(2256, "Practise");
            Dic.Add(3056, "code");

            //bool search = Dic.ContainsKey(205);
            bool search = Dic.ContainsValue("code");
            //Dic.Remove(105);
            Console.WriteLine(search);

            foreach(KeyValuePair<int, string> item in Dic)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }

        /// <summary>
        /// SortedDictionary contains key value pair. They are type specific.
        /// Key must be unique as major tasks like search, remove are done using keys only.
        /// Functionality are same as that of dictionary but only difference is that all the data will be sorted on the basis of the keys.
        /// </summary>
        public void SortedDictionaryConcept()
        {
            sortDic = new SortedDictionary<int,string>();
            sortDic.Add(101, "Value1");
            sortDic.Add(105, "1234");
            sortDic.Add(205, "1234");
            sortDic.Add(2256, "Practise");
            sortDic.Add(3056, "code");

            bool search = sortDic.ContainsKey(205);
            //bool search = sortDic.ContainsValue("code");
            //sortDic.Remove(205);
            Console.WriteLine(search);

            foreach (KeyValuePair<int,string> item in sortDic)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Collection c1 = new Collection();
            //c1.ListConcept();
            //c1.StackConcept();
            //c1.QueueConcept();
            //c1.DictionaryConcept();
            //c1.SortedDictionaryConcept();
        }
    }

}
