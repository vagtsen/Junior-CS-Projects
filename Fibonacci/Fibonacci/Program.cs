using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number\t"); // afinei ena tab me to \t
            int fib = int.Parse(Console.ReadLine());
            
            int a = 0;
            int b = 1;
            
            //int number = 1;
            for (int i = 3; i <= fib; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
                Console.WriteLine("the required {0} fib number is {1}", i, b);
            }
            Console.WriteLine(b);

        }
    }
}
