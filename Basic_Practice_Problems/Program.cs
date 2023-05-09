﻿using System;

namespace Basic_Practice_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Practice Problems!");
            Console.WriteLine("Count a total number of Duplicate elements in an array");
            int[] array = new int[10];
            Console.WriteLine("Enter 10 elements");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            var dict = new Dictionary<int, int>();
            foreach (var value in array)
            {
                if (dict.ContainsKey(value)) dict[value]++;
                else dict[value] = 1;
            }
            foreach (var pair in dict)
                Console.WriteLine("Value {0} occurred {1} times", pair.Key, pair.Value);
        }
    }
}