using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Disarium
{
    internal class Program
    {
        public static int Disarium(int num) {
        
            int sum = 0 , length = num.ToString().Length , rem = 0;

            while(num > 0)
            {
                rem = num % 10;
                sum += (int)Math.Pow(rem, length);
                num /= 10;
                length--;
            }

            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number to Calculate Disarium No");
            int num = Convert.ToInt32(Console.ReadLine());

            int result = Disarium(num);
            Console.WriteLine($"Disarium of num {num} is : {result}");
        }
    }
}
