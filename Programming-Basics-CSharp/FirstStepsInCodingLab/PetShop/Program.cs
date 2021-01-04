using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfDogs = int.Parse(Console.ReadLine());
            int countOfOtherAnimals = int.Parse(Console.ReadLine());

            double sum = countOfDogs * 2.50 + countOfOtherAnimals * 4;
            Console.WriteLine($"{sum} lv.");
        }
    }
}
