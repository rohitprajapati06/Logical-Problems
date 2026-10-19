using System;
using System.Collections.Generic;

public class Program
{

  public static void Frequency(string input)
	{
		var dict = new Dictionary<char,int>();
		foreach(char c in input){
			if(!dict.ContainsKey(c)){
				dict[c] = 1; 
			}
			
			dict[c] ++ ;
		}
		
		foreach(var items in dict){
			Console.WriteLine($"{items.Key} : {items.Value}");
		}
	}
  
	public static void Main(string[] args){
		string input = "programming";
		Frequency(input);
	}
	
}
