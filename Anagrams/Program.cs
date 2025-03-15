using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    internal class Program
    {
        public static bool Anagram(string s1, string s2)
        {
            if (s1 == s2) { 
                return false;
            }

            char[] ch1 = s1.ToCharArray();
            char[] ch2 = s2.ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            string str1 = new string(ch1);
            string str2 = new string(ch2);  
           
            return str1.Equals(str2);


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String1");
            string s1 = Console.ReadLine().ToLower();

            Console.WriteLine("Enter String2");
            string s2 = Console.ReadLine().ToLower();

            if (Anagram(s1, s2))
            {
                Console.WriteLine("Its an Anagram");
            }
            else {
                Console.WriteLine("Not an Anagram");
            }
        }
    }
}
