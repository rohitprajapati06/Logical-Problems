
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_oof_Range_of_Cubes
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int sum = 0;

            Console.WriteLine("Enter First Number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second Number");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a >= b)
            {
                Console.WriteLine("First Number should be less than Second Number");
            }
            else
            {

                for (int i = a; i <= b; i++)
                {
                    sum += i * i * i;
                }
                Console.WriteLine("The Sum of Range of Cubes from " + a + " to " + b + " is :\n" + sum);
         
            }
            Console.ReadKey();
        }
    }
}
