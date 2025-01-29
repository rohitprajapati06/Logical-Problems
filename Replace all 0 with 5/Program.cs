using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replace_all_0_with_5
{
    internal class Program
    {
        public static string Replace0with5(string input) { 
            
            char[] chars = new char[input.Length];
            for (int i = 0; i < input.Length; i++) {
                if (input[i] == '0') { 
                    chars[i] = '5';
                }
                else
                {
                    chars[i] = input[i];
                }
            }
            return new string(chars);
            
        }
        static void Main(string[] args)
        {
            string input = "1050";
            string result = Replace0with5(input);
            Console.WriteLine(result);
        }
    }
}
