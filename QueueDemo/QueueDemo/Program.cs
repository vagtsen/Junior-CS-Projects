using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var myQueue = new Queue<int>();
            myQueue.Enqueue(100);
            myQueue.Enqueue(112);

            int val = myQueue.Dequeue();
            Console.WriteLine(val);

            for (int i = 0; i < 50; i++)
            {
                myQueue.Enqueue(i);
            }
            foreach (int i in myQueue)
            {
                Console.WriteLine(i);
            }
            var witchvalue = myQueue.Dequeue();
            Console.WriteLine("Witchvalue = {0}", witchvalue);
            witchvalue = myQueue.Dequeue();
            Console.WriteLine("Whitchvalue = {0}, second time", witchvalue);
        }
    }
}
