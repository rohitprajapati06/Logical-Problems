using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_Average_of_an_Array
{
    internal class Program
    {
        public static int Average(int[] arr) {

            int length = arr.Length;
            int sum = 0;
            for (int i = 0; i <= length-1; i++) { 
            
                sum += arr[i];
            }
            int average = sum / length;
            return average;
        }

        static void Main(string[] args)
        {
            int[] arr = {10,2,20,4};
            int avg = Average(arr);
            Console.WriteLine("Average of an Array : "+avg);
        }
    }
}
