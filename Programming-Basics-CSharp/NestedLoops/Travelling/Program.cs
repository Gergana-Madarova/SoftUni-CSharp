using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            double sum = 0;

            while (destination != "End")
            {
                double minMoney = double.Parse(Console.ReadLine());
                do
                {
                    string saveMoney = Console.ReadLine();
                    if (saveMoney != "End")
                    {
                        sum += double.Parse(saveMoney);
                    }
                    else
                    {
                        destination = "End";
                        break;
                    }
                }
                while (sum < minMoney);

                if (destination == "End")
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"Going to {destination}!");
                    sum = 0;
                    destination = Console.ReadLine();
                }
            }
        }
    }
}
