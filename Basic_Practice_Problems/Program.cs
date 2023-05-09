using System;

namespace Basic_Practice_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Practice Problems!");
            Console.WriteLine("Find maximum and minimum element in an array");
            int[] arr1 = new int[100];
            int i, mx, mn, n;
            Console.Write("Enter array size: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter {0} elements in the array", n);

            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            mx = arr1[0];
            mn = arr1[0];
            for (i = 1; i < n; i++)
            {
                if (arr1[i] > mx)
                {
                    mx = arr1[i];
                }

                if (arr1[i] < mn)
                {
                    mn = arr1[i];
                }
            }
            Console.WriteLine("Maximum element is : {0}", mx);
            Console.WriteLine("Minimum element is : {0}", mn);
        }
    }
}