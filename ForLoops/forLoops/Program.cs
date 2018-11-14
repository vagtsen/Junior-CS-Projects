using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoops
{
    class Program
    {
        

        static void Main(string[] args)
        {
           
            //for (int i = 0; i<10; ++i) // eite to trexoume me postfix h me prefix einai to idio giati iparxei mon mia energeia 
            //{
            //    Console.WriteLine("Welcome " +i);
            //}
            //Console.WriteLine("End of loop");

            //int age = 35;
            //int newAge = ++age; //prefix operator
            //Console.WriteLine("age: {0}, newAge{1}",age, newAge);
            //newAge = age++; // postfix operator 
            //Console.WriteLine("age: {0}, newAge{1}", age, newAge);

            //int i = 0; einai ektos tou scope
            
            //for (int i = 0; i < 10; ++i)
           // {
                
           // }
            //int j = 0;
            //for (; ;)
            //{
            //    ++j;
            //    if (j == 5)
            //    {
            //        continue; //Synexise sthn epomenh epanalispsi ..ara den ektyponei to j =5 
            //    }
            //    Console.WriteLine("Welcome....{0}", j);
                
            //     if (j >10)
            //    {
            //        break; // profanos stamataei ti loupa 
            //    }
            //    Console.WriteLine("End of loop"); 
            //}

            //prints after 1000 per 50 
            //for (int i = 0; i <=2000; i++)
            //{

            //    if (i<=1000 && i % 100 == 0)
            //    {
            //        Console.WriteLine("Happy Birthday ! {0}", i);
                    
            //    }
                
            //    else if (i>1000 && i% 50 == 0)
            //    {
            //        Console.WriteLine("Happy Birthday ! {0}", i);
                    
            //    }
               
            //}

            //print the 
            //Console.Write("Enter a number\t"); // afinei ena tab me to \t
            //int number = int.Parse(Console.ReadLine());
            //Convert.ToInt32(Console.ReadLine());


            //for (int i = 0; i<=10; i++)
           // {
            //    var product = number * (i); //Alla ean to kano xwris na dilosoume exo apo to for to i xtypaei giati ??
             //   Console.WriteLine("The product of number {0} multiplied by {1} is {2}  : ",number,i ,product);
           // }

            //Nested Loop 
            //for (int i = 1; i <= 12; i++)
            //{
            //   for( int j = 1; j <= 7; j++)
            //    {
            //        Console.Write(j + "  ");
            //    }
            //    Console.WriteLine("\t\t" + i);
            //}

            Console.Write("Enter a number\t"); // afinei ena tab me to \t
            int fib= int.Parse(Console.ReadLine());

            int fib1 = 0;
            int fib2 = 1;
            int fib3 = fib1 + fib2;
            int Number;
            for (int i = 0; i <= fib; i++)
            {
                if ( fib > fib3)
                {
                    var number  += fib3 + i;
                    //Console.WriteLine("The sum is  : ",fib    
                    Console.WriteLine("The fibonacci number of fib {0} is {1}  : ", fib, number);
                }
                else if (fib == fib3)
                {

                    Console.WriteLine("The fibonacci number of fib {0} is {1}  : ", fib,fib3);
                }
            }
            
        }
        }
    }

