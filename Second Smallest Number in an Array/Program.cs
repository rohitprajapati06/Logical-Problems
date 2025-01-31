using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Smallest_Number_in_an_Array
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = {25,36,15,45,12,36,52,16,39,21,23 };
            int secondsmall = SecondSmallestNumber(arr);
            Console.WriteLine("Second Smallest Number in an Array is : "+secondsmall); 
        }

        public static int SecondSmallestNumber(int[] arr)
        {
            int smallest = int.MaxValue;
            int secondsmallest = int.MaxValue;

            foreach (int num in arr) {
                if (num < smallest)
                {
                    secondsmallest = smallest;
                    smallest = num;
                }
                else if(num < secondsmallest && num != smallest){ 
                        secondsmallest = num;
                }
            }

            return secondsmallest;
        }
    }
}
