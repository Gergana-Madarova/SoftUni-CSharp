using System;
using System.Diagnostics.CodeAnalysis;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int period = int.Parse(Console.ReadLine());
            double annualInterest = double.Parse(Console.ReadLine());

            //сума = депозирана сума  + срок на депозита * ((депозирана сума * годишен лихвен процент ) / 12)
            double sum = deposit + period * ((deposit * annualInterest * 0.01) / 12);

            Console.WriteLine(sum);
        }
    }
}
