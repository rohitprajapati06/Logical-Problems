using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Duplicate_from_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1,3,3,5,6,6,7,8,8,9,9,10};
            int n = arr.Length;

            if (arr[0] != arr[1])
            {
                Console.Write(arr[0] + " ");
            }
            for (int i = 1; i < arr.Length-1; i++) {
                if (arr[i] != arr[i+1] && arr[i] != arr[i - 1])
                {
                    Console.Write(arr[i] + " ");
                }
            }
            if (arr[n-1] != arr[n-2])
            {
                Console.Write(arr[n-1] + " ");
            }
            Console.ReadKey();
        }
        
    }
}
