using System;

class Program
{
    static void Main()
    {
        // Initialize the array
        int[] array = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Original Array:");
        PrintArray(array);

        // Reverse the array
        ReverseArray(array);

        Console.WriteLine("Reversed Array:");
        PrintArray(array);
    }  
    static void ReverseArray(int[] array)
    {
        int start = 0;
        int end = array.Length - 1;

        while (start < end)
        {
            // Swap the elements at the start and end
            int temp = array[start];
            array[start] = array[end];
            array[end] = temp;

            // Move the pointers
            start++;
            end--;
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
