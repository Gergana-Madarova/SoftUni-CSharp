using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = string.Empty;
            string typeOfRest = string.Empty;
            double sum = 0.0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    sum = 0.3 * budget;
                    typeOfRest = "Camp";
                }

                if (season == "winter")
                {
                    sum = 0.7 * budget;
                    typeOfRest = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    sum = 0.4 * budget;
                    typeOfRest = "Camp";
                }

                if (season == "winter")
                {
                    sum = 0.8 * budget;
                    typeOfRest = "Hotel";
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                sum = 0.9 * budget;
                typeOfRest = "Hotel";
            }
            //къде ще почива и колко ще похарчи
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeOfRest} - {sum:f2}");
        }
    }
}
