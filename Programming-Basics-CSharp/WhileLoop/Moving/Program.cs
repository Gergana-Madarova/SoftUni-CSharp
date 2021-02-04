using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            int space = width * length * hight;
            int spaceFree = space;
            int spaceOccupied = 0;
            bool noSpace = false;
            int outPut = 0;

            string counter = Console.ReadLine();

            while (counter != "Done")
            {
                spaceOccupied = spaceOccupied + int.Parse(counter);
                spaceFree = space - spaceOccupied;
                if (spaceOccupied >= space)
                {
                    noSpace = true;
                    outPut = spaceOccupied - space;
                    break;
                }
                else
                {
                    counter = Console.ReadLine();
                }
            }

            if (noSpace)
            {
                Console.WriteLine($"No more free space! You need {outPut} Cubic meters more.");
            }
            else
            {
                Console.WriteLine($"{spaceFree} Cubic meters left.");
            }
        }
    }
}
