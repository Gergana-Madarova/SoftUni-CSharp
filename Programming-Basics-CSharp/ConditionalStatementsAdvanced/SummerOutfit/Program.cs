using System;

namespace SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            string outfit = string.Empty;
            string shoes = string.Empty;

            if ((timeOfDay == "Evening") || ((timeOfDay == "Afternoon") && (degrees <= 18 && degrees >= 10)) || ((timeOfDay == "Morning") && (degrees <= 24 && degrees > 18)))
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            else if (((timeOfDay == "Afternoon") && (degrees <= 24 && degrees > 18)) || ((timeOfDay == "Morning") && (degrees >= 25)))
            {
                outfit = "T-Shirt";
                shoes = "Sandals";
            }
            else if ((timeOfDay == "Morning") && (degrees <= 18 && degrees >= 10))
            {
                outfit = "Sweatshirt";
                shoes = "Sneakers";
            }
            else if ((timeOfDay == "Afternoon") && (degrees >= 25))
            {
                outfit = "Swim Suit";
                shoes = "Barefoot";
            }

            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}
