using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForVacation = double.Parse(Console.ReadLine());
            double ownerMoney = double.Parse(Console.ReadLine());

            int days = 1;
            int allDays = 0;
            string command = string.Empty;
            double curMoney = 0.0;
            bool saveMoney = true;

            while (moneyForVacation > ownerMoney)
            {
                command = Console.ReadLine();
                curMoney = double.Parse(Console.ReadLine());
                allDays++;

                if (command == "spend")
                {
                    ownerMoney -= curMoney;
                    if (ownerMoney<0)
                    {
                        ownerMoney = 0;
                    }
                    if (days < 5)
                    {
                        days++;
                    }
                    else if (days >= 5)
                    {
                        saveMoney = false;
                        break;
                    }
                }
                else if (command == "save")
                {
                    days = 1;
                    ownerMoney += curMoney;
                }
            }

            if (saveMoney == false)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(allDays);
            }
            else
            {
                Console.WriteLine($"You saved the money for {allDays} days.");
            }
        }
    }
}
