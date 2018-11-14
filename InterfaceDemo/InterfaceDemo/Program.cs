using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Einai ena sumvolaio opws auto pou epistrefw apo th methodo
            //deksi click sto solution add new item kai meta interface

            var storableObjects = new List<Storable>(); // λίστα που δέχεται storables έβαλα το Interface 
            Note note = new Note();
            storableObjects.Add(note);
            DBEntry dbEntry = new DBEntry();
            storableObjects.Add(dbEntry);

            note = new Note();
            storableObjects.Add(note);

            note = new Note();
            storableObjects.Add(note);
            dbEntry = new DBEntry();
            storableObjects.Add(dbEntry);

            foreach(Storable storable in storableObjects)
            {
                storable.Write(null);
                Console.WriteLine(storable.Read());
            }

        }
    }
}
