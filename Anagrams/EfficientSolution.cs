using System;
using System.Collections.Generic;

public class Program{
	public static bool AreAnagram(string s1 , string s2){
		
		if(s1 == null || s2 == null) return false;
		if(s1.Length != s2.Length) return false;
		
		var charCount = new Dictionary<char,int>();
		
		foreach(char c in s1){
			charCount.TryGetValue(c,out int count);
			charCount[c] = count + 1;
		}
		foreach(char c in s2){
			
			if(!charCount.ContainsKey(c)){
				return false;
			}
			
			charCount[c]--;
			
			if(charCount[c] > 0){
				return false;
			}
		}
		
		return true;
		
	}
	public static void Main(string[] args){
		string s1 = "listen";
		string s2 = "silent";
		if(AreAnagram(s1,s2)){
			Console.WriteLine("Are Anagrams");
		}else{
			Console.WriteLine("Not an Anagrams");
		}
	}
}
