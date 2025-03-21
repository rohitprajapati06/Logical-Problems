using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Sum
{
    internal class Program
    {
        public static bool TwoSum(int[] arr , int target)
        {
            int start = 0;
            int end = arr.Length-1;

            while (start < end) { 
                
                int sum = arr[start] + arr[end];

                if (sum == target) { 
                    return true;
                }else if( sum > target)
                {
                    end--;
                }
                else
                {
                    start++;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] arr = { 2,3,7,11,15};
            int target = 10;
            bool val = TwoSum(arr,target);
            Console.WriteLine(val);
        }
    }
}
