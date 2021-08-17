using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P2EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            //string patternEmojis = @"([:*]{2})([A-Z][a-z]{2,})\1";
            //\1 в regex-а означава back reference към 1-та група т.е. ([:*]{2}) или първото оградено в скоби ()
            string patternEmojis = @"(:{2}|\*{2})[A-Z][a-z]{2,}\1";
            string patternDigits = @"[0-9]";
            Regex numRegex = new Regex(patternDigits);
            Regex emojiRegex = new Regex(patternEmojis);
            long coolTreshold = 1;

            string input = Console.ReadLine();
            //Matches(input) - колекцията от мачове,
            //Select(m => m.Value) - защото ни трябва като колекция само със стойностите вътре Select
            //Select(int.Parse) - обръщаме колекцията от string в колекция от int
            //ToList() - защото само той има foreach
            //ForEach - за всеки един елемент на този списък умножаваме coolTreshold по него
            numRegex.Matches(input)
                    .Select(m => m.Value)
                    .Select(int.Parse)
                    .ToList()
                    .ForEach(x => coolTreshold *= x);

            var matches = emojiRegex.Matches(input);
            int totalEmojis = matches.Count;
            List<string> coolEmojis = new List<string>();

            foreach (Match item in matches)
            {
                long coolIndex = item.Value
                    .Substring(2, item.Value.Length - 4)
                    .ToCharArray()
                    .Sum(x => (int)x);

                if (coolIndex > coolTreshold)
                {
                    coolEmojis.Add(item.Value);
                }
            }

            Console.WriteLine($"Cool threshold: {coolTreshold}");
            Console.WriteLine($"{totalEmojis} emojis found in the text. The cool ones are:");

            foreach (var item in coolEmojis)
            {
                Console.WriteLine(item);
            }
        }
    }
}
