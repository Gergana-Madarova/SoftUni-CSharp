using System;

namespace _09._PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            while (input != "end")
            {
                string output = Palidrom(input).ToLower();
                Console.WriteLine(output);
                input = Console.ReadLine().ToLower();
            }
        }

        private static string Palidrom(string input)
        {
            string isPalindrome = "true";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                {
                    isPalindrome = "false";
                }
            }

            return isPalindrome;
        }
    }
}
