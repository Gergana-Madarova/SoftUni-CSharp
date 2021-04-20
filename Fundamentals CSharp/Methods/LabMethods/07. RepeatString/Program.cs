using System;

namespace _07._RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string output = RepeatString(input, n);
                     
            Console.WriteLine(output);
        }

        private static string RepeatString(string input, int n)
        {
            string output = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                output += input;
            }

            return output;
        }
    }
}
