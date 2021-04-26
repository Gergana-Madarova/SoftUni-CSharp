using System;

namespace TriangleОfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j == i)
                    {
                        Console.Write(i);
                        break;
                    }

                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
