using System;
using System.Linq;

class Program
{
    public static void Main()
    {
        int[] array = { 40, 10, 20, 30 };
        Console.WriteLine("Original Array: " + string.Join(", ", array));

        int[] rankedArray = GetRankedArray(array);
        Console.WriteLine("Ranked Array: " + string.Join(", ", rankedArray));
    }

    public static int[] GetRankedArray(int[] array)
    {
        // Create a sorted version of the array and map each element to its rank
        var sorted = array
            .Distinct() // Removes duplicate values
            .OrderBy(x => x) // Sorts the values in ascending order
            .Select((value, index) => new { value, rank = index + 1 }) // Assigns a rank to each value
            .ToDictionary(x => x.value, x => x.rank); // Creates a dictionary mapping each value to its rank

        // Replace each element in the array with its rank
        return array.Select(x => sorted[x]).ToArray(); // Replace each element with its rank from the dictionary
    }

}