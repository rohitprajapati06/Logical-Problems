using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] arr = {5,9,2,7,6 };
        int SecondNumber = SecondLargest(arr);
        Console.WriteLine("Second Largest Number in an Array is :"+SecondNumber);
        Console.ReadKey();
    }

    public static int SecondLargest(int[] arr) {

        int largest = int.MinValue;
        int secondlargest = int.MinValue;

        foreach(int num in arr)
        {
            if(num > largest)
            {
                secondlargest = largest;
                largest = num;

            }
            else if (num > secondlargest && num != largest)
            {
                secondlargest = num;
            }
        }
        return secondlargest;
    }
}



/*                   Logic 

        int[] arr = { 12, 35, 1, 10, 34, 1 };
                       ^      ^
                     num    largest =  int. MinValue  , 2 largest = int.MinValue
        

    foreach (int num in arr)
    {
            if (num > largest)
            {
                secondLargest = largest;           ..... The order inside 
                largest = num;                         if-else matters
            }

     if num = 12  > largest = 1
         secondlargest = 1           because , largest = 1
         largest = 12                because , num = 12 
    

     else if (num > secondlargest && num != largest)
            {
                secondlargest = num;
            }
Ex.      num = 7  , secondlargest = 5 , largest = 9

        7 > 5  && 7 != 9
        secondlargest = 7
*/