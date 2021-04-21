using System;
using System.Data.SqlTypes;

namespace _2._VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            int output = GetVowelsCount(input);

            Console.WriteLine(output);
        }

        private static int GetVowelsCount(string input)
        {
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'a':
                    case 'o':
                    case 'e':
                    case 'u':
                    case 'i':
                    case 'y':
                        {
                            count++;
                        }
                        break;
                }
            }

            return count;
        }
    }
}
