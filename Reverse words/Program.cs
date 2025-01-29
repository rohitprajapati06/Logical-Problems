using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_words
{
    using System;

    class Program
    {
         public static void Main(string[] args)
        {
            string inputString = " sky is blue";
            Console.WriteLine("The given String is : \n"+inputString+"\n");

            string reversedString = ReverseWords(inputString);
            Console.WriteLine("After Reversing : \n"+reversedString); // Output: "World Hello"

            Console.ReadKey();
        }

         public static string ReverseWords(string s) // Method
        {
            // Split the string into words
            string[] words = s.Split(' ');

            // Reverse the array of words
            Array.Reverse(words);

            // Join the reversed array of words into a string
            return string.Join(" ", words);
            
        }
    }       
        
}
/*                                 LOGIC  
 
  In the Main Method : 

    We had just defined a String and later on with the help of 
     ( FUNCTION ) we have reversed each word in a string

    In Method :

    1)  Split out String , and stroing it in array -    [ because after spliting it becomes multiple ]
             
        string[] words = s.Split(' ');

    2)  Reversing the Splited String 

        Array.Reverse(words);

    3)  Joining the Array , and printed in Main Method

        return string.Join(" ", words);

 */