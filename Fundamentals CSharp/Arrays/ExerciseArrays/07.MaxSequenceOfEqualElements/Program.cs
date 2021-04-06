using System;
using System.Linq;

namespace _07.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] inputInt = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sequenceOfEqual = 0;
            int count = 1;
            int sequenceCount = 1;


            for (int i = inputInt.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    if (inputInt[i] == inputInt[i + 1])
                    {
                        if (sequenceCount <= count)
                        {
                            sequenceOfEqual = inputInt[i];
                        }
                    }
                    else if (sequenceCount == 1)
                    {
                        sequenceOfEqual = inputInt[i];
                    }
                }
                else if (inputInt[i] == inputInt[i - 1])
                {
                    count = count + 1;

                    if (sequenceCount <= count)
                    {
                        sequenceOfEqual = inputInt[i];
                        sequenceCount = count;
                    }
                }
                else
                {
                    count = 1;
                }
            }

            int[] equalElements = new int[sequenceCount];
            for (int j = 0; j < sequenceCount; j++)
            {
                equalElements[j] = sequenceOfEqual;
            }

            Console.WriteLine(string.Join(" ", equalElements));
        }
    }
}
