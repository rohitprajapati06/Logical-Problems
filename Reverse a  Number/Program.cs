// See https://aka.ms/new-console-template for more information
using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, rev = 0 , rem,temp;
            Console.WriteLine("Enter number for Reverse");
             n = Convert.ToInt32(Console.ReadLine());
            while(n > 0)
            {
                rem = n % 10;
                rev = rev * 10 + rem;
                n /= 10;
            }
            Console.WriteLine("Reverse of a number is "+rev);
        }
    }
}