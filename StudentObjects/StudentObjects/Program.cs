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
                Console.ReadKey();
            }

        }
        static void ReadFileIntoElementsArray(string fileName)
        {

            using (StreamReader reader = new StreamReader(fileName))
            {
                int i = 0;
                while (!reader.EndOfStream)
                {
                    var record = reader.ReadLine();
                    var elements = record.Split(',');

                    var number = Convert.ToInt32(elements[0]);
                    var first = Convert.ToString(elements[1]);
                    var last = Convert.ToString(elements[2]);
                    var dob = Convert.ToDateTime(elements[3]);
                    var grade = Convert.ToChar(elements[4]);
                    
                    
                    Student s = new Student(number, first, last, dob, grade);

                    foreach (var item in elements)
                    {
                        records.Add(s);
                    }
                    
                    i++;
                }

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
