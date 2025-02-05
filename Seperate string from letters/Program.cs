using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = "Hello123";
        string letters = "";

        foreach(char c in input)
        {
            if ( (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
            { 
                letters += c;
            }
        }
        Console.WriteLine("Orignal Strings : "+input);
        Console.WriteLine("Seperated Strings : "+letters);
        Console.ReadKey();
    }
}




/*              Logic
        
 ASCII Range for Letters:
'A' to 'Z': Uppercase letters.
'a' to 'z': Lowercase letters.

        foreach(char c in input)
        {
            if ( (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
            { 
                letters += c;
            }
        }

In this it will check through range of ASCII letters and add it in var letters
 
 */