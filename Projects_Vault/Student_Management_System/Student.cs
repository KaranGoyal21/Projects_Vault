using System;
using System.Collections.Generic;

namespace Student_Management_System
{
    enum Subject
    {
        History = 1,
        Geography = 2,
        Maths = 3,
        Hindi = 4,
        Marathi = 5,
        English = 6,
        German = 7,
        Science = 8
    }

    class Student
    {
        public int Standard { get; set; }
        public int RollNo { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public string Address { get; set; }
        public List<Subject> SubjectList { get; set; }

        public Student()
        { }

        public Student(int a, int b, string c, int d, double e, string f, List<Subject> subjects)
        {
            this.Standard = a;
            this.RollNo = b;
            this.Name = c;
            this.Age = d;
            this.Height = e;
            this.Address = f;
            this.SubjectList = subjects;
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
