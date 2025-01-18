using System;

class Program
{
    static void Main()
    {
        string input = "abc"; // Example string
        Console.WriteLine("All substrings of "+input);

        FindAllSubstrings(input);
    }

    static void FindAllSubstrings(string input)
    {
        int length = input.Length;

        // Outer loop for the starting point of substrings
        for (int i = 0; i < length; i++)
        {
            // Inner loop for the ending point of substrings
            for (int j = i + 1; j <= length; j++)
            {
                // Extract substring using Substring method
                Console.WriteLine(input.Substring(i, j - i));
            }
        }
    }
}


/* Substring copy the string from the input.Substring(start position , end position)*/