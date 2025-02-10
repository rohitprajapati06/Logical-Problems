// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics.CodeAnalysis;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Range for Pattern");
            int n = Convert.ToInt32(Console.ReadLine());
           

            for (int i = 0; i <= n; i++) 
            {
                for(int j = n; j > i; j--)// This give spaces initialy
                {
                    Console.Write(" ");
                }
                for(int k = 0;k < i; k++)
                {
                    Console.Write("*");// This will define * after spaces( middle part )
                }
                for (int l = 1; l < i; l++)
                {
                    Console.Write("*"); // This will define * at end part & completing Triangle
                }
                Console.WriteLine();// This will goes to new line after going throgh nested loops
            }
        }
    }
}
/* LOGIC 
 
For drawing a triangle we have to use nested loops

the main loop,
        for (int i = 0; i <= n; i++) , ASSUME n = 5
    We will use this loop for newline 

Now we have to take 3 loops inside  main loop , which is our Nested Loop

In 1 nested for loop 
        for(int j = n; j > i; j--){
            Console.Write(" ");

As you can see j = 5 , it  will print 5 space and later on reduce it ( j -- ) one by one
   

In 2 nested for loop 
          for(int k = 0;k < i; k++) 
             Console.Write("*");

So Now spaces are already there , this will print from 0 to 5 in ( * ) after spaces
Example.    
             *
            ** 
           ***
         
In 3 nested for loop 
    for (int l = 1; l < i; l++)
        Console.Write("*");

Now there is already spaces & few pattern of star from above 2 nested loop respectively
  this will increment * from 1 to 5  after spaces & few pattern , Completes the triangle 
 */

