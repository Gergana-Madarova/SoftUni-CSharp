using System;
using System.Globalization;
using System.Linq;

namespace _05.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool topInt = false;
            int counter = 0;
            int[] result = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                int j = i + 1;
                while (j < numbers.Length)
                {
                    if (numbers[i] > numbers[j])
                    {
                        topInt = true;
                    }
                    else
                    {
                        topInt = false;
                        break;
                    }
                    j++;
                }
                if (topInt || i + 1 == numbers.Length)
                {
                    result[counter] = numbers[i];
                    topInt = false;
                    counter++;
                }
            }

            int[] removeEmptyElements = new int[counter];

            for (int k = 0; k < counter; k++)
            {
                removeEmptyElements[k] = result[k];
            }

            Console.WriteLine(string.Join(" ", removeEmptyElements));
        }
    }
}
