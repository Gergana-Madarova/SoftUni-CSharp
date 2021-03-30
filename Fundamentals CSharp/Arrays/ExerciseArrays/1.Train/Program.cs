using System;
using System.Linq;

namespace _1.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfWagons = int.Parse(Console.ReadLine());
            int[] train = new int[countOfWagons];
            int sum = 0;

            for (int i = 0; i < train.Length; i++)
            {
                train[i] = int.Parse(Console.ReadLine());
                sum += train[i];
            }

            Console.WriteLine(string.Join(" ", train));
            Console.WriteLine(sum);
        }
    }
}
