using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string film = Console.ReadLine();
            int allTickets = 0;
            int counterTickets = 0;
            int counterStudent = 0;
            int counterStandart = 0;
            int counterKid = 0;

            while (film != "Finish")
            {
                int freeSeat = int.Parse(Console.ReadLine());
                for (int i = 1; i <= freeSeat; i++)
                {
                    string typeOfTicket = Console.ReadLine();

                    if (typeOfTicket != "End")
                    {
                        counterTickets++;
                        if (typeOfTicket == "student")
                        {
                            counterStudent++;
                        }
                        else if (typeOfTicket == "standard")
                        {
                            counterStandart++;
                        }
                        else if (typeOfTicket == "kid")
                        {
                            counterKid++;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                double ticketsP = (1.0 * counterTickets / freeSeat) * 100;
                allTickets += counterTickets;
                counterTickets = 0;

                Console.WriteLine($"{film} - {ticketsP:f2}% full.");
                film = Console.ReadLine();
            }

            double studentP = 1.0 * counterStudent / allTickets * 100;
            double standarP = 1.0 * counterStandart / allTickets * 100;
            double kidP = 1.0 * counterKid / allTickets * 100;
            Console.WriteLine($"Total tickets: {allTickets}");
            Console.WriteLine($"{studentP:f2}% student tickets.");
            Console.WriteLine($"{standarP:f2}% standard tickets.");
            Console.WriteLine($"{kidP:f2}% kids tickets.");
        }
    }
}
