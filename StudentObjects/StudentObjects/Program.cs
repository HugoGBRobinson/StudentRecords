using System;
using System.Collections.Generic;
using System.IO;

namespace StudentObjects
{
    class Program
    {
        static List<Student> records = new List<Student>();
        static void Main(string[] args)
        {
            ReadToStudentList();
            
            
        }

        private static void ReadToStudentList()
        {
            Console.Write("Enter FileName: ");
            string fileName = Console.ReadLine() + ".txt";
            try
            {
                ReadFileIntoElementsArray(fileName);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File does not exist");
            }



        }
        static void ReadFileIntoElementsArray(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                var ElementsArray = reader.ToString().Split(',');


            }
        }

        private static void PrintStudent(Student s1)
        {
            Console.WriteLine(s1.Number);
            Console.WriteLine(s1.FirstName);
            Console.WriteLine(s1.LastName);
            Console.WriteLine(s1.DateOfBirth);
            Console.WriteLine(s1.Grade);
            Console.ReadKey();
        }
    }
}
