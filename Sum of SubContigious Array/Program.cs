using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_SubContigious_Array
{
    public  class Program
    {
        public static int Sum(int[] num)
        {
            int CurrentMax = num[0];
            int Max = num[0];

            for (int i = 1; i < num.Length; i++)
            {
                CurrentMax = Math.Max(num[i], num[i]+CurrentMax );
                Max = Math.Max(Max, CurrentMax);
            }

            return Max;
        }
        static void Main(string[] args)
        {
            int[] num = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int SumMax = Sum(num);
            Console.WriteLine(SumMax);
            Console.ReadKey();

        }
    }
}

/*                               LOGIC
 
      1)     Current Max &  Max = num [0]  ;     Defined Initially 


      2)      for (int i = 1; i < num.Length; i++)
            Iterating throgh For Loop starting with Index Position 1 because 
                0 index position is already defined 


     3)      CurrentMax = Math.Max(CurrentMax, num[i]+CurrentMax);
            Current Max will Store maximum Value between  num[i] + CurrentMax , CurrentMax


      4)    Max = Math.Max(Max, CurrentMax);
           Max will store the recent  Currentmax , Max

          
    As this will Iterate and return Max value for Subarray sum 
 
 
 
 
 
 */