using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Right_Rotation_of_Array_by_1
{
    internal class Program
    {
        void Right(int[] arr)
        {
            int x = arr[arr.Length - 1];
            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = x;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 ,4,5};
            Console.WriteLine("Orignal Array");
            foreach (int i in arr) { 
                Console.Write(i+" ");
            }

            Program p = new Program();
            p.Right(arr);
            Console.WriteLine("\n\nRight Rotation of array of by 1 ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
/*          LOGIC               
 
        int x = arr[arr.Length - 1];
We are taking a temporary variable x and storing last index position value in it
         
        for (int i = arr.Length-1; i > 0; i--)
In for Loop we are decrementing through last position till first position
            
         arr[i] = arr[i - 1];
While iterating , arr[i] will store value of arr[i-1]
For Ex .  arr[2] = arr[2-1] , So it will hold value of arr[1] postiton
           
         arr[0] = x;
The 0 position of array will have the last position which is stored in 
    temporary variable x.
 
 
 */  