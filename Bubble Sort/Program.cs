using System;
namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] intArray = new int[5];
            Console.WriteLine("Enter the Array Elements : ");
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Sorting the array
            for (int j = 0; j < intArray.Length - 1; j++)   //Outer Loop
            {

                for (int i = 0; i < intArray.Length - 1; i++)//Inner Loop
                {
                    count = count + 1;//Optional for tracking iteration count
                    if (intArray[i] > intArray[i + 1])
                    {
                        int temp = intArray[i + 1];
/*    Swapping  */      intArray[i + 1] = intArray[i];
                        intArray[i] = temp;
                    }
                }
            }

            Console.WriteLine("After Sorting Array :");
            foreach (int item in intArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nThe Loop iterates :" + count);
            Console.ReadKey();
        }
    }
}