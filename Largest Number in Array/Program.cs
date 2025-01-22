using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Number_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 58,3,54,69,89,87,94,4,32,91 };
            int largestnum = LargestNumber(arr);
            Console.WriteLine("The Largest Number in an Array is : "+largestnum);
            Console.ReadKey();

        }

        public static int LargestNumber(int[] arr)
        {
            int largest = int.MinValue;

            foreach (int num in arr) 
            {
                if(num > largest)
                {
                    largest = num;
                }
            }
            return largest;
        }
    }
}
