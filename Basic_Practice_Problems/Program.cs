using System;

namespace Basic_Practice_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Practice Problems!");
            Console.WriteLine("Program to Print a Pattern");
            int i, n;
            Console.Write("Enter number of rows to draw pattern: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                string pattern = new string('*', (n - i));
                string res = string.Join(" ", pattern.ToArray());
                Console.WriteLine(res);
            }
        }
    }
}