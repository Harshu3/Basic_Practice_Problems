using System;

namespace Basic_Practice_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Practice Problems!");
            Console.WriteLine("Program to find Sum of all Digits of a Given Number!");
            Console.WriteLine("Enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0, a;
            while (n != 0)
            {
                a = n % 10;
                sum += a;
                n = n / 10;
            }
            
            Console.WriteLine("Sum of all digits: " + sum);
        }
    }
}