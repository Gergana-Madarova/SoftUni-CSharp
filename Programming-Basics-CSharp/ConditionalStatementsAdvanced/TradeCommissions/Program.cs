using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double commission = 0.0;
            double percent = 0.0;
            bool err = false;

            switch (city)
            {
                case "Sofia":
                    {
                        if (sales > 10000)
                        {
                            percent = 0.12;
                        }
                        else if (sales > 1000)
                        {
                            percent = 0.08;
                        }
                        else if (sales > 500)
                        {
                            percent = 0.07;
                        }
                        else if (sales > 0)
                        {
                            percent = 0.05;
                        }
                    }
                    break;
                case "Varna":
                    {
                        if (sales > 10000)
                        {
                            percent = 0.13;
                        }
                        else if (sales > 1000)
                        {
                            percent = 0.10;
                        }
                        else if (sales > 500)
                        {
                            percent = 0.075;
                        }
                        else if (sales > 0)
                        {
                            percent = 0.045;
                        }
                    }
                    break;
                case "Plovdiv":
                    {
                        if (sales > 10000)
                        {
                            percent = 0.145;
                        }
                        else if (sales > 1000)
                        {
                            percent = 0.12;
                        }
                        else if (sales > 500)
                        {
                            percent = 0.08;
                        }
                        else if (sales > 0)
                        {
                            percent = 0.055;
                        }
                    }
                    break;
                default:
                    err = true;
                    break;
            }

            if (sales>=0 && err == false)
            {
                commission = percent * sales;
                Console.WriteLine($"{commission:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
