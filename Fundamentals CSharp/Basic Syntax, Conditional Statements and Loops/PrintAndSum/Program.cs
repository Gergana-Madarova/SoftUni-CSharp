using System;

namespace PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = startNum; i <= endNum; i++)
            {
                if (i == endNum)
                {
                    Console.Write(i);
                    sum += i;
                    break;
                }
                Console.Write(i + " ");
                sum += i;
            }

            Console.WriteLine($"\nSum: {sum}");
        }
    }
}
