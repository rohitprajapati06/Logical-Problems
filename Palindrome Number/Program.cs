using System;
public class PalindromeExample
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the Number: ");
        int n = int.Parse(Console.ReadLine());

        int r, sum = 0, temp;

        temp = n;
        while (n > 0)
        {
            r = n % 10;
            sum = sum * 10 + r;
            n = n / 10;
        }
        if (temp == sum)
            Console.Write("Number is Palindrome.");
        else
            Console.Write("Number is not Palindrome");
    }
}