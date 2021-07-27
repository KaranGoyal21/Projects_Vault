using System;

namespace ClassesAndRecords
{
    class Program
    {
        /*
        static void PrintCourse(Course course)
        {
            Console.WriteLine(course.Name);
        }*/


        static void Main(string[] args)
        {
            /*
            var pluralsightCourse = new Course();
            pluralsightCourse.Name = "Working with c# records";
            pluralsightCourse.Author = "Roland Guijt";

            PrintCourse(pluralsightCourse);

            var anotherCourse = pluralsightCourse;

            Console.WriteLine(pluralsightCourse.Name);
            Console.WriteLine(anotherCourse.Name);


            var classroomCourse = new CourseRecord("Working with c# records", "Roland Guijt");// this record is known as positional record.


            var (name, author) = classroomCourse; // destructuring concept.

            Console.WriteLine(name);
            Console.WriteLine(author);


            var (name, author) = pluralsightCourse; // destructuring class
            Console.WriteLine(name);
            Console.WriteLine(author);

            var anotherCourse = classroomCourse with { Name = "C# Getting Started" };// cloning mechanism which creates another instance instead of referencing the same memory.

            //var title = classroomCourse.GetTitle();

            var (name, author) = classroomCourse;
            */

            CourseRecord classroomCourse = new TimeCourseRecord(
                Name:"Working with c# records",
                Author:"Roland Guijt",
                Duration:90
                );

            var cloneCourse = classroomCourse with { Name = "John" };
            var castCourse = (TimeCourseRecord)cloneCourse;
            var duration = castCourse.Duration;

        }
    }

    public class Course
    {
        public string Name { get; set; }
        public string Author { get; set; }

        public void Deconstruct(out string name, out string author)
        {
            name = Name;
            author = Author;
        }
    }

    /// <summary>
    /// Records are immutable and values cannot be changed after object is constructed.
    /// It is more rigid than a class.
    /// </summary>

    /*
    public record CourseRecord(string Name, string Author)//these are properties in parameters of records with pascal casing. 
    {
        
        public string GetTitle()
        {
            return $"{Name} - {Author}";
        }

    }

    public record CourseRecord(string Name)
    {
        public CourseRecord(string name, string author) : this(name)
        {
            Author = author;
        }

        public void Deconstruct(out string name, out string author)
        {
            name = Name;
            author = Author;
        }


        /// <summary>
        /// Custom record types properties
        /// </summary>

        public string Author { get; init; }

        public string Title
        {
            get
            {
                return $"{Name} - {Author}";
            }
        }
    }
    */

    public record CourseRecord(string Name, string Author);
    public record TimeCourseRecord(string Name, string Author,int Duration): CourseRecord(Name, Author);
}
