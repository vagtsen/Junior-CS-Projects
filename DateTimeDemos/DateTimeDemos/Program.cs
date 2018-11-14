using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2015,1,1);
            DateTime now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);
            //or
            //Console.WriteLine("Hour: " + today.Hour);

            var tomorrow = now.AddDays(1.0);// η DateTime είναι Immutable
            Console.WriteLine(now);
            var yesterday = now.AddDays(-1.0);
            Console.WriteLine(yesterday);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            //Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToString()); // όποιο object και να περάσω θα μπορέσει να μου καλέσει την μέθοδο toString
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm")); //DateTime format specifier


            // creating TimeSpan

            var timeSpan = new TimeSpan(1, 2, 3);
            Console.WriteLine("TimeSpan = " +timeSpan);
            
            //two ways of creating timeSpan
            var timeSpan1 = new TimeSpan(1, 0, 0); 
            var timeSpan2 = TimeSpan.FromHours(1);

            //Console.WriteLine(timeSpan1);
            //Console.WriteLine(timeSpan2);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);

            var duration = end - start;
            Console.WriteLine("Duration " +duration);

            // properties 

            Console.WriteLine("Minutes: " +timeSpan.Minutes);
            Console.WriteLine("Minutes: " +timeSpan.TotalMinutes);

            //Add 

            Console.WriteLine("Add example: " + timeSpan.Add(TimeSpan.FromMinutes(8))); // addition of 8 minutes 

            //Subtract 

            Console.WriteLine("Subtract example : " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //Parse 

            var timeSpanFromParse = TimeSpan.Parse("01:02:03");
            Console.WriteLine("Parse :" + timeSpanFromParse);

        }
    }
}
