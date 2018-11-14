using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Item [] items = new Item[5]; // το Item[] είναι σα να γράφω var , το New θα καλέσει τον constructor του array 
            Random r = new Random();
            
            for (int i = 0; i<items.Length; i++)
            {
                items[i] = new Item(r.Next());
            }

            Console.WriteLine("Items : ");
            foreach (Item item in items)
            {
                Console.WriteLine("ItemID = {0} ", item.ID);
            }

            Item myItem = items[1];
            Console.WriteLine("My Item has ID = {0}", myItem.ID);

            var Presidents = new String[5];
            Presidents[0] = "Melissanidis";
            Presidents[1] = "Marinakis";
            Presidents[2] = "Alafouzos";

            Console.WriteLine("Presidents : ");
            foreach (string president in Presidents)
            {
                Console.WriteLine(president);
            }
            

            Array.Sort(Presidents); // βάζει σε αλφαβητική σειρά τον πίνακα των string μέσω της static method sort που κάλεσα μέσω της κλάσης array
            foreach (string president in Presidents)
            {
                Console.WriteLine(president);
            }
        }
    }
}
