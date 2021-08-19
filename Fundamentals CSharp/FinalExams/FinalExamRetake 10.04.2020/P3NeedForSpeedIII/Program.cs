using System;
using System.Collections.Generic;
using System.Linq;

namespace P3NeedForSpeedIII
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCars = int.Parse(Console.ReadLine());

            //или Dictionary<string, List<int>> cars = new Dictionary<string, List>();
            Dictionary<string, Dictionary<string, int>> cars = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < numOfCars; i++)
            {
                //{car}|{mileage}|{fuel}
                string[] carInfo = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);
                string name = carInfo[0];
                int mileage = int.Parse(carInfo[1]);
                int fluel = int.Parse(carInfo[2]);

                cars.Add(name,
                    new Dictionary<string, int>()
                    {
                        {"mileage", mileage},
                        {"fuel", fluel }
                    });
            }

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] tokens = command
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string carName = tokens[1];

                switch (tokens[0])
                {
                    case "Drive":
                        int distance = int.Parse(tokens[2]);
                        int fuel = int.Parse(tokens[3]);

                        int currentFuel = cars[carName]["fuel"];

                        if (fuel > currentFuel)
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }
                        else
                        {
                            cars[carName]["mileage"] += distance;
                            cars[carName]["fuel"] -= fuel;

                            Console.WriteLine($"{carName} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        }

                        if (cars[carName]["mileage"] >= 100000)
                        {
                            Console.WriteLine($"Time to sell the {carName}!");
                            cars.Remove(carName);
                        }
                        break;

                    case "Refuel":
                        fuel = int.Parse(tokens[2]);
                        currentFuel = cars[carName]["fuel"];

                        if (fuel + currentFuel > 75)
                        {
                            fuel = 75 - currentFuel;
                        }

                        //променяме колекцията
                        cars[carName]["fuel"] += fuel;

                        Console.WriteLine($"{carName} refueled with {fuel} liters");
                        break;

                    case "Revert":
                        var km = int.Parse(tokens[2]);
                        cars[carName]["mileage"] -= km;

                        if (cars[carName]["mileage"] <= 10000)
                        {
                            cars[carName]["mileage"] = 10000;
                        }
                        else
                        {
                            Console.WriteLine($"{carName} mileage decreased by {km} kilometers");
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            var ordered = cars.OrderByDescending(x => x.Value["mileage"]).ThenBy(x => x.Key);

            foreach (var car in ordered)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value["mileage"]} kms, Fuel in the tank: {car.Value["fuel"]} lt.");
            }
        }
    }
}
