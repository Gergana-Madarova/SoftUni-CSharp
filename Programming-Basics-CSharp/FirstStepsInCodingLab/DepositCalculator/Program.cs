using System;
using System.Diagnostics.CodeAnalysis;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double Deposit = double.Parse(Console.ReadLine());
            int Period = int.Parse(Console.ReadLine());
            double AnnualInterest = double.Parse(Console.ReadLine());

            //сума = депозирана сума  + срок на депозита * ((депозирана сума * годишен лихвен процент ) / 12)
            double sum = Deposit + Period * ((Deposit * AnnualInterest * 0.01) / 12);

            Console.WriteLine(sum);
        }
    }
}
