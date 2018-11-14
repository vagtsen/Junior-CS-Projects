using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            List<int> myList = new List<int>(); //είναι δυναμικό σε σχέση με τον πίνακα, όταν του βάζω κάτι δημιουργεί κατευθείαν νέα θέση
            var random = new Random();
            for (int i = 0; i <10; i++)
            {
                myList.Add(r.Next()); //να πάω στη λίστα και να προσθέσω ακεραίους με τη χρήση της random 
            }

            myList.Sort(); // sortaro τη λίστα 

            foreach (int i in myList) 
            {
                Console.WriteLine( i);
            }

        }
    }
}
