using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seperate_Numbers_from_strings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = "Hello123";
            string nums = "";

            foreach(char c in input)
            {
                if (c >= '0' && c <= '9') 
                {              
                    nums += c;
                }
            }
            Console.WriteLine("Orignal Strings : "+input);
            Console.WriteLine("Seperated Numbers : "+nums);
            Console.ReadKey();



        }
    }
}
