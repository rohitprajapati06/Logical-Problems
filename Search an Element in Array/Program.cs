using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_an_Element_in_Array
{
    internal class Program
    {
        public static int LinearSearch(int[] arr, int target)
        {
            for(int i = 0 ; i <arr.Length ; i++) {

                if (arr[i] == target) { 
                    return i;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] arr = { 5, 6, 8, 3, 9 };
            Console.WriteLine("Enter the element to search for");
            int target = Convert.ToInt32(Console.ReadLine());

            int index = LinearSearch(arr, target);
            if (index != -1)
            {
                Console.WriteLine("Element " + target + " found at index :" + index);
            }
            else {
                Console.WriteLine("Element " + target + " not found in  Array ");
            }
        }
    }
}
