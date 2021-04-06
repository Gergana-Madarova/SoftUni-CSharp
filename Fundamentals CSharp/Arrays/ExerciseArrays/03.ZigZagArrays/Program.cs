using System;

namespace _03.ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] result1 = new string[n];
            string[] result2 = new string[n];

            for (int i = 1; i <= n; i++)
            {
                string[] arr = Console.ReadLine().Split();

                if (i % 2!=0)
                {
                    result1[i - 1] = arr[0];
                    result2[i - 1] = arr[1];
                }
                else
                {
                    result1[i - 1] = arr[1];
                    result2[i - 1] = arr[0];
                }            
            }
            Console.WriteLine(string.Join(" ", result1));
            Console.WriteLine(string.Join(" ", result2));
        }
    }
}
