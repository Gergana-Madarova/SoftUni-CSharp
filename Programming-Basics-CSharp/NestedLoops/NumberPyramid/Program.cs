using System;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int current = 1;
            bool bigger = false;

            for (int rows = 1; rows <= number; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    if (current>number)
                    {
                        bigger = true;
                        break;
                    }
                    Console.Write(current + " ");
                    current++;
                }
                if (bigger)
                {
                    break;
                }

                Console.WriteLine();
            }
        }
    }
}
