using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		int[] arr = {40,20,30,20,10};
		int[] output = RankedArray(arr);
		Console.Write(String.Join(" ",output));
		
	}
	
	public static int[] RankedArray(int[] arr){
		 
		 int[] sorted = (int[])arr.Clone();
		 Array.Sort(sorted);
		
		 Dictionary<int,int> rankmap = new Dictionary<int,int>();
		 int rank = 1;
		
		 foreach(int num in sorted){
		 	
			  if(!rankmap.ContainsKey(num)){
			  	 rankmap[num] = rank++;
			  }
		 }
		
		for(int i = 0 ; i < arr.Length ; i++){
			arr[i] = rankmap[arr[i]];
		}
		 
		return arr;
	}
}
