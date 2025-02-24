// See https://aka.ms/new-console-template for more information
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.IO;
namespace DividingAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1 ,56 ,98,34,67,22,59,28,73,49,27  };
            int mid = arr.Length / 2;

            int[] left = new int [mid];
            int[] right = new int[arr.Length-mid];

            Array.Copy(arr, 0, left, 0, mid);
            Array.Copy(arr,mid, right, 0, arr.Length-mid);


            Console.WriteLine("Left part of an array");
            foreach (int i in left)
            {
                Console.Write(i+" ");
            }

            Console.WriteLine("\n\nRight part of an array");
            foreach (int j in right)
            {
                Console.Write(j+" ");
            }
            


        }
    }
}
