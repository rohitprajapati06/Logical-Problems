using System;

class Program
{
    public static int MaxProductSubarray(int[] nums)
    {
        if (nums == null || nums.Length == 0)
            return 0;

        int maxProduct = nums[0];
        int currentMax = nums[0];
        int currentMin = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < 0)
            {
                // Swap currentMax and currentMin
                int temp = currentMax;
                currentMax = currentMin;
                currentMin = temp;
            }

            currentMax = Math.Max(nums[i], currentMax * nums[i]);
            currentMin = Math.Min(nums[i], currentMin * nums[i]);

            maxProduct = Math.Max(maxProduct, currentMax);
        }

        return maxProduct;
    }

    static void Main(string[] args)
    {
        int[] nums = { 2, 3, -2, 4 ,-1};
        Console.WriteLine("Maximum Product Subarray: " + MaxProductSubarray(nums));
    }
}
