using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallest_Number_in_Array
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 54,62,35,15,36,12,16,11,78,95};
            int smallnum = SmallestArray(arr);
            Console.WriteLine("Smaller Number in an Array is : "+smallnum);
            Console.ReadKey();
        }

        public static int SmallestArray(int[] arr) {
            
            int smallest = int.MaxValue;
            foreach (int num in arr) { 
                if(num < smallest)
                {
                    smallest = num; 
                }
            }
            return smallest;
        }
    }
}
