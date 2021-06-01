using System;
using System.IO;

namespace FileIODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileExists();
            //ReadAllLines();
            //ReadAllText();
            // FileCopy();
            // DeleteFile();
            // ReadFromStreamReader();
            WriteUsingStreamWriter();
            Console.ReadKey();
        }

        public static void FileExists()
        {
            String path = @"C:\Users\Dell\DotNetProjects\FileIODemo\Example.txt";
            if (File.Exists(path))
                Console.WriteLine("File exists");
            else
                Console.WriteLine("File doesn't exists");
        }

        public static void ReadAllLines()
        {
            String path = @"C:\Users\Dell\DotNetProjects\FileIODemo\Example.txt";
            String[] lines;
            lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);

        }

        public static void ReadAllText()
        {
            String path = @"C:\Users\Dell\DotNetProjects\FileIODemo\Example.txt";
            String lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);

        }

        public static void FileCopy()
        {
            string path = @"C:\Users\Dell\DotNetProjects\FileIODemo\Example.txt";
            string copypath = @"C:\Users\Dell\DotNetProjects\FileIODemo\ExampleNew1.txt";

            File.Copy(path, copypath);

        }

        public static void DeleteFile()
        {
            string path = @"C:\Users\Dell\DotNetProjects\FileIODemo\ExampleNew1.txt"; ;

            File.Delete(path);

        }

        public static void ReadFromStreamReader()
        {
            String path = @"C:\Users\Dell\DotNetProjects\FileIODemo\Example.txt"; ;

            using (StreamReader sr = File.OpenText(path))
            {
                String s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

        }

        public static void WriteUsingStreamWriter()
        {
            String path = @"C:\Users\Dell\DotNetProjects\FileIODemo\Demo.txt";

            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("Hellow World - .Net is awesome");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
        }

    }


}