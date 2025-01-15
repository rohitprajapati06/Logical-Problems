


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_an_element_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            int element = 4;
            int[] newarr = new int[arr.Length + 1];

            Array.Copy(arr, newarr, arr.Length);

            newarr[arr.Length] = element;
            Console.WriteLine("After adding new element array is :");
            foreach (int i in newarr)
            {
                Console.Write(i+" ");
            }


        }
    }
}
