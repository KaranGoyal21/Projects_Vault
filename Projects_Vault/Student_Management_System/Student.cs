using System;

namespace Student_Management_System
{
    class Student
    {
        public int Standard { get; set; }
        public int RollNo { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public string Address { get; set; }

        public Student()
        { }

        public Student(int a, int b, string c, int d, double e, string f)
        {
            this.Standard = a;
            this.RollNo = b;
            this.Name = c;
            this.Age = d;
            this.Height = e;
            this.Address = f;
        }

        public Student(string a, int b, int c)
        {
            this.Name = a;
            this.Age = b;
            this.Standard = c;
        }

        public Student(string a, int b)
        {
            this.Name = a;
            this.Age = b;
        }
    }
}
