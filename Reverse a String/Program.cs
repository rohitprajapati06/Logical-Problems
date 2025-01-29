// See https://aka.ms/new-console-template for more information
using System;
namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str, rev=null;
            Console.WriteLine("Enter a String to Reverse");
            str = Console.ReadLine();
            
            for (int i = str.Length-1;i >= 0; i--)
            {
                rev += str[i];
            }
            Console.WriteLine("\nReverse of a String is \n"+rev);
            Console.ReadKey();
        }
    }
}
/*
 Logic 

First Reading a string from user
Taking a variable in which Reverse of string will store & it value keeping as nuul
    string rev = null ;

Using for loop
            for (int i = str.Length-1;i >= 0; i--)
1) i = str.Length - 1 ,means , str.Length - 1  = Last index of given string

2) i > = 0  , checking condition which is True

3)  i --  , decreasing from Last index of given string

IMPORTANT:

 rev += str[i]; 
    += this will add str[i] 

Ex. abc 
    |||
    123
i is at last index because of decrement operater -- 
Starting from c and end to a & += add it together,
It becomes cba..

Print rev 

 

 */