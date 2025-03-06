using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmStrong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int n = int.Parse(Console.ReadLine());

            int temp = n , sum = 0 , rem = 0 ;

            while (n > 0) {
                rem = n % 10;
                sum = sum + (rem * rem * rem);
                n = n / 10;
            }

            if(temp == sum)
            {
                Console.WriteLine($"{sum} is an armstrong number");
            }
            else
            {
                Console.WriteLine($"{temp} is not an armstrong number");
            }
        }
    }
}
