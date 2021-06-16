using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac_GUI
{
    public partial class GenericCollectionConcept : Form
    {
        List<int> list;
        Stack<int> stack;
        Queue<int> queue;
        Dictionary<int, string> Dic;
        SortedDictionary<int, string> sortDic;
        public GenericCollectionConcept()
        {
            InitializeComponent();
        }

        private void CollectionConcept_Load(object sender, EventArgs e)
        {
            /*
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
            MessageBox.Show("Count: " + count);

            int capacity = list.Capacity;
            MessageBox.Show("Capacity: " + capacity);

            list.TrimExcess();
            capacity = list.Capacity;
            MessageBox.Show("Capacity: " + capacity);

            foreach (int item in list)
            {
                listBox1.Items.Add(item);
            }



            stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);

            //stack.Pop();
            int top = stack.Peek();
            MessageBox.Show(top.ToString());

            foreach (int item in stack)
            {
                listBox1.Items.Add(item);
            }



            queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);

            //queue.Dequeue();
            int top = queue.Peek();
            MessageBox.Show(top.ToString());

            foreach (int item in queue)
            {
                listBox1.Items.Add(item);
            }




            Dic = new Dictionary<int, string>();
            Dic.Add(101, "Value1");
            Dic.Add(105, "1234");
            Dic.Add(205, "1234");
            Dic.Add(2256, "Practise");
            Dic.Add(3056, "code");

            //bool search = Dic.ContainsKey(205);
            bool search = Dic.ContainsValue("code");
            //Dic.Remove(105);
            MessageBox.Show(search.ToString());

            foreach (KeyValuePair<int, string> item in Dic)
            {
                listBox1.Items.Add(item.Key + " : " + item.Value);
            }
            */




            sortDic = new SortedDictionary<int, string>();
            sortDic.Add(101, "Value1");
            sortDic.Add(105, "1234");
            sortDic.Add(205, "1234");
            sortDic.Add(2256, "Practise");
            sortDic.Add(3056, "code");

            bool search = sortDic.ContainsKey(205);
            //bool search = sortDic.ContainsValue("code");
            //sortDic.Remove(205);
            MessageBox.Show(search.ToString());

            foreach (KeyValuePair<int, string> item in sortDic)
            {
                listBox1.Items.Add(item.Key + " : " + item.Value);
            }

        }
    }
}
