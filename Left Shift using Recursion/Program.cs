using System;

namespace HelloWorld
{
    class Program
    {
        public static void LeftShift(int[] arr, int index, int start)
        {

            if (index == arr.Length - 1)
            {
                arr[index] = start;
                return;
            }

            arr[index] = arr[index + 1];

            LeftShift(arr, index + 1, start); 

        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int start = arr[0];
            LeftShift(arr, 0, start);
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}