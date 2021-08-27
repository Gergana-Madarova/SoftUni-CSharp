using System;
using System.Linq;

namespace P1WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {

            string stops = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Travel")
            {
                string[] tokens = command.Split(":", StringSplitOptions.RemoveEmptyEntries);

                switch (tokens[0])
                {
                    case "Add Stop":
                        {
                            int index = int.Parse(tokens[1]);
                            string str = tokens[2];

                            if (stops.Length > index && index >= 0)
                            {
                                stops = stops.Insert(index, str);
                            }
                            break;
                        }

                    case "Remove Stop":
                        {
                            int startIndex = int.Parse(tokens[1]);
                            int endIndex = int.Parse(tokens[2]);

                            if (stops.Length > startIndex && startIndex >= 0 && stops.Length > endIndex && endIndex >= 0)
                            {
                                stops = stops.Remove(startIndex, endIndex - startIndex + 1);
                            }
                            break;
                        }

                    case "Switch":
                        {
                            string oldString = tokens[1];
                            string newString = tokens[2];

                            if (stops.Contains(oldString))
                            {
                                stops = stops.Replace(oldString, newString);
                            }
                            break;
                        }
                }

                Console.WriteLine(stops);
                command = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: { stops}");
        }
    }
}
