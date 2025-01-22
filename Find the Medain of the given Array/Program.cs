using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_Medain_of_the_given_Array
{
    public class Program
    {
        public static double Medain(int[] arr) { 
            
            Array.Sort(arr);
            int n  = arr.Length;
            if (n % 2 == 1) { 
                return arr[n / 2];
            }
            return (arr[n / 2 - 1] + arr[n / 2]) / 2.0; 

        }
        static void Main(string[] args)
        {
            int [] arr = { 5,1,6,3,2,5,4,9,8,7,5,2,3,6 };
            double medain = Medain(arr);
            Console.WriteLine("Medain of an given array is : "+medain);
        }
    }
}


/*                                LOGIC          
             
 
        Medain is the middle value , in an Arrange numbers / Sorted array 


Odd numbers : Ex .  { 1 , 2 , 3 , 4 , 5 , 6 , 7 , 8 , 9 }
        Medain is 5 , cause its a middle number


Even number : Ex .  { 1 , 2 , 3 , 4 , 5 , 6 , 7 , 8  }
        Medain is ,
                    4 + 5 / 2   = 4.5 

        Medain is Average of Sum of two Middle Number  in Even Numbers 
            the 2 middle number is 4 and 5 
 
 
 
 
 
 
 
 
 
 
 
 
 
 */