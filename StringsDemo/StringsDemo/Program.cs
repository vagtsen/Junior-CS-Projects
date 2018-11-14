using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Peri Aidinopoulos ";
            Console.WriteLine("Trim '{0}'", fullName.Trim()); // trimarei to keno 
            Console.WriteLine("ToUpper '{0}'", fullName.Trim().ToUpper());
            
            var index = fullName.IndexOf(" ");
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index +1);

            Console.WriteLine("Enter a Name");
            var name = Console.ReadLine();
            



            Console.WriteLine("FirstName : " +firstName);
            Console.WriteLine("LastName : " +lastName);
            Console.WriteLine(index);
            Console.WriteLine(fullName); // επιστρέφει κανονικά το String γιατί τα String γενικά είναι immutable!!! , δηλαδη δεν μεταβάλλονται

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName : " + names[0]);
            Console.WriteLine("LastName : " + names[1]);

            Console.WriteLine(fullName.Replace("Peri", "Periklis"));

            //if (String.IsNullOrEmpty(" ".Trim())) // οποιoδήποτε object μπορεί να γίνει Null , χρησιμοποιείται για να ελέγξω ένα string
            if (String.IsNullOrWhiteSpace(" "))
            {
                // "" -> σημαίνει empty 
                //" " -> σημαίνει whiteSpace
                Console.WriteLine("Invalid");
            }
            else
            {
                Console.WriteLine("Valid");
            }
        }
    }
}
