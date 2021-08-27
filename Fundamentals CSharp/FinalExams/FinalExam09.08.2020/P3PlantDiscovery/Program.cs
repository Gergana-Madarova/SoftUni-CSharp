using System;
using System.Collections.Generic;
using System.Linq;

namespace P3PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());

            //или Dictionary<string, List<int>> plantsRarity = new Dictionary<string, List>();
            Dictionary<string, int> plantsRarity = new Dictionary<string, int>();
            Dictionary<string, float> plantsRating = new Dictionary<string, float>();

            for (int i = 0; i < n; i++)
            {
                //"{namePlant}<->{rarity}
                string[] plantInfo = Console.ReadLine()
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string namePlant = plantInfo[0];
                int rarity = int.Parse(plantInfo[1]);

                if (plantsRarity.Keys.Contains(namePlant))
                {
                    plantsRarity[namePlant] = rarity;
                }
                plantsRarity.Add(namePlant, rarity);
            }

            string command = Console.ReadLine();

            while (command != "Exhibition")
            {
                string[] tokens = command
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string[] commandInfo = tokens[1].Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                string namePlant = commandInfo[0];

                switch (tokens[0])
                {
                    case "Rate":
                        float rating = int.Parse(commandInfo[1]);

                        if (plantsRating.Keys.Contains(namePlant))
                        {
                            plantsRating[namePlant] = (rating + plantsRating[namePlant])/2;
                        }
                        else
                        {
                            plantsRating.Add(namePlant, rating);
                        }
                        break;

                    case "Update":
                        int newRarity = int.Parse(commandInfo[1]);

                        if (plantsRarity.Keys.Contains(namePlant))
                        {
                            plantsRarity[namePlant] = newRarity;
                        }
                        break;

                    case "Reset":
                        if (plantsRating.Keys.Contains(namePlant))
                        {
                            plantsRating[namePlant] = 0;
                        }
                        break;
                    default:
                            Console.WriteLine("error");
                            break;
                }

                command = Console.ReadLine();
            }

            //The plants should be sorted by rarity descending, then by average rating descending

            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in plantsRarity.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"- {item.Key}; Rarity: {item.Value}; Rating: {plantsRating[item.Key]:f2}");
            }
        }
    }
}
