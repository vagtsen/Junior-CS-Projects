using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee John = new Employee("John Taramas", "uyfiyg", " jkviygcvuv", "nuyvuv", "juuhviuv");
            Console.WriteLine(John);

            John.Insurance = new InsuranceInfo()
            {
                PolicyId = "111",
                PolicyName = "LifeTime"
            };
            Console.WriteLine(John);

            Manager Bill = new Manager("Bill Trump","Paraiou","Peristeri","Attikis","4444");
            Console.WriteLine(Bill);

            Console.WriteLine(John.DoWork());
            Console.WriteLine(Bill.DoWork());

            Employee Alex = new Manager("Alex Sarli","Papa","Zografou","Attikis","16452");
            Console.WriteLine("Alex do Work : " + Alex.DoWork());

            //Ομαδοποίησα τα αποτελέσματα 
            List <Employee> employees = new List<Employee>();

            employees.Add(John);
            employees.Add(Bill);
            employees.Add(Alex);

            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp.DoWork());
            }
        }
    }
}
