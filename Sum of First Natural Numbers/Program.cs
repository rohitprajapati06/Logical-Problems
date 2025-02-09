using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_First_Natural_Numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int n = SumofNaturalNumbers(num);
            Console.WriteLine("Sum of N Natural Number till " + num + " is " + n);

        }

        public static int SumofNaturalNumbers(int num)
        {
            return num * (num + 1) / 2;
        }
    }
}
