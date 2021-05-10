using System;
using System.Collections.Generic;
using System.Linq;

namespace P05BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            List<int> bombNum = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int specialNum = bombNum[0];
            int power = bombNum[1];

            while (numbers.Contains(specialNum) && numbers.Count > 0)
            {
                int index = numbers.IndexOf(specialNum);
                int rightIndex = index + power;
                int leftIndex = index - power;

                if (rightIndex >= numbers.Count)
                {
                    rightIndex = numbers.Count - 1;
                }

                if (leftIndex < 0)
                {
                    leftIndex = 0;
                }

                numbers.RemoveRange(leftIndex, rightIndex - leftIndex + 1);
            }

            int sum = 0;

            foreach (int num in numbers)
            {
                sum += num;
            }

            //Console.WriteLine(string.Join(' ', numbers));
            Console.WriteLine(sum);
        }
    }
}
