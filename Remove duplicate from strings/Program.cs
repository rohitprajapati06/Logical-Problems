using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_duplicate_from_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string input = Console.ReadLine();
            string output = string.Empty;
            string duplicate = string.Empty;    

            for (int i = 0; i < input.Length; i++) {

                if (!output.Contains(input[i]))
                {
                    output += input[i]; 
                }
                else if (!duplicate.Contains(input[i]))
                {
                    duplicate += input[i];
                }
            }
            Console.WriteLine("After Removing Duplicates : "+output);
            Console.Write("Duplicate Elements : " + duplicate);
            int num = duplicate.Length;
            Console.Write(" which is " + num);
            Console.ReadKey();
        }


    }
}
/*                      Logic 
    

    if (!output.Contains(input[i]))
This line Checks if Output contains input[index] till loop completion .
As we see the condition is False
So we put , ! Not operation to Reverse result 

    output += input[i];
This Line will add the input[index] in output if its not present 
  += This operator adds value 


    Else if came to play when if condition is false
    The remaining input[i] which not include in output follow the same condition
        
    !duplicate.Contains(input[i])
    This line will check whether the reaming string is not present in duplicates
    
    duplicate += input[i];
    This will add duplicate elements
 
 
 */