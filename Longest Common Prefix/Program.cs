using System;

class Program
{
    static void Main()
    {
        string[] words = { "flower", "flow", "flight" };
        string longestCommonPrefix = FindLongestCommonPrefix(words);
        Console.WriteLine("Longest Common Prefix: " + longestCommonPrefix);
    }

    static string FindLongestCommonPrefix(string[] words)
    {
        if (words == null || words.Length == 0) return "";

        // Start with the first string as the prefix
        string prefix = words[0];

        for (int i = 1; i < words.Length; i++)
        {
            while(!words[i].StartsWith(prefix))
            {
                // Reduce the prefix length until it matches the start of the current string
                prefix = prefix.Substring(0, prefix.Length - 1);

                // If prefix becomes empty, there's no common prefix
                if (prefix == "") return "";
            }
        }

        return prefix;
    }
}
