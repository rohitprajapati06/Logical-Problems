using System;
class Program
{
    public static void Shiftzeros(int[] arr)
    {
        int nonzero = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != 0)
            {
                int temp = arr[nonzero];
                arr[nonzero] = arr[i];
                arr[i] = temp;

                nonzero++;
            }
        }
    }

    public static void Main(string[] args)
    {
        int[] arr = { 0, 1, 9, 8, 4, 0, 0, 2, 7, 0, 6, 0, 9 };
        Console.WriteLine("Orginal array : " + string.Join(", ", arr));

        Shiftzeros(arr);
        Console.WriteLine("After Shifting : " + string.Join(", ", arr));

    }
}