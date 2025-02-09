using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Squares_of_Numbers
{

    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number of terms (N): ");
            int n = int.Parse(Console.ReadLine());

            int sum = SumOfSquares(n);
            Console.WriteLine("The sum of the series 1^2 + 2^2 + ... + N^2 is : "+sum);
        }

        public static int SumOfSquares(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i * i;
            }
            return sum;
        }
    }

}