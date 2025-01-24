using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion___Multiples___1_to_100
{
    internal class Program
    {
        static void  Mult(int number)
        {
            if(number > 100)    //If number is grater than 100 , recursion will stop
                return;

            Console.WriteLine(number); // This will print the number
            Mult(number + 8);   // Recursive Function call itself untill number exceeds 100
        }
            

        static void Main(string[] args)
        {
            Mult(8);
            Console.ReadKey();
        }
    }
}
