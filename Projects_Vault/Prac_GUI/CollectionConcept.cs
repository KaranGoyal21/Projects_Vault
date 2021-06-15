using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac_GUI
{
    public partial class CollectionConcept : Form
    {
        ArrayList list;
        Stack stack;
        Queue queue;
        Hashtable ht;
        SortedList sortList;
        public CollectionConcept()
        {
            InitializeComponent();
        }

        private void CollectionConcept_Load(object sender, EventArgs e)
        {
            /*
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
            MessageBox.Show("Count: " + count);

            int capacity = list.Capacity;
            MessageBox.Show("Capacity: " + capacity);

            list.TrimToSize();
            capacity = list.Capacity;
            MessageBox.Show("Capacity: " + capacity);

            foreach (object item in list)
            {
                listBox1.Items.Add(item);
            }



            stack = new Stack();
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");
            stack.Push("Fourth");
            stack.Push("5th");

            stack.Pop();
            object top = stack.Peek();
            MessageBox.Show(top.ToString());

            foreach (object item in stack)
            {
                listBox1.Items.Add(item);
            }



            queue = new Queue();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            queue.Enqueue("Fourth");
            queue.Enqueue("5th");

            queue.Dequeue();
            object top = queue.Peek();
            MessageBox.Show(top.ToString());

            foreach (object item in queue)
            {
                listBox1.Items.Add(item);
            }



            ht = new Hashtable();
            ht.Add("key1", "Value1");
            ht.Add("abcd", "1234");
            ht.Add("xyz", "1234");
            ht.Add("ijkl", "Practise");
            ht.Add("2key", "code");

            bool search = ht.Contains("xyz");
            //ht.Remove("key1");
            MessageBox.Show(search.ToString());

            foreach (DictionaryEntry item in ht)
            {
                listBox1.Items.Add(item.Key + " : " + item.Value);
            }
            */



            sortList = new SortedList();
            sortList.Add("key1", "Value1");
            sortList.Add("abcd", "1234");
            sortList.Add("xyz", "1234");
            sortList.Add("ijkl", "Practise");
            sortList.Add("2key", "code");

            //sortList.Remove("key1");

            foreach (DictionaryEntry item in sortList)
            {
                listBox1.Items.Add(item.Key + " : " + item.Value);
            }
        }
    }
}
