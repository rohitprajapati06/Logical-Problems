// See https://aka.ms/new-console-template for more information
using System;

namespace Fibonacci
{
    class Fibo
    {
        static void Main(string[] args)
        {
            int n1 = 0 ;
            int n2 = 1 ;
            int n3 ;
            int num;

            Console.WriteLine("Enter Number for Fibonaci Series");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write(n1+ " " +n2+ " ");
            for (int i = 2; i < num; i++)// i = 2 beacuse 1 and 2 term already defined
            {
                n3 = n1 + n2;
                Console.Write(n3+ " ");               
                n1 = n2;
                n2 = n3;
            }
            Console.ReadKey(); // if place insisde loop will execute only once


        /*
         * LOGIC
            Fibonaci is the sum of previous two element , where n1 = 0 & n2 = 1  and so on.......
            n3 = n1 + n2 
            print n3
        Now, n1 becomes n2....... i.e  n1 = 1
             n2 becomes n3.........i.e  n2 = 1
        The First iteration is complete,
        the loop will goes on till where condition is defined
         i < n ... it will increase till n
         */
        }
    }
}

