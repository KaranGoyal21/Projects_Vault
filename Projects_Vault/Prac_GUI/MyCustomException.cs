using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac_GUI
{
    /// <summary>
    /// Custom exceptions are made for our specific application
    /// </summary>
    class MyCustomException : Exception
    {

        public MyCustomException()
        {
        }
        public MyCustomException(string message) : base(message)
        {
        }
        public MyCustomException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
