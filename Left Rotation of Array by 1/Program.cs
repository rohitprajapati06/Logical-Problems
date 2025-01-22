using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_Rotation_of_Array_by_1
{
    public class Program
    {
        public static void Left(int[] arr)
        {
            int x = arr[0];
            for (int i = 0; i < arr.Length-1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[arr.Length - 1] = x;
        }
            static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 ,4,5};
            Console.WriteLine("Orignal Array");
            foreach (int i in arr) { 
                Console.Write(i+" ");
            }

            Left(arr);
            Console.WriteLine("\n\nLeft Rotation of Array by 1 ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
/*                              LOGIC               
 
        int x = arr[0];
We are taking a temporary variable x and storing 0 index position value in it
         
        for (int i = 0; i < arr.Length-1; i++)
In for Loop we are iterating through 0 position till last position
            
         arr[i] = arr[i + 1];
While iterating , arr[i] will store value of arr[i+1]
For Ex .  arr[1] = arr[1+1] , So it will hold value of arr[2] postiton
           
         arr[arr.Length - 1] = x;
The Last position of array will have the arr[0] position which is stored in 
    temporary variable x.
 
 
 */
