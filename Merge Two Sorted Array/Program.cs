using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Two_Sorted_Array
{
    public class Program
    {
        public static int[] MergeSortedArray(int[] arr1 , int[] arr2)
        {
            List<int> merged = new List<int>();
            int i = 0 , j = 0 ;
            while(i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j]) {
                    merged.Add(arr1[i]);
                    i++;
                }
                else
                {
                    merged.Add(arr2[j]);
                    j++;
                }
            }

            while(i < arr1.Length)
            {
                merged.Add(arr1[i]);
                i++;
            }

            while(j < arr2.Length)
            {
                merged.Add(arr2[j]);
                j++;
            }

            return merged.ToArray();
        } 
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 3, 6 };
            int[] arr2 = { 2,4, 5 };
            int[] MergeArray = MergeSortedArray( arr1, arr2);

            Console.WriteLine(string.Join(" , ",MergeArray));
            Console.ReadKey();
        }
    }
}
