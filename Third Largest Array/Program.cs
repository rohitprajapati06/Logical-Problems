using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 24, 65, 31, 78, 25, 94, 38 };
        int ThirdNumber = ThirdLargestNumber(arr);
        Console.WriteLine("Third Largest Number in an Array : "+ThirdNumber);
    }

    public static int ThirdLargestNumber(int[] arr)
    {
        int Thirdlargest = int.MinValue;
        int Secondlargest = int.MinValue;
        int largest = int.MinValue;

        foreach (int num in arr) {

            if (num > largest) {
                Thirdlargest = Secondlargest;        // Order is Important
                Secondlargest = largest;             // Otherwise output 
                largest = num;                       // will be wrong
            }
            else if(num > Secondlargest && num != largest)
            {
                Thirdlargest = Secondlargest;
                Secondlargest = num;
            }
            else if(num > Thirdlargest && num != Secondlargest && num != largest)
            {
                Thirdlargest = num;
            }                  
        }

        return Thirdlargest;
    }
}