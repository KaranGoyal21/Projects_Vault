using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Project
{
    /// <summary>
    /// Attribute Concept
    /// It passes the information about the behavior of various elements at runtime.
    /// It is a class derived from system attribute.
    /// </summary>

    [AttributeUsage(AttributeTargets.Class/*|AttributeTargets.Property|AttributeTargets.Method*/)]// Restrict attribute for particular type.
    class SampleAttribute : Attribute
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    [Sample(Id = 10, Name = "Karan")]
    class MyClass
    {
        /*
        [Sample]
        public int MyProperty { get; set; }

        [Sample]
        public void Method()
        {

        }
        */
    }
}