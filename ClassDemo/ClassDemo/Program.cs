using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Peri = new Employee(); // create an instance of a class or object of a class
            Peri.Age = 21;
            Console.WriteLine("The age of the employee Peri is {0}", Peri.Age);
        }
    }
}
