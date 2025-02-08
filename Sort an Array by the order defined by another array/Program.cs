using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static int[] RelativeSortArray(int[] arr1, int[] arr2)
    {
        // Dictionary to store the order of elements in arr2
        Dictionary<int, int> orderMap = new Dictionary<int, int>();
        for (int i = 0; i < arr2.Length; i++)
        {
            orderMap[arr2[i]] = i;
        }


        // Split arr1 into two groups: elements in arr2 and elements not in arr2
        List<int> inArr2 = new List<int>();
        List<int> notInArr2 = new List<int>();

        foreach (var num in arr1)
        {
            if (orderMap.ContainsKey(num))
                inArr2.Add(num);
            else
                notInArr2.Add(num);
        }

        // Sort elements in list inArr2 based on their order in Arr2
        inArr2.Sort((a, b) => orderMap[a].CompareTo(orderMap[b]));

        // Sort elements not in arr2 in ascending order
        notInArr2.Sort();

        // Combine the two groups
        return inArr2.Concat(notInArr2).ToArray();
    }

    static void Main(string[] args)
    {
        // Example 1
        int[] arr1 = { 2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19 };
        int[] arr2 = { 2, 1, 4, 3, 9, 6 };
        int[] result = RelativeSortArray(arr1, arr2);
        Console.WriteLine(string.Join(", ", result));  // Output: 2, 2, 2, 1, 4, 3, 3, 9, 6, 7, 19

    }
}


/*                                  Logic
 
 
 
 // Dictionary to store the order of elements in arr2
        Dictionary<int, int> orderMap = new Dictionary<int, int>();
        for (int i = 0; i < arr2.Length; i++)
        {
            orderMap[arr2[i]] = i;
        }

output =>

orderMap = {
    2: 0,
    1: 1,
    4: 2,                       value is the index position 
    3: 3,               
    9: 4,
    6: 5
}

 

        foreach (var num in arr1)
        {
            if (orderMap.ContainsKey(num))
                inArr2.Add(num);
            else
                notInArr2.Add(num);
        }
 
if arr1 is present as a key in dictionary
    then add in  inArr2 
else , notinArr2 



output => 

            inArr2 = [2, 3, 1, 3, 2, 4, 6, 9, 2]
            notInArr2 = [7, 19]
 


 
 
 // Sort elements in list inArr2 based on their order in Arr2
        inArr2.Sort((a, b) => orderMap[a].CompareTo(orderMap[b]));

 Sort inArr2 by ordermap by comparing with dictionary order map with value/index postion as,
 
 
 {
    2: 0,
    1: 1,
    4: 2,
    3: 3,
    9: 4,
    6: 5
}

 
 it num ( key ) get sorted according to value ( index )
 
 
 
 */