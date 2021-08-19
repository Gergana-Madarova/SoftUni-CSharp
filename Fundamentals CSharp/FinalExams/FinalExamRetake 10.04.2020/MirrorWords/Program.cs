using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P2MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(#|@)([A-Za-z]{3,})\1{2}([A-Za-z]{3,})\1";
            Regex patternRegex = new Regex(pattern);
            MatchCollection matches = patternRegex.Matches(input);

            List<string> mirroredPairs = new List<string>();

            foreach (Match match in matches)
            {
                string secondWord = match.Groups[3].ToString();
                string firstWord = match.Groups[2].ToString();
                string reversWord = string.Empty;

                for (int i = firstWord.Length - 1; i >= 0; i--)
                {
                    reversWord += firstWord[i];
                }

                if (reversWord == secondWord)
                {
                    string addWord = firstWord + " <=> " + secondWord;
                    mirroredPairs.Add(addWord);
                }
            }

            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
            }
            else if (matches.Count > 0)
            {
                Console.WriteLine($"{matches.Count} word pairs found!");

                if (mirroredPairs.Count > 0)
                {
                    Console.WriteLine("The mirror words are:");
                    Console.WriteLine(string.Join(", ", mirroredPairs));
                }
                else
                {
                    Console.WriteLine("No mirror words!");
                }
            }
        }
    }
}
