using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Project
{
    class Length
    {
        static void Main (string[] args)
        {
            Length len1 = new Length(2, 4);
            Length len2 = new Length(6, 8);
            Length len3 = len1 + len2;
            if(len1 > len2 )
            {
                Console.WriteLine("Len1 is greater");
            }
            else
            {
                Console.WriteLine("Len2 is greater");
            }

            Console.WriteLine(len1.GetLength());
            Console.WriteLine(len2.GetLength());
            Console.WriteLine("Total : "+len3.GetLength());
        }

        int feet, inch;
        public Length()    //Constructor overloading
        {
            this.feet = 0;
            this.inch = 0;
        }
        public Length(int feet, int inch)    //Constructor overloading
        {
            this.feet = feet;
            this.inch = inch;
        }

        public static Length operator +(Length l1, Length l2)    //Operator overloading
        {
            Length l3 = new Length();
            l3.feet = l1.feet + l2.feet;
            l3.inch = l1.inch + l2.inch;
            if(l3.inch >= 12)
            {
                l3.feet++;
                l3.inch -= 12;
            }
            return l3;
        }

        public static bool operator >(Length l1, Length l2)    //Operator overloading
        {
            if (l1.feet > l2.feet)
                return true;
            else if (l1.feet == l2.feet)
            {
                if (l1.inch > l2.inch)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public static bool operator <(Length l1, Length l2)    //Operator overloading
        {
            if (l1.feet < l2.feet)
                return true;
            else if (l1.feet == l2.feet)
            {
                if (l1.inch < l2.inch)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        string GetLength()
        {
            return string.Format("Length :{0}' {1}\"", feet, inch);
        }
    }
}
