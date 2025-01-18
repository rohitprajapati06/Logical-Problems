using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Vowels___Consonant_and_Space_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vowels = 0, consonants = 0 , spaces = 0;
            Console.WriteLine("Enter a String");
            string input = Console.ReadLine().ToLower();

            foreach(char c in input)
            {
                if ("aeiou".Contains(c))
                {
                    vowels++;
                }
                else if (Char.IsLetter(c)) { 
                    consonants++;
                }
                else if(c ==' '){
                    spaces++;   
                }
            }

            Console.WriteLine("Vowels : " + vowels + "\nConsonants : " + consonants + "\nSpaces : " + spaces);

        }
    }
}
