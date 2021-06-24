using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Practice_Project
{
    /// <summary>
    /// Reflection Concept      (ildasm (dll file name) in cmd prmt)
    /// If we want a structure or any detailed information about a particular assembly or a type.
    /// It is used to obtain type information at runtime
    /// </summary>
    class program
    {
        static void Main(string[] args)
        {
            /*    If dll is available
            
            string path = @"E:\study\study\projects\Projects_Vault\Projects_Vault\AssemblyConceptManageUser\bin\Debug\net5.0\AssemblyConceptManageUser.dll";

            Assembly assembly = Assembly.LoadFile(path);

            Type[] types = assembly.GetTypes();
            foreach (var type in types)
            {
                Console.WriteLine("Class : " + type.Name);

                MethodInfo[] methods = type.GetMethods();
                foreach (var method in methods)
                {
                    Console.WriteLine("-- Method:" + method.Name);

                    ParameterInfo[] parameters = method.GetParameters();
                    foreach (var parameter in parameters)
                    {
                        Console.WriteLine("---- Parameter: " + parameter.Name + " : " + parameter.ParameterType);
                    }
                }
            }*/

            // if we want to pass particular type name

            Type type = typeof(string);

            Console.WriteLine("Class : " + type.Name);

            PropertyInfo[] properties = type.GetProperties();
            foreach (var prop in properties)
            {
                Console.WriteLine("-- Property: " + prop);
            }

            //MethodInfo[] methods = type.GetMethods();
            //foreach (var method in methods)
            //{
            //    Console.WriteLine("-- Method:" + method.Name);

            //    ParameterInfo[] parameters = method.GetParameters();
            //    foreach (var parameter in parameters)
            //    {
            //        Console.WriteLine("---- Parameter: " + parameter.Name + " : " + parameter.ParameterType);
            //    }
            //}


        }
    }
}
