using System;

namespace _3.GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());

            double currBalance = balance;
            double spent = 0;
            double price = 0;

            string game = Console.ReadLine();

            while (game != "Game Time")
            {
                bool notFound = false;

                switch (game)
                {
                    case "OutFall 4":
                    case "RoverWatch Origins Edition":
                        {
                            price = 39.99;
                            break;
                        }
                    case "CS: OG":
                        {
                            price = 15.99;
                            break;
                        }
                    case "Zplinter Zell":
                        {
                            price = 19.99;
                            break;
                        }
                    case "Honored 2":
                        {
                            price = 59.99;
                            break;
                        }
                    case "RoverWatch":
                        {
                            price = 29.99;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Not Found");
                            notFound = true;
                            break;
                        }
                }
                if (!notFound)
                {
                    currBalance -= price;

                    if (currBalance == 0)
                    {
                        Console.WriteLine($"Bought {game}");
                        Console.WriteLine("Out of money!");
                        return;
                    }
                    else if (currBalance < 0)
                    {
                        Console.WriteLine("Too Expensive");
                        currBalance += price;
                    }
                    else if (currBalance > 0)
                    {
                        Console.WriteLine($"Bought {game}");
                        spent += price;
                    }
                }
                game = Console.ReadLine();
            }

            Console.WriteLine($"Total spent: ${spent:f2}. Remaining: ${balance - spent:f2}");
        }
    }
}
