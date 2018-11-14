using System;
using System.Text;

namespace Humanity
{
    class Worker : Human // Inheritance
    {
        private  decimal MinWeekSalary = 10;
        private  int MinWorkingHoursPerDay = 1;
        private  int MaxWorkingHoursPerDay = 12;

        private decimal weekSalary;
        //Property evaluation 
        private decimal WeekSalary
        {
            set
            {
                if (value <= MinWeekSalary)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: {nameof(weekSalary)}");
                }
                weekSalary = value;
            }
        }
        private double workHoursPerDay;

        //Property evaluation
        private double WorkHoursPerDay
        {
            set
            {
                if (value < MinWorkingHoursPerDay || value > MaxWorkingHoursPerDay)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: {nameof(workHoursPerDay)}");
                }

                this.workHoursPerDay = value;
            }
        }
        private static int counter;
        // A read-only static property:
        public static int Counter
        {
            get { return counter; }
        }

        //Creation of Worker Constructor
        public Worker(string firstName, string lastName, decimal weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            WeekSalary = weekSalary;
            WorkHoursPerDay = workHoursPerDay;

            ++counter;
        }

 
        private decimal GetSalaryPerHour()
        {
            var salaryPerDay = weekSalary / 5;
            return salaryPerDay / (decimal)workHoursPerDay;
        }
        
        //Overriding ToString for printing the results 
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append(base.ToString())
                .AppendLine($"Week Salary: {weekSalary}")
                .AppendLine($"Hours per day: {workHoursPerDay}") // using String Interpolation
                .AppendLine($"Salary per hour: {GetSalaryPerHour()}");

            return sb.ToString();
        }

        //public override void GetStudentWorker()
        //{
            
        //    int counter = 0;
        //    do
        //    {
        //        Console.WriteLine("Please enter student's data seperated with backspace");
        //        var studentData = Console.ReadLine().Split();
        //        Console.WriteLine("Please enter worker's data seperated with backspace");
        //        var workerData = Console.ReadLine().Split();

        //        try
        //        {
        //            var student = new Student(studentData[0], studentData[1], studentData[2]);
        //            var worker = new Worker(workerData[0], workerData[1], decimal.Parse(workerData[2]), double.Parse(workerData[3]));

        //            Console.WriteLine(student);//print the Students Data
        //            Console.WriteLine(worker);//print the Workers Data
        //            Console.WriteLine("Workers are : " + Worker.Counter);// Counting the Workers
        //        }
        //        catch (ArgumentException ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //        }

        //    } while (Worker.Counter < 3);
        //}

    }
}
