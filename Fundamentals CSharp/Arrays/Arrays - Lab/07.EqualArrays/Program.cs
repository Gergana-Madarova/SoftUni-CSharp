using System;
using System.Linq;

namespace _07.EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string output = string.Empty;
            int sum = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    sum += arr1[i];
                    output = $"Arrays are identical. Sum: {sum}";
                }
                else if (arr1[i] != arr2[i])
                {
                    output = $"Arrays are not identical. Found difference at {i} index";
                    break;
                }
            }

            Console.WriteLine(output);
        }
    }
}
