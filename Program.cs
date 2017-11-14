using System;
using System.IO;

namespace Student_Records
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Student Records");
            Console.WriteLine("Select an option:");
            Console.WriteLine("1-ReadFile");
            Console.WriteLine("2-Individual Student");
            int userInput = 0;
            userInput = Convert.ToInt32(Console.ReadLine());
            string[] StudentRecordsArray = new string[5];
            if (userInput == 1)
            {
                string FileNameInput = "";
                Console.WriteLine("Enter file name:");
                FileNameInput = Console.ReadLine();
                Console.WriteLine("");
                var FileNameOutput = StudentRecordesFunction(StudentRecordsArray,FileNameInput);
            }
            else if (userInput == 2)
            {
                string FileNameInput = "";
                Console.WriteLine("Enter file name:");
                FileNameInput = Console.ReadLine();
                string IndividualStudentCredentials = "";
                 IndividualStudentCredentials =   IndividualStudentCredentialsFunction(FileNameInput, IndividualStudentCredentials);
                Console.WriteLine(IndividualStudentCredentials);
            }
            Console.ReadKey();
        }
        private static string IndividualStudentCredentialsFunction(string FileNameInput, string IndividualStudentCredentials)
        {
            string[] StudentRecordsArrayInFunction = new string[5];
            using (StreamReader reader = new StreamReader(FileNameInput))
            {
                int i = 0;
                while (!reader.EndOfStream)
                {
                    StudentRecordsArrayInFunction[i] = reader.ReadLine();
                    i++;
                }
                Console.WriteLine("Choose a student you would like the credentials of");
                string ASingleFieldInStudentRecordsArrayInFunction = "";
                string StudentNumber = "";
                for (int i2 = 0; i2 < StudentRecordsArrayInFunction.Length; i2++)
                {
                    ASingleFieldInStudentRecordsArrayInFunction = Convert.ToString(StudentRecordsArrayInFunction[i2]);
                    StudentNumber = ASingleFieldInStudentRecordsArrayInFunction.Substring(0,3);
                    Console.WriteLine(StudentNumber);
                }
                string UserStudentInput = Console.ReadLine();
                Console.WriteLine("");
                bool BooleanValue = false;
                int count = 0;
                while (BooleanValue == false)
                {
                    if (UserStudentInput == StudentRecordsArrayInFunction[count].Substring(0,3))
                    {
                        IndividualStudentCredentials = (StudentRecordsArrayInFunction[count]);
                        BooleanValue = true;
                    }
                    else
                    {
                        count++;
                    }
                }
                return IndividualStudentCredentials;
            }
        }
        private static string[] StudentRecordesFunction(string[] StudentRecordsArray,string FileNameInput)
        {
            string[] StudentRecordsArrayInFunction = new string[5];
            using (StreamReader reader = new StreamReader(FileNameInput))
            {
                int i = 0;
                while (!reader.EndOfStream)
                {
                    StudentRecordsArrayInFunction[i] = reader.ReadLine();
                    i++;
                }
                foreach (var item in StudentRecordsArrayInFunction)
                {
                    Console.WriteLine(item);
                }
                return StudentRecordsArrayInFunction;
            }    
        }
    }
}
