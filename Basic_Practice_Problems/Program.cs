using System;

namespace Basic_Practice_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Practice Problems!");
            Console.WriteLine("Program to Print a Pattern");
            int size, row, column;
            Console.Write("Enter size to draw pattern: ");
            size = Convert.ToInt32(Console.ReadLine());

            for ( row = 0; row < size; row++)
            {
                for ( column = 0; column < size; column++)
                {
                    if (row == 0 || column == 0 || row == size - 1 || column == size - 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}