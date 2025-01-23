using System;

namespace LogicalPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a n to Check if it's Both Prime and Palindrome: ");
            int n = int.Parse(Console.ReadLine());

            // Check if the n is both prime and palindrome
            if (IsPrime(n) && IsPalindrome(n))
            {
                Console.WriteLine( n+" is Both Prime and Palindrome.");
            }
            else
            {
                Console.WriteLine(n + " is not Prime and Palindrome.");
            }
        }



        // Method to check if a n is prime
       public static bool IsPrime(int n)
        {
            if (n <= 1) return false; // ns <= 1 are not prime
            for (int i = 2; i <= n / 2; i++) // Check divisors from 2 to n/2
            {
                if (n % i == 0) return false; // Not prime if divisible by i
            }
            return true; // Prime if no divisors found
        }

        // Method to check if a n is palindrome
        public static bool IsPalindrome(int n)
        {
            int temp = n, sum = 0, remainder;
            while (n > 0)
            {
                remainder = n % 10;
                sum = (sum * 10) + remainder; // Reverse the n
                n = n / 10;
            }
            return temp == sum; // Check if reversed n equals original
        }
    }
}
