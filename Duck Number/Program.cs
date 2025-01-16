
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck_Number
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter to check if its Duck or Not");
            string n = Console.ReadLine();

            if (Duck(n))
            {
                Console.WriteLine("Its a Duck No");
            }
            else
            {
                Console.WriteLine("Not Duck");
            }
            Console.ReadKey();
        }
           static bool Duck(string n)
            {
                if (n[0] == '0')
                {
                    return false;
                }
                for (int i = 1; i < n.Length; i++)
                {
                    if (n[i] == '0')
                    {
                        return true;
                    }
                }
                return false;

            }
        
    }
}
