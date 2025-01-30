using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotation_Of_Array_by_K_Position
{
    using System;

    namespace Rotation_Of_Array_by_K_Position
    {
        internal class Program
        {
            // Reverse the subarray from index start to end
            static void Swap(int[] arr, int start, int end)
            {
                while (start < end)
                {
                    int temp = arr[start];
                    arr[start] = arr[end];
                    arr[end] = temp;
                    start++;
                    end--;
                }
            }

            static void Main(string[] args)
            {
                int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
                Console.WriteLine("Original Array:");
                foreach (int i in arr)
                {
                    Console.Write(i + " ");
                }

                Console.Write("\n\nEnter Position of K: ");
                int position = Convert.ToInt32(Console.ReadLine());

                // To handle cases where position > array length
                position = position % arr.Length;

                // Reverse first part
                Swap(arr, 0, position - 1);

                // Reverse second part
                Swap(arr, position, arr.Length - 1);

                // Reverse the entire array
                Swap(arr, 0, arr.Length - 1);

                Console.WriteLine("\nRotation of array by K positions:");
                foreach (int i in arr)
                {
                    Console.Write(i + " ");
                }

                Console.ReadKey();
            }
        }
    }

}
/*                      LOGIC               
 
FUNCTION :

    if (start < end)
   Checking if the start index is less than end index

         int temp = arr[start];
         arr[start] = arr[end];
          arr[end] = temp;
    It will Perform swapping until the condition is true

            start++;
             end--;
    After each Swapping , it will move pointers start by +1 position and
        end by -1 position.



Call by Value after creating Object


     p.Swap(arr, 0 , position-1 );          1 part
    It will Swap array from 0 index to position - 1 index defined by user
Ex. 1,2,3,4,5,6,7   k = 2 , It will swap first two position
    2,1,3,4,5,6,7
    

     p.Swap(arr , position ,arr.Length-1 );  2 part
    It will swap array starting from position index which is defined to last index
Ex. 1,2,3,4,5,6,7   k = 2 , It will swap first two position
    2,1,3,4,5,6,7 its already done in previous step
Now , 2,1,7,6,5,4,3


     p.Swap(arr,0,arr.Length-1);    3 part
    It will swap whole array
Ex. 2,1,7,6,5,4 this is the array after 2 swapping
Now , 3,4,5,6,7,1,2


 */