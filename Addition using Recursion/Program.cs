using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition_using_Recursion
{
    public class Program
    {
        public static int Add(int a = 5, int b = 4)
        {
            if (a == 0)  
            return b;
        
            return Add(--a, ++b);          
        }
         public static void Main(string[] args)
        {
            int sum = Add();
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
