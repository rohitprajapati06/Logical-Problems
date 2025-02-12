using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Highest_Odd_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "54616792";
            for (int i = input.Length - 1; i >= 0; i--) {

                if (input[i] % 2 != 0)
                {
                    Console.WriteLine($" Highest Odd Number : {input.Substring(0, i + 1)}");
                    return;
                }
            }
        }
    }
}
