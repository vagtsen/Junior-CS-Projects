using System;
using System.Linq;
using System.Text;

namespace Humanity
{
    class Student : Human
    {
        private  int FacNumMinLength = 5;
        private  int FacNumMaxLength = 10;
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            FacultyNumber = facultyNumber;
        }

        //public Student()
        //{
        //}

        //property evaluation , using only the set 
        private string FacultyNumber
        {
            set
            {
                if (value.Length < FacNumMinLength || value.Length > FacNumMaxLength ||
                    !value.All(char.IsLetterOrDigit)) // determine whether a character is a letter or a digit
                {
                    throw new ArgumentException("Invalid faculty number!");
                }

                facultyNumber = value;
            }
        }
        //Overriding ToString for printing the results 
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString())
                .AppendLine($"Faculty number: {facultyNumber}"); // using String Interpolation

            return sb.ToString();
        }

       // public override void GetStudentWorker()
       // {
       //     int counter = 0;
       //     do
       //     {
       //         Console.WriteLine("Please enter student's data seperated with backspace");
       //         var studentData = Console.ReadLine().Split();
       //         Console.WriteLine("Please enter worker's data seperated with backspace");
       //         var workerData = Console.ReadLine().Split();

       //         try
       //         {
       //             var student = new Student(studentData[0], studentData[1], studentData[2]);
       //             var worker = new Worker(workerData[0], workerData[1], decimal.Parse(workerData[2]), double.Parse(workerData[3]));

       //             Console.WriteLine(student);//print the Students Data
       //             Console.WriteLine(worker);//print the Workers Data
       //             Console.WriteLine("Workers are : " + Worker.Counter);// Counting the Workers
       //         }
       //         catch (ArgumentException ex)
       //         {
       //             Console.WriteLine(ex.Message);
       //         }

       //     } while (Worker.Counter < 3);      
       //}

    }
}
