// See https://aka.ms/new-console-template for more information
using System;
namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            Console.WriteLine("Enter Prime Number to check");
            n = Convert.ToInt32(Console.ReadLine());
            for(i = 2; i <= n/2; i++) // i cannot be 1 because its neither prime nor composite
            {
                if (n % i == 0)
                {
                    Console.WriteLine("The Given Number is not an Prime Number");
                    return;
                }
            }
            Console.WriteLine("It is an Prime Number ");

        }
    }
}
/*
 LOGIC 
Prime Number is any thing that is not divisible by any number , 1 is neither prime nor composite

    Assume n = 5
for i = 2 , it will increase till n/2 ,because i <= n will give prime for all  ,    5/2 = 2
if modulus of 5 % 2 = 0 
it will not be prime else prime
 */
