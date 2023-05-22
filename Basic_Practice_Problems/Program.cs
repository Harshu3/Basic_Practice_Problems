using System;

namespace Basic_Practice_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Practice Problems!");
            Console.WriteLine("Program to Reverse Each Word in a given String!");
            Console.WriteLine("Enter a String:");
            string s = Console.ReadLine();
            string rev = "";
            int length = s.Length - 1;
            while (length >= 0)
            {
                rev = rev + s[length];
                length--;
            }
            Console.WriteLine("After reverse: " + rev);
        }
    }
}