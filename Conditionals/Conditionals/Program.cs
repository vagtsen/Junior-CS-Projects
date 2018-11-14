using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string ageAsString = Console.ReadLine();
            int age = int.Parse(ageAsString);
            

            //Check for Voting
            if (age >= 70)
            {
                Console.WriteLine("You are too old to vote"); //Steketai kai autonoma mono tou to if 

            }
            else if (age >= 18)
            {
                Console.WriteLine("You are an Adult");
            }
            else if (age < 18)
            {
                Console.WriteLine("You cannot vote .You are too young!");

            }
            else 
            {
                Console.WriteLine("Something went wrong!");//kalyptei ola ta ypoloipa conditions 
            }
          //End Check for Voting 
        }
    }
}
