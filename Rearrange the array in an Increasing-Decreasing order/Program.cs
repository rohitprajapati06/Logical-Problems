using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] array = { 1, 9, 2, 8, 3, 7, 4, 6, 5 };

        // Rearrange the array
        int[] result = RearrangeArray(array);

        // Print the result
        Console.WriteLine("Rearranged Array: " + string.Join(", ", result));
    }

    static int[] RearrangeArray(int[] arr)
    {
        // Sort the array
        Array.Sort(arr);

        // Split into two halves
        int mid = arr.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[arr.Length - mid];

        Array.Copy(arr, mid, right, 0, arr.Length - mid);
        Array.Copy(arr, 0, left, 0, mid);

        Array.Reverse(right);

        // Combine the two halves
        return left.Concat(right).ToArray();
    }
}
