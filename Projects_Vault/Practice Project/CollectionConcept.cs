using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Project
{
    /// <summary>
    /// Implementing collection concept. 
    /// Memory allocation is of dynamic type i.e memory consumption will be according to the data stored in the collection.
    /// Data stored will be of object type.
    /// Number of elements are stored in single collection.
    /// In basic array its of static type.
    /// </summary>

    class Collection
    {
        ArrayList list;
        Stack stack;
        Queue queue;
        Hashtable ht;
        SortedList sortList;

        /// <summary>
        /// ArrayList can be used to add, remove, sort in ascending and descending order of the list using index/oject value.
        /// Its zero based index list.
        /// </summary>
        public void ArrayListConcept()
        {
            list = new ArrayList();
            list.Add("First");
            list.Add("Second");
            list.Add("Third");
            list.Add("Fourth");
            list.Add("5th");

            //list.Remove("Third");
            //list.RemoveAt(3);
            //list.RemoveRange(2, 2);

            //list.Sort();
            //list.Reverse();

            int count = list.Count;
            Console.WriteLine("Count: " +count);

            int capacity = list.Capacity;
            Console.WriteLine("Capacity: " +capacity);

            list.TrimToSize();
            capacity = list.Capacity;
            Console.WriteLine("Capacity: " + capacity);

            foreach (var item in list)
            {
                //Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Stack uses push and pop concept i.e last in first out.
        /// </summary>
        public void StackConcept()
        {
            stack = new Stack();
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");
            stack.Push("Fourth");
            stack.Push("5th");

            stack.Pop();
            var top = stack.Peek();
            Console.WriteLine(top);

            foreach(object item in stack)
            {
                //Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Queue uses queuing and dequeuing concept i.e first in first out.
        /// </summary>
        public void QueueConcept()
        {
            queue = new Queue();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            queue.Enqueue("Fourth");
            queue.Enqueue("5th");

            queue.Dequeue();
            object top = queue.Peek();
            Console.WriteLine(top);

            foreach(object item in queue)
            {
                //Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Hashtable contains key value pair.
        /// Key must be unique as major tasks like search, remove are done using keys only.
        /// </summary>
        public void HashtableConcept()
        {
            ht = new Hashtable();
            ht.Add("key1", "Value1");
            ht.Add("abcd", "1234");
            ht.Add("xyz", "1234");
            ht.Add("ijkl", "Practise");
            ht.Add("2key", "code");

            bool search = ht.Contains("xyz");
            //ht.Remove("key1");
            Console.WriteLine(search);

            foreach(DictionaryEntry item in ht)
            {
                //Console.WriteLine(item.Key + " : " + item.Value);
            }
        }

        /// <summary>
        /// SortedList contains key value pair.
        /// Key must be unique as major tasks like search, remove are done using keys only.
        /// Functionality are same as that of hashtable but only difference is that all the data will be sorted on the basis of the keys.
        /// </summary>
        public void SortedListConcept()
        {
            sortList = new SortedList();
            sortList.Add("key1", "Value1");
            sortList.Add("abcd", "1234");
            sortList.Add("xyz", "1234");
            sortList.Add("ijkl", "Practise");
            sortList.Add("2key", "code");

            //sortList.Remove("key1");

            foreach(DictionaryEntry item in sortList)
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
            //c1.ArrayListConcept();
            //c1.StackConcept();
            //c1.QueueConcept();
            //c1.HashtableConcept();
            c1.SortedListConcept();
        }
    }

}
