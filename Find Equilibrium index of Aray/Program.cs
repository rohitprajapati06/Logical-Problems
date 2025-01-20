using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = {-7, 1, 5, 2, -4, 3, 0 };
        FindEquilibriumIndices(arr);
    }

    static void FindEquilibriumIndices(int[] arr)
    {
        int totalSum = 0, leftSum = 0;

        // Calculate total sum of the array
        foreach (int num in arr)
        {
            totalSum += num;
        }

        // Traverse the array to find the equilibrium index
        for (int i = 0; i < arr.Length; i++)
        {
            // totalSum - leftSum - arr[i] gives the right sum
            if (leftSum == totalSum - leftSum - arr[i])
            {
                Console.WriteLine($"Equilibrium Index Found at: {i}");
            }
            leftSum += arr[i];
        }
    }
}

/*                                 Equilibrium
 *                         
 *                         
            leftsum (sum of elements before i) == rightsum (sum of elements after i)
            
  Right sum is

    total sum - left sum - arr[i] 

*/