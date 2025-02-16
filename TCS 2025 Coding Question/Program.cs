/*
 
 Q. Given an array , such that split the array in two part , 
    find the product of the both the parts of array , if second part is 
    greater than the first part then reverse the array , if not print as it is
 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCS_2025_Coding_Question
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter Array elements seperated by space");
            string[] input = Console.ReadLine().Split(' ');

            for(int i = 0; i < input.Length; i++)
            {
                arr[i] = Convert.ToInt32(input[i]);
            }

            int mid = arr.Length / 2;
            int[] firsthalf = new int[mid];
            int[] secondhalf = new int[arr.Length - mid];

            int product1 = 1;
            int product2 = 1;

            List<int> result = new List<int>();

            Array.Copy(arr, 0, firsthalf, 0, mid);
            Array.Copy(arr, mid , secondhalf, 0, arr.Length - mid);

            foreach (int i in firsthalf) { 
                product1 *= i;
            }

            foreach (int i in secondhalf) { 
                product2 *= i;
            }

            if(product2 > product1)
            {
                for (int i = arr.Length-1; i >= 0; i--) { 
                    result.Add(arr[i]);
                }
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                Console.WriteLine(string.Join(" ", arr));

            }
        }
    }
}
