using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Project
{
    /// <summary>
    /// Assembly Concept.
    /// It is basic structure to create or modify application developed in c#.
    /// It is also used for deployment and configurational things.
    /// .EXE/.DLL are known as assembly.
    /// Two types of assembly i.e private & shared.
    /// Private assembly referencing creates the copy of dll/exe assembly in your project.
    /// Shared assembly is created by installing assembly in GAC(global assembly cache) through which multiple referncing can be done.
    /// Copy of assembly is not created in shared assembly.
    /// </summary>

    public class User
    {
        public string HelloUser(string user)
        {
            return "Hello" + user;
        }

        public bool AuthenticateUser(string user, string password)
        {
            if (user == "karan" && password == "12345")
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
        }
    }

}