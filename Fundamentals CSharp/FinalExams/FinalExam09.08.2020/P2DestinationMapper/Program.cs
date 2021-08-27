using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P2DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(=|\/)([A-Z][A-Za-z]{2,})\1";
            Regex patternRegex = new Regex(pattern);
            MatchCollection matches = patternRegex.Matches(input);

            int travelPoints = 0;

            List<string> places = new List<string>();

            foreach (Match match in matches)
            {
                string place = match.Groups[2].ToString();

                travelPoints += place.Length;
                places.Add(place);
            }

            Console.Write("Destinations:");

            for (int i = 0; i < places.Count; i++)
            {
                if (i == places.Count-1)
                {
                    Console.Write($" {places[i]}");
                    break;
                }

                Console.Write($" {places[i]},");
            }
            //foreach (var place in places)
            //{
            //    Console.Write($" {place},");
            //}

            Console.WriteLine();
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
