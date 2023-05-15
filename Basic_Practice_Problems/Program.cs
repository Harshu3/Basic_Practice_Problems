using System;

namespace Basic_Practice_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Practice Problems!");
            Console.WriteLine("Find Unique elements in an array");
            int[] arr = new int[100];
            int i, j, n;
            Console.Write("Enter array size: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter {0} elements in the array", n);

            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Unique elements in array:");
            
            for (i = 0; i < n; i++)
            {
                bool isUnique = false;
                for (j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isUnique = true;
                        break;
                    }
                }
                if (!isUnique)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}