using System;
using System.IO;

namespace Practice_Project
{
    static class ReadStudentData
    {
        public static void ReadDataInsideFile()
        {
            FileInfo data = new FileInfo(@$"{AppConstants.BaseDirectoryPath}\data.txt");
            if (data.Exists)
            {
                StreamReader reader = data.OpenText();
                string str = reader.ReadLine();
                while (str != null)
                {
                    Console.WriteLine(str);
                    str = reader.ReadLine();
                }
                reader.Close();
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
        } 

        public static void WriteDataInsideFile()
        {
            FileInfo data = new FileInfo(@$"{AppConstants.BaseDirectoryPath}\data.txt");
            if (data.Exists)
            {
                StreamWriter write = data.AppendText();
                string str = Console.ReadLine();
                write.WriteLine(str);
                write.Close();
            }
            else
            {
                StreamWriter write = data.CreateText();
                string str = Console.ReadLine();
                write.WriteLine(str);
                write.Close();
            }
        }

        static void Main(string[] args)
        {
            ReadStudentData.ReadDataInsideFile();
            Console.WriteLine();
            ReadStudentData.WriteDataInsideFile();
            Console.WriteLine();
            ReadStudentData.ReadDataInsideFile();
        }
    }
}
