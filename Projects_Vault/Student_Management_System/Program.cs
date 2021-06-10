using System;
using System.Collections.Generic;

namespace Student_Management_System
{
    class Program
    {
        static List<Student> stuList;

        static void Main(string[] args)
        {
            FillStudentData();
            DisplayAll();

            Console.WriteLine("\nEnter Roll No");
            GetName(int.Parse(Console.ReadLine()));

            Console.WriteLine("\nEnter Student Name");
            GetRollNo(Console.ReadLine());
        }

        public static void FillStudentData()
        {
            Student s1 = new Student(8, 101, "Alex", 14, 5.5, "Pimpri");
            Student s2 = new Student(9, 102, "Lisa", 15, 5.6, "Chinchwad");
            Student s3 = new Student(10, 103, "Owen", 16, 5.8, "KP");
            Student s4 = new Student(7, 104, "Max", 13, 5.2, "Shivajinagar");
            Student s5 = new Student(6, 105, "Justin", 12, 5.1, "Kothrud");

            stuList = new List<Student>() { s1, s2, s3, s4, s5 };
        }

        public static void DisplayAll()
        {
            foreach(var data in stuList)
            {
                Console.WriteLine("Standard = {0} \t Roll no = {1} \t Name = {2} \t Age = {3} \t Height = {4} \t Address = {5} \t Subjects = {6}",data.Standard,data.RollNo,data.Name,data.Age,data.Height,data.Address,data.SubjectList);
            }
        }

        public static void GetName(int rollNo)
        {
            foreach(var data in stuList)
            {
                if(rollNo == data.RollNo)
                {
                    Console.WriteLine(data.Name);
                    break;
                }
            }
        }

        public static void GetRollNo(string name)
        {
            foreach (var data in stuList)
            {
                if (name == data.Name)
                {
                    Console.WriteLine(data.RollNo);
                    break;
                }
            }
        }
    }
}