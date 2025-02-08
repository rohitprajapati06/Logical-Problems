using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0, remainder;

            while (num > 0) {

                remainder = num % 10;
                sum = sum + remainder;
                num = num/10;
            }
            Console.WriteLine("Sum of Digits are :" + sum);
            Console.ReadKey();
        }
    }
}
