using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headset = lostGamesCount / 2;
            int mouse = lostGamesCount / 3;
            //When Pesho trashes both his mouse and headset in the same lost game,
            //he also trashes his keyboard.
            int keyboard = lostGamesCount / 6;
            //Every second time, when he trashes his keyboard, he also trashes his display.
            int display = lostGamesCount / 12;

            double expenses = headset * headsetPrice + mouse * mousePrice + keyboard * keyboardPrice + display * displayPrice;

            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
