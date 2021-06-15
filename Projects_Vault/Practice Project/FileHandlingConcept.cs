using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Project
{
    class Program
    {
        /// <summary>
        /// File handling using static class called file.
        /// We have to pass a location for every opertion we have to perform.
        /// </summary>
        public static class FileHandling
        {
            /// <summary>
            /// File static class used to create, copy, move and delete the files.
            /// We have to pass a location for every opertion we perform.
            /// </summary>
            public static void FileHandle()
            {
                //File.Create(@"D:\study\projects\Projects_Vault\Projects_Vault\Practice Project\file_handling\file.txt");
                //File.Copy(@"D:\study\projects\Projects_Vault\Projects_Vault\Practice Project\file_handling\file.txt", 
                //@"D:\study\projects\Projects_Vault\Projects_Vault\Practice Project\file_handling\temp\new_file.txt");

                //File.Move(@"D:\study\projects\Projects_Vault\Projects_Vault\Practice Project\file_handling\temp\new_file.txt",
                //@"D:\study\projects\Projects_Vault\Projects_Vault\Practice Project\file_handling\temp\renamed_file.txt");

                //File.Delete(@"D:\study\projects\Projects_Vault\Projects_Vault\Practice Project\file_handling\file.txt");
            }

            // <summary>
            /// File info class used to get more info regarding files along with create, copy, move and delete commands.
            /// We have to pass a location once only while creating an instance of the class.
            /// </summary>
            public static void FileInfoHandle()
            {
                FileInfo file = new FileInfo(@"D:\study\projects\Projects_Vault\Projects_Vault\Practice Project\file_handling\file.txt");
                file.Create();
            }

            public static void SaveDataInsideFile()
            {
                FileInfo file = new FileInfo(@"D:\study\projects\Projects_Vault\Projects_Vault\Practice Project\file_handling\myText.txt");
                StreamWriter writer = file.CreateText();
                writer.WriteLine(Console.ReadLine());
                writer.Close();
            }

            public static void ReadDataInsideFile()
            {
                FileInfo file = new FileInfo(@"D:\study\projects\Projects_Vault\Projects_Vault\Practice Project\file_handling\myText.txt");
                if (file.Exists)
                {
                    StreamReader reader = file.OpenText();
                    string str;
                    while((str = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(str);
                    }
                    reader.Close();
                }
            }
        }

        static void Main(string[] args)
        {
            //FileHandling.FileHandle();
            //FileHandling.FileInfoHandle();
            //FileHandling.SaveDataInsideFile();
            //FileHandling.ReadDataInsideFile();
        }
    }

}
