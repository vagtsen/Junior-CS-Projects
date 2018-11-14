using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Project Humanity!
//We will model Students and Workers.
//1. Every Student should have firstName, lastName, and a
// faculty number
//2. Every Worker should have firstName, lastName, week salary and
// work hours per day.
//3. Our software should be able to calculate the money he earns
// by hour.
//4. Print the Student info in the following format:

//  First Name : {Student's First Name}
//  Last Name : {Student's Last Name}
//  Faculty Number : {Student's Faculty Number}
//            
//5.Print the worker info in the following format:
//  First Name : {Worker's First Name}
//  Last Name : {Worker's Last Name}
//  Week Salary : {Worker's Week Salary}
//  Hours Per Day:{Worker's working hours}                                                
//  Salary Per Hour:{Worker's salary per hour}
//  Προσοχή θα χρειαστεί να κάνω και validation στα properties !!                             

//Constraints:
//First Name: Should start with a capital letter, should be more
//than 2 characters
//Last Name: Should start with a capital letter, should be more
//than 3 characters
//Faculty Number: Should be in Range[5...10] π.χ CB01105 
//Week Salary: Should be more than 10
//Working Hours: Should be in Range[1...12]
//Print exactly two digits after every double value's 
//decimal operator.
//Consider workweek from Monday to Friday.
//A Faculty Number should be consisted only of digits and letters.
//FirstName and LastName must always be submitted. If first letter
//is not a capital, our software must fix it.
//At the end do not forget to print how many workers exist
// in our program.

namespace Humanity
{
    class Program
    {
        static void Main(string[] args)
        {
            
                do
                {
                    Console.WriteLine("Please enter student's data seperated with backspace");
                    var studentData = Console.ReadLine().Split();
                    Console.WriteLine("Please enter worker's data seperated with backspace");
                    var workerData = Console.ReadLine().Split();

                    try
                    {
                        var student = new Student(studentData[0], studentData[1], studentData[2]);
                        var worker = new Worker(workerData[0], workerData[1], decimal.Parse(workerData[2]), double.Parse(workerData[3]));

                        Console.WriteLine(student);//print the Students Data
                        Console.WriteLine(worker);//print the Workers Data
                        Console.WriteLine("Workers are : " + Worker.Counter);// Counting the Workers
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                } while (Worker.Counter < 3);   //stop condition    

            //Student vag = new Student();
            //Worker vag1 = new Worker();

            //vag.GetStudentWorker();
            //vag1.GetStudentWorker();
        }
    }
}
